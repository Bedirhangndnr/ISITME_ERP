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

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Editor")]

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
        public async Task<IActionResult> Index()
        {
            var result = await _notificationService.GetAllByNonDeletedAndActiveAsync();
            if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.NotificationRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllNotifications()
        {
            var notifications = await _notificationService.GetAllByNonDeletedAndActiveAsync();
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
    }
}