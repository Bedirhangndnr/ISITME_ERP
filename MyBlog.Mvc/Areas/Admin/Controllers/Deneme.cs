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
using MyBlog.Entities.Dtos.CustomerDtos;
using MyBlog.Entities.Dtos.EmployeeDtos;
using MyBlog.Entities.Dtos.ArticleDtos;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    

    public class CustomerReferanceTitle : BaseController
    {
        private readonly ICustomerService _customerService;
        private readonly ICustomerReferanceService _customerReferanceService;
        private readonly IEmployeeService _employeeService;
        private readonly IEmployeeTypeService _employeeTypeService;
        private readonly ICustomerTypeService _customerTypeService;
        private readonly IPaymentService _paymentService;
        private readonly IPaymentTypeService _paymentTypeService;
        private readonly IToastNotification _toastNotification;

        public CustomerReferanceTitle(ICustomerService customerService,
            ICustomerReferanceService customerReferanceService,
            IPaymentService paymentService,
            IPaymentTypeService paymentTypeService,
            IEmployeeService employeeService,
            IEmployeeTypeService employeeTypeService,
            ICustomerTypeService customerTypeService, UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _paymentService = paymentService;
            _paymentTypeService = paymentTypeService;
            _customerService = customerService;
            _customerReferanceService = customerReferanceService;
            _customerTypeService = customerTypeService;
            _employeeService = employeeService;
            _employeeTypeService = employeeTypeService;

            _toastNotification = toastNotification;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _employeeService.GetAllAsync();
            if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            return NotFound();
        }

    }
}
