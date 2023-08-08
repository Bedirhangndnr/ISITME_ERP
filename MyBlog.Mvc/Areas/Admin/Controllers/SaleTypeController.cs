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
using MyBlog.Entities.Dtos.SaleTypeDtos;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Services.Utilities;
using MyBlog.Mvc.Consts; 
namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Editor")]

    public class SaleTypeController : BaseController
    {
        private readonly ISaleTypeService _saleTypeService;
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;


        public SaleTypeController(
            INotificationService notificationService,
            ISaleTypeService saleTypeService,
            UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _notificationService = notificationService;
            _saleTypeService = saleTypeService;
            _toastNotification = toastNotification;
        }

        [HttpGet]
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.SaleTypeRead}")]
        public async Task<IActionResult> Index(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _saleTypeService.GetAllByNonDeletedAndActiveAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _saleTypeService.GetAllByDeletedAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return View();
        }
        [HttpGet]
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.SaleTypeRead}")]
        public async Task<JsonResult> GetAllSaleTypes(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var employeeTypes = await _saleTypeService.GetAllByNonDeletedAndActiveAsync();
                var employeeTypeResult = JsonSerializer.Serialize(employeeTypes, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(employeeTypeResult);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _saleTypeService.GetAllByDeletedAsync();
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
        [HttpGet]
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.SaleTypeCreate}")]

        public IActionResult Add()
        {
            return PartialView("_SaleTypeAddPartial");
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.SaleTypeCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(SaleTypeAddDto saleTypeAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _saleTypeService.AddAsync(saleTypeAddDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new SaleTypeAddAjaxViewModel
                    {
                        SaleTypeDto = result.Data,
                        SaleTypeAddPartial = await this.RenderViewToStringAsync("_SaleTypeAddPartial", saleTypeAddDto)
                    });
                    return Json(categoryAddAjaxModel);
                }
            }
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new SaleTypeAddAjaxViewModel
            {
                SaleTypeAddPartial = await this.RenderViewToStringAsync("_SaleTypeAddPartial", saleTypeAddDto)
            });
            return Json(categoryAddAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.SaleTypeUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int saleTypeId, string tableType)
        {
            ViewBag.TableType = tableType;
            var result = await _saleTypeService.GetSaleTypeUpdateDtoAsync(saleTypeId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_SaleTypeUpdatePartial", result.Data);
            }
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.SaleTypeUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(SaleTypeUpdateDto saleTypeUpdateDto, string tableType)
        {
            ViewBag.tableType = tableType;
            if (ModelState.IsValid)
            {
                var result = await _saleTypeService.UpdateAsync(saleTypeUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                        NotificationMessageTypes.Updated,
                        "Marka",
                        result.Data.SaleType.ModifiedByName),
                        NotificationMessageService.GetTitle(NotificationMessageTypes.Updated), userId: LoggedInUser.Id
                        );
                    var categoryUpdateAjaxModel = JsonSerializer.Serialize(new SaleTypeUpdateAjaxViewModel
                    {
                        SaleTypeDto = result.Data,
                        SaleTypeUpdatePartial = await this.RenderViewToStringAsync("_SaleTypeUpdatePartial", saleTypeUpdateDto)
                    });
                    return Json(categoryUpdateAjaxModel);
                }
            }
            var categoryUpdateAjaxErrorModel = JsonSerializer.Serialize(new SaleTypeUpdateAjaxViewModel
            {
                SaleTypeUpdatePartial = await this.RenderViewToStringAsync("_SaleTypeUpdatePartial", saleTypeUpdateDto)
            });
            return Json(categoryUpdateAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.SaleTypeDelete}")]
        [HttpPost]
        public async Task<JsonResult> Delete(int saleTypeId, string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _saleTypeService.DeleteAsync(saleTypeId, LoggedInUser.UserName);
                var deletedSaleType = JsonSerializer.Serialize(result.Data);
                return Json(deletedSaleType);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _saleTypeService.HardDeleteAsync(saleTypeId);
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.SaleStatusDelete}")]
        public async Task<JsonResult> UndoDelete(int saleTypeId)
        {
            var result = await _saleTypeService.UndoDeleteAsync(saleTypeId, LoggedInUser.UserName);
            var undoDeletedSaleType = JsonSerializer.Serialize(result.Data);
            return Json(undoDeletedSaleType);
        }
    }
}