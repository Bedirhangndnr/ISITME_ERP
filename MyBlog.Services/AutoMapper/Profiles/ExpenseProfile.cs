using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ExpenseDtos;

namespace MyBlog.Services.AutoMapper.Profiles
{
    public class ExpenseProfile:Profile
    {
        public ExpenseProfile()
        {
            CreateMap<ExpenseAddDto, Expense>().ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(x => DateTime.Now))
                .ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now));
            CreateMap<ExpenseUpdateDto, Expense>().ReverseMap().ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now)); ;
            CreateMap<Expense, ExpenseUpdateDto>().ReverseMap().ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(x => DateTime.Now)); ;
        
        }
    }
}
