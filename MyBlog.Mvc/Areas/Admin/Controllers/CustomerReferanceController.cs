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
using MyBlog.Entities.Dtos.CategoryDtos;
using MyBlog.Entities.Dtos.CustomerReferanceDtos;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Mvc.Areas.Admin.Models.CustomerModels;
using MyBlog.Mvc.Consts;
using MyBlog.Services.Utilities;
using MyBlog.Entities.Dtos.CustomerReferanceDtos;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Editor")]

    public class CustomerReferanceController : BaseController
    {
        private readonly ICustomerReferanceService _customerReferanceService;
        private readonly INotificationService _notificationService;
        private readonly ICategoryService _categoryService;
        private readonly IToastNotification _toastNotification;


        public CustomerReferanceController(ICustomerReferanceService customerReferanceService,
            INotificationService notificationService,
            ICategoryService categoryService, UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _notificationService = notificationService;
            _customerReferanceService = customerReferanceService;
            _categoryService = categoryService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerReferenceRead}")]
        [HttpGet]
        public async Task<IActionResult> Index(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _customerReferanceService.GetAllByNonDeletedAndActiveAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _customerReferanceService.GetAllByDeletedAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return View();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerReferenceRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllCustomerReferances(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var employeeTypes = await _customerReferanceService.GetAllByNonDeletedAndActiveAsync();
                var employeeTypeResult = JsonSerializer.Serialize(employeeTypes, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(employeeTypeResult);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _customerReferanceService.GetAllByDeletedAsync();
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerReferenceCreate}")]
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_CustomerReferanceAddPartial");
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerReferenceCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(CustomerReferanceAddDto customerReferanceAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _customerReferanceService.AddAsync(customerReferanceAddDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new CustomerReferanceAddAjaxViewModel
                    {
                        CustomerReferanceDto = result.Data,
                        CustomerReferanceAddPartial = await this.RenderViewToStringAsync("_CustomerReferanceAddPartial", customerReferanceAddDto)
                    });
                    return Json(categoryAddAjaxModel);
                }
            }
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new CustomerReferanceAddAjaxViewModel
            {
                CustomerReferanceAddPartial = await this.RenderViewToStringAsync("_CustomerReferanceAddPartial", customerReferanceAddDto)
            });
            return Json(categoryAddAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerReferenceUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int customerReferanceId, string tableType)
        {
            ViewBag.TableType = tableType;
            var result = await _customerReferanceService.GetCustomerReferanceUpdateDtoAsync(customerReferanceId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_CustomerReferanceUpdatePartial", result.Data);
            }
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerReferenceUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(CustomerReferanceUpdateDto customerReferanceUpdateDto, string tableType)
        {
            ViewBag.tableType = tableType;
            if (ModelState.IsValid)
            {
                var result = await _customerReferanceService.UpdateAsync(customerReferanceUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync( NotificationMessageService.GetMessage(
                        NotificationMessageTypes.Updated,
                        "Marka",
                        result.Data.CustomerReferance.ModifiedByName),
                        NotificationMessageService.GetTitle(NotificationMessageTypes.Updated), userId: LoggedInUser.Id
                        );
                    var categoryUpdateAjaxModel = JsonSerializer.Serialize(new CustomerReferanceUpdateAjaxViewModel
                    {
                        CustomerReferanceDto = result.Data,
                        CustomerReferanceUpdatePartial = await this.RenderViewToStringAsync("_CustomerReferanceUpdatePartial", customerReferanceUpdateDto)
                    });
                    return Json(categoryUpdateAjaxModel);
                }
            }
            var categoryUpdateAjaxErrorModel = JsonSerializer.Serialize(new CustomerReferanceUpdateAjaxViewModel
            {
                CustomerReferanceUpdatePartial = await this.RenderViewToStringAsync("_CustomerReferanceUpdatePartial", customerReferanceUpdateDto)
            });
            return Json(categoryUpdateAjaxErrorModel);

        }
        public async Task<JsonResult> Delete(int customerReferanceId, string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _customerReferanceService.DeleteAsync(customerReferanceId, LoggedInUser.UserName);
                var deletedCustomerReferance = JsonSerializer.Serialize(result.Data);
                return Json(deletedCustomerReferance);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _customerReferanceService.HardDeleteAsync(customerReferanceId);
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
        public async Task<JsonResult> UndoDelete(int customerReferanceId)
        {
            var result = await _customerReferanceService.UndoDeleteAsync(customerReferanceId, LoggedInUser.UserName);
            var undoDeletedCustomerReferance = JsonSerializer.Serialize(result.Data);
            return Json(undoDeletedCustomerReferance);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerReferenceDelete}")]
        [HttpGet]
        public async Task<IActionResult> HardDelete(int customerReferanceId)
        {
            var result = await _customerReferanceService.HardDeleteAsync(customerReferanceId);
            var deletedCustomerReferance = JsonSerializer.Serialize(result);
            return View(deletedCustomerReferance);

        }
    }
}