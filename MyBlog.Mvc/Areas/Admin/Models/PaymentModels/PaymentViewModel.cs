using MyBlog.Entities.Dtos.PaymentDtos;
using MyBlog.Entities.Dtos.ProductDtos;

namespace MyBlog.Mvc.Areas.Admin.Models
{
    // Şu an Kullanılmıyor.
    public class PaymentViewModel
    {
        public string PaymentTypeName { get; set; }
        public PaymentListDto PaymentListDto { get; set; }
        public ProductListWithRelatedTables ProductListWithRelatedTables { get; set; }

    }

}
