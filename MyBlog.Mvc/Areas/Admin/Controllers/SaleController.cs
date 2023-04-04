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
using MyBlog.Entities.Dtos.SaleDtos;
using MyBlog.Entities.Dtos.ArticleDtos;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Shared.Utilities.Results.Concrete;
using MyBlog.Mvc.Consts;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Editor")]

    public class SaleController : BaseController
    {
        private readonly ISaleService _saleService;
        private readonly ISaleTypeService _saleTypeService;
        private readonly ISaleStatusService _saleStatusService;
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;
        private readonly IEmployeeService _employeeService;
        private readonly IToastNotification _toastNotification;

        public SaleController(ISaleService saleService,
            ISaleTypeService saleTypeService,
        ISaleStatusService saleStatusService,
        IProductService productService,
        ICustomerService customerService,
        IEmployeeService employeeService,
        ISaleTypeService SaleTypeService, UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _saleService = saleService;
            _saleTypeService = SaleTypeService;
            _saleStatusService = saleStatusService;
            _productService = productService;
            _customerService = customerService;
            _employeeService = employeeService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.SaleRead}")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _saleService.GetAllByNonDeletedAndActiveAsync();
            if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.SaleRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllSales()
        {
            var Sales = await _saleService.GetAllByNonDeletedAndActiveAsync();
            var SaleResult = JsonSerializer.Serialize(Sales, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(SaleResult);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.SaleCreate}")]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var saleTypeList = await _saleTypeService.GetAllByNonDeletedAndActiveAsync();
            var saleStatusList = await _saleStatusService.GetAllByNonDeletedAndActiveAsync();
            var customerList = await _customerService.GetAllByNonDeletedAndActiveAsync();
            var productList = await _productService.GetAllByNonDeletedAndActiveAsync();
            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            if ((saleTypeList.ResultStatus == ResultStatus.Success &&
                saleStatusList.ResultStatus == ResultStatus.Success &&
                customerList.ResultStatus == ResultStatus.Success &&
                productList.ResultStatus == ResultStatus.Success &&
                employeeList.ResultStatus == ResultStatus.Success))
            {
                return View(new SaleAddViewModel
                {
                    Customers = customerList.Data.Customers,
                    Employees = employeeList.Data.Employees,
                    Products = productList.Data.Products,
                    SaleStatuses = saleStatusList.Data.SaleStatuses,
                    SaleTypes = saleTypeList.Data.SaleTypes
                });
            }
            else
            {
                _toastNotification.AddErrorToastMessage(employeeList.Message, new ToastrOptions
                {
                    Title = "İşlem Başarısız." 
                });
            }
            return NotFound();
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.SaleCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(SaleAddViewModel saleAddViewModel)
        {
            if (ModelState.IsValid)
            {
                var saleTypeAddDto = Mapper.Map<SaleAddDto>(saleAddViewModel);
                var result = await _saleService.AddAsync(saleTypeAddDto, LoggedInUser.UserName, LoggedInUser.Id);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem!"
                    });
                    return RedirectToAction("Index", "Sale");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                }
            }

            var saleTypeList = await _saleTypeService.GetAllByNonDeletedAndActiveAsync();
            var saleStatusList = await _saleStatusService.GetAllByNonDeletedAndActiveAsync();
            var customerList = await _customerService.GetAllByNonDeletedAndActiveAsync();
            var productList = await _productService.GetAllByNonDeletedAndActiveAsync();
            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            saleAddViewModel.Customers = customerList.Data.Customers;
            saleAddViewModel.Employees = employeeList.Data.Employees;
            saleAddViewModel.Products = productList.Data.Products;
            saleAddViewModel.SaleStatuses = saleStatusList.Data.SaleStatuses;
            saleAddViewModel.SaleTypes = saleTypeList.Data.SaleTypes;
            return View(saleAddViewModel);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.SaleUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int saleId)
        {
            var saleList = await _saleService.GetSaleUpdateDtoAsync(saleId);
            var saleTypeList = await _saleTypeService.GetAllByNonDeletedAndActiveAsync();
            var saleStatusList = await _saleStatusService.GetAllByNonDeletedAndActiveAsync();
            var customerList = await _customerService.GetAllByNonDeletedAndActiveAsync();
            var productList = await _productService.GetAllByNonDeletedAndActiveAsync();
            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();

            var saleTypeResult = await _saleTypeService.GetAllByNonDeletedAndActiveAsync();
            if ((saleTypeList.ResultStatus == ResultStatus.Success &&
               saleStatusList.ResultStatus == ResultStatus.Success &&
               saleList.ResultStatus == ResultStatus.Success &&
               customerList.ResultStatus == ResultStatus.Success &&
               productList.ResultStatus == ResultStatus.Success &&
               employeeList.ResultStatus == ResultStatus.Success))
            {
                var SaleUpdateViewModel = Mapper.Map<SaleUpdateViewModel>(saleList.Data);
                SaleUpdateViewModel.Customers = customerList.Data.Customers;
                SaleUpdateViewModel.Employees = employeeList.Data.Employees;
                SaleUpdateViewModel.Products = productList.Data.Products;
                SaleUpdateViewModel.SaleStatuses = saleStatusList.Data.SaleStatuses;
                SaleUpdateViewModel.SaleTypes = saleTypeList.Data.SaleTypes;
                return View(SaleUpdateViewModel);
            }
            else
            {
                return NotFound();
            }
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.SaleUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(SaleUpdateViewModel SaleUpdateViewModel)
        {
            if (ModelState.IsValid)
            {

                var SaleUpdateDto = Mapper.Map<SaleUpdateDto>(SaleUpdateViewModel);

                var result = await _saleService.UpdateAsync(SaleUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return RedirectToAction("Index", "Sale");
                }
                else
                {
                    _toastNotification.AddErrorToastMessage(SaleUpdateDto.Message, new ToastrOptions
                    {
                        Title = "Başarısız İşlem!"
                    });
                    ModelState.AddModelError("", result.Message);
                }
            }
            var saleTypeList = await _saleTypeService.GetAllByNonDeletedAndActiveAsync();
            var saleStatusList = await _saleStatusService.GetAllByNonDeletedAndActiveAsync();
            var customerList = await _customerService.GetAllByNonDeletedAndActiveAsync();
            var productList = await _productService.GetAllByNonDeletedAndActiveAsync();
            var employeeList = await _employeeService.GetAllByNonDeletedAndActiveAsync();
            SaleUpdateViewModel.Customers = customerList.Data.Customers;
            SaleUpdateViewModel.Employees = employeeList.Data.Employees;
            SaleUpdateViewModel.Products = productList.Data.Products;
            SaleUpdateViewModel.SaleStatuses = saleStatusList.Data.SaleStatuses;
            SaleUpdateViewModel.SaleTypes = saleTypeList.Data.SaleTypes;
            return View(SaleUpdateViewModel);

        }
    }
}
