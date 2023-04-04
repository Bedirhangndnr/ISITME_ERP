using MyBlog.Services.Utilities;
using System;

namespace MyBlog.Mvc.Areas.Admin.Models.SingleModels
{
    public class UpdatePageButtonsModel
    {
        public int Id { get; set; }
        public string TableType { get; set; }
        public string InUpdate { get; set; } = "1";
    }
}
