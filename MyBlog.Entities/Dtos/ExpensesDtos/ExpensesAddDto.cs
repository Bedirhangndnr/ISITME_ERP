using Microsoft.AspNetCore.Http;
using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using MyBlog.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.ExpenseDtos
{
    public class ExpenseAddDto:DtoGetBase
    {
        public string? Note { get; set; } = "";

        [DisplayName("Tutar")]
        public int Amount { get; set; }
        [DisplayName("Günlük Mü?")]
        public bool IsDaily { get; set; }
        [DisplayName("Gelir Mi?")]
        public bool IsIncome { get; set; } = false;

    }
}
