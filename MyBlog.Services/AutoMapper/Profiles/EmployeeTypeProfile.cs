using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;

namespace MyBlog.Services.AutoMapper.Profiles
{
    public class EmployeeTypeProfile:Profile
    {
        public EmployeeTypeProfile()
        {
            CreateMap<EmployeeTypeAddDto, EmployeeType>()
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
            //    .ForMember(dest => dest.ModifiedByName, opt => opt.MapFrom(x => x.CreatedByName))
            //    .ForMember(dest=>dest.IsActive,opt=>opt.MapFrom(x=>false)); // dto dan Employeee aktarılırken ısactive değeri default olarak false atandı.
            CreateMap<EmployeeTypeUpdateDto, EmployeeType>()
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<EmployeeType, EmployeeTypeUpdateDto>();

        }
    }
}
