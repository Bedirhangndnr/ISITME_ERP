using Microsoft.CodeAnalysis;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class MessageToDeveloper : EntityBase, IEntity
    {
        public string? Title { get; set; }
        public string Message { get; set; }
        public bool IsRead{ get; set; }
        public int Progress{ get; set; }
        public DateTime EstimatedCompletionDate { get; set; }
    }
}
