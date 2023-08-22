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
using MyBlog.Entities.Dtos.PaymentTypeDtos;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Mvc.Consts;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    

    public class PaymentTypeController : BaseController
    {
        private readonly IPaymentTypeService _paymentTypeService;
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;


        public PaymentTypeController(
            INotificationService notificationService,
            IPaymentTypeService paymentTypeService,
            UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _notificationService = notificationService;
            _paymentTypeService = paymentTypeService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.PaymentTypeRead}")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _paymentTypeService.GetAllAsync();
            if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.PaymentTypeRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllPaymentTypes()
        {
            var paymentTypes = await _paymentTypeService.GetAllAsync();
            var paymentTypeResult = JsonSerializer.Serialize(paymentTypes, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(paymentTypeResult);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.PaymentTypeCreate}")]
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_PaymentTypeAddPartial");
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.PaymentTypeCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(PaymentTypeAddDto paymentTypeAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _paymentTypeService.AddAsync(paymentTypeAddDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new PaymentTypeAddAjaxViewModel
                    {
                        PaymentTypeDto = result.Data,
                        PaymentTypeAddPartial = await this.RenderViewToStringAsync("_PaymentTypeAddPartial", paymentTypeAddDto)
                    });
                    return Json(categoryAddAjaxModel);
                }
            }
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new PaymentTypeAddAjaxViewModel
            {
                PaymentTypeAddPartial = await this.RenderViewToStringAsync("_PaymentTypeAddPartial", paymentTypeAddDto)
            });
            return Json(categoryAddAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.PaymentTypeUpdate }")]
        [HttpGet]
        public async Task<IActionResult> Update(int paymentTypeId)
        {
            var result = await _paymentTypeService.GetPaymentTypeUpdateDtoAsync(paymentTypeId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_PaymentTypeUpdatePartial", result.Data);
            }
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.PaymentTypeUpdate }")]
        [HttpPost]
        public async Task<IActionResult> Update(PaymentTypeUpdateDto categoryUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _paymentTypeService.UpdateAsync(categoryUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                        NotificationMessageTypes.Updated, 
                        "Marka", 
                        result.Data.PaymentType.ModifiedByName),
                        NotificationMessageService.GetTitle(NotificationMessageTypes.Updated), userId: LoggedInUser.Id
                        );
                    var categoryUpdateAjaxModel = JsonSerializer.Serialize(new PaymentTypeUpdateAjaxViewModel
                    {
                        PaymentTypeDto = result.Data,
                        PaymentTypeUpdatePartial = await this.RenderViewToStringAsync("_PaymentTypeUpdatePartial", categoryUpdateDto)
                    });
                    return Json(categoryUpdateAjaxModel);
                }
            }
            var categoryUpdateAjaxErrorModel = JsonSerializer.Serialize(new PaymentTypeUpdateAjaxViewModel
            {
                PaymentTypeUpdatePartial = await this.RenderViewToStringAsync("_PaymentTypeUpdatePartial", categoryUpdateDto)
            });
            return Json(categoryUpdateAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.PaymentTypeDelete}")]
        [HttpPost]
        public async Task<JsonResult> Delete(int paymentTypeId)
        {
            var result = await _paymentTypeService.DeleteAsync(paymentTypeId, LoggedInUser.UserName);
            var deletedEmployeeType = JsonSerializer.Serialize(result.Data);
            return Json(deletedEmployeeType);
        }
    }
}