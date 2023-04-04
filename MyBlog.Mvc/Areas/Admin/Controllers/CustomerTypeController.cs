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
using MyBlog.Entities.Dtos.CustomerTypeDtos;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Entities.Dtos.CustomerTypeDtos;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Mvc.Areas.Admin.Models.CustomerModels;
using MyBlog.Mvc.Consts;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Editor")]

    public class CustomerTypeController : BaseController
    {
        private readonly ICustomerTypeService _customerTypeService;
        private readonly ICustomerTypeService _categoryService;
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;


        public CustomerTypeController(ICustomerTypeService customerTypeService,
            INotificationService notificationService,
            ICustomerTypeService categoryService,
            UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _notificationService = notificationService;
            _customerTypeService = customerTypeService;
            _categoryService = categoryService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerTypeRead}")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _customerTypeService.GetAllAsync();
            if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerTypeRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllCustomerTypes()
        {
            var customerTypes = await _customerTypeService.GetAllAsync();
            var customerTypeResult = JsonSerializer.Serialize(customerTypes, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(customerTypeResult);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerTypeCreate}")]
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_CustomerTypeAddPartial");
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerTypeCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(CustomerTypeAddDto customerTypeAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _customerTypeService.AddAsync(customerTypeAddDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new CustomerTypeAddAjaxViewModel
                    {
                        CustomerTypeDto = result.Data,
                        CustomerTypeAddPartial = await this.RenderViewToStringAsync("_CustomerTypeAddPartial", customerTypeAddDto)
                    });
                    return Json(categoryAddAjaxModel);
                }
            }
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new CustomerTypeAddAjaxViewModel
            {
                CustomerTypeAddPartial = await this.RenderViewToStringAsync("_CustomerTypeAddPartial", customerTypeAddDto)
            });
            return Json(categoryAddAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerReferenceUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int customerTypeId)
        {
            var result = await _customerTypeService.GetCustomerTypeUpdateDtoAsync(customerTypeId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_CustomerTypeUpdatePartial", result.Data);
            }
            return NotFound();
        }
        
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerReferenceUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(CustomerTypeUpdateDto categoryUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _categoryService.UpdateAsync(categoryUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                        NotificationMessageTypes.Updated, 
                        "Müşteri Tipleri", 
                        result.Data.CustomerType.ModifiedByName),
                        NotificationMessageService.GetTitle(NotificationMessageTypes.Updated)
                        );
                    var categoryUpdateAjaxModel = JsonSerializer.Serialize(new CustomerTypeUpdateAjaxViewModel
                    {
                        CustomerTypeDto = result.Data,
                        CustomerTypeUpdatePartial = await this.RenderViewToStringAsync("_CustomerTypeUpdatePartial", categoryUpdateDto)
                    });
                    return Json(categoryUpdateAjaxModel);
                }
            }
            var categoryUpdateAjaxErrorModel = JsonSerializer.Serialize(new CustomerTypeUpdateAjaxViewModel
            {
                CustomerTypeUpdatePartial = await this.RenderViewToStringAsync("_CustomerTypeUpdatePartial", categoryUpdateDto)
            });
            return Json(categoryUpdateAjaxErrorModel);

        }
    }
}