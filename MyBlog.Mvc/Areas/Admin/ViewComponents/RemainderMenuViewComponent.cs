using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.CustomerDtos;
using MyBlog.Mvc.Areas.Admin.Models;
using MyBlog.Mvc.Areas.Admin.Models.SingleModels;
using MyBlog.Services.Abstract;

namespace MyBlog.Mvc.Areas.Remainder.ViewComponents
{
    public class RemainderMenuViewComponent : ViewComponent
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;


        public RemainderMenuViewComponent(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var customers = await _customerService.GetAllForRemainds();
            return View(new RemaindsViewModel
            {
                Customers= customers.Data.Customers
            });
        }
    }
}
