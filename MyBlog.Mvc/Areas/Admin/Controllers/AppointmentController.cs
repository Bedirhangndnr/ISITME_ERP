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
        private readonly IToastNotification _toastNotification;

        public AppointmentController(IAppointmentService appointmentService,
        ICustomerService customerService,
        IAppointmentTypeService appointmentTypeService,
        IEmployeeService employeeService,
        UserManager<User> userManager, IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _appointmentTypeService = appointmentTypeService;
            _employeeService = employeeService;
            _appointmentService = appointmentService;
            _customerService = customerService;
            _toastNotification = toastNotification;
        }
        [Authorize(Roles = "SuperAdmin")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _appointmentService.GetAllByNonDeletedAndActiveAsync();
            if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.AppointmentRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllAppointments()
        {
            var appointments = await _appointmentService.GetAllByNonDeletedAndActiveAsync();
            var appointmentResult = JsonSerializer.Serialize(appointments, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(appointmentResult);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.AppointmentCreate}")]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
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

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.AppointmentCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(AppointmentAddViewModel appointmentAddViewModel)
        {
            if (ModelState.IsValid)
            {
                var appointmentAddDto = Mapper.Map<AppointmentAddDto>(appointmentAddViewModel);
                var result = await _appointmentService.AddAsync(appointmentAddDto, LoggedInUser.UserName, LoggedInUser.Id);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem!"
                    });
                    return RedirectToAction("Index", "Appointment");
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.AppointmentUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int appointmentId)
        {
            var appointmentList = await _appointmentService.GetAppointmentUpdateDtoAsync(appointmentId);
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.AppointmentCreate}")]
        [HttpPost]
        public async Task<IActionResult> Update(AppointmentUpdateViewModel AppointmentUpdateViewModel)
        {
            if (ModelState.IsValid)
            {
                var AppointmentUpdateDto = Mapper.Map<AppointmentUpdateDto>(AppointmentUpdateViewModel);

                var result = await _appointmentService.UpdateAsync(AppointmentUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return RedirectToAction("Index", "Appointment");
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
    }
}
