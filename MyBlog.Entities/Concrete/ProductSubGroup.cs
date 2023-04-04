using MyBlog.Shared.Entities.Abstract;
using MyBlog.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class ProductSubGroup : EntityBase,IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ProductGroup? ProductGroup { get; set; }
        public int? ProductGroupId { get; set; }
        public ICollection<Product> Products { get; set; }


    }
}
