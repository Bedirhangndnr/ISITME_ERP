﻿using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;
using MyBlog.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Dtos.PaymentTypeDtos
{
    public class PaymentTypeDto : DtoGetBase
    {
        public PaymentType PaymentType { get; set; }
    }
}
