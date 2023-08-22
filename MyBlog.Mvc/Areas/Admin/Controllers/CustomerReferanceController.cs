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
    

    public class CustomerReferanceController : BaseController
    {
        private readonly ICustomerReferanceService _customerReferanceService;
        private readonly ICustomerReferanceTitleService _customerReferanceTitleService;
        private readonly INotificationService _notificationService;
        private readonly ICategoryService _categoryService;
        private readonly IToastNotification _toastNotification;


        public CustomerReferanceController(ICustomerReferanceService customerReferanceService,
            ICustomerReferanceTitleService customerReferanceTitleService,
            INotificationService notificationService,
            ICategoryService categoryService, UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _notificationService = notificationService;
            _customerReferanceService = customerReferanceService;
            _customerReferanceTitleService = customerReferanceTitleService;
            _categoryService = categoryService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.CustomerReferenceRead}")]
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.CustomerReferenceRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllCustomerReferances(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var customerReferanceTypes = await _customerReferanceService.GetAllByNonDeletedAndActiveAsync();
                var customerReferanceTypeResult = JsonSerializer.Serialize(customerReferanceTypes, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(customerReferanceTypeResult);
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.CustomerReferenceCreate}")]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var user = await UserManager.GetUserAsync(HttpContext.User);
            var roles = await UserManager.GetRolesAsync(user);
            ViewBag.User = user;
            ViewBag.Roles = roles;
            var referanceTitleList = await _customerReferanceTitleService.GetAllByNonDeletedAndActiveAsync();

            if (referanceTitleList.ResultStatus == ResultStatus.Success)
            {
                var model = new CustomerReferanceAddDto()
                {
                    CustomerReferanceTitles = referanceTitleList.Data.CustomerReferanceTitles
                };

                return PartialView("_CustomerReferanceAddPartial", model);
            }
            return NotFound();
        }

        [Authorize(Roles =
            $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.CustomerReferenceCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(CustomerReferanceAddDto customerReferanceAddDto)
        {
            {
                var referanceTitleList = await _customerReferanceTitleService.GetAllByNonDeletedAndActiveAsync();

                if (referanceTitleList.ResultStatus == ResultStatus.Success)
                {
                    customerReferanceAddDto.CustomerReferanceTitles = referanceTitleList.Data.CustomerReferanceTitles;
                }

                ModelState.Remove("CustomerReferanceTitles");
                if (ModelState.IsValid)
                {
                    var result =
                        await _customerReferanceService.AddAsync(customerReferanceAddDto, LoggedInUser.UserName);
                    if (result.ResultStatus == ResultStatus.Success)
                    {
                        var options = new JsonSerializerOptions
                        {
                            ReferenceHandler = ReferenceHandler.Preserve
                        };
                        var customerReferanceAddAjaxModel = JsonSerializer.Serialize(new CustomerReferanceAddAjaxViewModel
                        {
                            CustomerReferanceDto = result.Data,
                            CustomerReferanceAddPartial =
                                await this.RenderViewToStringAsync("_CustomerReferanceAddPartial",
                                    customerReferanceAddDto)
                        }, options);
                        return Json(customerReferanceAddAjaxModel);
                    }
                }

                var customerReferanceAddAjaxErrorModel = JsonSerializer.Serialize(new CustomerReferanceAddAjaxViewModel
                {
                    CustomerReferanceAddPartial =
                        await this.RenderViewToStringAsync("_CustomerReferanceAddPartial", customerReferanceAddDto)
                });
                return Json(customerReferanceAddAjaxErrorModel);
            }

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.CustomerReferenceUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int Id, string tableType)
        {
            var user = await UserManager.GetUserAsync(HttpContext.User);
            var roles = await UserManager.GetRolesAsync(user);

            ViewBag.User = user;
            ViewBag.Roles = roles;
            ViewBag.TableType = tableType;
            var result = await _customerReferanceService.GetCustomerReferanceUpdateDtoAsync(Id);  // burda bir sıkıntı var.

            var customerReferanceTitleList = await _customerReferanceTitleService.GetAllByNonDeletedAndActiveAsync();
            result.Data.CustomerReferanceTitles = customerReferanceTitleList.Data.CustomerReferanceTitles;
            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_CustomerReferanceUpdatePartial", result.Data);
            }
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.CustomerReferenceUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(CustomerReferanceUpdateDto customerReferanceUpdateDto, string tableType)
        {
            ViewBag.tableType = tableType;
            ModelState.Remove("tableType");

            if (ModelState.IsValid)
            {
                var result = await _customerReferanceService.UpdateAsync(customerReferanceUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                            NotificationMessageTypes.Updated,
                            "Referans",
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
            var referanceUpdateAjaxErrorModel = JsonSerializer.Serialize(new CustomerReferanceUpdateAjaxViewModel
            {
                CustomerReferanceUpdatePartial = await this.RenderViewToStringAsync("_CustomerReferanceUpdatePartial", customerReferanceUpdateDto)
            });
            return Json(referanceUpdateAjaxErrorModel);

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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.CustomerReferenceDelete}")]
        public async Task<JsonResult> UndoDelete(int customerReferanceId)
        {
            var result = await _customerReferanceService.UndoDeleteAsync(customerReferanceId, LoggedInUser.UserName);
            var undoDeletedCustomerReferance = JsonSerializer.Serialize(result.Data);
            return Json(undoDeletedCustomerReferance);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.CustomerReferenceDelete}")]
        [HttpGet]
        public async Task<IActionResult> HardDelete(int customerReferanceId)
        {
            var result = await _customerReferanceService.HardDeleteAsync(customerReferanceId);
            var deletedCustomerReferance = JsonSerializer.Serialize(result);
            return View(deletedCustomerReferance);

        }
    }
}