using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MyBlog.Data.Concrete.EntityFramework.Context;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.CustomerDtos;
using MyBlog.Mvc.Areas.Admin.Models;
using MyBlog.Mvc.Halpers.Abstract;
using MyBlog.Services.Abstract;
using MyBlog.Shared.Entities.Concrete;
using System.Data;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    public class HomeController1 : BaseController
    {
        private readonly MyBlogContext _dbContext;
        private readonly ICategoryService _categoryService;

        public HomeController1(MyBlogContext dbContext, ICategoryService categoryService, UserManager<User> userManager, IMapper mapper, IImageHelper imageHelper) : base(userManager, mapper, imageHelper)
        {
            _categoryService = categoryService;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var category = Mapper.Map<Category>(_categoryService.GetAsync(1));
            //var auditLogs = _dbContext.ChangeTracker.Entries().Take(20);
            EntityEntry enrty = _dbContext.Entry(category);
            Console.WriteLine($"entity State: {enrty}");
            return View();
        }
    }
}
