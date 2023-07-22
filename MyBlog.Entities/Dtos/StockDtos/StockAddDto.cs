using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.StockDtos
{
    public class StockAddDto : DtoGetBase
    {
        [DisplayName("Hasta")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; } = 1; // Kalan. Product ile stock arasında 1-1 bir ilişki olduğu
                                                // için şu an için burası bu şekilde dıracak ilerleyen
                                                // zamanlarda bu durumun değişme ihtimaline karşı yazıldı.
    }
}
