﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;
using MyBlog.Shared.Entities.Abstract;

namespace MyBlog.Entities.Dtos.ParameterDtos
{
    public class ParameterDto : DtoGetBase
    {
        public Parameter Parameter { get; set; }
    }
}
