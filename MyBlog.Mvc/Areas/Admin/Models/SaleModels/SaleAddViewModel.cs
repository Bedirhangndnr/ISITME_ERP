using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using MyBlog.Shared.Entities.Concrete;

namespace MyBlog.Mvc.Areas.Admin.Models
{
    public class SaleAddViewModel : DtoGetBase
    {
        [DisplayName("SGK Tutarı | TL")]
        public int? AmountOfSgk { get; set; }
        public bool IsInvoiceDue { get; set; } = false;

        [DisplayName("Satış Tutarı | TL")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public int Amount { get; set; }
        [DisplayName("Hasta")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public IList<Customer> Customers { get; set; }
        public int CustomerId { get; set; }
        [DisplayName("Satış Tipi")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public IList<SaleType> SaleTypes { get; set; }
        public int SaleTypeId { get; set; }
        [DisplayName("Satış Durumu")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public IList<SaleStatus> SaleStatuses { get; set; }
        public int SaleStatusId { get; set; }
        [DisplayName("Ürün")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public IList<Product> Products { get; set; }
        public int ProductId { get; set; }
        [DisplayName("Personel")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public IList<Employee> Employees { get; set; }
        public int EmployeeId { get; set; }
        [DisplayName("Açıklama")]
        [MaxLength(500, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1} Karakterden Az Olmamalıdır")]
        public string? Description { get; set; }
    }
}
