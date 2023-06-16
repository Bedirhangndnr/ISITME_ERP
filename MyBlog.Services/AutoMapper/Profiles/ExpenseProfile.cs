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
            CreateMap<ExpenseAddDto, Expense>();
            CreateMap<ExpenseUpdateDto, Expense>().ReverseMap();
        
        }
    }
}
