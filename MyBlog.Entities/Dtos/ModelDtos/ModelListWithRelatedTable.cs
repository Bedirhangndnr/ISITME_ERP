using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.ModelDtos
{
    public class ModelListWithRelatedTable : DtoGetBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? BrandId { get; set; }
        public string? BrandTitle { get; set; }
        public string? Description { get; set; }

    }
}
