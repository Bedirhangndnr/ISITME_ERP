using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.SaleDtos;

namespace MyBlog.Services.AutoMapper.Profiles
{
    public class SaleProfile:Profile
    {
        public SaleProfile()
        {
            CreateMap<Sale, SaleUpdateDto>().ReverseMap();
            CreateMap<SaleAddDto, Sale>()
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now))
                .ForMember(dest => dest.ModifiedByName, opt => opt.MapFrom(x => x.CreatedByName))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(x => false)); // dto dan Salee aktarılırken ısactive değeri default olarak false atandı.
            CreateMap<SaleUpdateDto, Sale>()
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<Sale, SaleUpdateDto>();

        }
    }
}
