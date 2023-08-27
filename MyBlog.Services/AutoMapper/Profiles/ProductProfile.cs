using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ProductDtos;

namespace MyBlog.Services.AutoMapper.Profiles
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            //CreateMap<ProductAddDto, Product>();
            CreateMap<Product, ProductUpdateDto>();
            CreateMap<ProductAddDto, Product>()
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now))
                .ForMember(dest => dest.ModifiedByName, opt => opt.MapFrom(x => x.CreatedByName))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(x => true)); // dto dan Producte aktarılırken ısactive değeri default olarak false atandı.
            CreateMap<ProductUpdateDto, Product>()
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<Product, ProductUpdateDto>();

        }
    }
}
