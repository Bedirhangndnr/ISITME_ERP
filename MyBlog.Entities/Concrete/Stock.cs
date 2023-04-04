using MyBlog.Shared.Entities.Abstract;
using MyBlog.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class Stock : EntityBase, IEntity
    {
        public int? ProductId { get; set; }
        public Product? Product{ get; set; }
        public int Quantity { get; set; } // Kalan
        public int Description { get; set; } // Kalan

    }
}
