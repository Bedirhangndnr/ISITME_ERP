using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class OutPayment: EntityBase, IEntity
    {
        public decimal DebtAmount { get; set; }
        public decimal AmountPaid { get; set; } = 0;
        public string? Description { get; set; }
        public bool IsPaid { get; set; }
        public string PaidPlace { get; set; }
        public DateTime DueDate { get; set; }
        public List<OutPaymentDetail> PaymentDetails { get; set; }
    }
}
