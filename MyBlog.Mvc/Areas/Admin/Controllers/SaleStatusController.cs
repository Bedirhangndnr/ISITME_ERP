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
using MyBlog.Entities.Dtos.SaleStatusDtos;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Entities.Dtos.SaleStatusDtos;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Mvc.Consts;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Editor")]

    public class SaleStatusController : BaseController
    {
        private readonly ISaleStatusService _saleStatusService;
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;


        public SaleStatusController(
            INotificationService notificationService,
            ISaleStatusService saleStatusService,
            UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _notificationService = notificationService;
            _saleStatusService = saleStatusService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.SaleStatusRead}")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _saleStatusService.GetAllAsync();
            if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.SaleStatusRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllSaleStatuses()
        {
            var saleStatuses = await _saleStatusService.GetAllAsync();
            var saleStatusResult = JsonSerializer.Serialize(saleStatuses, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(saleStatusResult);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.SaleStatusCreate}")]
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_SaleStatusAddPartial");
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.SaleStatusCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(SaleStatusAddDto saleStatusAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _saleStatusService.AddAsync(saleStatusAddDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new SaleStatusAddAjaxViewModel
                    {
                        SaleStatusDto = result.Data,
                        SaleStatusAddPartial = await this.RenderViewToStringAsync("_SaleStatusAddPartial", saleStatusAddDto)
                    });
                    return Json(categoryAddAjaxModel);
                }
            }
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new SaleStatusAddAjaxViewModel
            {
                SaleStatusAddPartial = await this.RenderViewToStringAsync("_SaleStatusAddPartial", saleStatusAddDto)
            });
            return Json(categoryAddAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.SaleStatusUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int saleStatusId)
        {
            var result = await _saleStatusService.GetSaleStatusUpdateDtoAsync(saleStatusId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_SaleStatusUpdatePartial", result.Data);
            }
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.SaleStatusUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(SaleStatusUpdateDto categoryUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _saleStatusService.UpdateAsync(categoryUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                        NotificationMessageTypes.Updated, 
                        "Marka", 
                        result.Data.SaleStatus.ModifiedByName),
                        NotificationMessageService.GetTitle(NotificationMessageTypes.Updated)
                        );
                    var categoryUpdateAjaxModel = JsonSerializer.Serialize(new SaleStatusUpdateAjaxViewModel
                    {
                        SaleStatusDto = result.Data,
                        SaleStatusUpdatePartial = await this.RenderViewToStringAsync("_SaleStatusUpdatePartial", categoryUpdateDto)
                    });
                    return Json(categoryUpdateAjaxModel);
                }
            }
            var categoryUpdateAjaxErrorModel = JsonSerializer.Serialize(new SaleStatusUpdateAjaxViewModel
            {
                SaleStatusUpdatePartial = await this.RenderViewToStringAsync("_SaleStatusUpdatePartial", categoryUpdateDto)
            });
            return Json(categoryUpdateAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.SaleStatusDelete}")]
        [HttpPost]
        public async Task<JsonResult> Delete(int saleStatusId)
        {
            var result = await _saleStatusService.DeleteAsync(saleStatusId, LoggedInUser.UserName);
            var deletedEmployeeType = JsonSerializer.Serialize(result.Data); 
            return Json(deletedEmployeeType);
        }
    }
}