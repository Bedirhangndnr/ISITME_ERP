using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;

namespace MyBlog.Mvc.Areas.Admin.Models
{
    public class EmployeeTypeAddAjaxViewModel
    {
        public EmployeeTypeAddDto EmployeeTypeAddDto { get; set; }
        public string EmployeeTypeAddPartial { get; set; }
        public EmployeeTypeDto EmployeeTypeDto { get; set; }
    }
}
