using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Shared.Entities.Concrete;

namespace MyBlog.Entities.Dtos.ProductDtos
{
    public class ProductAddDto : DtoGetBase
    {
        [DisplayName("Fiyat")]
        [Range(0, int.MaxValue, ErrorMessage = "{0} 0'dan küçük olamaz")]
        public int Price { get; set; }

        [DisplayName("Adet")]
        [Range(0, int.MaxValue, ErrorMessage = "{0} 0'dan küçük olamaz")]
        public int Quantity { get; set; }

        [DisplayName("Kategori Not Alanı")]
        [MaxLength(500, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1} Karakterden Az Olmamalıdır")]
        public string Note { get; set; }
        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} Boş Olmamalıdır...")]
        public bool IsActive { get; set; } = true;
        [DisplayName("Satıldı Mı")]
        public bool IsSold { get; set; } = false;
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
        [DisplayName("Model")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public int? ProductSubGroupId { get; set; }
        public ProductSubGroup? ProductSubGroup { get; set; }
        [DisplayName("Geliştiriciye Mesaj")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public int ModelId { get; set; }
        public Model Model { get; set; }

    }
}
