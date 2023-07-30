using MyBlog.Services.Utilities;
using System;

namespace MyBlog.Mvc.Areas.Admin.Models.SingleModels
{
    public class BreadCrumbsViewModel
    {
        
        public string Area { get; set; } 
        public string Controller { get; set; }
        public string ControllerTr { get; set; }
        public string Action { get; set; }
        public string ActionTR{ get; set; }
        public string TableType { get; set; }
        public int Depth{ get; set; }
        public int Id { get; set; }

    }
}
