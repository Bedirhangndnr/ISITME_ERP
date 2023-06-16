using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.SaleDtos
{
    public class SaleListWithRelatedTables: DtoGetBase
    {
        public int? AmountOfSgk { get; set; }
        public bool IsInvoiceDue { get; set; } = false;
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal Amount { get; set; }
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public int SaleTypeId { get; set; }
        public string SaleTypeName { get; set; }
        public int SaleStatusId { get; set; }
        public string SaleStatusName { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

    }
}
