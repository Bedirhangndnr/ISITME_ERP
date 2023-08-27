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
using MyBlog.Entities.Dtos.MessageToDeveloperDtos;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Mvc.Consts;
using MyBlog.Services.Utilities;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class MessageToDeveloperController : BaseController
    {
        private readonly IMessageToDeveloperService _messageToDeveloperService;
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;


        public MessageToDeveloperController(
            INotificationService notificationService,
            IMessageToDeveloperService messageToDeveloperService,
            UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _notificationService = notificationService;
            _messageToDeveloperService = messageToDeveloperService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.MessageToDeveloperRead}")]
        [HttpGet]
        public async Task<IActionResult> Index(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _messageToDeveloperService.GetAllByNonDeletedAndActiveAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _messageToDeveloperService.GetAllByDeletedAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile Karşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return View();
        }
        [HttpGet]
        public async Task<JsonResult> GetAllMessageToDevelopers(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var employeeTypes = await _messageToDeveloperService.GetAllByNonDeletedAndActiveAsync();
                var employeeTypeResult = JsonSerializer.Serialize(employeeTypes, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(employeeTypeResult);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _messageToDeveloperService.GetAllByDeletedAsync();
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.MessageToDeveloperCreate}")]
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_MessageToDeveloperAddPartial");
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.MessageToDeveloperCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(MessageToDeveloperAddDto messageToDeveloperAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _messageToDeveloperService.AddAsync(messageToDeveloperAddDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new MessageToDeveloperAddAjaxViewModel
                    {
                        MessageToDeveloperDto = result.Data,
                        MessageToDeveloperAddPartial = await this.RenderViewToStringAsync("_MessageToDeveloperAddPartial", messageToDeveloperAddDto)
                    });
                    return Json(categoryAddAjaxModel);
                }
            }
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new MessageToDeveloperAddAjaxViewModel
            {
                MessageToDeveloperAddPartial = await this.RenderViewToStringAsync("_MessageToDeveloperAddPartial", messageToDeveloperAddDto)
            });
            return Json(categoryAddAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.MessageToDeveloperUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int messageToDeveloperId, string tableType)
        {
            ViewBag.TableType = tableType;
            var result = await _messageToDeveloperService.GetMessageToDeveloperUpdateDtoAsync(messageToDeveloperId);
            var user = await UserManager.GetUserAsync(HttpContext.User);
            var roles = await UserManager.GetRolesAsync(user);
            ViewBag.User = user;
            ViewBag.Roles = roles;


            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_MessageToDeveloperUpdatePartial", result.Data);
            }
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.MessageToDeveloperUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(MessageToDeveloperUpdateDto messageToDeveloperUpdateDto, string tableType)
        {
            ViewBag.tableType = tableType;
            if (ModelState.IsValid)
            {
                var result = await _messageToDeveloperService.UpdateAsync(messageToDeveloperUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                        NotificationMessageTypes.Updated,
                        "Geliştiriciye Mesaj",
                        result.Data.MessageToDeveloper.ModifiedByName),
                        NotificationMessageService.GetTitle(NotificationMessageTypes.Updated), userId: LoggedInUser.Id
                        );
                    var categoryUpdateAjaxModel = JsonSerializer.Serialize(new MessageToDeveloperUpdateAjaxViewModel
                    {
                        MessageToDeveloperDto = result.Data,
                        MessageToDeveloperUpdatePartial = await this.RenderViewToStringAsync("_MessageToDeveloperUpdatePartial", messageToDeveloperUpdateDto)
                    });
                    return Json(categoryUpdateAjaxModel);
                }
            }
            var categoryUpdateAjaxErrorModel = JsonSerializer.Serialize(new MessageToDeveloperUpdateAjaxViewModel
            {
                MessageToDeveloperUpdatePartial = await this.RenderViewToStringAsync("_MessageToDeveloperUpdatePartial", messageToDeveloperUpdateDto)
            });
            return Json(categoryUpdateAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.MessageToDeveloperDelete}")]
        [HttpPost]
        public async Task<JsonResult> Delete(int messageToDeveloperId, string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _messageToDeveloperService.DeleteAsync(messageToDeveloperId, LoggedInUser.UserName);
                var deletedMessageToDeveloper = JsonSerializer.Serialize(result.Data);
                return Json(deletedMessageToDeveloper);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _messageToDeveloperService.HardDeleteAsync(messageToDeveloperId);
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.MessageToDeveloperDelete}")]
        public async Task<JsonResult> UndoDelete(int messageToDeveloperId)
        {
            var result = await _messageToDeveloperService.UndoDeleteAsync(messageToDeveloperId, LoggedInUser.UserName);
            var undoDeletedMessageToDeveloper = JsonSerializer.Serialize(result.Data);
            return Json(undoDeletedMessageToDeveloper);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.MessageToDeveloperDelete}")]
        [HttpGet]
        public async Task<IActionResult> HardDelete(int messageToDeveloperId)
        {
            var result = await _messageToDeveloperService.HardDeleteAsync(messageToDeveloperId);
            var deletedMessageToDeveloper = JsonSerializer.Serialize(result);
            return View(deletedMessageToDeveloper);

        }
    }
}