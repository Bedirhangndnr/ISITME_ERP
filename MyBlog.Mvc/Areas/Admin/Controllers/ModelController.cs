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
using MyBlog.Entities.Dtos.ModelDtos;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Mvc.Consts;
using MyBlog.Services.Utilities;
using MyBlog.Entities.Dtos.ModelDtos;
using MyBlog.Entities.Dtos.OutPaymentDetailDtos;
using MyBlog.Entities.Dtos.ProductSubGroupDtos;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]


    public class ModelController : BaseController
    {
        private readonly IModelService _modelService;
        private readonly IBrandService _brandService;
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;


        public ModelController(
            INotificationService notificationService,
            IModelService modelService,
            IBrandService brandService,
            UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _notificationService = notificationService;
            _modelService = modelService;
            _brandService = brandService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ModelRead}")]
        [HttpGet]
        public async Task<IActionResult> Index(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _modelService.GetAllByNonDeletedAndActiveAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _modelService.GetAllByDeletedAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile Karşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return View();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ModelCreate}")]
        [HttpGet]
        public async Task<JsonResult> GetAllModels(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var employeeTypes = await _modelService.GetAllByNonDeletedAndActiveAsync();
                var employeeTypeResult = JsonSerializer.Serialize(employeeTypes, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(employeeTypeResult);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _modelService.GetAllByDeletedAsync();
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ModelCreate}")]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var brandList = await _brandService.GetAllByNonDeletedAndActiveAsync();
            if (brandList.ResultStatus == ResultStatus.Success)
            {
                var model = new ModelAddDto
                {
                    Brands = brandList.Data.Brands,
                };

                return PartialView("_ModelAddPartial", model);
            }
            return null;
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ModelCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(ModelAddDto modelAddDto)
        {
            var brandList = await _brandService.GetAllByNonDeletedAndActiveAsync();
            if (brandList.ResultStatus == ResultStatus.Success)
            {
                modelAddDto.Brands = brandList.Data.Brands;
            }
            ModelState.Remove("Brands");
            if (ModelState.IsValid)
            {
                int? groupId = modelAddDto.BrandId != null ? modelAddDto.BrandId : 0;
                var group = _brandService.GetAsync(groupId.Value);
                string? groupTitle = group.Result.Data.Brand.Title != null ? group.Result.Data.Brand.Title : string.Empty;
                groupTitle = groupTitle != null ? groupTitle : "Grup Adı Yok";

                var result = await _modelService.AddAsync(modelAddDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var options = new JsonSerializerOptions
                    {
                        ReferenceHandler = ReferenceHandler.Preserve
                    };
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new ModelAddAjaxViewModel
                    {
                        ModelDto = result.Data,
                        ModelAddPartial = await this.RenderViewToStringAsync("_ModelAddPartial", modelAddDto)
                    }, options);
                    return Json(categoryAddAjaxModel);
                }
            }
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new ModelAddAjaxViewModel
            {
                ModelAddPartial = await this.RenderViewToStringAsync("_ModelAddPartial", modelAddDto)
            });
            return Json(categoryAddAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ModelUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int modelId, string tableType)
        {
            ViewBag.TableType = tableType;
            var result = await _modelService.GetModelUpdateDtoAsync(modelId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_ModelUpdatePartial", result.Data);
            }
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ModelUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(ModelUpdateDto modelUpdateDto, string tableType)
        {
            ViewBag.tableType = tableType;
            if (ModelState.IsValid)
            {
                var result = await _modelService.UpdateAsync(modelUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    int? groupId = modelUpdateDto.BrandId != null ? modelUpdateDto.BrandId : 0;
                    var groupTitle = _brandService.GetAsync(groupId.Value).Result.Data.Brand.Title;
                    groupTitle = groupTitle != null ? groupTitle : "Grup Adı Yok";

                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                        NotificationMessageTypes.Updated,
                        "Geliştiriciye Mesaj",
                        result.Data.Model.ModifiedByName),
                        NotificationMessageService.GetTitle(NotificationMessageTypes.Updated), userId: LoggedInUser.Id
                        );
                    var categoryUpdateAjaxModel = JsonSerializer.Serialize(new ModelUpdateAjaxViewModel
                    {
                        ModelDto = result.Data,
                        ModelUpdatePartial = await this.RenderViewToStringAsync("_ModelUpdatePartial", modelUpdateDto),
                        BrandTitle = groupTitle
                    }); ;
                    return Json(categoryUpdateAjaxModel);
                }
            }
            var categoryUpdateAjaxErrorModel = JsonSerializer.Serialize(new ModelUpdateAjaxViewModel
            {
                ModelUpdatePartial = await this.RenderViewToStringAsync("_ModelUpdatePartial", modelUpdateDto)
            });
            return Json(categoryUpdateAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ModelDelete}")]
        [HttpPost]
        public async Task<JsonResult> Delete(int modelId, string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _modelService.DeleteAsync(modelId, LoggedInUser.UserName);
                var deletedModel = JsonSerializer.Serialize(result.Data);
                return Json(deletedModel);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _modelService.HardDeleteAsync(modelId);
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
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.DefaultUser}, {AuthorizeDefinitionConstants.ModelDelete}")]
        public async Task<JsonResult> UndoDelete(int modelId)
        {
            var result = await _modelService.UndoDeleteAsync(modelId, LoggedInUser.UserName);
            var undoDeletedModel = JsonSerializer.Serialize(result.Data);
            return Json(undoDeletedModel);
        }
    }
}