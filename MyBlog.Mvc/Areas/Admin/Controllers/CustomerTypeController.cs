﻿using Microsoft.AspNetCore.Mvc;
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
using MyBlog.Entities.Dtos.CustomerTypeDtos;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Entities.Dtos.CustomerTypeDtos;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Mvc.Areas.Admin.Models.CustomerModels;
using MyBlog.Mvc.Consts;
using MyBlog.Services.Utilities;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Editor")]

    public class CustomerTypeController : BaseController
    {
        private readonly ICustomerTypeService _customerTypeService;
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;


        public CustomerTypeController(ICustomerTypeService customerTypeService,
            INotificationService notificationService,
            UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _notificationService = notificationService;
            _customerTypeService = customerTypeService;
            _toastNotification = toastNotification;
        } 

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerTypeRead}")]
        [HttpGet]
        public async Task<IActionResult> Index(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _customerTypeService.GetAllByNonDeletedAndActiveAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _customerTypeService.GetAllByDeletedAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return View();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerTypeRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllCustomerTypes(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var employeeTypes = await _customerTypeService.GetAllByNonDeletedAndActiveAsync();
                var employeeTypeResult = JsonSerializer.Serialize(employeeTypes, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(employeeTypeResult);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _customerTypeService.GetAllByDeletedAsync();
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
                    var customerTypeAddAjaxModel = JsonSerializer.Serialize(new CustomerTypeAddAjaxViewModel
                    {
                        CustomerTypeDto = result.Data,
                        CustomerTypeAddPartial = await this.RenderViewToStringAsync("_CustomerTypeAddPartial", customerTypeAddDto)
                    });
                    return Json(customerTypeAddAjaxModel);
                }
            }
            var customerTypeAddAjaxErrorModel = JsonSerializer.Serialize(new CustomerTypeAddAjaxViewModel
            {
                CustomerTypeAddPartial = await this.RenderViewToStringAsync("_CustomerTypeAddPartial", customerTypeAddDto)
            });
            return Json(customerTypeAddAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerReferenceUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int customerTypeId, string tableType)
        {
            ViewBag.TableType = tableType;
            var result = await _customerTypeService.GetCustomerTypeUpdateDtoAsync(customerTypeId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_CustomerTypeUpdatePartial", result.Data);
            }
            return NotFound();
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerReferenceUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(CustomerTypeUpdateDto customerTypeUpdateDto, string tableType)
        {
            ViewBag.tableType = tableType;
            if (ModelState.IsValid)
            {
                var result = await _customerTypeService.UpdateAsync(customerTypeUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                        NotificationMessageTypes.Updated,
                        "Marka",
                        result.Data.CustomerType.ModifiedByName),
                        NotificationMessageService.GetTitle(NotificationMessageTypes.Updated), userId: LoggedInUser.Id
                        );
                    var customerTypeUpdateAjaxModel = JsonSerializer.Serialize(new CustomerTypeUpdateAjaxViewModel
                    {
                        CustomerTypeDto = result.Data,
                        CustomerTypeUpdatePartial = await this.RenderViewToStringAsync("_CustomerTypeUpdatePartial", customerTypeUpdateDto)
                    });
                    return Json(customerTypeUpdateAjaxModel);
                }
            }
            var customerTypeUpdateAjaxErrorModel = JsonSerializer.Serialize(new CustomerTypeUpdateAjaxViewModel
            {
                CustomerTypeUpdatePartial = await this.RenderViewToStringAsync("_CustomerTypeUpdatePartial", customerTypeUpdateDto)
            });
            return Json(customerTypeUpdateAjaxErrorModel);

        }
        public async Task<JsonResult> Delete(int customerTypeId, string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _customerTypeService.DeleteAsync(customerTypeId, LoggedInUser.UserName);
                var deletedCustomerType = JsonSerializer.Serialize(result.Data);
                return Json(deletedCustomerType);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _customerTypeService.HardDeleteAsync(customerTypeId);
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerReferenceDelete}")]
        public async Task<JsonResult> UndoDelete(int customerTypeId)
        {
            var result = await _customerTypeService.UndoDeleteAsync(customerTypeId, LoggedInUser.UserName);
            var undoDeletedCustomerType = JsonSerializer.Serialize(result.Data);
            return Json(undoDeletedCustomerType);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerReferenceDelete}")]
        [HttpGet]
        public async Task<IActionResult> HardDelete(int customerTypeId)
        {
            var result = await _customerTypeService.HardDeleteAsync(customerTypeId);
            var deletedCustomerType = JsonSerializer.Serialize(result);
            return View(deletedCustomerType);

        }
    }
}