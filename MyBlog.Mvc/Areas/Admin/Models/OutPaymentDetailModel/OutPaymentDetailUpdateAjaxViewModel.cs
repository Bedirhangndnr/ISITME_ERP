using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.CategoryDtos;
using MyBlog.Entities.Dtos.OutPaymentDetailDtos;
using MyBlog.Shared.Entities.Concrete;

namespace MyBlog.Mvc.Areas.Admin.Models
{
    public class OutPaymentDetailUpdateAjaxViewModel
    {
        public OutPaymentDetailUpdateDto OutPaymentDetailUpdateDto { get; set; }
        //ajax ile post işlemi yaptığımızda dönecek model.
        public string OutPaymentDetailUpdatePartial { get; set; }
        public OutPaymentDetailDto OutPaymentDetailDto { get; set; }
    }
}
