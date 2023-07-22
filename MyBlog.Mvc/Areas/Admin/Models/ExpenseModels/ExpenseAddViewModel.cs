using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Concrete;

namespace MyBlog.Mvc.Areas.Admin.Models
{
    public class ExpenseAddViewModel
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
