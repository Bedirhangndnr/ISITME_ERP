using Microsoft.AspNetCore.Mvc;
using MyBlog.Services.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Mvc.Areas.Admin.Models;
using AutoMapper;
using MyBlog.Entities.ComplexTypes;
using MyBlog.Entities.Dtos;
using MyBlog.Mvc.Halpers.Abstract;
using Microsoft.AspNetCore.Identity;
using MyBlog.Entities.Concrete;
using System.Text.Json.Serialization;
using System.Text.Json;
using NToastNotify;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using MyBlog.Entities.Dtos.CustomerReferanceDtos;
using MyBlog.Entities.Dtos.ProductGroupDtos;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Mvc.Consts;
using MyBlog.Services.Utilities;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    

    public class ProductGroupController : BaseController
    {
        private readonly IProductGroupService _productGroupService;
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;


        public ProductGroupController(
            INotificationService notificationService,
            IProductGroupService productGroupService,
            UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _notificationService = notificationService;
            _productGroupService = productGroupService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductGroupRead}")]
        [HttpGet]
        public async Task<IActionResult> Index(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _productGroupService.GetAllByNonDeletedAndActiveAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _productGroupService.GetAllByDeletedAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return View();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductGroupRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllProductGroups(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var employeeTypes = await _productGroupService.GetAllByNonDeletedAndActiveAsync();
                var employeeTypeResult = JsonSerializer.Serialize(employeeTypes, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(employeeTypeResult);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _productGroupService.GetAllByDeletedAsync();
                var rmployeeTypes = JsonSerializer.Serialize(result, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(rmployeeTypes);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile Karşılaşıldı *", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return Json(null);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductGroupCreate}")]
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_ProductGroupAddPartial");
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductGroupCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(ProductGroupAddDto productGroupAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _productGroupService.AddAsync(productGroupAddDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new ProductGroupAddAjaxViewModel
                    {
                        ProductGroupDto = result.Data,
                        ProductGroupAddPartial = await this.RenderViewToStringAsync("_ProductGroupAddPartial", productGroupAddDto)
                    });
                    return Json(categoryAddAjaxModel);
                }
            }
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new ProductGroupAddAjaxViewModel
            {
                ProductGroupAddPartial = await this.RenderViewToStringAsync("_ProductGroupAddPartial", productGroupAddDto)
            });
            return Json(categoryAddAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductGroupUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int productGroupId, string tableType)
        {
            ViewBag.TableType = tableType;
            var result = await _productGroupService.GetProductGroupUpdateDtoAsync(productGroupId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_ProductGroupUpdatePartial", result.Data);
            }
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductGroupUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(ProductGroupUpdateDto productGroupUpdateDto, string tableType)
        {
            ViewBag.tableType = tableType;
            if (ModelState.IsValid)
            {
                var result = await _productGroupService.UpdateAsync(productGroupUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                        NotificationMessageTypes.Updated,
                        "Marka",
                        result.Data.ProductGroup.ModifiedByName),
                        NotificationMessageService.GetTitle(NotificationMessageTypes.Updated), userId: LoggedInUser.Id
                        );
                    var categoryUpdateAjaxModel = JsonSerializer.Serialize(new ProductGroupUpdateAjaxViewModel
                    {
                        ProductGroupDto = result.Data,
                        ProductGroupUpdatePartial = await this.RenderViewToStringAsync("_ProductGroupUpdatePartial", productGroupUpdateDto)
                    });
                    return Json(categoryUpdateAjaxModel);
                }
            }
            var categoryUpdateAjaxErrorModel = JsonSerializer.Serialize(new ProductGroupUpdateAjaxViewModel
            {
                ProductGroupUpdatePartial = await this.RenderViewToStringAsync("_ProductGroupUpdatePartial", productGroupUpdateDto)
            });
            return Json(categoryUpdateAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductGroupDelete}")]
        [HttpPost]
        public async Task<JsonResult> Delete(int productGroupId, string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _productGroupService.DeleteAsync(productGroupId, LoggedInUser.UserName);
                var deletedProductGroup = JsonSerializer.Serialize(result.Data);
                return Json(deletedProductGroup);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _productGroupService.HardDeleteAsync(productGroupId);
                var hardDeletedAppointmentResult = JsonSerializer.Serialize(result);
                return Json(hardDeletedAppointmentResult);
            }
            else
            {
                // Hatalı silme türü parametresi durumunda hata döndürme
                return Json("Hatalı silme türü parametresi!");
            }
        }
        [HttpPost]
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductGroupDelete}")]
        public async Task<JsonResult> UndoDelete(int productGroupId)
        {
            var result = await _productGroupService.UndoDeleteAsync(productGroupId, LoggedInUser.UserName);
            var undoDeletedProductGroup = JsonSerializer.Serialize(result.Data);
            return Json(undoDeletedProductGroup);
        }
    }
}