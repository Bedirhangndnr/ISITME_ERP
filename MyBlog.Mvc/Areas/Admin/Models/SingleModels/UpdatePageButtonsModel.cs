using MyBlog.Services.Utilities;
using System;

namespace MyBlog.Mvc.Areas.Admin.Models.SingleModels
{
    public class UpdatePageButtonsModel
    {
        public int Id { get; set; }
        public int InMainPage { get; set; } = 0;
        public string TableType { get; set; }
        public int InUpdate { get; set; } = 0;
        public string Controller { get; set; } = "";
        public string Action { get; set; } = "";
    }
}
