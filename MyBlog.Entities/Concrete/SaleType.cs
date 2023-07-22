using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class SaleType : EntityBase, IEntity
    {
        public string Title{ get; set; }
        public ICollection<Sale> Sales { get; set; }
        public string? Description { get; set; }
    }
}
