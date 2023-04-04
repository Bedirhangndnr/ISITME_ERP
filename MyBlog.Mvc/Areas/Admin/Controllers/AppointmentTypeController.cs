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
using MyBlog.Entities.Dtos.AppointmentTypeDtos;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Entities.Dtos.AppointmentTypeDtos;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Mvc.Consts;
using MyBlog.Services.Utilities;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Editor")]

    public class AppointmentTypeController : BaseController
    {
        private readonly IAppointmentTypeService _appointmentTypeService;
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;


        public AppointmentTypeController(
            INotificationService notificationService,
            IAppointmentTypeService appointmentTypeService,
            UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _notificationService = notificationService;
            _appointmentTypeService = appointmentTypeService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.AppointmentTypeRead}")]
        [HttpGet]
        public async Task<IActionResult> Index(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _appointmentTypeService.GetAllByNonDeletedAndActiveAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _appointmentTypeService.GetAllByDeletedAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return View();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.AppointmentTypeRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllAppointmentTypes(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var employeeTypes = await _appointmentTypeService.GetAllByNonDeletedAndActiveAsync();
                var employeeTypeResult = JsonSerializer.Serialize(employeeTypes, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(employeeTypeResult);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _appointmentTypeService.GetAllByDeletedAsync();
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.AppointmentTypeCreate}")]
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_AppointmentTypeAddPartial");
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.AppointmentTypeCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(AppointmentTypeAddDto appointmentTypeAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _appointmentTypeService.AddAsync(appointmentTypeAddDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                        NotificationMessageTypes.Updated,
                        TableNamesConstants.AppointmentTypes,
                        result.Data.AppointmentType.ModifiedByName),
                        NotificationMessageService.GetTitle(NotificationMessageTypes.Updated)
                        );
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new AppointmentTypeAddAjaxViewModel
                    {
                        AppointmentTypeDto = result.Data,
                        AppointmentTypeAddPartial = await this.RenderViewToStringAsync("_AppointmentTypeAddPartial", appointmentTypeAddDto)
                    });
                    return Json(categoryAddAjaxModel);
                }
            }
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new AppointmentTypeAddAjaxViewModel
            {
                AppointmentTypeAddPartial = await this.RenderViewToStringAsync("_AppointmentTypeAddPartial", appointmentTypeAddDto)
            });
            return Json(categoryAddAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.AppointmentTypeUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int appointmentTypeId, string tableType)
        {
            ViewBag.TableType = tableType;
            var result = await _appointmentTypeService.GetAppointmentTypeUpdateDtoAsync(appointmentTypeId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_AppointmentTypeUpdatePartial", result.Data);
            }
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.AppointmentTypeUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(AppointmentTypeUpdateDto categoryUpdateDto, string tableType)
        {
            ViewBag.tableType = tableType;
            if (ModelState.IsValid)
            {
                var result = await _appointmentTypeService.UpdateAsync(categoryUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                        NotificationMessageTypes.Updated,
                        TableNamesConstants.AppointmentTypes,
                        result.Data.AppointmentType.ModifiedByName),
                        NotificationMessageService.GetTitle(NotificationMessageTypes.Updated)
                        );
                    var categoryUpdateAjaxModel = JsonSerializer.Serialize(new AppointmentTypeUpdateAjaxViewModel
                    {
                        AppointmentTypeDto = result.Data,
                        AppointmentTypeUpdatePartial = await this.RenderViewToStringAsync("_AppointmentTypeUpdatePartial", categoryUpdateDto)
                    });
                    return Json(categoryUpdateAjaxModel);
                }
            }
            var categoryUpdateAjaxErrorModel = JsonSerializer.Serialize(new AppointmentTypeUpdateAjaxViewModel
            {
                AppointmentTypeUpdatePartial = await this.RenderViewToStringAsync("_AppointmentTypeUpdatePartial", categoryUpdateDto)
            });
            return Json(categoryUpdateAjaxErrorModel);

        }
        //[Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.AppointmentTypeDelete}")]
        //    [HttpPost]
        //    public async Task<JsonResult> Delete(int appointmentTypeId)
        //    {
        //        var result = await _appointmentTypeService.DeleteAsync(appointmentTypeId, LoggedInUser.UserName);
        //        var deletedAppointmentType = JsonSerializer.Serialize(result.Data);
        //        return Json(deletedAppointmentType);
        //    }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.AppointmentTypeDelete}")]
        [HttpPost]
        public async Task<JsonResult> Delete(int appointmentTypeId, string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _appointmentTypeService.DeleteAsync(appointmentTypeId, LoggedInUser.UserName);
                var deletedAppointmentType = JsonSerializer.Serialize(result.Data);
                return Json(deletedAppointmentType);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _appointmentTypeService.HardDeleteAsync(appointmentTypeId);
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
        [Authorize(Roles = "SuperAdmin, AppointmentType.Update")]
        public async Task<JsonResult> UndoDelete(int appointmentTypeId)
        {
            var result = await _appointmentTypeService.UndoDeleteAsync(appointmentTypeId, LoggedInUser.UserName);
            var undoDeletedAppointmentType = JsonSerializer.Serialize(result.Data);
            return Json(undoDeletedAppointmentType);
        }
        [Authorize(Roles = "SuperAdmin, AppointmentType.Update")]
        [HttpGet]
        public async Task<IActionResult> HardDelete(int appointmentTypeId)
        {
            var result = await _appointmentTypeService.HardDeleteAsync(appointmentTypeId);
            var deletedAppointmentType = JsonSerializer.Serialize(result);
            return View(deletedAppointmentType);

        }
    }
}