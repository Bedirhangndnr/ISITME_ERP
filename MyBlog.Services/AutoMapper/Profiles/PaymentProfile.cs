using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;

namespace MyBlog.Services.AutoMapper.Profiles
{
    public class PaymentTypeProfile:Profile
    {
        public PaymentTypeProfile()
        {
            //CreateMap<CustomerAddDto, Customer>()
            //    .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now))
            //    .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now))
            //    .ForMember(dest => dest.ModifiedByName, opt => opt.MapFrom(x => x.CreatedByName))
            //    .ForMember(dest=>dest.IsActive,opt=>opt.MapFrom(x=>false)); // dto dan Customere aktarılırken ısactive değeri default olarak false atandı.
            //CreateMap<CustomerUpdateDto, Customer>()
            //    .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
            //CreateMap<Customer, CustomerUpdateDto>();

        }
    }
}
