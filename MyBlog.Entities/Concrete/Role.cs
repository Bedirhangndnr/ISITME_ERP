using Microsoft.AspNetCore.Identity;
using MyBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class Role: IdentityRole<int> // intager primary keyler ile oluşması için
    {
        //public string Menu { get; set; }
        public string? Definition { get; set; }
        public int AccessLevel { get; set; }
        // hangi action'a karşılık geldiğine dair bir bilgi
        //public string? ActionType { get; set; }
    }
}
