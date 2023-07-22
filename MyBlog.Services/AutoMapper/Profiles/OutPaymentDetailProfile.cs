using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;
using MyBlog.Entities.Dtos.OutPaymentDetailDtos;

namespace MyBlog.Services.AutoMapper.Profiles
{
    public class OutPaymentDetailProfile:Profile
    {
        public OutPaymentDetailProfile()
        {
            CreateMap<OutPaymentDetailAddDto, OutPaymentDetail>()
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<OutPaymentDetailUpdateDto, OutPaymentDetail>()
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<OutPaymentDetail, OutPaymentDetailUpdateDto>();

        }
    }
}
