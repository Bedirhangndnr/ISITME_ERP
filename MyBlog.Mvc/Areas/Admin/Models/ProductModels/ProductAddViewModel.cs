using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Concrete;

namespace MyBlog.Mvc.Areas.Admin.Models
{
    public class ProductAddViewModel
    {
        [DisplayName("Not")]
        [MaxLength(500, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1} Karakterden Az Olmamalıdır")]
        public string? Note { get; set; }
        [DisplayName("Ürün Adı")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        [MaxLength(35, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(2, ErrorMessage = "{0} {1} Karakterden Küçük Olmamalıdır")]
        public string ProductName { get; set; }
        [DisplayName("Seri Numarası")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        [MaxLength(35, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(2, ErrorMessage = "{0} {1} Karakterden Küçük Olmamalıdır")]
        public string SerialNumber { get; set; }
        [DisplayName("Ürün Alt Grubu")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public int? ProductSubGroupId { get; set; }
        public IList<ProductSubGroup>? ProductSubGroups { get; set; }
        [DisplayName("Marka")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public int BrandId { get; set; }
        public IList<Brand> Brands { get; set; }
    }
}
