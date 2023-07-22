using MyBlog.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Shared.Entities.Abstract
{
    public abstract class DtoGetBase
    {
        public virtual ResultStatus ResultStatus { get; set; }
        public virtual string? Message { get; set; }
        public string ? ModifiedByName { get; set; }
        public string ? CreatedByName { get; set; }
        public DateTime  CreatedDate { get; set; }
        public DateTime  ModifiedDate { get; set; }
    }
}
