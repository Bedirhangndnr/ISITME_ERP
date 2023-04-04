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
using MyBlog.Entities.Dtos.ProductDtos;
using MyBlog.Entities.Dtos.ArticleDtos;
using MyBlog.Services.Utilities;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Mvc.Consts;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Editor")]

    public class ProductController : BaseController
    {
        private readonly IProductService _productService;
        private readonly IProductSubGroupService _productSubGroupService;
        private readonly IBrandService _brandService;
        private readonly IToastNotification _toastNotification;

        public ProductController(IProductService productService,
            IProductSubGroupService productSubGroupService,
        IBrandService brandService,
        IProductSubGroupService ProductSubGroupService,
        UserManager<User> userManager, IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _productSubGroupService = ProductSubGroupService;
            _productService = productService;
            _brandService = brandService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductRead}")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _productService.GetAllByNonDeletedAndActiveAsync();
            if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductRead}")]
        [HttpGet]
        public async Task<JsonResult> GetAllProducts()
        {
            var Products = await _productService.GetAllByNonDeletedAndActiveAsync();
            var ProductResult = JsonSerializer.Serialize(Products, new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            });
            return Json(ProductResult);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductCreate}")]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var productSubGroupList = await _productSubGroupService.GetAllByNonDeletedAndActiveAsync();
            var brandList = await _brandService.GetAllByNonDeletedAndActiveAsync();
            var productList = await _productService.GetAllByNonDeletedAndActiveAsync();
            if ((productSubGroupList.ResultStatus == ResultStatus.Success &&
                brandList.ResultStatus == ResultStatus.Success &&
                productList.ResultStatus == ResultStatus.Success))
            {
                return View(new ProductAddViewModel
                {
                    Brands = brandList.Data.Brands,
                    ProductSubGroups = productSubGroupList.Data.ProductSubGroups
                });
            }
            return NotFound();
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductCreate }")]
        [HttpPost]
        public async Task<IActionResult> Add(ProductAddViewModel productAddViewModel)
        {
            if (ModelState.IsValid)
            {
                var productSubGroupAddDto = Mapper.Map<ProductAddDto>(productAddViewModel);
                var result = await _productService.AddAsync(productSubGroupAddDto, LoggedInUser.UserName, LoggedInUser.Id);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    _toastNotification.AddSuccessToastMessage(result.Message, new ToastrOptions
                    {
                        Title = "Başarılı İşlem!"
                    });
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                }
            }

            var productSubGroupList = await _productSubGroupService.GetAllByNonDeletedAndActiveAsync();
            var brandList = await _brandService.GetAllByNonDeletedAndActiveAsync();
            var productList = await _productService.GetAllByNonDeletedAndActiveAsync();
            productAddViewModel.Brands = brandList.Data.Brands;
            productAddViewModel.ProductSubGroups = productSubGroupList.Data.ProductSubGroups;
            return View(productAddViewModel);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductUpdate }")]
        [HttpGet]
        public async Task<IActionResult> Update(int productId)
        {
            var productList = await _productService.GetProductUpdateDtoAsync(productId);
            var productSubGroupList = await _productSubGroupService.GetAllByNonDeletedAndActiveAsync();
            var brandList = await _brandService.GetAllByNonDeletedAndActiveAsync();

            var productSubGroupResult = await _productSubGroupService.GetAllByNonDeletedAndActiveAsync();
            if (productSubGroupList.ResultStatus == ResultStatus.Success &&
               productList.ResultStatus == ResultStatus.Success &&
               brandList.ResultStatus == ResultStatus.Success)
            {
                var ProductUpdateViewModel = Mapper.Map<ProductUpdateViewModel>(productList.Data);
                ProductUpdateViewModel.Brands = brandList.Data.Brands;
                ProductUpdateViewModel.ProductSubGroups = productSubGroupList.Data.ProductSubGroups;
                return View(ProductUpdateViewModel);
            }
            else
            {
                return NotFound();
            }
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ProductUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(ProductUpdateViewModel ProductUpdateViewModel)
        {
            if (ModelState.IsValid)
            {
                var ProductUpdateDto = Mapper.Map<ProductUpdateDto>(ProductUpdateViewModel);

                var result = await _productService.UpdateAsync(ProductUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    _toastNotification.AddErrorToastMessage(ProductUpdateDto.Message, new ToastrOptions
                    {
                        Title = "Başarısız İşlem!"
                    });
                    ModelState.AddModelError("", result.Message);
                }
            }
            var productSubGroupList = await _productSubGroupService.GetAllByNonDeletedAndActiveAsync();
            var brandList = await _brandService.GetAllByNonDeletedAndActiveAsync();
            var productList = await _productService.GetAllByNonDeletedAndActiveAsync();
            ProductUpdateViewModel.Brands = brandList.Data.Brands;
            ProductUpdateViewModel.ProductSubGroups = productSubGroupList.Data.ProductSubGroups;
            return View(ProductUpdateViewModel);

        }
    }
}
