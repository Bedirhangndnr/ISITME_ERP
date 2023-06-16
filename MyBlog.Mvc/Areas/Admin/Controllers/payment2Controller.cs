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
using MyBlog.Entities.Dtos.PaymentDtos;
using MyBlog.Entities.Dtos.ArticleDtos;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Mvc.Consts;
using MyBlog.Mvc.CustomAttributes;
using MyBlog.Mvc.Enums;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class payment2Controller : BaseController
    {
        private readonly IPaymentService _paymentService;
        private readonly IEmployeeService _employeeService;
        private readonly ICustomerService _customerService;
        private readonly IPaymentTypeService _paymentTypeService;
        private readonly IToastNotification _toastNotification;

        public payment2Controller(IPaymentService paymentService,
        ICustomerService customerService,
        IPaymentTypeService paymentTypeService,
        IEmployeeService employeeService,
        UserManager<User> userManager, IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _paymentTypeService = paymentTypeService;
            _employeeService = employeeService;
            _paymentService = paymentService;
            _customerService = customerService;
            _toastNotification = toastNotification;
        }
        [Authorize(Roles = "SuperAdmin")]
        [HttpGet]
        public async Task<IActionResult> Index(string tableType)
        {
            ViewBag.tableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _paymentService.GetAllByNonDeletedAndActiveAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _paymentService.GetAllByDeletedAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.PaymentRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllPayments(string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var payments = await _paymentService.GetAllByNonDeletedAndActiveAsync();
                var paymentResult = JsonSerializer.Serialize(payments, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(paymentResult);

            }   
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _paymentService.GetAllByDeletedAsync();
                var payments = JsonSerializer.Serialize(result, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(payments);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile Karşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return Json(null);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.PaymentCreate}")]
        [HttpGet]
        public async Task<IActionResult> Add(string tableType)
        {
            ViewBag.tableType = tableType;
            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            var customerList = await _customerService.GetAllByNonDeletedAndActiveAsync();
            var paymentTypeList = await _paymentTypeService.GetAllByNonDeletedAndActiveAsync();
            if ((employeeList.ResultStatus == ResultStatus.Success &&
                customerList.ResultStatus == ResultStatus.Success &&
                paymentTypeList.ResultStatus == ResultStatus.Success))
            {
                return View(new PaymentAddViewModel
                {
                    Customers = customerList.Data.Customers,
                    Employees = employeeList.Data.Employees,
                    PaymentTypes = paymentTypeList.Data.PaymentTypes
                });
            }
            return NotFound();
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.PaymentCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(PaymentAddViewModel paymentAddViewModel, string tableType)
        {
            ModelState.Remove("tableType");
            if (ModelState.IsValid)
            {
                var paymentAddDto = Mapper.Map<PaymentAddDto>(paymentAddViewModel);
                var result = await _paymentService.AddAsync(paymentAddDto, LoggedInUser.UserName, LoggedInUser.Id);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem!"
                    });
                    return RedirectToAction("Index", "Payment", new { tableType = tableType });
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                }
            }

            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            var customerList = await _customerService.GetAllByNonDeletedAndActiveAsync();
            var paymentTypeList = await _paymentTypeService.GetAllByNonDeletedAndActiveAsync();
            paymentAddViewModel.Customers = customerList.Data.Customers;
            paymentAddViewModel.Employees = employeeList.Data.Employees;
            paymentAddViewModel.PaymentTypes = paymentTypeList.Data.PaymentTypes;
            return View(paymentAddViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Update(int Id, string tableType)
        {
            ViewBag.tableType = tableType;
            var paymentList = await _paymentService.GetPaymentUpdateDtoAsync(Id);
            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            var customerList = await _customerService.GetAllByNonDeletedAndActiveAsync();
            var paymentTypeList = await _paymentTypeService.GetAllByNonDeletedAndActiveAsync();
            if (employeeList.ResultStatus == ResultStatus.Success &&
               paymentList.ResultStatus == ResultStatus.Success &&
               paymentTypeList.ResultStatus == ResultStatus.Success &&
               customerList.ResultStatus == ResultStatus.Success)
            {
                var PaymentUpdateViewModel = Mapper.Map<PaymentUpdateViewModel>(paymentList.Data);
                PaymentUpdateViewModel.Customers = customerList.Data.Customers;
                PaymentUpdateViewModel.PaymentTypes = paymentTypeList.Data.PaymentTypes;
                PaymentUpdateViewModel.Employees = employeeList.Data.Employees;
                return View(PaymentUpdateViewModel);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public async Task<IActionResult> Update(PaymentUpdateViewModel PaymentUpdateViewModel, string tableType)
        {
            ModelState.Remove("tableType");
            if (ModelState.IsValid)
            {
                var PaymentUpdateDto = Mapper.Map<PaymentUpdateDto>(PaymentUpdateViewModel);

                var result = await _paymentService.UpdateAsync(PaymentUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem!"
                    });
                    return RedirectToAction("Index", "Payment", new { tableType = tableType });
                }
                else
                {
                    _toastNotification.AddErrorToastMessage(PaymentUpdateDto.Message, new ToastrOptions
                    {
                        Title = "Başarısız İşlem!"
                    });
                    ModelState.AddModelError("", result.Message);
                }
            }
            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            var customerList = await _customerService.GetAllByNonDeletedAndActiveAsync();
            var paymentTypeList = await _paymentTypeService.GetAllByNonDeletedAndActiveAsync();
            PaymentUpdateViewModel.Customers = customerList.Data.Customers;
            PaymentUpdateViewModel.Employees = employeeList.Data.Employees;
            PaymentUpdateViewModel.PaymentTypes = paymentTypeList.Data.PaymentTypes;
            return View(PaymentUpdateViewModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.EmployeeUpdate}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteFromUpdatePage(int paymentId, string tableType)
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                // Silme işlemi modaldan geldiyse normal controller işlemini yap => buradaki if koşulu bunun bir ajax sorgusuolup olamdığını kontrol eder.
                return await Delete(paymentId, tableType);
            }
            else
            {
                string errMessage = "";
                if (tableType == TableReturnTypesConstants.NonDeletedTables)
                {
                    var result = await _paymentService.DeleteAsync(paymentId, LoggedInUser.UserName);
                    if (result.ResultStatus == ResultStatus.Success)
                    {
                        _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                        {
                            Title = "Başarılı İşlem!"
                        });
                        return RedirectToAction("Index", "Payment", new { tableType = tableType });
                    }
                    errMessage = result.Message;
                }
                else if (tableType == TableReturnTypesConstants.DeletedTables)
                {
                    var result = await _paymentService.HardDeleteAsync(paymentId);
                    if (result.ResultStatus == ResultStatus.Success)
                    {
                        _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                        {
                            Title = "Başarılı İşlem!"
                        });
                        return RedirectToAction("Index", "Payment", new { tableType = tableType });
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.PaymentDelete}")]
        [HttpPost]
        public async Task<JsonResult> Delete(int paymentId, string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _paymentService.DeleteAsync(paymentId, LoggedInUser.UserName);
                var paymentResult = JsonSerializer.Serialize(result.Data);
                return Json(paymentResult);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _paymentService.HardDeleteAsync(paymentId);
                var hardDeletedPaymentResult = JsonSerializer.Serialize(result);
                return Json(hardDeletedPaymentResult);
            }
            else
            {
                // Hatalı silme türü parametresi durumunda hata döndürme
                return Json("Hatalı silme türü parametresi!");
            }
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.PaymentDelete}")]
        [HttpPost]
        public async Task<JsonResult> HardDelete(int paymentId)
        {
            var result = await _paymentService.HardDeleteAsync(paymentId);
            var hardDeletedPaymentResult = JsonSerializer.Serialize(result);
            return Json(hardDeletedPaymentResult);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.PaymentRead}")]
        [HttpGet]
        public async Task<IActionResult> DeletedPayments()
        {
            var result = await _paymentService.GetAllByDeletedAsync();
            return View(result.Data);

        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.PaymentRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllDeletedPayments()
        {
            var result = await _paymentService.GetAllByDeletedAsync();
            var payments = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(payments);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.PaymentDelete}")]
        [HttpPost]
        public async Task<JsonResult> UndoDelete(int paymentId)
        {
            var result = await _paymentService.UndoDeleteAsync(paymentId, LoggedInUser.UserName);
            var undoDeletePaymentResult = JsonSerializer.Serialize(result.Data);
            return Json(undoDeletePaymentResult);
        }
    }
}
