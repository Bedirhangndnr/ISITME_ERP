using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Entities.Dtos.EmployeeTypeDtos;

namespace MyBlog.Mvc.Areas.Admin.Models
{
    public class EmployeeTypeUpdateAjaxViewModel
    {
        public EmployeeTypeUpdateDto EmployeeTypeUpdateDto { get; set; }
        public string EmployeeTypeUpdatePartial { get; set; }
        public EmployeeTypeDto EmployeeTypeDto { get; set; }
    }
}
