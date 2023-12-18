using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class Sale : EntityBase, IEntity
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public int AmountOfSgk { get; set; }
        public bool IsInvoiceDue { get; set; }
        public int IsProduct { get; set; }
        public Customer? Customer { get; set; }
        public int? CustomerId { get; set; }
        public SaleType? SaleType { get; set; }
        public int? SaleTypeId { get; set; }
        public SaleStatus? SaleStatus { get; set; }
        public int? SaleStatusId { get; set; }

        public Employee? Employee { get; set; }
        public int? EmployeeId { get; set; }

    }
}
