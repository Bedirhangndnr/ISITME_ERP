using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class Parameter : EntityBase, IEntity
    {
        public string? ParamCode { get; set; }
        public string? ParamType { get; set; }
        public string? ParamDescription { get; set; }
        public string? ParamValue { get; set; }
        public string? ParamValue1 { get; set; }
        public string? ParamValue2 { get; set; }
        public string? ParamValue3 { get; set; }
        public string? ParamValue4 { get; set; }
        public string? ParamValue5 { get; set; }
        public string? ParamValue6 { get; set; }


    }
}
