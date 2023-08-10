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
using MyBlog.Entities.Dtos.EmployeeDtos;
using MyBlog.Mvc.Consts;
using MyBlog.Services.Utilities;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;
using MyBlog.Shared.Utilities.Results.Concrete;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class EmployeeController : BaseController
    {
        private readonly IEmployeeService _employeeService;
        private readonly IEmployeeTypeService _employeeTypeService;
        private readonly IPaymentService _paymentService;
        private readonly IPaymentTypeService _paymentTypeService;
        private readonly INotificationService _notificationService;

        private readonly IToastNotification _toastNotification;

        public EmployeeController(IEmployeeService employeeService,
            IPaymentService paymentService,
            IPaymentTypeService paymentTypeService,
                        INotificationService notificationService,

            IEmployeeTypeService EmployeeTypeService, UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _paymentService = paymentService;
            _paymentTypeService = paymentTypeService;
            _notificationService = notificationService;

            _employeeService = employeeService;
            _employeeTypeService = EmployeeTypeService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.EmployeeRead}")]
        [HttpGet]
        public async Task<IActionResult> Index(string tableType)
        {
            ViewBag.tableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _employeeService.GetAllByNonDeletedAndActiveAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _employeeService.GetAllByDeletedAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return NotFound();



        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.EmployeeRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllEmployees(string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var employees = await _employeeService.GetAllByNonDeletedAndActiveAsync();
                var employeeResult = JsonSerializer.Serialize(employees, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(employeeResult);

            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _employeeService.GetAllByDeletedAsync();
                var employees = JsonSerializer.Serialize(result, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(employees);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return Json(null);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.EmployeeCreate}")]
        [HttpGet]
        public async Task<IActionResult> Add(string tableType)
        {
            ViewBag.tableType = tableType;
            var employeeTypesList = await _employeeTypeService.GetAllByNonDeletedAndActiveAsync();
            if ((employeeTypesList.ResultStatus == ResultStatus.Success))
            {
                return View(new EmployeeAddViewModel
                {
                    EmployeeTypes = employeeTypesList.Data.EmployeeTypes,
                });
            }
            return NotFound();
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.EmployeeCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(EmployeeAddViewModel employeeAddViewModel, string tableType)
        {
            ModelState.Remove("tableType");
            if (ModelState.IsValid)
            {
                var employeeTypeAddDto = Mapper.Map<EmployeeAddDto>(employeeAddViewModel);
                if (employeeAddViewModel.PictureFile != null)
                {
                    var imageResult = await ImageHelper.Upload(employeeAddViewModel.FirstName,
    employeeAddViewModel.PictureFile, PictureType.Post);
                    employeeTypeAddDto.Picture = imageResult.Data.FullName;
                }
                else
                {
                    employeeTypeAddDto.Picture = "/userImages/defaultUser.png";
                }
                var result = await _employeeService.AddAsync(employeeTypeAddDto, LoggedInUser.UserName, LoggedInUser.Id);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.Added,
TableNamesConstants.Employees,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.Added), userId: LoggedInUser.Id
);
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem!"
                    });
                    return RedirectToAction("Index", "Employee", new { tableType = tableType });
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                }
            }


            var employeeTypesList = await _employeeTypeService.GetAllByNonDeletedAndActiveAsync();
            employeeAddViewModel.EmployeeTypes = employeeTypesList.Data.EmployeeTypes;
            return View(employeeAddViewModel);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.EmployeeUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int Id, string tableType)
        {
            ViewBag.tableType = tableType;
            ViewBag.controller = "updateController";
            var employeeResult = await _employeeService.GetEmployeeUpdateDtoAsync(Id);
            var employeeTypeResult = await _employeeTypeService.GetAllByNonDeletedAndActiveAsync();
            if (employeeResult.ResultStatus == ResultStatus.Success && employeeTypeResult.ResultStatus == ResultStatus.Success)
            {
                var EmployeeUpdateViewModel = Mapper.Map<EmployeeUpdateViewModel>(employeeResult.Data);
                EmployeeUpdateViewModel.EmployeeTypes = employeeTypeResult.Data.EmployeeTypes;
                return View(EmployeeUpdateViewModel);
            }
            else
            {
                return NotFound();
            }
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.EmployeeUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(EmployeeUpdateViewModel EmployeeUpdateViewModel, string tableType)
        {
            ModelState.Remove("tableType");
            if (ModelState.IsValid)
            {
                bool isPictureUploaded = false;
                var oldPicture = EmployeeUpdateViewModel.Picture;
                var EmployeeUpdateDto = Mapper.Map<EmployeeUpdateDto>(EmployeeUpdateViewModel);

                if (EmployeeUpdateViewModel.PictureFile != null)
                {
                    var uploadedImageResult = await ImageHelper.Upload(EmployeeUpdateViewModel.FirstName,
                        EmployeeUpdateViewModel.PictureFile, PictureType.Post);
                    EmployeeUpdateViewModel.Picture = uploadedImageResult.ResultStatus == ResultStatus.Success
                        ? uploadedImageResult.Data.FullName
                        : "postImages/defaultThumbnail.jpg";
                    if (oldPicture != "postImages/defaultThumbnail.jpg")
                    {
                        EmployeeUpdateDto.Picture = EmployeeUpdateViewModel.Picture;
                        isPictureUploaded = true;
                    }
                }

                var result = await _employeeService.UpdateAsync(EmployeeUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    if (isPictureUploaded)
                    {
                        ImageHelper.Delete(oldPicture);
                    }
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.Updated,
TableNamesConstants.Employees,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.Updated), userId: LoggedInUser.Id
);
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem!"
                    });
                    return RedirectToAction("Index", "Employee", new { tableType = tableType });
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                }
            }
            var employeeTypesList = await _employeeTypeService.GetAllByNonDeletedAndActiveAsync();
            EmployeeUpdateViewModel.EmployeeTypes = employeeTypesList.Data.EmployeeTypes;
            return View(EmployeeUpdateViewModel);
        }



        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.EmployeeUpdate}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteFromUpdatePage(int employeeId, string tableType)
        {
            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                // Silme işlemi modaldan geldiyse normal controller işlemini yap => buradaki if koşulu bunun bir ajax sorgusuolup olamdığını kontrol eder.
                return await Delete(employeeId, tableType);
            }
            else
            {
                string errMessage = "";
                if (tableType == TableReturnTypesConstants.NonDeletedTables)
                {
                    var result = await _employeeService.DeleteAsync(employeeId, LoggedInUser.UserName);
                    if (result.ResultStatus == ResultStatus.Success)
                    {
                        _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                        {
                            Title = "Başarılı İşlem!"
                        });
                        return RedirectToAction("Index", "Employee", new { tableType = tableType });
                    }
                    errMessage = result.Message;
                }
                else if (tableType == TableReturnTypesConstants.DeletedTables)
                {
                    var result = await _employeeService.HardDeleteAsync(employeeId);
                    if (result.ResultStatus == ResultStatus.Success)
                    {
                        _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                        {
                            Title = "Başarılı İşlem!"
                        });
                        return RedirectToAction("Index", "Employee", new { tableType = tableType });
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.EmployeeDelete}")]

        [HttpPost]
        public async Task<JsonResult> Delete(int employeeId, string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _employeeService.DeleteAsync(employeeId, LoggedInUser.UserName);
                var employeeResult = JsonSerializer.Serialize(result.Data);
                await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.Deleted,
TableNamesConstants.Employees,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.Deleted), userId: LoggedInUser.Id
);
                return Json(employeeResult);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _employeeService.HardDeleteAsync(employeeId);
                var hardDeletedEmployeeResult = JsonSerializer.Serialize(result);
                  await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.HardDeleted,
TableNamesConstants.Employees,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.HardDeleted), userId: LoggedInUser.Id
);
                    return Json(hardDeletedEmployeeResult);
            }
            else
            {
                // Hatalı silme türü parametresi durumunda hata döndürme
                return Json("Hatalı silme türü parametresi!");
            }
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.EmployeeDelete}")]

        [HttpPost]
        public async Task<JsonResult> HardDelete(int employeeId)
        {
            var result = await _employeeService.HardDeleteAsync(employeeId);
            var hardDeletedEmployeeResult = JsonSerializer.Serialize(result);
            return Json(hardDeletedEmployeeResult);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.EmployeeDelete}")]

        [HttpGet]
        public async Task<IActionResult> DeletedEmployees()
        {
            var result = await _employeeService.GetAllByDeletedAsync();
            return View(result.Data);

        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.EmployeeRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllDeletedEmployees()
        {
            var result = await _employeeService.GetAllByDeletedAsync();
            var employees = JsonSerializer.Serialize(result, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(employees);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.EmployeeUpdate}")]
        [HttpPost]
        public async Task<JsonResult> UndoDelete(int employeeId)
        {
            var result = await _employeeService.UndoDeleteAsync(employeeId, LoggedInUser.UserName);
            var undoDeleteEmployeeResult = JsonSerializer.Serialize(result.Data);
            await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.UndoDeleted,
TableNamesConstants.Employees,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.UndoDeleted), userId: LoggedInUser.Id
);
            return Json(undoDeleteEmployeeResult);
        }

    }
}
