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
using MyBlog.Entities.Dtos.OutPaymentDtos;
using MyBlog.Entities.Dtos.ArticleDtos;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Mvc.Consts;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]


    public class OutPaymentController : BaseController
    {
        private readonly IOutPaymentService _outPaymentService;
        private readonly IOutPaymentDetailService _outPaymentDetailService;
        private readonly IEmployeeService _employeeService;
        private readonly ICustomerService _customerService;
        private readonly IAssociatedInstitutionService _associatedInstitutionService;
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;


        public OutPaymentController(
                        INotificationService notificationService,

            IOutPaymentService outPaymentService,
            IOutPaymentDetailService outPaymentDetailService,
        IAssociatedInstitutionService associatedInstitutionService,
        IEmployeeService employeeService,
        ICustomerService customerService,
        UserManager<User> userManager, IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _customerService = customerService;
            _notificationService = notificationService;

            _employeeService = employeeService;
            _outPaymentService = outPaymentService;
            _outPaymentDetailService = outPaymentDetailService;
            _associatedInstitutionService = associatedInstitutionService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.OutPaymentRead}")]
        [HttpGet]
        public async Task<IActionResult> Index(string tableType)
        {
            ViewBag.tableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _outPaymentService.GetAllByNonDeletedAndActiveAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _outPaymentService.GetAllByDeletedAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile Karşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return NotFound();

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.OutPaymentRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllOutPayments(string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var outPayments = await _outPaymentService.GetAllByNonDeletedAndActiveAsync();
                var outPaymentResult = JsonSerializer.Serialize(outPayments, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(outPaymentResult);

            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _outPaymentService.GetAllByDeletedAsync();
                var outPayments = JsonSerializer.Serialize(result, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(outPayments);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return Json(null);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.OutPaymentCreate}")]
        [HttpGet]
        public async Task<IActionResult> Add(string tableType)
        {

            ViewBag.tableType = tableType;
            if (true)
            {
                return View(new OutPaymentAddViewModel
                {
                });
            }
            return NotFound();
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.OutPaymentCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(OutPaymentAddViewModel outPaymentAddViewModel, string tableType)
        {
            ModelState.Remove("tableType");
            ModelState.Remove("Description");
            ModelState.Remove("OutPaymentDetails");
            if (ModelState.IsValid)
            {
                var outPaymentTypeAddDto = Mapper.Map<OutPaymentAddDto>(outPaymentAddViewModel);
                var result = await _outPaymentService.AddAsync(outPaymentTypeAddDto, LoggedInUser.UserName, LoggedInUser.Id);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.Added,
TableNamesConstants.OutPayments,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.Added), userId: LoggedInUser.Id
);
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem!"
                    });
                    return RedirectToAction("Index", "OutPayment", new { tableType = tableType });
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                }
            }
            return View(outPaymentAddViewModel);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.OutPaymentUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int id, string tableType)
        {

            // Kodun u kısmında nalayamadığım bir sorun var. developer toolsu açında buraya tekrar giriyor sonra bakacağım.
            if (id != 0 && tableType != null)
            {
                ViewBag.TableType = tableType;

                var outPaymentUpdateDto = await _outPaymentService.GetOutPaymentUpdateDtoAsync(id);
                var outPaymentDetailList = await _outPaymentDetailService.GetAllByNonDeletedAndActiveAsync(id);
                outPaymentUpdateDto.Data.TotalAmount = Convert.ToDecimal(outPaymentDetailList.Data.OutPaymentDetails.Sum(d => d.AmountPaid).ToString("0.##"));
                outPaymentUpdateDto.Data.DebtAmount = Convert.ToDecimal(outPaymentUpdateDto.Data.DebtAmount.ToString("0.##"));
                if (outPaymentUpdateDto.ResultStatus != ResultStatus.Success)
                {
                    return NotFound();
                }

                var outPaymentUpdateViewModel = Mapper.Map<OutPaymentUpdateViewModel>(outPaymentUpdateDto.Data);
                outPaymentUpdateViewModel.OutPaymentDetails = outPaymentDetailList.Data.OutPaymentDetails;

                return View(outPaymentUpdateViewModel);
            }
            else { return NotFound(); }
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.OutPaymentUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(OutPaymentUpdateViewModel outPaymentUpdateViewModel, string tableType)
        {
            //ModelState.Remove("OutPaymentDetails");
            outPaymentUpdateViewModel.DebtAmount = Convert.ToDecimal(Convert.ToDouble(outPaymentUpdateViewModel.DebtAmount) / 100);
            ModelState.Remove("tableType");
            var outPaymentDetailList = await _outPaymentDetailService.GetAllByNonDeletedAndActiveAsync(outPaymentUpdateViewModel.Id);
            outPaymentUpdateViewModel.OutPaymentDetails = outPaymentDetailList.Data.OutPaymentDetails;

            if (ModelState.IsValid)
            {
                var outPaymentUpdateDto = Mapper.Map<OutPaymentUpdateDto>(outPaymentUpdateViewModel);

                var result = await _outPaymentService.UpdateAsync(outPaymentUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                       NotificationMessageTypes.Updated,
                       TableNamesConstants.OutPayments,
                       LoggedInUser.UserName),
                       NotificationMessageService.GetTitle(NotificationMessageTypes.Updated), userId: LoggedInUser.Id
                       );
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem!"
                    });
                    return RedirectToAction("Index", "OutPayment", new { tableType = tableType });
                }
                else
                {
                    _toastNotification.AddErrorToastMessage(outPaymentUpdateDto.Message, new ToastrOptions
                    {
                        Title = "Başarısız İşlem!"
                    });
                    ModelState.AddModelError("", result.Message);
                }
            }
            return View(outPaymentUpdateViewModel);

        }
        [HttpGet]
        public async Task<IActionResult> LoadAssociatedInstitutions(int outPaymentTypeId)
        {
            // outPaymentTypeId'ye göre ilgili AssociatedInstitutions'ları asenkron olarak getir
            var associatedInstitutions = await _associatedInstitutionService.GetAllByNonDeletedAndActiveAsync(0, outPaymentTypeId);

            // associatedInstitutions listesini PartialView olarak dön
            return PartialView("_AssociatedInstitutionsListPartial", associatedInstitutions.Data.AssociatedInstitutions);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.OutPaymentUpdate}")]
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
                    var result = await _outPaymentService.DeleteAsync(Id, LoggedInUser.UserName);
                    if (result.ResultStatus == ResultStatus.Success)
                    {
                        _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                        {
                            Title = "Başarılı İşlem!"
                        });
                        return RedirectToAction("Index", "OutPayment", new { tableType = tableType });
                    }
                    errMessage = result.Message;
                }
                else if (tableType == TableReturnTypesConstants.DeletedTables)
                {
                    var result = await _outPaymentService.HardDeleteAsync(Id);
                    if (result.ResultStatus == ResultStatus.Success)
                    {
                        _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                        {
                            Title = "Başarılı İşlem!"
                        });
                        return RedirectToAction("Index", "OutPayment", new { tableType = tableType });
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.OutPaymentDelete}")]

        [HttpPost]
        public async Task<JsonResult> Delete(int outPaymentId, string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _outPaymentService.DeleteAsync(outPaymentId, LoggedInUser.UserName);
                var outPaymentResult = JsonSerializer.Serialize(result.Data);
                // update detail
                var outPaymentDetail = _outPaymentDetailService
                    .DeleteByOutPaymentIdAsync(outPaymentId, LoggedInUser.UserName);
                await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                    NotificationMessageTypes.Deleted,
                    TableNamesConstants.OutPayments,
                    LoggedInUser.UserName),
                    NotificationMessageService.GetTitle(NotificationMessageTypes.Deleted), userId: LoggedInUser.Id
                    ); return Json(outPaymentResult);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _outPaymentService.HardDeleteAsync(outPaymentId);
                var hardDeletedOutPaymentResult = JsonSerializer.Serialize(result);
                // update detail
                var outPaymentDetail = _outPaymentDetailService
                    .HardDeleteByOutPaymentIdAsync(outPaymentId);
                await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                    NotificationMessageTypes.HardDeleted,
                    TableNamesConstants.OutPayments,
                    LoggedInUser.UserName),
                    NotificationMessageService.GetTitle(NotificationMessageTypes.HardDeleted), userId: LoggedInUser.Id
                    ); return Json(hardDeletedOutPaymentResult);
            }
            else
            {
                // Hatalı silme türü parametresi durumunda hata döndürme
                return Json("Hatalı silme türü parametresi!");
            }
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.OutPaymentDelete}")]

        [HttpPost]
        public async Task<JsonResult> HardDelete(int outPaymentId)
        {
            var result = await _outPaymentService.HardDeleteAsync(outPaymentId);
            var hardDeletedOutPaymentResult = JsonSerializer.Serialize(result);
            return Json(hardDeletedOutPaymentResult);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.OutPaymentDelete}")]

        [HttpGet]
        public async Task<IActionResult> DeletedOutPayments()
        {
            var result = await _outPaymentService.GetAllByDeletedAsync();
            return View(result.Data);

        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.OutPaymentRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllDeletedOutPayments()
        {
            var result = await _outPaymentService.GetAllByDeletedAsync();
            var outPayments = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(outPayments);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.OutPaymentUpdate}")]
        [HttpPost]
        public async Task<JsonResult> UndoDelete(int outPaymentId)
        {
            var result = await _outPaymentService.UndoDeleteAsync(outPaymentId, LoggedInUser.UserName);
            var undoDeleteOutPaymentResult = JsonSerializer.Serialize(result.Data);
            // update detail
            var outPaymentDetail = _outPaymentDetailService
                .UndoDeleteByOutPaymentIdAsync(outPaymentId, LoggedInUser.UserName);
            await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.UndoDeleted,
TableNamesConstants.OutPayments,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.UndoDeleted), userId: LoggedInUser.Id
);
            return Json(undoDeleteOutPaymentResult);
        }

    }
}