using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class CustomerReferanceTitle : EntityBase, IEntity
    {
        public string Title { get; set; }
        public ICollection<CustomerReferance> CustomersReferances { get; set; }
    }
}
