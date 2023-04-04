using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.SaleTypeDtos
{
    public class SaleTypeDto : DtoGetBase
    {
        public SaleType SaleType { get; set; }
    }
}
