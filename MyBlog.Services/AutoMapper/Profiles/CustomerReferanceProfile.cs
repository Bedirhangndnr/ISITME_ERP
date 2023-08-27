using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;
using MyBlog.Entities.Dtos.CustomerReferanceDtos;
using MyBlog.Services.Abstract;

namespace MyBlog.Services.AutoMapper.Profiles
{
    public class CustomerReferanceProfile : Profile
    {
        public CustomerReferanceProfile()
        {
            CreateMap<CustomerReferanceAddDto, CustomerReferance>()
                .ForMember(dest => dest.CreatedDate, opt
                => opt.MapFrom(x => DateTime.Now))
                .ForMember(dest => dest.CreatedDate, opt
                    => opt.MapFrom(x => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt
                    => opt.MapFrom(x => DateTime.Now))
                .ForMember(dest => dest.CustomerReferanceTitleId, opt
                    => opt.MapFrom(x => 1));
            CreateMap<CustomerReferanceUpdateDto, CustomerReferance>()
                .ForMember(dest => dest.ModifiedDate, opt
                    => opt.MapFrom(x => DateTime.Now));
            CreateMap<CustomerReferance, CustomerReferanceUpdateDto>();

        }
    }
}
