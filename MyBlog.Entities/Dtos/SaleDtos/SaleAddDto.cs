using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.SaleDtos
{
    public class SaleAddDto : DtoGetBase
    {
        [DisplayName("SGK Tutarı ")]
        public int? AmountOfSgk { get; set; }
        public bool IsInvoiceDue { get; set; }=false;
        [DisplayName("Satış Tutarı ")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        [MaxLength(150, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        public int Amount { get; set; }
        [DisplayName("Hasta")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        [DisplayName("Satış Tipi")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public SaleType SaleType { get; set; }
        public int SaleTypeId { get; set; }
        [DisplayName("Satış Durumu")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public SaleStatus SaleStatus { get; set; }
        public int SaleStatusId { get; set; }
        [DisplayName("Ürün")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public Product Product { get; set; }
        public int ProductId { get; set; }
        [DisplayName("Personel")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        [DisplayName("Not")]
        [MaxLength(500, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1} Karakterden Az Olmamalıdır")]
        public string? Not { get; set; }
    }
}
