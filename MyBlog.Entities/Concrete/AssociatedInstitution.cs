using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class AssociatedInstitution : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int PaymentTypeId { get; set; }
        public PaymentType PaymentType { get; set; }
        public ICollection<Payment> Payments { get; set; }

    }
}
