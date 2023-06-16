using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.AppointmentDtos;
using MyBlog.Entities.Dtos.PaymentDtos;

namespace MyBlog.Services.AutoMapper.Profiles
{
    public class AppointmentProfile:Profile
    {
        public AppointmentProfile()
        {
            CreateMap<AppointmentAddDto, Appointment>();
            CreateMap<AppointmentUpdateDto, Appointment>().ReverseMap();

            CreateMap<PaymentAddDto, Payment>();
            CreateMap<PaymentUpdateDto, Payment>();
            CreateMap<Payment, PaymentUpdateDto>();
            //CreateMap<AppointmentAddDto, Appointment>()
            //    .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now))
            //    .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now))
            //    .ForMember(dest => dest.ModifiedByName, opt => opt.MapFrom(x => x.CreatedByName))
            //    .ForMember(dest=>dest.IsActive,opt=>opt.MapFrom(x=>false)); // dto dan Appointmente aktarılırken ısactive değeri default olarak false atandı.
            //CreateMap<AppointmentUpdateDto, Appointment>()
            //    .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
            //CreateMap<Appointment, AppointmentUpdateDto>();

        }
    }
}
