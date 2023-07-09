using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.OutPaymentDetailDtos;
using MyBlog.Shared.Entities.Abstract;
using MyBlog.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.OutPaymentDetailDtos
{
    public class OutPaymentDetailListDto : DtoGetBase
    {
        public IList<Concrete.OutPaymentDetail> OutPaymentDetails { get; set; }
            
    }
}
