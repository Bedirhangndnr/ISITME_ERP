﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;

namespace MyBlog.Entities.Dtos.ExpenseDtos
{
    public class ExpenseDto : DtoGetBase
    {
        public Expense Expense { get; set; }
    }
}
