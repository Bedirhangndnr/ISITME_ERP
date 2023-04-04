using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.SaleDtos;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.ProductDtos
{
    public class ProductListDto:DtoGetBase
    {
        public IList<Product> Products{ get; set; }
        public IList<ProductListWithRelatedTables> ProductListWithRelatedTables { get; set; } = null;

    }
}
