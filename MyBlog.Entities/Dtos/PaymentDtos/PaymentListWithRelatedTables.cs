using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.PaymentDtos
{
    public class PaymentListWithRelatedTables: DtoGetBase
    {
        public int Id { get; set; }
        public int? PaymentTypeId { get; set; }
        public string? PaymentTypeTitle { get; set; }
        public int? AssociatedInstitutionId { get; set; }
        public string? AssociatedInstitutionTitle { get; set; }
        public int? SaleTypeId { get; set; }
        public string? SaleTypeTitle { get; set; }
        public int AmountPaid { get; set; } // defaullt olarak tl olarak yazılacak
        public string? Description { get; set; }
        public string CustomerName { get; set; }
        public string? Note { get; set; }
        public int CustomerId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime Date { get; set; }
        public int? EmployeeId { get; set; }
    }
}
