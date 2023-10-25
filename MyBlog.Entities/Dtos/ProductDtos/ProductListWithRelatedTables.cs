using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.ProductDtos
{
    public class ProductListWithRelatedTables: DtoGetBase
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int ProductSubGroupId { get; set; }
        public bool IsSold { get; set; }

        public string ProductSubGroupTitle { get; set; }
        public int ProductCategoryId { get; set; }
        public string ProductCategoryTitle { get; set; }
        public string ProductName { get; set; }
        public string SerialNumber { get; set; }
        public int ModelId { get; set; }
        public string ModelTitle { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; }
    }
}
