using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class CustomerType : EntityBase, IEntity
    {
        public ICollection<Customer> Customers { get; set; }
        public string Title { get; set; }
    }
}
