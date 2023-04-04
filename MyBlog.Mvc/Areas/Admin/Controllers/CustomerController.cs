using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Entities.Concrete;
using MyBlog.Mvc.Halpers.Abstract;
using MyBlog.Services.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using NToastNotify;
using System.Text.Json.Serialization;
using System.Text.Json;
using MyBlog.Entities.ComplexTypes;
using MyBlog.Entities.Dtos.CustomerDtos;
using MyBlog.Entities.Dtos.EmployeeDtos;
using MyBlog.Entities.Dtos.ArticleDtos;
using MyBlog.Mvc.Areas.Admin.Models.CustomerModels;
using MyBlog.Mvc.Consts;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Editor")]

    public class CustomerController : BaseController
    {
        private readonly ICustomerService _customerService;
        private readonly ICustomerReferanceService _customerReferanceService;
        private readonly IEmployeeService _employeeService;
        private readonly ICustomerTypeService _customerTypeService;
        private readonly IPaymentService _paymentService;
        private readonly IPaymentTypeService _paymentTypeService;
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;

        public CustomerController(ICustomerService customerService,
            ICustomerReferanceService customerReferanceService,
            IPaymentService paymentService,
            IPaymentTypeService paymentTypeService,
            INotificationService notificationService,
            IEmployeeService employeeService,
            ICustomerTypeService customerTypeService, UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _notificationService = notificationService;
            _paymentService = paymentService;
            _paymentTypeService = paymentTypeService;
            _customerService = customerService;
            _customerReferanceService = customerReferanceService;
            _customerTypeService = customerTypeService;
            _employeeService = employeeService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerRead}")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _customerService.GetAllAsync();
            if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllCustomers()
        {
            var customers = await _customerService.GetAllAsync();
            var customerResult = JsonSerializer.Serialize(customers, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(customerResult);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerCreate}")]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var customerTypesList = await _customerTypeService.GetAllByNonDeletedAndActiveAsync();
            var customerReferancesList = await _customerReferanceService.GetAllByNonDeletedAndActiveAsync();
            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            if ((customerReferancesList.ResultStatus == ResultStatus.Success) && (customerTypesList.ResultStatus == ResultStatus.Success))
            {
                return View(new CustomerAddViewModel
                {
                    Employees = employeeList.Data.Employees,
                    CustomerReferances = customerReferancesList.Data.CustomerReferances,
                    CustomerTypes = customerTypesList.Data.CustomerTypes
                });
            }
            return NotFound();
        }





        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(CustomerAddViewModel customerAddViewModel)
        {
            var customerReferance = await _customerReferanceService.GetAsync(customerAddViewModel.CustomerReferanceId);
            var customerType = await _customerTypeService.GetAsync(customerAddViewModel.CustomerTypeId);
            var employee = await _employeeService.GetAsync(customerAddViewModel.EmployeeId);
            if (ModelState.IsValid)
            {
                var customerAddDto = Mapper.Map<CustomerAddDto>(customerAddViewModel);
                if (customerAddViewModel.PictureFile != null)
                {
                    var imageResult = await ImageHelper.Upload(customerAddViewModel.FirstName,
    customerAddViewModel.PictureFile, PictureType.Post);
                    customerAddDto.Picture = imageResult.Data.FullName;
                }
                else
                {
                    customerAddDto.Picture = "/userImages/defaultUser.png";
                }
                var result = await _customerService.AddAsync(customerAddDto, LoggedInUser.UserName, LoggedInUser.Id);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem!"
                    });
                    return RedirectToAction("Index", "Customer");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                }
            }

            var customerTypesList = await _customerTypeService.GetAllByNonDeletedAndActiveAsync();
            var customerReferancesList = await _customerReferanceService.GetAllByNonDeletedAndActiveAsync();
            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            customerAddViewModel.Employees = employeeList.Data.Employees;
            customerAddViewModel.CustomerReferances = customerReferancesList.Data.CustomerReferances;
            customerAddViewModel.CustomerTypes = customerTypesList.Data.CustomerTypes;
            return View(customerAddViewModel);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int customerId)
        {
            var customerResult = await _customerService.GetCustomerUpdateDtoAsync(customerId);
            var customerTypeResult = await _customerTypeService.GetAllByNonDeletedAndActiveAsync();
            var customerReferanceResult = await _customerReferanceService.GetAllByNonDeletedAndActiveAsync();
            var employeeResult = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            if (customerResult.ResultStatus == ResultStatus.Success
                && customerTypeResult.ResultStatus == ResultStatus.Success
                && customerReferanceResult.ResultStatus == ResultStatus.Success
                && employeeResult.ResultStatus == ResultStatus.Success)
            {
                var customerUpdateViewModel = Mapper.Map<CustomerUpdateViewModel>(customerResult.Data);
                customerUpdateViewModel.CustomerReferances = customerReferanceResult.Data.CustomerReferances;
                customerUpdateViewModel.CustomerTypes = customerTypeResult.Data.CustomerTypes;
                customerUpdateViewModel.Employees = employeeResult.Data.Employees;
                return View(customerUpdateViewModel);
            }
            else
            {
                return NotFound();
            }
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(CustomerUpdateViewModel customerUpdateViewModel)
        {
            if (ModelState.IsValid)
            {
                bool isPictureUploaded = false;
                var oldPicture = customerUpdateViewModel.Picture;
                var CustomerUpdateDto = Mapper.Map<CustomerUpdateDto>(customerUpdateViewModel);

                if (customerUpdateViewModel.PictureFile != null)
                {
                    var uploadedImageResult = await ImageHelper.Upload(customerUpdateViewModel.FirstName,
                        customerUpdateViewModel.PictureFile, PictureType.Post);
                    customerUpdateViewModel.Picture = uploadedImageResult.ResultStatus == ResultStatus.Success
                        ? uploadedImageResult.Data.FullName
                        : "postImages/defaultThumbnail.jpg";
                    if (oldPicture != "postImages/defaultThumbnail.jpg")
                    {
                        isPictureUploaded = true;
                    }
                }

                var result = await _customerService.UpdateAsync(CustomerUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    if (isPictureUploaded)
                    {
                        ImageHelper.Delete(oldPicture);
                    }
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem!"
                    });
                    return RedirectToAction("Index", "Customer");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                }
            }
            var customerTypesList = await _customerTypeService.GetAllByNonDeletedAndActiveAsync();
            var customerReferancesList = await _customerReferanceService.GetAllByNonDeletedAndActiveAsync();
            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            customerUpdateViewModel.Employees = employeeList.Data.Employees;
            customerUpdateViewModel.CustomerReferances = customerReferancesList.Data.CustomerReferances;
            customerUpdateViewModel.CustomerTypes = customerTypesList.Data.CustomerTypes;
            return View(customerUpdateViewModel);
        }
    }
}
