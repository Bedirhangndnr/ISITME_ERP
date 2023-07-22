using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.SaleStatusDtos
{
    public class SaleStatusListDto:DtoGetBase
    {
        public IList<SaleStatus> SaleStatuses{ get; set; }

    }
}
