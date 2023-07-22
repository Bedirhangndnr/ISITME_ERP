using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.PaymentDtos;
using MyBlog.Shared.Entities.Abstract;
using MyBlog.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.PaymentDtos
{
    public class PaymentListDto : DtoGetBase
    {
        public IList<Payment> Payments { get; set; }
        public IList<PaymentListWithRelatedTables> PaymentListWithRelatedTables { get; set; } = null;

    }
}
