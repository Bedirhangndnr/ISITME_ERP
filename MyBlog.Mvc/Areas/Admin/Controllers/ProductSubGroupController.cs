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
using MyBlog.Entities.Dtos.ProductSubGroupDtos;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Entities.Dtos.ProductSubGroupDtos;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Mvc.Consts;
using MyBlog.Services.Utilities;
using MyBlog.Entities.Dtos.ProductSubGroupDtos;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    

    public class ProductSubGroupController : BaseController
    {
        private readonly IProductSubGroupService _productSubGroupService;
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;


        public ProductSubGroupController(
            INotificationService notificationService,
            IProductSubGroupService productSubGroupService,
            UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _notificationService = notificationService;
            _productSubGroupService = productSubGroupService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ProductSubGroupRead}")]
        [HttpGet]
        public async Task<IActionResult> Index(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _productSubGroupService.GetAllByNonDeletedAndActiveAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _productSubGroupService.GetAllByDeletedAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile Karşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return View();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ProductSubGroupCreate}")]
        [HttpGet]
        public async Task<JsonResult> GetAllProductSubGroups(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var employeeTypes = await _productSubGroupService.GetAllByNonDeletedAndActiveAsync();
                var employeeTypeResult = JsonSerializer.Serialize(employeeTypes, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(employeeTypeResult);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _productSubGroupService.GetAllByDeletedAsync();
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ProductSubGroupCreate}")]
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_ProductSubGroupAddPartial");
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ProductSubGroupCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(ProductSubGroupAddDto productSubGroupAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _productSubGroupService.AddAsync(productSubGroupAddDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new ProductSubGroupAddAjaxViewModel
                    {
                        ProductSubGroupDto = result.Data,
                        ProductSubGroupAddPartial = await this.RenderViewToStringAsync("_ProductSubGroupAddPartial", productSubGroupAddDto)
                    });
                    return Json(categoryAddAjaxModel);
                }
            }
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new ProductSubGroupAddAjaxViewModel
            {
                ProductSubGroupAddPartial = await this.RenderViewToStringAsync("_ProductSubGroupAddPartial", productSubGroupAddDto)
            });
            return Json(categoryAddAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ProductSubGroupUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int productSubGroupId, string tableType)
        {
            ViewBag.TableType = tableType;
            var result = await _productSubGroupService.GetProductSubGroupUpdateDtoAsync(productSubGroupId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_ProductSubGroupUpdatePartial", result.Data);
            }
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ProductSubGroupUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(ProductSubGroupUpdateDto productSubGroupUpdateDto, string tableType)
        {
            ViewBag.tableType = tableType;
            if (ModelState.IsValid)
            {
                var result = await _productSubGroupService.UpdateAsync(productSubGroupUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                        NotificationMessageTypes.Updated,
                        "Geliştiriciye Mesaj",
                        result.Data.ProductSubGroup.ModifiedByName),
                        NotificationMessageService.GetTitle(NotificationMessageTypes.Updated), userId: LoggedInUser.Id
                        );
                    var categoryUpdateAjaxModel = JsonSerializer.Serialize(new ProductSubGroupUpdateAjaxViewModel
                    {
                        ProductSubGroupDto = result.Data,
                        ProductSubGroupUpdatePartial = await this.RenderViewToStringAsync("_ProductSubGroupUpdatePartial", productSubGroupUpdateDto)
                    });
                    return Json(categoryUpdateAjaxModel);
                }
            }
            var categoryUpdateAjaxErrorModel = JsonSerializer.Serialize(new ProductSubGroupUpdateAjaxViewModel
            {
                ProductSubGroupUpdatePartial = await this.RenderViewToStringAsync("_ProductSubGroupUpdatePartial", productSubGroupUpdateDto)
            });
            return Json(categoryUpdateAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ProductSubGroupDelete}")]
        [HttpPost]
        public async Task<JsonResult> Delete(int productSubGroupId, string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _productSubGroupService.DeleteAsync(productSubGroupId, LoggedInUser.UserName);
                var deletedProductSubGroup = JsonSerializer.Serialize(result.Data);
                return Json(deletedProductSubGroup);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _productSubGroupService.HardDeleteAsync(productSubGroupId);
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ProductSubGroupDelete}")]
        public async Task<JsonResult> UndoDelete(int productSubGroupId)
        {
            var result = await _productSubGroupService.UndoDeleteAsync(productSubGroupId, LoggedInUser.UserName);
            var undoDeletedProductSubGroup = JsonSerializer.Serialize(result.Data);
            return Json(undoDeletedProductSubGroup);
        }
    }
}