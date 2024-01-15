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
        [DisplayName("SGK Tutarı")]
        public int? AmountOfSgk { get; set; }
        public bool IsInvoiceDue { get; set; } = false;

        [DisplayName("Satış Tutarı")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public int Amount { get; set; }
        [DisplayName("Hasta")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public IList<Customer> Customers { get; set; }
        [DisplayName("Hasta")]

        public int CustomerId { get; set; }
        [DisplayName("Satış Tipi")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public IList<SaleType> SaleTypes { get; set; }
        [DisplayName("Satış Tipi")]
        public int SaleTypeId { get; set; }
        [DisplayName("Satış Durumu")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public IList<SaleStatus> SaleStatuses { get; set; }
        public int SaleStatusId { get; set; }
        [DisplayName("Ürün")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public IList<Product> Products { get; set; }
        public IList<ProductListWithRelatedTables> ProductListWithRelatedTables { get; set; }
        [DisplayName("Ürün")]
        public int ProductId { get; set; }

        public int OldProductId { get; set; } = 0;
        [DisplayName("Personel")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public IList<Employee> Employees { get; set; }
        [DisplayName("Personel")]
        public int EmployeeId { get; set; }
        [DisplayName("Açıklama")]
        [MaxLength(500, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1} Karakterden Az Olmamalıdır")]
        public string? Description { get; set; }
    }
    public class SaleAddRequest
    {
        public List<SaleAddViewModel> SaleAddViewModelList { get; set; }
        public string TableType { get; set; }
    }
}
