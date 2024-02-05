using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ProductDtos;
using MyBlog.Shared.Entities.Abstract;
using MyBlog.Shared.Entities.Concrete;

namespace MyBlog.Mvc.Areas.Admin.Models
{
    public class SaleAddViewModel : DtoGetBase
    {

        [DisplayName("Satış Tutarı")]
        public decimal? Amount { get; set; }
        public decimal? AmountOfSgk { get; set; }
        [DisplayName("Hasta")]
        public IList<Customer> Customers { get; set; }
        [DisplayName("SGK Türü")]
        public IList<Parameter> SgkList { get; set; }
        public int? SgkId { get; set; }
        public string? SgkTypeTitle { get; set; }

        [DisplayName("Hasta")]

        public int? CustomerId { get; set; }
        [DisplayName("Satış Tipi")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public IList<SaleType> SaleTypes { get; set; }
        [DisplayName("Satış Tipi")]
        public int? SaleTypeId { get; set; }
        [DisplayName("Satış Durumu")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public IList<SaleStatus> SaleStatuses { get; set; }
        public bool IsDelivered
        {
            get
            {
                return DeliveryDate != null;
            }
        }
        [DisplayName("Teslim Tarihi")]
        public DateTime? DeliveryDate { get; set; }
        [DisplayName("Kapora")]
        public decimal? DownPayment { get; set; }
        public int? SaleStatusId { get; set; }
        [DisplayName("Ürün")]
        public IList<Product>? Products { get; set; }
        public IList<ProductListWithRelatedTables>? ProductListWithRelatedTables { get; set; }
        [DisplayName("Ürün")]
        public int? ProductId { get; set; }

        public int? OldProductId { get; set; } = 0;
        [DisplayName("Personel")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public IList<Employee>? Employees { get; set; }
        [DisplayName("Personel")]
        public int? EmployeeId { get; set; }
        [DisplayName("Açıklama")]
        [MaxLength(500, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        public string? Description { get; set; }
        [DisplayName("Açıklama")]
        [MaxLength(500, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        public string? Note { get; set; }
    }
    public class SaleAddRequest
    {
        public List<SaleAddViewModel> SaleAddViewModelList { get; set; }
        public string TableType { get; set; }
    }
}

