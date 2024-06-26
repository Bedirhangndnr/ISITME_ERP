﻿using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class ChangeLog : IEntity
    {
        public int Id { get; set; }
        public string? TableName { get; set; }
        public string? Action { get; set; }
        public DateTime? DateTime { get; set; }
        public string? OldValues { get; set; }
        public string? NewValues { get; set; }
    }
}
