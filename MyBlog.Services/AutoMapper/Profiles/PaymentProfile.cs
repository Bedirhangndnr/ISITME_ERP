using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.PaymentDtos;

namespace MyBlog.Services.AutoMapper.Profiles
{
    public class PaymentProfile:Profile
    {
        public PaymentProfile()
        {
            CreateMap<PaymentAddDto, Payment>();
            CreateMap<PaymentUpdateDto, Payment>();
            CreateMap<Payment, PaymentUpdateDto>();
        }
    }
}
