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
using MyBlog.Entities.Dtos.SaleTypeDtos;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Editor")]

    public class SaleTypeController : BaseController
    {
        private readonly ISaleTypeService _saleTypeService;
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;


        public SaleTypeController(
            INotificationService notificationService,
            ISaleTypeService saleTypeService,
            UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _notificationService = notificationService;
            _saleTypeService = saleTypeService;
            _toastNotification = toastNotification;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _saleTypeService.GetAllAsync();
            if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            return NotFound();
        }
        [HttpGet]
        public async Task<JsonResult> GetAllSaleTypes()
        {
            var saleTypes = await _saleTypeService.GetAllAsync();
            var saleTypeResult = JsonSerializer.Serialize(saleTypes, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(saleTypeResult);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_SaleTypeAddPartial");
        }
        [HttpPost]
        public async Task<IActionResult> Add(SaleTypeAddDto saleTypeAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _saleTypeService.AddAsync(saleTypeAddDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new SaleTypeAddAjaxViewModel
                    {
                        SaleTypeDto = result.Data,
                        SaleTypeAddPartial = await this.RenderViewToStringAsync("_SaleTypeAddPartial", saleTypeAddDto)
                    });
                    return Json(categoryAddAjaxModel);
                }
            }
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new SaleTypeAddAjaxViewModel
            {
                SaleTypeAddPartial = await this.RenderViewToStringAsync("_SaleTypeAddPartial", saleTypeAddDto)
            });
            return Json(categoryAddAjaxErrorModel);

        }
        [HttpGet]
        public async Task<IActionResult> Update(int saleTypeId)
        {
            var result = await _saleTypeService.GetSaleTypeUpdateDtoAsync(saleTypeId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_SaleTypeUpdatePartial", result.Data);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Update(SaleTypeUpdateDto categoryUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _saleTypeService.UpdateAsync(categoryUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                        NotificationMessageTypes.Updated, 
                        "Marka", 
                        result.Data.SaleType.ModifiedByName),
                        NotificationMessageService.GetTitle(NotificationMessageTypes.Updated)
                        );
                    var categoryUpdateAjaxModel = JsonSerializer.Serialize(new SaleTypeUpdateAjaxViewModel
                    {
                        SaleTypeDto = result.Data,
                        SaleTypeUpdatePartial = await this.RenderViewToStringAsync("_SaleTypeUpdatePartial", categoryUpdateDto)
                    });
                    return Json(categoryUpdateAjaxModel);
                }
            }
            var categoryUpdateAjaxErrorModel = JsonSerializer.Serialize(new SaleTypeUpdateAjaxViewModel
            {
                SaleTypeUpdatePartial = await this.RenderViewToStringAsync("_SaleTypeUpdatePartial", categoryUpdateDto)
            });
            return Json(categoryUpdateAjaxErrorModel);

        }
        [HttpPost]
        public async Task<JsonResult> Delete(int saleTypeId)
        {
            var result = await _saleTypeService.DeleteAsync(saleTypeId, LoggedInUser.UserName);
            var deletedEmployeeType = JsonSerializer.Serialize(result.Data);
            return Json(deletedEmployeeType);
        }
    }
}