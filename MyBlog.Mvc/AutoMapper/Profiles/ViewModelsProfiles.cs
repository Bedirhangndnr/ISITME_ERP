using AutoMapper;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ArticleDtos;
using MyBlog.Entities.Dtos.CategoryDtos;
using MyBlog.Entities.Dtos.CustomerDtos;
using MyBlog.Entities.Dtos.EmployeeDtos;
using MyBlog.Entities.Dtos.SaleDtos;
using MyBlog.Entities.Dtos.NotificationDtos;
using MyBlog.Mvc.Areas.Admin.Models;
using MyBlog.Shared.Entities.Concrete;
using MyBlog.Entities.Dtos.ProductDtos;
using MyBlog.Entities.Dtos.AppointmentDtos;
using MyBlog.Mvc.Areas.Admin.Models.ArticleModels;
using MyBlog.Mvc.Areas.Admin.Models.CustomerModels;
using MyBlog.Mvc.Areas.Admin.Models.SingleModels;

namespace MyBlog.Mvc.AutoMapper.Profiles
{
    public class ViewModelsProfile : Profile
    {
        public ViewModelsProfile()
        {
            CreateMap<ArticleAddViewModel, ArticleAddDto>();
            CreateMap<ArticleUpdateViewModel, ArticleUpdateDto>().ReverseMap();
            CreateMap<CustomerAddViewModel, CustomerAddDto>().ReverseMap();
            CreateMap<CustomerUpdateDto, CustomerUpdateViewModel>().ReverseMap();
            CreateMap<EmployeeAddViewModel, EmployeeAddDto>().ReverseMap();
            CreateMap<EmployeeUpdateDto, EmployeeUpdateViewModel>().ReverseMap();
            CreateMap<SaleAddViewModel, SaleAddDto>().ReverseMap();
            CreateMap<SaleUpdateDto, SaleUpdateViewModel>().ReverseMap();
            CreateMap<ProductAddViewModel, ProductAddDto>().ReverseMap();
            CreateMap<ProductUpdateDto, ProductUpdateViewModel>().ReverseMap(); 
            CreateMap<AppointmentAddViewModel, AppointmentAddDto>().ReverseMap();
            CreateMap<AppointmentUpdateDto, AppointmentUpdateViewModel>().ReverseMap();
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<NotificationListDto, NotificationViewModel>();
        }
    }
}
