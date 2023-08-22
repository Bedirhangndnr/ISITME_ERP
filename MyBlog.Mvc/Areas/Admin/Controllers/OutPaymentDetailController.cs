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
using MyBlog.Entities.Dtos.CustomerReferanceDtos;
using MyBlog.Entities.Dtos.OutPaymentDetailDtos;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Services.Utilities;
using MyBlog.Mvc.Consts; 
namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    

    public class OutPaymentDetailController : BaseController
    {
        private readonly IOutPaymentDetailService _outPaymentDetailService;
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;
        private readonly IEmployeeService _employeeService;
        private readonly IOutPaymentService _outPaymentService;


        public OutPaymentDetailController(
            IEmployeeService employeeService,
            IOutPaymentDetailService outPaymentDetailService,
            INotificationService notificationService,
            IOutPaymentService outPaymentService,
            UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _employeeService = employeeService;
            _outPaymentDetailService = outPaymentDetailService;
            _notificationService = notificationService;
            _outPaymentService = outPaymentService;
            _toastNotification = toastNotification;
        }

        [HttpGet]
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.OutPaymentDetailRead}")]
        public async Task<IActionResult> Index(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _outPaymentDetailService.GetAllByNonDeletedAndActiveAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _outPaymentDetailService.GetAllByDeletedAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return View();
        }
        [HttpGet]
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.OutPaymentDetailRead}")]
        public async Task<JsonResult> GetAllOutPaymentDetails(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var employeeTypes = await _outPaymentDetailService.GetAllByNonDeletedAndActiveAsync();
                var employeeTypeResult = JsonSerializer.Serialize(employeeTypes, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(employeeTypeResult);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _outPaymentDetailService.GetAllByDeletedAsync();
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
        [HttpGet]
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.OutPaymentDetailCreate}")]
        public async Task<IActionResult> Add(int outPaymentId)
        {
            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            var outPaymentList= await _outPaymentService.GetAllByNonDeletedAndActiveAsync();
            
            if (employeeList.ResultStatus == ResultStatus.Success)
            {
                var model = new OutPaymentDetailAddDto
                {
                    OutPaymentId=outPaymentId,
                    Employees = employeeList.Data.Employees,
                    OutPayments = outPaymentList.Data.OutPayments
                };

                return PartialView("_OutPaymentDetailAddPartial", model);
            }

            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.OutPaymentDetailCreate}")]
        [HttpPost]
            public async Task<IActionResult> Add(OutPaymentDetailAddDto outPaymentDetailAddDto)
            {
                var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
                var outPaymentList = await _outPaymentService.GetAllByNonDeletedAndActiveAsync();

                if (employeeList.ResultStatus == ResultStatus.Success)
                {
                    outPaymentDetailAddDto.Employees = employeeList.Data.Employees;
                    outPaymentDetailAddDto.OutPayments= outPaymentList.Data.OutPayments;
                }
                ModelState.Remove("Employees");
                ModelState.Remove("OutPayments");
            if (ModelState.IsValid)
            {
                var result = await _outPaymentDetailService.AddAsync(outPaymentDetailAddDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var options = new JsonSerializerOptions
                    {
                        ReferenceHandler = ReferenceHandler.Preserve
                    };
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new OutPaymentDetailAddAjaxViewModel
                    {
                        OutPaymentDetailDto = result.Data,
                        OutPaymentDetailAddPartial = await this.RenderViewToStringAsync("_OutPaymentDetailAddPartial", outPaymentDetailAddDto)
                    },options);
                    return Json(categoryAddAjaxModel);
                }
            }
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new OutPaymentDetailAddAjaxViewModel
            {
                OutPaymentDetailAddPartial = await this.RenderViewToStringAsync("_OutPaymentDetailAddPartial", outPaymentDetailAddDto)
            });
            return Json(categoryAddAjaxErrorModel);
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.OutPaymentDetailUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int Id, string tableType)
        {
            ViewBag.TableType = tableType;
            var result = await _outPaymentDetailService.GetOutPaymentDetailUpdateDtoAsync(Id);  // burda bir sıkıntı var.

            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            var outPaymentList = await _outPaymentService.GetAllByNonDeletedAndActiveAsync();
            result.Data.Employees = employeeList.Data.Employees;
            result.Data.OutPayments = outPaymentList.Data.OutPayments;
            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_OutPaymentDetailUpdatePartial", result.Data);
            }
            return NotFound();  
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.OutPaymentDetailUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(OutPaymentDetailUpdateDto outPaymentDetailUpdateDto, string tableType)
        {
            ViewBag.tableType = tableType;
            ModelState.Remove("tableType");

            if (ModelState.IsValid)
            {
                var result = await _outPaymentDetailService.UpdateAsync(outPaymentDetailUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                        NotificationMessageTypes.Updated,
                        "Marka",
                        result.Data.OutPaymentDetail.ModifiedByName),
                        NotificationMessageService.GetTitle(NotificationMessageTypes.Updated), userId: LoggedInUser.Id
                        );
                    var categoryUpdateAjaxModel = JsonSerializer.Serialize(new OutPaymentDetailUpdateAjaxViewModel
                    {
                        OutPaymentDetailDto = result.Data,
                        OutPaymentDetailUpdatePartial = await this.RenderViewToStringAsync("_OutPaymentDetailUpdatePartial", outPaymentDetailUpdateDto)
                    });
                    return Json(categoryUpdateAjaxModel);
                }
            }
            var categoryUpdateAjaxErrorModel = JsonSerializer.Serialize(new OutPaymentDetailUpdateAjaxViewModel
            {
                OutPaymentDetailUpdatePartial = await this.RenderViewToStringAsync("_OutPaymentDetailUpdatePartial", outPaymentDetailUpdateDto)
            });
            return Json(categoryUpdateAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.OutPaymentDetailDelete}")]
        [HttpPost]
        public async Task<JsonResult> Delete(int outPaymentDetailId, string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _outPaymentDetailService.DeleteAsync(outPaymentDetailId, LoggedInUser.UserName);
                var deletedOutPaymentDetail = JsonSerializer.Serialize(result.Data);
                return Json(deletedOutPaymentDetail);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _outPaymentDetailService.HardDeleteAsync(outPaymentDetailId);
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.SaleStatusDelete}")]
        public async Task<JsonResult> UndoDelete(int outPaymentDetailId)
        {
            var result = await _outPaymentDetailService.UndoDeleteAsync(outPaymentDetailId, LoggedInUser.UserName);
            var undoDeletedOutPaymentDetail = JsonSerializer.Serialize(result.Data);
            return Json(undoDeletedOutPaymentDetail);
        }
    }
}