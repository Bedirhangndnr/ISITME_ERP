using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.OutPaymentDtos;

namespace MyBlog.Services.AutoMapper.Profiles
{
    public class OutPaymentProfile:Profile
    {
        public OutPaymentProfile()
        {
            CreateMap<OutPaymentAddDto, OutPayment>();
            CreateMap<OutPaymentUpdateDto, OutPayment>();
            CreateMap<OutPayment, OutPaymentUpdateDto>();
        }
    }
}
