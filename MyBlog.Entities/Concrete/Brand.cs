using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class Brand : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Model> Models{ get; set; }
    }
}
