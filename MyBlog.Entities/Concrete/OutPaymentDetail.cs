using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class OutPaymentDetail : EntityBase, IEntity
    {
        public decimal AmountPaid { get; set; }
        public string Description { get; set; }
        // Foreign key property for linking with OutPayment
        public int OutPaymentId { get; set; }
        public OutPayment OutPayment { get; set; }

        // Foreign key property for linking with Employee
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
