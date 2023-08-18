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
using MyBlog.Entities.Dtos.NotificationDtos;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Mvc.Consts;
using MyBlog.Services.Utilities;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    

    public class NotificationController : BaseController
    {
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;


        public NotificationController(INotificationService notificationService, UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _notificationService = notificationService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.NotificationRead}")]
        [HttpGet]
        public async Task<IActionResult> Index(string tableType, string notificationType)
        {
            ViewBag.tableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _notificationService.GetAllByNonDeletedAndActiveAsync(notificationType);
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.NotificationRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllNotifications(string notificationType)
        {
            var notifications = await _notificationService.GetAllByNonDeletedAndActiveAsync(notificationType);
            var notificationResult = JsonSerializer.Serialize(notifications, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(notificationResult);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.NotificationUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int notificationId)
        {
            var result = await _notificationService.GetNotificationUpdateDtoAsync(notificationId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_NotificationUpdatePartial", result.Data);
            }
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.NotificationUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(NotificationUpdateDto categoryUpdateDto)
        {
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.NotificationDelete}")]
        [HttpPost]
        public async Task<JsonResult> Delete(int notificationId, string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _notificationService.DeleteAsync(notificationId, LoggedInUser.UserName);
                var notificationResult = JsonSerializer.Serialize(result.Data);
                return Json(notificationResult);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _notificationService.HardDeleteAsync(notificationId);
                var hardDeletedNotificationResult = JsonSerializer.Serialize(result);
                return Json(hardDeletedNotificationResult);
            }
            else
            {
                // Hatalı silme türü parametresi durumunda hata döndürme
                return Json("Hatalı silme türü parametresi!");
            }
        }
    }
}