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
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    

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

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.CustomerRead}")]
        [HttpGet]
        public async Task<IActionResult> Index(string tableType)
        {

            ViewBag.tableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _customerService.GetAllByNonDeletedAndActiveAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _customerService.GetAllByNonDeletedAndActiveAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.CustomerRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllCustomers(string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var customers = await _customerService.GetAllByNonDeletedAndActiveAsync();
                var customerResult = JsonSerializer.Serialize(customers, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                });
                return Json(customerResult);

            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _customerService.GetAllByNonDeletedAndActiveAsync();
                var customers = JsonSerializer.Serialize(result, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(customers);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile Karşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return Json(null);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.CustomerCreate}")]
        [HttpGet]
        public async Task<IActionResult> Add(string tableType)
        {
            ViewBag.tableType = tableType;
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





        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.CustomerCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(CustomerAddViewModel customerAddViewModel, string tableType)
        {
            ModelState.Remove("tableType");
            ModelState.Remove("Adress");
            //var customerReferance = await _customerReferanceService.GetAsync(customerAddViewModel.CustomerReferanceId);
            //var customerType = await _customerTypeService.GetAsync(customerAddViewModel.CustomerTypeId);
            //var employee = await _employeeService.GetAsync(customerAddViewModel.EmployeeId);
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
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.Added,
TableNamesConstants.Customers,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.Added), userId: LoggedInUser.Id
);
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem!"
                    });
                    return RedirectToAction("Index", "Customer", new { tableType = tableType });
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.CustomerUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int Id, string tableType)
        {
            ViewBag.tableType = tableType;
            var customerResult = await _customerService.GetCustomerUpdateDtoAsync(Id);
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.CustomerUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(CustomerUpdateViewModel customerUpdateViewModel, string tableType)
        {
            ModelState.Remove("tableType");
            if (ModelState.IsValid)
            {
                bool isPictureUploaded = false;
                var oldPicture = customerUpdateViewModel.Picture;
                var customerUpdateDto = Mapper.Map<CustomerUpdateDto>(customerUpdateViewModel);

                if (customerUpdateViewModel.PictureFile != null)
                {
                    var uploadedImageResult = await ImageHelper.Upload(customerUpdateViewModel.FirstName,
                        customerUpdateViewModel.PictureFile, PictureType.Post);
                    customerUpdateViewModel.Picture = uploadedImageResult.ResultStatus == ResultStatus.Success
                        ? uploadedImageResult.Data.FullName
                        : "postImages/defaultThumbnail.jpg";
                    if (oldPicture != "postImages/defaultThumbnail.jpg")
                    {
                        customerUpdateDto.Picture = customerUpdateViewModel.Picture;
                        isPictureUploaded = true;
                    }
                }

                var result = await _customerService.UpdateAsync(customerUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    if (isPictureUploaded)
                    {
                        ImageHelper.Delete(oldPicture);
                    }
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.Updated,
TableNamesConstants.Customers,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.Updated), userId: LoggedInUser.Id,
customerId: customerUpdateDto.Id
);
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem!"
                    });
                    return RedirectToAction("Index", "Customer", new { tableType = tableType });
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
                    var result = await _customerService.DeleteAsync(appointmentId, LoggedInUser.UserName);
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
                    var result = await _customerService.HardDeleteAsync(appointmentId);
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.CustomerDelete}")]
        [HttpPost]
        public async Task<JsonResult> Delete(int customerId, string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _customerService.DeleteAsync(customerId, LoggedInUser.UserName);
                var customerResult = JsonSerializer.Serialize(result.Data);
                await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.Deleted,
TableNamesConstants.Customers,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.Deleted), userId: LoggedInUser.Id
);
                return Json(customerResult);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _customerService.HardDeleteAsync(customerId);
                var hardDeletedCustomerResult = JsonSerializer.Serialize(result);
                await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.HardDeleted,
TableNamesConstants.Customers,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.HardDeleted), userId: LoggedInUser.Id
);
                return Json(hardDeletedCustomerResult);
            }
            else
            {
                // Hatalı silme türü parametresi durumunda hata döndürme
                return Json("Hatalı silme türü parametresi!");
            }
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.CustomerDelete}")]
        [HttpPost]
        public async Task<JsonResult> UndoDelete(int customerId)
        {
            var result = await _customerService.UndoDeleteAsync(customerId, LoggedInUser.UserName);
            var undoDeleteCustomerResult = JsonSerializer.Serialize(result.Data);
            await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.UndoDeleted,
TableNamesConstants.Customers,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.UndoDeleted), userId: LoggedInUser.Id
);
            return Json(undoDeleteCustomerResult);
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}")]
        [HttpGet]
        public async Task<IActionResult> ViewAllActions(int id)
        {
            var result = await _notificationService.GetAllByNonDeletedAndActiveAsync("DatabaseTracking", id);
            var customer = await _customerService.GetAsync(id);
            string customerName=customer.Data.Customer.FirstName + " " + customer.Data.Customer.LastName;
            ViewBag.customerNameVB = customerName;
            if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            return View();
        }
    }
}
