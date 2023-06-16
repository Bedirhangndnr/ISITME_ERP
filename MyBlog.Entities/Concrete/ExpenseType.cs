using MyBlog.Shared.Entities.Abstract;
using MyBlog.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class ExpenseType:EntityBase,IEntity
    {
        public ICollection<Expense> Expenses { get; set; }
        public int Title{ get; set; }

    }
}
