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
using MyBlog.Entities.Dtos.BrandDtos;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Entities.Dtos.BrandDtos;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Mvc.Consts;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Editor")]

    public class BrandController : BaseController
    {
        private readonly IBrandService _brandService;
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;


        public BrandController(
            INotificationService notificationService,
            IBrandService brandService,
            UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _notificationService = notificationService;
            _brandService = brandService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.AppointmentRead}")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _brandService.GetAllAsync();
            if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            return NotFound();
        }
        [HttpGet]
        public async Task<JsonResult> GetAllBrands()
        {
            var brands = await _brandService.GetAllAsync();
            var brandResult = JsonSerializer.Serialize(brands, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(brandResult);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.AppointmentCreate}")]
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_BrandAddPartial");
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.AppointmentCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(BrandAddDto brandAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _brandService.AddAsync(brandAddDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new BrandAddAjaxViewModel
                    {
                        BrandDto = result.Data,
                        BrandAddPartial = await this.RenderViewToStringAsync("_BrandAddPartial", brandAddDto)
                    });
                    return Json(categoryAddAjaxModel);
                }
            }
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new BrandAddAjaxViewModel
            {
                BrandAddPartial = await this.RenderViewToStringAsync("_BrandAddPartial", brandAddDto)
            });
            return Json(categoryAddAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.AppointmentUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int brandId)
        {
            var result = await _brandService.GetBrandUpdateDtoAsync(brandId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_BrandUpdatePartial", result.Data);
            }
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.AppointmentUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(BrandUpdateDto categoryUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _brandService.UpdateAsync(categoryUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                        NotificationMessageTypes.Updated,
                        "Marka",
                        result.Data.Brand.ModifiedByName),
                        NotificationMessageService.GetTitle(NotificationMessageTypes.Updated)
                        );
                    var categoryUpdateAjaxModel = JsonSerializer.Serialize(new BrandUpdateAjaxViewModel
                    {
                        BrandDto = result.Data,
                        BrandUpdatePartial = await this.RenderViewToStringAsync("_BrandUpdatePartial", categoryUpdateDto)
                    });
                    return Json(categoryUpdateAjaxModel);
                }
            }
            var categoryUpdateAjaxErrorModel = JsonSerializer.Serialize(new BrandUpdateAjaxViewModel
            {
                BrandUpdatePartial = await this.RenderViewToStringAsync("_BrandUpdatePartial", categoryUpdateDto)
            });
            return Json(categoryUpdateAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.AppointmentDelete}")]
        [HttpPost]
        public async Task<JsonResult> Delete(int brandId)
        {
            var result = await _brandService.DeleteAsync(brandId, LoggedInUser.UserName);
            var deletedEmployeeType = JsonSerializer.Serialize(result.Data);
            return Json(deletedEmployeeType);
        }
    }
}