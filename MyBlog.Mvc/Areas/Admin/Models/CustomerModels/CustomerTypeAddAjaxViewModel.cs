using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.CategoryDtos;
using MyBlog.Entities.Dtos.CustomerTypeDtos;
using MyBlog.Shared.Entities.Concrete;

namespace MyBlog.Mvc.Areas.Admin.Models.CustomerModels
{
    public class CustomerTypeAddAjaxViewModel
    {
        public CustomerTypeAddDto CustomerTypeAddDto { get; set; }
        //ajax ile post işlemi yaptığımızda dönecek model.
        public string CustomerTypeAddPartial { get; set; }
        public CustomerTypeDto CustomerTypeDto { get; set; }
    }
}
