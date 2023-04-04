using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;
using MyBlog.Entities.Dtos.ProductSubGroupDtos;

namespace MyBlog.Services.AutoMapper.Profiles
{
    public class ProductSubGroupProfile:Profile
    {
        public ProductSubGroupProfile()
        {
            CreateMap<ProductSubGroupAddDto, ProductSubGroup>()
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
            //    .ForMember(dest => dest.ModifiedByName, opt => opt.MapFrom(x => x.CreatedByName))
            //    .ForMember(dest=>dest.IsActive,opt=>opt.MapFrom(x=>false)); // dto dan Customere aktarılırken ısactive değeri default olarak false atandı.
            CreateMap<ProductSubGroupUpdateDto, ProductSubGroup>() 
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<ProductSubGroup, ProductSubGroupUpdateDto>();

        }
    }
}
