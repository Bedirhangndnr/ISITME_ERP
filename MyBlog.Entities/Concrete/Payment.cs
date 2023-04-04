using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class Payment: EntityBase, IEntity
    {
        public PaymentType? PaymentType { get; set; }
        public int? PaymentTypeId { get; set; }
        public int AmountPaid { get; set; } // defaullt olarak tl olarak yazılacak
        public string? Description { get; set; }
        public Customer? Customer { get; set; }
        public int? CustomerId{ get; set; }        
        public Employee? Employee { get; set; }
        public int? EmployeeId { get; set; }

        // finans nazılı ve bilaale açık,
        // finans kısmı kulanıcılara açık 


    }
}
