using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.ProductSubGroupDtos
{
    public class ProductSubGroupListWithRelatedTable : DtoGetBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? GroupId { get; set; }
        public string? GroupTitle { get; set; }
        public string Description { get; set; }

    }
}
