using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Entities.Concrete;
using MyBlog.Mvc.Areas.Admin.Models;
using MyBlog.Mvc.Halpers.Abstract;
using MyBlog.Services.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using NToastNotify;
using System.Text.Json.Serialization;
using System.Text.Json;
using MyBlog.Entities.ComplexTypes;
using MyBlog.Entities.Dtos.AppointmentDtos;
using MyBlog.Entities.Dtos.ArticleDtos;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Mvc.Consts;
using MyBlog.Mvc.CustomAttributes;
using MyBlog.Mvc.Enums;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AppointmentController : BaseController
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IEmployeeService _employeeService;
        private readonly ICustomerService _customerService;
        private readonly IAppointmentTypeService _appointmentTypeService;
        private readonly INotificationService _notificationService;

        private readonly IToastNotification _toastNotification;

        public AppointmentController(IAppointmentService appointmentService,
        ICustomerService customerService,
                    INotificationService notificationService,

        IAppointmentTypeService appointmentTypeService,
        IEmployeeService employeeService,
        UserManager<User> userManager, IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _appointmentTypeService = appointmentTypeService;
            _employeeService = employeeService;
            _notificationService = notificationService;

            _appointmentService = appointmentService;
            _customerService = customerService;
            _toastNotification = toastNotification;
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.AppointmentRead}")]
        [HttpGet]
        public async Task<IActionResult> Index(string tableType)
        {
            ViewBag.tableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _appointmentService.GetAllByNonDeletedAndActiveAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _appointmentService.GetAllByDeletedAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.AppointmentRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllAppointments(string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var appointments = await _appointmentService.GetAllByNonDeletedAndActiveAsync();
                var appointmentResult = JsonSerializer.Serialize(appointments, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(appointmentResult);

            }   
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _appointmentService.GetAllByDeletedAsync();
                var appointments = JsonSerializer.Serialize(result, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(appointments);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile Karşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return Json(null);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.AppointmentCreate}")]
        [HttpGet]
        public async Task<IActionResult> Add(string tableType)
        {
            ViewBag.tableType = tableType;
            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            var customerList = await _customerService.GetAllByNonDeletedAndActiveAsync();
            var appointmentTypeList = await _appointmentTypeService.GetAllByNonDeletedAndActiveAsync();
            if ((employeeList.ResultStatus == ResultStatus.Success &&
                customerList.ResultStatus == ResultStatus.Success &&
                appointmentTypeList.ResultStatus == ResultStatus.Success))
            {
                return View(new AppointmentAddViewModel
                {
                    Customers = customerList.Data.Customers,
                    Employees = employeeList.Data.Employees,
                    AppointmentTypes = appointmentTypeList.Data.AppointmentTypes
                });
            }
            return NotFound();
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.AppointmentCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(AppointmentAddViewModel appointmentAddViewModel, string tableType)
        {
            ModelState.Remove("tableType");
            if (ModelState.IsValid)
            {
                var appointmentAddDto = Mapper.Map<AppointmentAddDto>(appointmentAddViewModel);
                var result = await _appointmentService.AddAsync(appointmentAddDto, LoggedInUser.UserName, LoggedInUser.Id);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.Added,
TableNamesConstants.Appointments,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.Added), userId: LoggedInUser.Id
);
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem!"
                    });
                    return RedirectToAction("Index", "Appointment", new { tableType = tableType });
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                }
            }

            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            var customerList = await _customerService.GetAllByNonDeletedAndActiveAsync();
            var appointmentTypeList = await _appointmentTypeService.GetAllByNonDeletedAndActiveAsync();
            appointmentAddViewModel.Customers = customerList.Data.Customers;
            appointmentAddViewModel.Employees = employeeList.Data.Employees;
            appointmentAddViewModel.AppointmentTypes = appointmentTypeList.Data.AppointmentTypes;
            return View(appointmentAddViewModel);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.AppointmentUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int Id, string tableType)
        {
            ViewBag.tableType = tableType;
            var appointmentList = await _appointmentService.GetAppointmentUpdateDtoAsync(Id);
            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            var customerList = await _customerService.GetAllByNonDeletedAndActiveAsync();
            var appointmentTypeList = await _appointmentTypeService.GetAllByNonDeletedAndActiveAsync();
            if (employeeList.ResultStatus == ResultStatus.Success &&
               appointmentList.ResultStatus == ResultStatus.Success &&
               appointmentTypeList.ResultStatus == ResultStatus.Success &&
               customerList.ResultStatus == ResultStatus.Success)
            {
                var AppointmentUpdateViewModel = Mapper.Map<AppointmentUpdateViewModel>(appointmentList.Data);
                AppointmentUpdateViewModel.Customers = customerList.Data.Customers;
                AppointmentUpdateViewModel.AppointmentTypes = appointmentTypeList.Data.AppointmentTypes;
                AppointmentUpdateViewModel.Employees = employeeList.Data.Employees;
                return View(AppointmentUpdateViewModel);
            }
            else
            {
                return NotFound();
            }
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.AppointmentCreate}")]
        [HttpPost]
        public async Task<IActionResult> Update(AppointmentUpdateViewModel AppointmentUpdateViewModel, string tableType)
        {
            ModelState.Remove("tableType");
            if (ModelState.IsValid)
            {
                var AppointmentUpdateDto = Mapper.Map<AppointmentUpdateDto>(AppointmentUpdateViewModel);

                var result = await _appointmentService.UpdateAsync(AppointmentUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.Updated,
TableNamesConstants.Appointments,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.Updated), userId: LoggedInUser.Id
);
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem!"
                    });
                    return RedirectToAction("Index", "Appointment", new { tableType = tableType });
                } 
                else
                {
                    _toastNotification.AddErrorToastMessage(AppointmentUpdateDto.Message, new ToastrOptions
                    {
                        Title = "Başarısız İşlem!"
                    });
                    ModelState.AddModelError("", result.Message);
                }
            }
            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            var customerList = await _customerService.GetAllByNonDeletedAndActiveAsync();
            var appointmentTypeList = await _appointmentTypeService.GetAllByNonDeletedAndActiveAsync();
            AppointmentUpdateViewModel.Customers = customerList.Data.Customers;
            AppointmentUpdateViewModel.Employees = employeeList.Data.Employees;
            AppointmentUpdateViewModel.AppointmentTypes = appointmentTypeList.Data.AppointmentTypes;
            return View(AppointmentUpdateViewModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.EmployeeUpdate}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteFromUpdatePage(int appointmentId, string tableType)
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                // Silme işlemi modaldan geldiyse normal controller işlemini yap => buradaki if koşulu bunun bir ajax sorgusuolup olamdığını kontrol eder.
                return await Delete(appointmentId, tableType);
            }
            else
            {
                string errMessage = "";
                if (tableType == TableReturnTypesConstants.NonDeletedTables)
                {
                    var result = await _appointmentService.DeleteAsync(appointmentId, LoggedInUser.UserName);
                    if (result.ResultStatus == ResultStatus.Success)
                    {
                        _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                        {
                            Title = "Başarılı İşlem!"
                        });
                        return RedirectToAction("Index", "Appointment", new { tableType = tableType });
                    }
                    errMessage = result.Message;
                }
                else if (tableType == TableReturnTypesConstants.DeletedTables)
                {
                    var result = await _appointmentService.HardDeleteAsync(appointmentId);
                    if (result.ResultStatus == ResultStatus.Success)
                    {
                        _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                        {
                            Title = "Başarılı İşlem!"
                        });
                        return RedirectToAction("Index", "Appointment", new { tableType = tableType });
                    }
                    errMessage = result.Message;
                }
                _toastNotification.AddErrorToastMessage(errMessage, new ToastrOptions
                {
                    Title = "Başarısız İşlem!"
                });
                // Silme işlemi update sayfasından geldiyse index sayfasına yönlendir 
                return RedirectToAction("Update");
            }
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.AppointmentDelete}")]
        [HttpPost]
        public async Task<JsonResult> Delete(int appointmentId, string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _appointmentService.DeleteAsync(appointmentId, LoggedInUser.UserName);
                var appointmentResult = JsonSerializer.Serialize(result.Data);
                await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.Deleted,
TableNamesConstants.Appointments,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.Deleted), userId: LoggedInUser.Id
);
                return Json(appointmentResult);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _appointmentService.HardDeleteAsync(appointmentId);
                var hardDeletedAppointmentResult = JsonSerializer.Serialize(result);
                await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.HardDeleted,
TableNamesConstants.Appointments,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.HardDeleted), userId: LoggedInUser.Id
);
                return Json(hardDeletedAppointmentResult);
            }
            else
            {
                // Hatalı silme türü parametresi durumunda hata döndürme
                return Json("Hatalı silme türü parametresi!");
            }
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.AppointmentDelete}")]
        [HttpPost]
        public async Task<JsonResult> HardDelete(int appointmentId)
        {
            var result = await _appointmentService.HardDeleteAsync(appointmentId);
            var hardDeletedAppointmentResult = JsonSerializer.Serialize(result);
            return Json(hardDeletedAppointmentResult);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.AppointmentRead}")]
        [HttpGet]
        public async Task<IActionResult> DeletedAppointments()
        {
            var result = await _appointmentService.GetAllByDeletedAsync();
            return View(result.Data);

        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.AppointmentRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllDeletedAppointments()
        {
            var result = await _appointmentService.GetAllByDeletedAsync();
            var appointments = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(appointments);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.AppointmentDelete}")]
        [HttpPost]
        public async Task<JsonResult> UndoDelete(int appointmentId)
        {
            var result = await _appointmentService.UndoDeleteAsync(appointmentId, LoggedInUser.UserName);
            var undoDeleteAppointmentResult = JsonSerializer.Serialize(result.Data);
            await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.UndoDeleted,
TableNamesConstants.Appointments,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.UndoDeleted), userId: LoggedInUser.Id
);
            return Json(undoDeleteAppointmentResult);
        }
    }
}
