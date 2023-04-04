using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class PaymentType:EntityBase, IEntity
    {
        public ICollection<Payment> Payments{ get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
