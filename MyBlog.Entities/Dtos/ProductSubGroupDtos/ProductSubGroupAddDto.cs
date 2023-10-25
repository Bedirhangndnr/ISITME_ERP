using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.ProductSubGroupDtos
{
    public class ProductSubGroupAddDto : DtoGetBase
    {
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(50, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        public string Title { get; set; }
        [DisplayName("Açıklama")]
        [MaxLength(100, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        public string? Description { get; set; }
        public ICollection<ProductGroup> ProductGroups { get; set; }
        public ProductGroup? ProductGroup { get; set; }
        public int? ProductGroupId { get; set; }
        public int? ProductGroupTitle { get; set; }

    }
}
