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
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Mvc.Consts;
using MyBlog.Services.Utilities;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]

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

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.BrandRead}")]
        [HttpGet]
        public async Task<IActionResult> Index(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _brandService.GetAllByNonDeletedAndActiveAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _brandService.GetAllByDeletedAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return View();
        }
        [HttpGet]
        public async Task<JsonResult> GetAllBrands(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var employeeTypes = await _brandService.GetAllByNonDeletedAndActiveAsync();
                var employeeTypeResult = JsonSerializer.Serialize(employeeTypes, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(employeeTypeResult);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _brandService.GetAllByDeletedAsync();
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.BrandCreate}")]
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_BrandAddPartial");
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.BrandCreate}")]
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.BrandUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int brandId, string tableType)
        {
            ViewBag.TableType = tableType;
            var result = await _brandService.GetBrandUpdateDtoAsync(brandId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_BrandUpdatePartial", result.Data);
            }
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.BrandUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(BrandUpdateDto brandUpdateDto, string tableType)
        {
            ViewBag.tableType = tableType;
            if (ModelState.IsValid)
            {
                var result = await _brandService.UpdateAsync(brandUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                        NotificationMessageTypes.Updated,
                        "Brand",
                        result.Data.Brand.ModifiedByName),
                        NotificationMessageService.GetTitle(NotificationMessageTypes.Updated), userId: LoggedInUser.Id
                        );
                    var categoryUpdateAjaxModel = JsonSerializer.Serialize(new BrandUpdateAjaxViewModel
                    {
                        BrandDto = result.Data,
                        BrandUpdatePartial = await this.RenderViewToStringAsync("_BrandUpdatePartial", brandUpdateDto)
                    });
                    return Json(categoryUpdateAjaxModel);
                }
            }
            var categoryUpdateAjaxErrorModel = JsonSerializer.Serialize(new BrandUpdateAjaxViewModel
            {
                BrandUpdatePartial = await this.RenderViewToStringAsync("_BrandUpdatePartial", brandUpdateDto)
            });
            return Json(categoryUpdateAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.BrandDelete}")]
        [HttpPost]
        public async Task<JsonResult> Delete(int brandId, string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _brandService.DeleteAsync(brandId, LoggedInUser.UserName);
                var deletedBrand = JsonSerializer.Serialize(result.Data);
                return Json(deletedBrand);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _brandService.HardDeleteAsync(brandId);
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.BrandDelete}")]
        public async Task<JsonResult> UndoDelete(int brandId)
        {
            var result = await _brandService.UndoDeleteAsync(brandId, LoggedInUser.UserName);
            var undoDeletedBrand = JsonSerializer.Serialize(result.Data);
            return Json(undoDeletedBrand);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.BrandDelete}")]
        [HttpGet]
        public async Task<IActionResult> HardDelete(int brandId)
        {
            var result = await _brandService.HardDeleteAsync(brandId);
            var deletedBrand = JsonSerializer.Serialize(result);
            return View(deletedBrand);

        }
    }
}