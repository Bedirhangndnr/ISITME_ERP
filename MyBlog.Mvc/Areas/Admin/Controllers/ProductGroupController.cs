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
using MyBlog.Entities.Dtos.ProductGroupDtos;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Entities.Dtos.ProductGroupDtos;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Mvc.Consts;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Editor")]

    public class ProductGroupController : BaseController
    {
        private readonly IProductGroupService _productGroupService;
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;


        public ProductGroupController(
            INotificationService notificationService,
            IProductGroupService productGroupService,
            UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _notificationService = notificationService;
            _productGroupService = productGroupService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductGroupRead}")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _productGroupService.GetAllAsync();
            if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductGroupRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllProductGroups()
        {
            var productGroups = await _productGroupService.GetAllAsync();
            var productGroupResult = JsonSerializer.Serialize(productGroups, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(productGroupResult);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductGroupCreate}")]
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_ProductGroupAddPartial");
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductGroupCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(ProductGroupAddDto productGroupAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _productGroupService.AddAsync(productGroupAddDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new ProductGroupAddAjaxViewModel
                    {
                        ProductGroupDto = result.Data,
                        ProductGroupAddPartial = await this.RenderViewToStringAsync("_ProductGroupAddPartial", productGroupAddDto)
                    });
                    return Json(categoryAddAjaxModel);
                }
            }
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new ProductGroupAddAjaxViewModel
            {
                ProductGroupAddPartial = await this.RenderViewToStringAsync("_ProductGroupAddPartial", productGroupAddDto)
            });
            return Json(categoryAddAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductGroupUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int productGroupId)
        {
            var result = await _productGroupService.GetProductGroupUpdateDtoAsync(productGroupId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_ProductGroupUpdatePartial", result.Data);
            }
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductGroupUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(ProductGroupUpdateDto categoryUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _productGroupService.UpdateAsync(categoryUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                        NotificationMessageTypes.Updated, 
                        "Marka", 
                        result.Data.ProductGroup.ModifiedByName),
                        NotificationMessageService.GetTitle(NotificationMessageTypes.Updated)
                        );
                    var categoryUpdateAjaxModel = JsonSerializer.Serialize(new ProductGroupUpdateAjaxViewModel
                    {
                        ProductGroupDto = result.Data,
                        ProductGroupUpdatePartial = await this.RenderViewToStringAsync("_ProductGroupUpdatePartial", categoryUpdateDto)
                    });
                    return Json(categoryUpdateAjaxModel);
                }
            }
            var categoryUpdateAjaxErrorModel = JsonSerializer.Serialize(new ProductGroupUpdateAjaxViewModel
            {
                ProductGroupUpdatePartial = await this.RenderViewToStringAsync("_ProductGroupUpdatePartial", categoryUpdateDto)
            });
            return Json(categoryUpdateAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductGroupDelete}")]
        [HttpPost]
        public async Task<JsonResult> Delete(int productGroupId)
        {
            var result = await _productGroupService.DeleteAsync(productGroupId, LoggedInUser.UserName);
            var deletedEmployeeType = JsonSerializer.Serialize(result.Data);
            return Json(deletedEmployeeType);
        }
    }
}