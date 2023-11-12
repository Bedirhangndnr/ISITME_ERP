using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class SubModel : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public Model Model { get; set; }
        public int ModelId{ get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
