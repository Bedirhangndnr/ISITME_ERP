using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.EmployeeDtos;

namespace MyBlog.Services.AutoMapper.Profiles
{
    public class EmployeeProfile:Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeAddDto, Employee>();
            CreateMap<EmployeeUpdateDto, Employee>().ReverseMap();
            //CreateMap<EmployeeAddDto, Employee>()
            //    .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now))
            //    .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now))
            //    .ForMember(dest => dest.ModifiedByName, opt => opt.MapFrom(x => x.CreatedByName))
            //    .ForMember(dest=>dest.IsActive,opt=>opt.MapFrom(x=>false)); // dto dan Employeee aktarılırken ısactive değeri default olarak false atandı.
            //CreateMap<EmployeeUpdateDto, Employee>()
            //    .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
            //CreateMap<Employee, EmployeeUpdateDto>();

        }
    }
}
