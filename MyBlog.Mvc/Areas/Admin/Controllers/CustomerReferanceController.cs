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
using MyBlog.Entities.Dtos.CategoryDtos;
using MyBlog.Entities.Dtos.CustomerReferanceDtos;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Mvc.Areas.Admin.Models.CustomerModels;
using MyBlog.Mvc.Consts;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Editor")]

    public class CustomerReferanceController : BaseController
    {
        private readonly ICustomerReferanceService _customerReferanceService;
        private readonly ICategoryService _categoryService;
        private readonly IToastNotification _toastNotification;


        public CustomerReferanceController(ICustomerReferanceService customerReferanceService, ICategoryService categoryService, UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _customerReferanceService = customerReferanceService;
            _categoryService = categoryService;
            _toastNotification = toastNotification;
        }

                [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerReferenceRead}")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _customerReferanceService.GetAllAsync();
            if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            return NotFound();
        }
                [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerReferenceRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllCustomerReferances()
        {
            var customerReferances = await _customerReferanceService.GetAllAsync();
            var customerReferancesResult = JsonSerializer.Serialize(customerReferances, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(customerReferancesResult);
        }
                [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerReferenceCreate}")]
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_CustomerReferanceAddPartial");
        }
                [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerReferenceCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(CustomerReferanceAddDto customerReferanceAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _customerReferanceService.AddAsync(customerReferanceAddDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new CustomerReferanceAddAjaxViewModel
                    {
                        CustomerReferanceDto = result.Data,
                        CustomerReferanceAddPartial = await this.RenderViewToStringAsync("_CustomerReferanceAddPartial", customerReferanceAddDto)
                    });
                    return Json(categoryAddAjaxModel);
                }
            }
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new CustomerReferanceAddAjaxViewModel
            {
                CustomerReferanceAddPartial = await this.RenderViewToStringAsync("_CustomerReferanceAddPartial", customerReferanceAddDto)
            });
            return Json(categoryAddAjaxErrorModel);

        }
                [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerReferenceUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int customerReferanceId)
        {
            var result = await _customerReferanceService.GetCustomerReferanceUpdateDtoAsync(customerReferanceId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_CustomerReferanceUpdatePartial", result.Data);
            }
            return NotFound();
        }
                [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.CustomerReferenceUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(CustomerReferanceUpdateDto customerReferanceUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _customerReferanceService.UpdateAsync(customerReferanceUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var customerReferanceUpdateAjaxModel = JsonSerializer.Serialize(new CustomerReferanceUpdateAjaxViewModel
                    {
                        CustomerReferanceDto = result.Data,
                        CustomerReferanceUpdatePartial = await this.RenderViewToStringAsync("_CustomerReferanceUpdatePartial", customerReferanceUpdateDto)
                    });
                    return Json(customerReferanceUpdateAjaxModel);
                }
            }
            var customerReferanceUpdateAjaxErrorModel = JsonSerializer.Serialize(new CustomerReferanceUpdateAjaxViewModel
            {
                CustomerReferanceUpdatePartial = await this.RenderViewToStringAsync("_CustomerReferanceUpdatePartial", customerReferanceUpdateDto)
            });
            return Json(customerReferanceUpdateAjaxErrorModel);

            }
        }
}