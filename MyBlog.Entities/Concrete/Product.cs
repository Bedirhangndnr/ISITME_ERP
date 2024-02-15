﻿using MyBlog.Shared.Entities.Abstract;
using MyBlog.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class Product:EntityBase,IEntity
    {
        public string ProductName { get; set; }
        public int Price{ get; set; }
        public int Status{ get; set; }
        public int? Quantity{ get; set; }
        public string SerialNumber { get; set; }
        public bool IsSold { get; set; } = false;
        public int? ProductSubGroupId { get; set; }
        public ProductSubGroup? ProductSubGroup { get; set; }
        public int? ModelId { get; set; }
        public Model? Model{ get; set; }
        public int? SubModelId { get; set; }
        public SubModel? SubModel { get; set; }
        public Stock Stock { get; set; }
        public Sale Sale { get; set; }
        public bool IsMultiple{ get; set; }
        public bool? IsProduct { get; set; }


    }
}
