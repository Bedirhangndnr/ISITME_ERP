﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBlog.Entities.Concrete;

namespace MyBlog.Entities.Dtos.CommentDtos
{
    public class CommentListDto
    {
        public IList<Comment> Comments { get; set; }
    }
}
