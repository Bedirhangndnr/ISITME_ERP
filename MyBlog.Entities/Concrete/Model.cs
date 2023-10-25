using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class Model : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public Brand Brand { get; set; }
        public int BrandId{ get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
