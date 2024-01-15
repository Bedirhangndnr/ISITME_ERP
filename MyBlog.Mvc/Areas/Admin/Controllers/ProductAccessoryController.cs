using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Entities.Concrete;
using MyBlog.Mvc.Areas.Admin.Models;
using MyBlog.Mvc.Halpers.Abstract;
using MyBlog.Services.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using NToastNotify;
using System.Text.Json.Serialization;
using System.Text.Json;
using MyBlog.Entities.ComplexTypes;
using MyBlog.Entities.Dtos.ProductDtos;
using MyBlog.Entities.Dtos.ArticleDtos;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Mvc.Consts;
using MyBlog.Mvc.Areas.Admin.Models.UserModels;
using MyBlog.Shared.Utilities.Results.Concrete;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]


    public class ProductAccessoryController : BaseController
    {
        private readonly IProductService _productService;
        private readonly IProductSubGroupService _productSubGroupService;
        private readonly IModelService _modelService;
        private readonly IBrandService _brandService;
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;
        public ProductAccessoryController(IProductService productService,
            IProductSubGroupService productSubGroupService,
            INotificationService notificationService,
            IModelService modelService,
            IBrandService brandService,
            IProductSubGroupService ProductSubGroupService,
        UserManager<User> userManager, IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _productSubGroupService = ProductSubGroupService;
            _productService = productService;
            _modelService = modelService;
            _brandService = brandService;
            _toastNotification = toastNotification;
            _notificationService = notificationService;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ProductRead}")]


        [HttpGet]
        public async Task<IActionResult> Index(string tableType)
        {
            ViewBag.tableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _productService.GetAllByNonDeletedAndActiveAccessoryAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _productService.GetAllByDeletedAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return NotFound();

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ProductRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllProducts(string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var products = await _productService.GetAllByNonDeletedAndActiveAccessoryAsync();
                var productResult = JsonSerializer.Serialize(products, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(productResult);

            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _productService.GetAllByDeletedAsync();
                var products = JsonSerializer.Serialize(result, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(products);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return Json(null);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ProductCreate}")]
        [HttpGet]
        public async Task<IActionResult> Add(string tableType)
        {
            ViewBag.tableType = tableType;
            var productSubGroupList = await _productSubGroupService.GetAllByNonDeletedAndActiveAsync();
            var modelList = await _modelService.GetAllByNonDeletedAndActiveAsync();
            var brandList = await _brandService.GetAllByNonDeletedAndActiveAccessoryAsync();
            var productList = await _productService.GetAllByNonDeletedAndActiveAccessoryAsync();

            if (productSubGroupList.ResultStatus == ResultStatus.Success &&
                modelList.ResultStatus == ResultStatus.Success &&
                brandList.ResultStatus == ResultStatus.Success &&
                productList.ResultStatus == ResultStatus.Success)
            {
                var user = await UserManager.GetUserAsync(HttpContext.User);
                var roles = await UserManager.GetRolesAsync(user);

                if (user != null && roles != null)
                {
                    var viewModel = new ProductAddViewModel
                    {
                        Models = modelList.Data.Models,
                        Brands = brandList.Data.Brands,
                        UserWithRolesModel = new UserWithRolesViewModel
                        {
                            User = user,
                            Roles = roles
                        }
                    };

                    return View(viewModel);
                }
            }

            return NotFound();
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ProductCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(ProductAddViewModel productAddViewModel, string tableType)
        {
            ModelState.Remove("tableType");
            ModelState.Remove("UserWithRolesModel");
            ModelState.Remove("ProductSubGroupId");
            ModelState.Remove("Brands");
            ModelState.Remove("Product");
            ModelState.Remove("ProductName");
            ModelState.Remove("SubModelId");
            productAddViewModel.SerialNumber = "0";
            if (ModelState.IsValid)
            {
                var productSubGroupAddDto = Mapper.Map<ProductAddDto>(productAddViewModel);
                productSubGroupAddDto.IsProduct = false;
                var result = await _productService.AddAsync(productSubGroupAddDto, LoggedInUser.UserName, LoggedInUser.Id);

                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                       NotificationMessageTypes.Added,
                       TableNamesConstants.Sales,
                       LoggedInUser.UserName),
                       NotificationMessageService.GetTitle(NotificationMessageTypes.Added), userId: LoggedInUser.Id
                       );

                    return RedirectToAction("Index", "ProductAccessory", new { tableType = tableType });
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                }
            }
            _toastNotification.AddErrorToastMessage("Başarısız!", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            ViewBag.tableType = tableType;
            var productSubGroupList = await _productSubGroupService.GetAllByNonDeletedAndActiveAsync();
            var modelList = await _modelService.GetAllByNonDeletedAndActiveAsync();
            var brandList = await _brandService.GetAllByNonDeletedAndActiveAccessoryAsync();
            var productList = await _productService.GetAllByNonDeletedAndActiveAccessoryAsync();

            if (productSubGroupList.ResultStatus == ResultStatus.Success &&
                modelList.ResultStatus == ResultStatus.Success &&
                brandList.ResultStatus == ResultStatus.Success &&
                productList.ResultStatus == ResultStatus.Success)
            {
                var user = await UserManager.GetUserAsync(HttpContext.User);
                var roles = await UserManager.GetRolesAsync(user);

                if (user != null && roles != null)
                {
                    var viewModel = new ProductAddViewModel
                    {
                        Models = modelList.Data.Models,
                        Brands = brandList.Data.Brands,
                        UserWithRolesModel = new UserWithRolesViewModel
                        {
                            User = user,
                            Roles = roles
                        }
                    };

                    return View(viewModel);
                }
            }

            return NotFound();

        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ProductUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int Id, string tableType)
        {
            var user = await UserManager.GetUserAsync(HttpContext.User);
            var roles = await UserManager.GetRolesAsync(user);
            ViewBag.tableType = tableType;
            var productList = await _productService.GetProductUpdateDtoAsync(Id);
            var productSubGroupList = await _productSubGroupService.GetAllByNonDeletedAndActiveAsync();
            var modelList = await _modelService.GetAllByNonDeletedAndActiveAsync();
            var brandList = await _brandService.GetAllByNonDeletedAndActiveAccessoryAsync();
            var model = await _modelService.GetAsync(productList.Data.ModelId);
            if (productSubGroupList.ResultStatus == ResultStatus.Success &&
               productList.ResultStatus == ResultStatus.Success &&
               brandList.ResultStatus == ResultStatus.Success &&
               modelList.ResultStatus == ResultStatus.Success)
            {
                var ProductUpdateViewModel = Mapper.Map<ProductUpdateViewModel>(productList.Data);
                ProductUpdateViewModel.BrandId = model.Data.Model.BrandId;
                ProductUpdateViewModel.Models = modelList.Data.Models;
                ProductUpdateViewModel.Brands = brandList.Data.Brands;
                ProductUpdateViewModel.UserWithRolesModel = new UserWithRolesViewModel
                {
                    User = user,
                    Roles = roles
                };
                return View(ProductUpdateViewModel);
            }
            else
            {
                return NotFound();
            }
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ProductUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(ProductUpdateViewModel ProductUpdateViewModel, string tableType)
        {
            ModelState.Remove("UserWithRolesModel");
            ModelState.Remove("tableType");
            ModelState.Remove("Brands");
            ModelState.Remove("ProductSubGroupId");
            ModelState.Remove("Product");
            ModelState.Remove("ProductName");
            ModelState.Remove("SubModelId");
            if (ModelState.IsValid)
            {
                var ProductUpdateDto = Mapper.Map<ProductUpdateDto>(ProductUpdateViewModel);
                ProductUpdateDto.IsProduct = false;

                var result = await _productService.UpdateAsync(ProductUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
   NotificationMessageTypes.Updated,
   TableNamesConstants.Sales,
   LoggedInUser.UserName),
   NotificationMessageService.GetTitle(NotificationMessageTypes.Updated), userId: LoggedInUser.Id
   );
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem!"
                    });
                    return RedirectToAction("Index", "ProductAccessory", new { tableType = tableType });
                }
                else
                {
                    _toastNotification.AddErrorToastMessage(ProductUpdateDto.Message, new ToastrOptions
                    {
                        Title = "Başarısız İşlem!"
                    });
                    ModelState.AddModelError("", result.Message);
                }
            }
            var productSubGroupList = await _productSubGroupService.GetAllByNonDeletedAndActiveAsync();
            var modelList = await _modelService.GetAllByNonDeletedAndActiveAsync();
            var productList = await _productService.GetAllByNonDeletedAndActiveAccessoryAsync();
            ProductUpdateViewModel.Models = modelList.Data.Models;
            var user = await UserManager.GetUserAsync(HttpContext.User);
            var roles = await UserManager.GetRolesAsync(user);
            ProductUpdateViewModel.UserWithRolesModel = new UserWithRolesViewModel
            {
                User = user,
                Roles = roles
            };
            return View(ProductUpdateViewModel);

        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ProductUpdate}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteFromUpdatePage(int Id, string tableType)
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                // Silme işlemi modaldan geldiyse normal controller işlemini yap => buradaki if koşulu bunun bir ajax sorgusuolup olamdığını kontrol eder.
                return await Delete(Id, tableType);
            }
            else
            {
                string errMessage = "";
                if (tableType == TableReturnTypesConstants.NonDeletedTables)
                {
                    var result = await _productService.DeleteAsync(Id, LoggedInUser.UserName);
                    if (result.ResultStatus == ResultStatus.Success)
                    {
                        _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                        {
                            Title = "Başarılı İşlem!"
                        });
                        return RedirectToAction("Index", "Product", new { tableType = tableType });
                    }
                    errMessage = result.Message;
                }
                else if (tableType == TableReturnTypesConstants.DeletedTables)
                {
                    var result = await _productService.HardDeleteAsync(Id);
                    if (result.ResultStatus == ResultStatus.Success)
                    {
                        _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                        {
                            Title = "Başarılı İşlem!"
                        });
                        return RedirectToAction("Index", "Product", new { tableType = tableType });
                    }
                    errMessage = result.Message;
                }
                _toastNotification.AddErrorToastMessage(errMessage, new ToastrOptions
                {
                    Title = "Başarısız İşlem!"
                });
                // Silme işlemi update sayfasından geldiyse index sayfasına yönlendir
                return RedirectToAction("Update");
            }
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ProductDelete}")]

        [HttpPost]
        public async Task<JsonResult> Delete(int productId, string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _productService.DeleteAsync(productId, LoggedInUser.UserName);
                var productResult = JsonSerializer.Serialize(result.Data);
                await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.Deleted,
TableNamesConstants.Sales,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.Deleted), userId: LoggedInUser.Id
);
                return Json(productResult);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _productService.HardDeleteAsync(productId);
                var hardDeletedProductResult = JsonSerializer.Serialize(result);
                await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.HardDeleted,
TableNamesConstants.Sales,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.HardDeleted), userId: LoggedInUser.Id
);
                return Json(hardDeletedProductResult);
            }
            else
            {
                // Hatalı silme türü parametresi durumunda hata döndürme
                return Json("Hatalı silme türü parametresi!");
            }
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ProductDelete}")]

        [HttpPost]
        public async Task<JsonResult> HardDelete(int productId)
        {
            var result = await _productService.HardDeleteAsync(productId);
            var hardDeletedProductResult = JsonSerializer.Serialize(result);
            return Json(hardDeletedProductResult);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ProductDelete}")]

        [HttpGet]
        public async Task<IActionResult> DeletedProducts()
        {
            var result = await _productService.GetAllByDeletedAsync();
            return View(result.Data);

        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ProductRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllDeletedProducts()
        {
            var result = await _productService.GetAllByDeletedAsync();
            var products = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(products);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ProductUpdate}")]
        [HttpPost]
        public async Task<JsonResult> UndoDelete(int productId)
        {
            var result = await _productService.UndoDeleteAsync(productId, LoggedInUser.UserName);
            var undoDeleteProductResult = JsonSerializer.Serialize(result.Data);
            await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.UndoDeleted,
TableNamesConstants.Sales,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.UndoDeleted), userId: LoggedInUser.Id
);
            return Json(undoDeleteProductResult);
        }

        [HttpGet]
        public async Task<IActionResult> LoadModels(int brandId)
        {
            // paymentTypeId'ye göre ilgili AssociatedInstitutions'ları asenkron olarak getir
            var models = await _modelService.GetAllByBrand(brandId);

            // associatedInstitutions listesini PartialView olarak dön
            return PartialView("_ModelListPartial", models.Data.Models);
        }

    }
}