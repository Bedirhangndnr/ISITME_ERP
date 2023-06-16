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
        public int AmountPaid { get; set; } = 0;// defaullt olarak tl olarak yazılacak
        public string? Description { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId{ get; set; }        
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public int? AssociatedInstitutionsId { get; set; }
        public AssociatedInstitution AssociatedInstitutions { get; set; }
        public int? PaymentTypeId { get; set; }
        public PaymentType PaymentType { get; set; }

        // finans nazılı ve bilaale açık,
        // finans kısmı kulanıcılara açık 


    }
}
