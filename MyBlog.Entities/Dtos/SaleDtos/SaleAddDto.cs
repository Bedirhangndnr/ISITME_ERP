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
        [DisplayName("Satış Tarihi")]
        public DateTime? SaleDate { get; set; }
        public DateTime? UpdatedSaleDate { get; set; }
        public bool? IsDelivered { get; set; }
        [DisplayName("SGK Tutarı ")]
        public decimal? AmountOfSgk { get; set; }
        public string? SgkTypeTitle { get; set; }
        [DisplayName("Teslim Tarihi")]
        public DateTime? DeliveryDate { get; set; }
        [DisplayName("Kapora")]
        public int? SgkId { get; set; }

        public decimal? DownPayment { get; set; }
        public bool IsInvoiceDue { get; set; } = false;
        public decimal Amount { get; set; }
        [DisplayName("Hasta")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        [DisplayName("Satış Tipi")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public SaleType SaleType { get; set; }
        public int? SaleTypeId { get; set; }
        [DisplayName("Satış Durumu")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public SaleStatus SaleStatus { get; set; }
        public int SaleStatusId { get; set; }
        [DisplayName("Ürün")]
        public Product Product { get; set; }
        public int? ProductId { get; set; }
        [DisplayName("Personel")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        [DisplayName("Not")]
        [MaxLength(500, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        public string? Not { get; set; }
        [DisplayName("Açıklama")]
        [MaxLength(500, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        public string? Description { get; set; }
    }

}
