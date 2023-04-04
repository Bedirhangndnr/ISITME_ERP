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
using MyBlog.Entities.Dtos.ProductSubGroupDtos;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Entities.Dtos.ProductSubGroupDtos;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Mvc.Consts;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Editor")]

    public class ProductSubGroupController : BaseController
    {
        private readonly IProductSubGroupService _productSubGroupService;
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;


        public ProductSubGroupController(
            INotificationService notificationService,
            IProductSubGroupService productSubGroupService,
            UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _notificationService = notificationService;
            _productSubGroupService = productSubGroupService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductSubGroupRead}")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _productSubGroupService.GetAllAsync();
            if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductSubGroupCreate}")]
        [HttpGet]
        public async Task<JsonResult> GetAllProductSubGroups()
        {
            var productSubGroups = await _productSubGroupService.GetAllAsync();
            var productSubGroupResult = JsonSerializer.Serialize(productSubGroups, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(productSubGroupResult);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductSubGroupCreate}")]
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_ProductSubGroupAddPartial");
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductSubGroupCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(ProductSubGroupAddDto productSubGroupAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _productSubGroupService.AddAsync(productSubGroupAddDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new ProductSubGroupAddAjaxViewModel
                    {
                        ProductSubGroupDto = result.Data,
                        ProductSubGroupAddPartial = await this.RenderViewToStringAsync("_ProductSubGroupAddPartial", productSubGroupAddDto)
                    });
                    return Json(categoryAddAjaxModel);
                }
            }
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new ProductSubGroupAddAjaxViewModel
            {
                ProductSubGroupAddPartial = await this.RenderViewToStringAsync("_ProductSubGroupAddPartial", productSubGroupAddDto)
            });
            return Json(categoryAddAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductSubGroupUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int productSubGroupId)
        {
            var result = await _productSubGroupService.GetProductSubGroupUpdateDtoAsync(productSubGroupId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_ProductSubGroupUpdatePartial", result.Data);
            }
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductSubGroupUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(ProductSubGroupUpdateDto categoryUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _productSubGroupService.UpdateAsync(categoryUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                        NotificationMessageTypes.Updated,
                        "Marka",
                        result.Data.ProductSubGroup.ModifiedByName),
                        NotificationMessageService.GetTitle(NotificationMessageTypes.Updated)
                        );
                    var categoryUpdateAjaxModel = JsonSerializer.Serialize(new ProductSubGroupUpdateAjaxViewModel
                    {
                        ProductSubGroupDto = result.Data,
                        ProductSubGroupUpdatePartial = await this.RenderViewToStringAsync("_ProductSubGroupUpdatePartial", categoryUpdateDto)
                    });
                    return Json(categoryUpdateAjaxModel);
                }
            }
            var categoryUpdateAjaxErrorModel = JsonSerializer.Serialize(new ProductSubGroupUpdateAjaxViewModel
            {
                ProductSubGroupUpdatePartial = await this.RenderViewToStringAsync("_ProductSubGroupUpdatePartial", categoryUpdateDto)
            });
            return Json(categoryUpdateAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductSubGroupDelete}")]
        [HttpPost]
        public async Task<JsonResult> Delete(int productSubGroupId)
        {
            var result = await _productSubGroupService.DeleteAsync(productSubGroupId, LoggedInUser.UserName);
            var deletedEmployeeType = JsonSerializer.Serialize(result.Data);
            return Json(deletedEmployeeType);
        }
    }
}