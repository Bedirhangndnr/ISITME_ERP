using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.CategoryDtos;
using MyBlog.Entities.Dtos.BrandDtos;
using MyBlog.Shared.Entities.Concrete;

namespace MyBlog.Mvc.Areas.Admin.Models
{
    public class BrandUpdateAjaxViewModel
    {
        public BrandUpdateDto BrandUpdateDto { get; set; }
        //ajax ile post işlemi yaptığımızda dönecek model.
        public string BrandUpdatePartial { get; set; }
        public BrandDto BrandDto { get; set; }
    }
}
