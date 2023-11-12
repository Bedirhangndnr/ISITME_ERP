﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MyBlog.Entities.Concrete;
using MyBlog.Mvc.Areas.Admin.Models.UserModels;
using MyBlog.Shared.Entities.Abstract;
using MyBlog.Shared.Entities.Concrete;

namespace MyBlog.Mvc.Areas.Admin.Models
{
    public class ProductAddViewModel:DtoGetBase
    {
        [DisplayName("Fiyat | TL")]
        [Range(0, int.MaxValue, ErrorMessage = "{0} 0'dan küçük olamaz")]
        public int Price { get; set; }

        [DisplayName("Adet")]
        [Range(0, int.MaxValue, ErrorMessage = "{0} 0'dan küçük olamaz")]
        public int Quantity { get; set; }
        [DisplayName("Not")]
        public string? Note { get; set; }
        [DisplayName("Satıldı Mı")]
        public bool IsSold { get; set; } = false;
        public bool? IsProduct { get; set; } = true;

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
        [DisplayName("Alt Model")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public int? SubModelId { get; set; }
        public IList<SubModel>? SubModels { get; set; }
        [DisplayName("Geliştiriciye Mesaj")]
        [Required(ErrorMessage = "{0} Boş Geçilemez...")]
        public int ModelId { get; set; }
        public IList<Model> Models { get; set; }
        public int BrandId { get; set; }
        public IList<Brand> Brands { get; set; }
        public UserWithRolesViewModel UserWithRolesModel { get; set; }

    }
}
