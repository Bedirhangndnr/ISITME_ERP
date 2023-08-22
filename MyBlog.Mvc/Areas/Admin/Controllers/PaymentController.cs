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

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    

    public class PaymentController : BaseController
    {
        private readonly IPaymentService _paymentService;
        private readonly IPaymentTypeService _paymentTypeService;
        private readonly IEmployeeService _employeeService;
        private readonly ICustomerService _customerService;
        private readonly IAssociatedInstitutionService _associatedInstitutionService;
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;


        public PaymentController(IPaymentService paymentService,
                        INotificationService notificationService,

            IPaymentTypeService paymentTypeService,
        IAssociatedInstitutionService associatedInstitutionService,
        IEmployeeService employeeService,
        ICustomerService customerService,
        UserManager<User> userManager, IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _notificationService = notificationService;

            _customerService = customerService;
            _employeeService = employeeService;
            _paymentTypeService = paymentTypeService;
            _paymentService = paymentService;
            _associatedInstitutionService = associatedInstitutionService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.PaymentRead}")]
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
            _toastNotification.AddErrorToastMessage("Bir Hata ile Karşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return NotFound();

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.PaymentRead}")]
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
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return Json(null);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.PaymentCreate}")]
        [HttpGet]
        public async Task<IActionResult> Add(string tableType)
        {

            ViewBag.tableType = tableType;
            //int associatedInstitutionsId = paymentListDto.Data.Payments[0].AssociatedInstitutionsId ?? 1;
            var paymentTypeList = await _paymentTypeService.GetAllByNonDeletedAndActiveAsync();
            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            var customerList = await _customerService.GetAllByNonDeletedAndActiveAsync();
            var associatedInstitutionsList = await _associatedInstitutionService.GetAllByNonDeletedAndActiveAsync(-1, 0);
            //var associatedInstitutionList = await _associatedInstitutionService.GetAllByNonDeletedAndActiveAsync();
            if ((paymentTypeList.ResultStatus == ResultStatus.Success &&
                employeeList.ResultStatus == ResultStatus.Success &&
                customerList.ResultStatus == ResultStatus.Success&&
                associatedInstitutionsList.ResultStatus == ResultStatus.Success))
            {
                return View(new PaymentAddViewModel
                {
                    Employees = employeeList.Data.Employees,
                    Customers = customerList.Data.Customers,
                    PaymentTypes = paymentTypeList.Data.PaymentTypes,
                    AssociatedInstitutions = associatedInstitutionsList.Data.AssociatedInstitutions
                });
            }
            return NotFound();
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.PaymentCreate }")]
        [HttpPost]
        public async Task<IActionResult> Add(PaymentAddViewModel paymentAddViewModel, string tableType)
        {
            ModelState.Remove("tableType");
            if (ModelState.IsValid)
            {
                var paymentTypeAddDto = Mapper.Map<PaymentAddDto>(paymentAddViewModel);
                var result = await _paymentService.AddAsync(paymentTypeAddDto, LoggedInUser.UserName, LoggedInUser.Id);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                       NotificationMessageTypes.Added,
                       TableNamesConstants.Payments,
                       LoggedInUser.UserName),
                       NotificationMessageService.GetTitle(NotificationMessageTypes.Added), userId: LoggedInUser.Id
                       );
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

            var paymentTypeList = await _paymentTypeService.GetAllByNonDeletedAndActiveAsync();
            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            var customerList = await _customerService.GetAllByNonDeletedAndActiveAsync();
            var associatedInstitutionsList = await _associatedInstitutionService.GetAllByNonDeletedAndActiveAsync(-1, 0);
            paymentAddViewModel.Employees = employeeList.Data.Employees;
            paymentAddViewModel.Customers = customerList.Data.Customers;
            paymentAddViewModel.PaymentTypes = paymentTypeList.Data.PaymentTypes;
            paymentAddViewModel.AssociatedInstitutions = associatedInstitutionsList.Data.AssociatedInstitutions;
            return View(paymentAddViewModel);
            }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.PaymentUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int id, string tableType)
        {   
            // Kodun u kısmında nalayamadığım bir sorun var. developer toolsu açında buraya tekrar giriyor sonra bakacağım.
            if( id != 0 && tableType != null)
            {
                ViewBag.TableType = tableType;

                var paymentUpdateDto = await _paymentService.GetPaymentUpdateDtoAsync(id);
                var paymentTypeResult = await _paymentTypeService.GetAllByNonDeletedAndActiveAsync();
                var customerResult = await _customerService.GetAllByNonDeletedAndActiveAsync();
                var employeeResult = await _employeeService.GetAllByNonDeletedAndActiveAsync();

                var associatedInstitutionsResult = await _associatedInstitutionService.GetAllByNonDeletedAndActiveAsync(paymentUpdateDto.Data.AssociatedInstitutionsId,0);

                if (paymentUpdateDto.ResultStatus != ResultStatus.Success ||
                    paymentTypeResult.ResultStatus != ResultStatus.Success ||
                    customerResult.ResultStatus != ResultStatus.Success ||
                    employeeResult.ResultStatus != ResultStatus.Success ||
                    associatedInstitutionsResult.ResultStatus != ResultStatus.Success)
                {
                    return NotFound();
                }

                var paymentUpdateViewModel = Mapper.Map<PaymentUpdateViewModel>(paymentUpdateDto.Data);
                paymentUpdateViewModel.PaymentTypes = paymentTypeResult.Data.PaymentTypes;
                paymentUpdateViewModel.Customers = customerResult.Data.Customers;
                paymentUpdateViewModel.Employees = employeeResult.Data.Employees;
                paymentUpdateViewModel.AssociatedInstitutions = associatedInstitutionsResult.Data.AssociatedInstitutions;
                paymentUpdateViewModel.PaymentTypeId = paymentUpdateViewModel.AssociatedInstitutions[0].PaymentTypeId;


                return View(paymentUpdateViewModel);
            }
            else { return NotFound(); }
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.PaymentUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(PaymentUpdateViewModel PaymentUpdateViewModel, string tableType)
        {
            ModelState.Remove("tableType");
            ModelState.Remove("paymentTypeId");
            if (ModelState.IsValid)
            {
                var PaymentUpdateDto = Mapper.Map<PaymentUpdateDto>(PaymentUpdateViewModel);

                var result = await _paymentService.UpdateAsync(PaymentUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                      NotificationMessageTypes.Updated,
                      TableNamesConstants.Payments,
                      LoggedInUser.UserName),
                      NotificationMessageService.GetTitle(NotificationMessageTypes.Added), userId: LoggedInUser.Id
                      );
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
            var paymentTypeList = await _paymentTypeService.GetAllByNonDeletedAndActiveAsync();
            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            var customerList = await _customerService.GetAllByNonDeletedAndActiveAsync();
            PaymentUpdateViewModel.Employees = employeeList.Data.Employees;
            PaymentUpdateViewModel.Customers = customerList.Data.Customers;
            PaymentUpdateViewModel.PaymentTypes = paymentTypeList.Data.PaymentTypes;
            return View(PaymentUpdateViewModel);

        }
        [HttpGet]
        public async Task<IActionResult> LoadAssociatedInstitutions(int paymentTypeId)
        {
            // paymentTypeId'ye göre ilgili AssociatedInstitutions'ları asenkron olarak getir
            var associatedInstitutions = await _associatedInstitutionService.GetAllByNonDeletedAndActiveAsync(0, paymentTypeId);

            // associatedInstitutions listesini PartialView olarak dön
            return PartialView("_AssociatedInstitutionsListPartial", associatedInstitutions.Data.AssociatedInstitutions);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.PaymentUpdate}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteFromUpdatePage(int Id, string tableType)
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                // Silme işlemi modaldan geldiyse normal controller işlemini yap => buradaki if koşulu bunun bir ajax sorgusuolup olamdığını kontrol eder.
                return await Delete(Id, tableType);
            }
            else
            {
                string errMessage = "";
                if (tableType == TableReturnTypesConstants.NonDeletedTables)
                {
                    var result = await _paymentService.DeleteAsync(Id, LoggedInUser.UserName);
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
                    var result = await _paymentService.HardDeleteAsync(Id);
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.PaymentDelete}")]

        [HttpPost]
        public async Task<JsonResult> Delete(int paymentId, string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _paymentService.DeleteAsync(paymentId, LoggedInUser.UserName);
                var paymentResult = JsonSerializer.Serialize(result.Data);
                await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                      NotificationMessageTypes.Deleted,
                      TableNamesConstants.Payments,
                      LoggedInUser.UserName),
                      NotificationMessageService.GetTitle(NotificationMessageTypes.Deleted), userId: LoggedInUser.Id
                      );
                return Json(paymentResult);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                      NotificationMessageTypes.HardDeleted,
                      TableNamesConstants.Payments,
                      LoggedInUser.UserName),
                      NotificationMessageService.GetTitle(NotificationMessageTypes.HardDeleted), userId: LoggedInUser.Id
                      );
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.PaymentDelete}")]

        [HttpPost]
        public async Task<JsonResult> HardDelete(int paymentId)
        {
            var result = await _paymentService.HardDeleteAsync(paymentId);
            var hardDeletedPaymentResult = JsonSerializer.Serialize(result);
            return Json(hardDeletedPaymentResult);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.PaymentDelete}")]

        [HttpGet]
        public async Task<IActionResult> DeletedPayments()
        {
            var result = await _paymentService.GetAllByDeletedAsync();
            return View(result.Data);

        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.PaymentRead}")]
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.PaymentUpdate}")]
        [HttpPost]
        public async Task<JsonResult> UndoDelete(int paymentId)
        {
            await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                      NotificationMessageTypes.UndoDeleted,
                      TableNamesConstants.Payments,
                      LoggedInUser.UserName),
                      NotificationMessageService.GetTitle(NotificationMessageTypes.UndoDeleted), userId: LoggedInUser.Id
                      );
            var result = await _paymentService.UndoDeleteAsync(paymentId, LoggedInUser.UserName);
            var undoDeletePaymentResult = JsonSerializer.Serialize(result.Data);
            return Json(undoDeletePaymentResult);
        }

    }
}