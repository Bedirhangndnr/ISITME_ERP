using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.OutPaymentDtos;
using MyBlog.Shared.Entities.Abstract;
using MyBlog.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.OutPaymentDtos
{
    public class OutPaymentListDto : DtoGetBase
    {
        public IList<Concrete.OutPayment> OutPayments { get; set; }
            
    }
}
