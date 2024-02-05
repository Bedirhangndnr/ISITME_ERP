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
using MyBlog.Entities.Dtos.SaleDtos;
using MyBlog.Entities.Dtos.ArticleDtos;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Shared.Utilities.Results.Concrete;
using MyBlog.Mvc.Consts;
using MyBlog.Entities.Dtos.ProductDtos;
using MyBlog.Shared.Utilities.Results;
using Microsoft.CodeAnalysis.FlowAnalysis;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SaleController : BaseController
    {
        private readonly ISaleService _saleService;
        private readonly ISaleTypeService _saleTypeService;
        private readonly ISaleStatusService _saleStatusService;
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;
        private readonly IEmployeeService _employeeService;
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;
        private readonly IParameterService _parameterService;


        public SaleController(ISaleService saleService,
        ISaleTypeService saleTypeService,
        ISaleStatusService saleStatusService,
        IProductService productService,
        INotificationService notificationService,
        ICustomerService customerService,
        IParameterService parameterService,
        IEmployeeService employeeService,
        ISaleTypeService SaleTypeService, UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _saleService = saleService;
            _saleTypeService = SaleTypeService;
            _saleStatusService = saleStatusService;
            _productService = productService;
            _customerService = customerService;
            _notificationService = notificationService;
            _parameterService = parameterService;

            _employeeService = employeeService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.SaleRead}")]
        [HttpGet]
        public async Task<IActionResult> Index(string tableType, int customerId = 0, string customerName = "")
        {
            ViewBag.tableType = tableType;
            var user = await UserManager.GetUserAsync(HttpContext.User);
            var roles = await UserManager.GetRolesAsync(user);
            ViewBag.User = user;
            ViewBag.Roles = roles;
            bool isSuperAdmin = User.IsInRole(AuthorizeDefinitionConstants.SuperAdmin);
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                IDataResult<SaleListDto> result;
                if (customerId == 0)
                {
                    result = await _saleService.GetAllByNonDeletedAndActiveAsync(isSuperAdmin);
                }
                else
                {
                    ViewBag.customerName = customerName + " Hastasına Ait";
                    result = await _saleService.GetAllByNonDeletedAndActiveByCustomerIdAsync(isSuperAdmin, customerId);
                }

                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _saleService.GetAllByDeletedAsync(isSuperAdmin);
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.SaleRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllSales(string tableType)
        {
            ViewBag.tableType = tableType;
            var user = await UserManager.GetUserAsync(HttpContext.User);
            var roles = await UserManager.GetRolesAsync(user);
            ViewBag.User = user;
            ViewBag.Roles = roles;
            bool isSuperAdmin = User.IsInRole(AuthorizeDefinitionConstants.SuperAdmin);
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var sales = await _saleService.GetAllByNonDeletedAndActiveAsync(isSuperAdmin);
                var saleResult = JsonSerializer.Serialize(sales, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(saleResult);

            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _saleService.GetAllByDeletedAsync(isSuperAdmin);
                var sales = JsonSerializer.Serialize(result, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(sales);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return Json(null);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSalesByCustomerId(string tableType, int customerId)
        {
            ViewBag.tableType = tableType;
            var user = await UserManager.GetUserAsync(HttpContext.User);
            var roles = await UserManager.GetRolesAsync(user);
            ViewBag.User = user;
            ViewBag.Roles = roles;
            bool isSuperAdmin = User.IsInRole(AuthorizeDefinitionConstants.SuperAdmin);
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _saleService.GetAllByNonDeletedAndActiveAsync(isSuperAdmin);
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _saleService.GetAllByDeletedAsync(isSuperAdmin);
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return NotFound();
            //ViewBag.tableType = tableType;
            //var user = await UserManager.GetUserAsync(HttpContext.User);
            //var roles = await UserManager.GetRolesAsync(user);
            //ViewBag.User = user;
            //ViewBag.Roles = roles;
            //bool isSuperAdmin = User.IsInRole(AuthorizeDefinitionConstants.SuperAdmin);
            //if (tableType == TableReturnTypesConstants.NonDeletedTables)
            //{
            //    var result = await _saleService.GetAllByNonDeletedAndActiveByCustomerIdAsync(isSuperAdmin, customerId);
            //    if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            //}
            //else if (tableType == TableReturnTypesConstants.DeletedTables)
            //{
            //    var result = await _saleService.GetAllByDeletedAsync(isSuperAdmin);
            //    if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            //}
            //_toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            //{
            //    Title = "Başarısız İşlem!"
            //});
            //return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.SaleCreate}")]
        [HttpGet]
        public async Task<IActionResult> Add(string tableType)
        {
            ViewBag.tableType = tableType;
            var saleTypeList = await _saleTypeService.GetAllByNonDeletedAndActiveAsync();
            var saleStatusList = await _saleStatusService.GetAllByNonDeletedAndActiveAsync();
            var customerList = await _customerService.GetAllByNonDeletedAndActiveAsync();
            var productList = await _productService.GetAllProductsAsync();
            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            var sgkList = await _parameterService.GetForSGK();
            if ((saleTypeList.ResultStatus == ResultStatus.Success &&
                 saleStatusList.ResultStatus == ResultStatus.Success &&
                 customerList.ResultStatus == ResultStatus.Success &&
                 productList.ResultStatus == ResultStatus.Success &&
                 sgkList.ResultStatus == ResultStatus.Success &&
                 employeeList.ResultStatus == ResultStatus.Success))
            {
                return View(new SaleAddViewModel
                {
                    Customers = customerList.Data.Customers,
                    Employees = employeeList.Data.Employees,
                    Products = productList.Data.Products,
                    SgkList = sgkList.Data.Parameters,
                    ProductListWithRelatedTables = productList.Data.ProductListWithRelatedTables,
                    SaleStatuses = saleStatusList.Data.SaleStatuses,
                    SaleTypes = saleTypeList.Data.SaleTypes
                });
            }
            else
            {
                _toastNotification.AddErrorToastMessage(employeeList.Message, new ToastrOptions
                {
                    Title = "İşlem Başarısız."
                });
            }
            return NotFound();
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.SaleCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] SaleAddRequest request)
        {
            SaleAddViewModel saleAddViewModel = new SaleAddViewModel();
            if (request.SaleAddViewModelList != null || request.SaleAddViewModelList.Count > 0)
            {
                foreach (var saleAddViewModel_ in request.SaleAddViewModelList)
                {

                    // Product Id Kontrolü eklenecek. satışlar içinde zate navrsa bu product id satışı olamaması gerekir. 
                    if (saleAddViewModel_.SgkId != null)
                    {
                        var parameter = _parameterService.GetAsync(saleAddViewModel_.SgkId.Value);
                        saleAddViewModel_.SgkTypeTitle = parameter.Result.Data.Parameter.ParamType;
                        saleAddViewModel_.AmountOfSgk = Convert.ToDecimal(parameter.Result.Data.Parameter.ParamValue);
                    }
                    var saleAddDto = Mapper.Map<SaleAddDto>(saleAddViewModel_);
                    if (saleAddViewModel_.IsDelivered)
                    {
                        saleAddDto.DeliveryDate = DateTime.Now;
                    }
                    IDataResult<ProductUpdateDto> productUpdateDto = await _productService.GetProductUpdateDtoAsync(saleAddDto.ProductId);
                    if (productUpdateDto.Data.IsProduct == true)
                    {
                        productUpdateDto.Data.IsSold = true;
                    }
                    productUpdateDto.Data.Quantity--;
                    var productUpdateResult = await _productService.UpdateAsync(productUpdateDto.Data, LoggedInUser.UserName);
                    var result = await _saleService.AddAsync(saleAddDto, LoggedInUser.UserName, LoggedInUser.Id);

                    if (!(result.ResultStatus == ResultStatus.Success && productUpdateResult.ResultStatus == ResultStatus.Success))
                    {
                        // Eğer bir işlemde hata oluşursa, hata mesajını ekle ve döngüden çık
                        ModelState.AddModelError("", result.Message);
                        break;
                    }
                }
                return Json(new { Success = true, Message = "Satış başarıyla eklendi." });

                //_toastNotification.AddSuccessToastMessage("Tüm satışlar başarıyla eklendi.", new ToastrOptions { Title = "Başarılı İşlem!" });
                //return RedirectToAction("Index", "Sale", new { tableType = request.TableType });
            }
            else
            {
                return BadRequest("Ürün silme işlemi başarısız oldu: ");
            }

        }

        private async Task LoadListsForViewModel(List<SaleAddViewModel> saleAddViewModelList)
        {
            // Bu metot, ViewModel için gerekli listeleri yükler
            var saleTypeList = await _saleTypeService.GetAllByNonDeletedAndActiveAsync();
            var saleStatusList = await _saleStatusService.GetAllByNonDeletedAndActiveAsync();
            var customerList = await _customerService.GetAllByNonDeletedAndActiveAsync();
            var productList = await _productService.GetAllByNonDeletedAndActiveAsync(true);
            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();

            foreach (var viewModel in saleAddViewModelList)
            {
                viewModel.Customers = customerList.Data.Customers;
                viewModel.Employees = employeeList.Data.Employees;
                viewModel.Products = productList.Data.Products;
                viewModel.SaleStatuses = saleStatusList.Data.SaleStatuses;
                viewModel.SaleTypes = saleTypeList.Data.SaleTypes;
            }
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.SaleUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int Id, string tableType)
        {
            ViewBag.tableType = tableType;
            
           
            var saleList = await _saleService.GetSaleUpdateDtoAsync(Id);
            var saleTypeList = await _saleTypeService.GetAllByNonDeletedAndActiveAsync();
            var saleStatusList = await _saleStatusService.GetAllByNonDeletedAndActiveAsync();
            var customerList = await _customerService.GetAllByNonDeletedAndActiveAsync();
            var productList = await _productService.GetAllProductsAsync();
            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            var sgkList = await _parameterService.GetForSGK();
            if ((saleTypeList.ResultStatus == ResultStatus.Success &&
                 saleStatusList.ResultStatus == ResultStatus.Success &&
                 customerList.ResultStatus == ResultStatus.Success &&
                 productList.ResultStatus == ResultStatus.Success &&
                 sgkList.ResultStatus == ResultStatus.Success &&
                 employeeList.ResultStatus == ResultStatus.Success))
            {
                var SaleUpdateViewModel = Mapper.Map<SaleUpdateViewModel>(saleList.Data);
                SaleUpdateViewModel.OldProductId = SaleUpdateViewModel.ProductId;
                SaleUpdateViewModel.Customers = customerList.Data.Customers;
                SaleUpdateViewModel.SgkList = sgkList.Data.Parameters;
                SaleUpdateViewModel.Employees = employeeList.Data.Employees;
                SaleUpdateViewModel.ProductListWithRelatedTables = productList.Data.ProductListWithRelatedTables;
                SaleUpdateViewModel.SaleStatuses = saleStatusList.Data.SaleStatuses;
                SaleUpdateViewModel.SaleTypes = saleTypeList.Data.SaleTypes;

                return View(SaleUpdateViewModel);
            }
            else
            {
                return NotFound();
            }
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.SaleUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(SaleUpdateViewModel SaleUpdateViewModel, string tableType)
        {
            ModelState.Remove("tableType");
            if (ModelState.IsValid)
            {
                var saleUpdateDto = Mapper.Map<SaleUpdateDto>(SaleUpdateViewModel);
                if (SaleUpdateViewModel.OldProductId != SaleUpdateViewModel.ProductId)
                {
                    IDataResult<ProductUpdateDto> oldProductUpdateDto = await _productService.GetProductUpdateDtoAsync(SaleUpdateViewModel.OldProductId.Value);
                    oldProductUpdateDto.Data.IsSold = false;
                    var oldProductUpdateResult = await _productService.UpdateAsync(oldProductUpdateDto.Data, LoggedInUser.UserName);

                    IDataResult<ProductUpdateDto> productUpdateDto = await _productService.GetProductUpdateDtoAsync(SaleUpdateViewModel.ProductId.Value);
                    productUpdateDto.Data.IsSold = true;
                    var productUpdateResult = await _productService.UpdateAsync(productUpdateDto.Data, LoggedInUser.UserName);
                }

                var result = await _saleService.UpdateAsync(saleUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    _toastNotification.AddSuccessToastMessage(saleUpdateDto.Message, new ToastrOptions
                    {
                        Title = "Güncelleme Başarılı!"
                    });
                    return RedirectToAction("Index", "Sale", new { tableType = tableType });
                }
                else
                {
                    _toastNotification.AddErrorToastMessage(saleUpdateDto.Message, new ToastrOptions
                    {
                        Title = "Başarısız İşlem!"
                    });
                    ModelState.AddModelError("", result.Message);
                }
            }
            var saleStatusList = await _saleStatusService.GetAllByNonDeletedAndActiveAsync();
            var customerList = await _customerService.GetAllByNonDeletedAndActiveAsync();
            var productList = await _productService.GetAllByNonDeletedAndActiveAsync();
            var saleTypeList = await _saleTypeService.GetAllByNonDeletedAndActiveAsync();
            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            SaleUpdateViewModel.Customers = customerList.Data.Customers;
            SaleUpdateViewModel.Employees = employeeList.Data.Employees;
            SaleUpdateViewModel.Products = productList.Data.Products;
            SaleUpdateViewModel.SaleStatuses = saleStatusList.Data.SaleStatuses;
            SaleUpdateViewModel.SaleTypes = saleTypeList.Data.SaleTypes;
            return View(SaleUpdateViewModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.SaleUpdate}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteFromUpdatePage(int saleId, string tableType)
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                // Silme işlemi modaldan geldiyse normal controller işlemini yap => buradaki if koşulu bunun bir ajax sorgusuolup olamdığını kontrol eder.
                return await Delete(saleId, tableType);
            }
            else
            {
                string errMessage = "";
                if (tableType == TableReturnTypesConstants.NonDeletedTables)
                {
                    var result = await _saleService.DeleteAsync(saleId, LoggedInUser.UserName);
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
                        return RedirectToAction("Index", "Sale", new { tableType = tableType });
                    }
                    errMessage = result.Message;
                }
                else if (tableType == TableReturnTypesConstants.DeletedTables)
                {
                    var result = await _saleService.HardDeleteAsync(saleId);
                    if (result.ResultStatus == ResultStatus.Success)
                    {
                        _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                        {
                            Title = "Başarılı İşlem!"
                        });
                        return RedirectToAction("Index", "Sale", new { tableType = tableType });
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.SaleDelete}")]
        [HttpPost]
        public async Task<JsonResult> Delete(int saleId, string tableType)
        {
            var result = await _saleService.DeleteAsync(saleId, LoggedInUser.UserName);
            var saleResult = JsonSerializer.Serialize(result.Data);
            IDataResult<ProductUpdateDto> oldProductUpdateDto = await _productService.GetProductUpdateDtoAsync(result.Data.Sale.ProductId);
            oldProductUpdateDto.Data.IsSold = false;
            oldProductUpdateDto.Data.Quantity = oldProductUpdateDto.Data.Quantity + 1 ; 
            var oldProductUpdateResult = await _productService.UpdateAsync(oldProductUpdateDto.Data, LoggedInUser.UserName);
            await _notificationService.AddAsync(NotificationMessageService.GetMessage(
               NotificationMessageTypes.Deleted,
               TableNamesConstants.Sales,
               LoggedInUser.UserName),
               NotificationMessageService.GetTitle(NotificationMessageTypes.Deleted), userId: LoggedInUser.Id
               );
            return Json(saleResult);
        }
        private async Task UpdateProductIsSold(int productId, bool isSold)
        {
            var product = await _productService.GetProductUpdateDtoAsync(productId);
            var productUpdateViewModel = Mapper.Map<ProductUpdateViewModel>(product.Data);
            var productUpdateDto = Mapper.Map<ProductUpdateDto>(productUpdateViewModel);


            if (productUpdateDto != null)
            {
                productUpdateDto.IsSold = isSold;
                var result = await _productService.UpdateAsync(productUpdateDto, LoggedInUser.UserName);
            }

        }

        [HttpPost]
        public async Task<IActionResult> DeleteProduct(int saleId)
        {
            var sale = await _saleService.GetSaleUpdateDtoAsync(saleId);
            var productId = sale.Data.ProductId;
            try
            {
                await _saleService.HardDeleteAsync(saleId);
                var result = await _productService.HardDeleteAsync(productId);
                return Ok("Ürün silindi.");
            }
            catch (Exception ex)
            {
                return BadRequest("Ürün silme işlemi başarısız oldu: " + ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> UpdateIsSold(int saleId, bool isSold)
        {
            var sale = await _saleService.GetSaleUpdateDtoAsync(saleId);
            var productId = sale.Data.ProductId;
            try
            {
                await _saleService.HardDeleteAsync(saleId);
                await UpdateProductIsSold(productId, isSold);
                return Ok("IsSold değeri güncellendi.");
            }
            catch (Exception ex)
            {
                return BadRequest("IsSold değeri güncelleme işlemi başarısız oldu: " + ex.Message);
            }
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.SaleDelete}")]

        [HttpPost]
        public async Task<IActionResult> HardDelete(int id)
        {
            var result = await _saleService.HardDeleteAsync(id);

            if (result.ResultStatus == ResultStatus.Success)
            {
                return Json(new { success = true, deletedSaleId = id });
            }
            else
            {
                return Json(new { success = false, message = result.Message });
            }
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.SaleDelete}")]

        [HttpGet]
        public async Task<IActionResult> DeletedSales()
        {
            var user = await UserManager.GetUserAsync(HttpContext.User);
            var roles = await UserManager.GetRolesAsync(user);
            ViewBag.User = user;
            ViewBag.Roles = roles;
            bool isSuperAdmin = User.IsInRole(AuthorizeDefinitionConstants.SuperAdmin);
            var result = await _saleService.GetAllByDeletedAsync(isSuperAdmin);
            return View(result.Data);

        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.SaleRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllDeletedSales()
        {
            var user = await UserManager.GetUserAsync(HttpContext.User);
            var roles = await UserManager.GetRolesAsync(user);
            ViewBag.User = user;
            ViewBag.Roles = roles;
            bool isSuperAdmin = User.IsInRole(AuthorizeDefinitionConstants.SuperAdmin);
            var result = await _saleService.GetAllByDeletedAsync(isSuperAdmin);
            var sales = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(sales);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.SaleUpdate}")]
        [HttpPost]
        public async Task<JsonResult> UndoDelete(int saleId)
        {
            await _notificationService.AddAsync(NotificationMessageService.GetMessage(
    NotificationMessageTypes.UndoDeleted,
    TableNamesConstants.Sales,
    LoggedInUser.UserName),
    NotificationMessageService.GetTitle(NotificationMessageTypes.UndoDeleted), userId: LoggedInUser.Id
    );
            var result = await _saleService.UndoDeleteAsync(saleId, LoggedInUser.UserName);
            var undoDeleteSaleResult = JsonSerializer.Serialize(result.Data);
            return Json(undoDeleteSaleResult);
        }

    }
}

