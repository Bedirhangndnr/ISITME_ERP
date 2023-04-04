using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.CategoryDtos;
using MyBlog.Entities.Dtos.AppointmentTypeDtos;
using MyBlog.Shared.Entities.Concrete;

namespace MyBlog.Mvc.Areas.Admin.Models
{
    public class AppointmentTypeAddAjaxViewModel
    {
        public AppointmentTypeAddDto AppointmentTypeAddDto { get; set; }
        //ajax ile post işlemi yaptığımızda dönecek model.
        public string AppointmentTypeAddPartial { get; set; }
        public AppointmentTypeDto AppointmentTypeDto { get; set; }
    }
}
