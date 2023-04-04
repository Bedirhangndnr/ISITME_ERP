using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.ProductCategoryDtos
{
    public class ProductCategoryUpdateDto : ProductCategoryAddDto
    {
        [Required]
        public int Id { get; set; }
    }
}
