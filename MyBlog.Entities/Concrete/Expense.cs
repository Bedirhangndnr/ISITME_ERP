using MyBlog.Shared.Entities.Abstract;
using MyBlog.Shared.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Concrete
{
    public class Expense:EntityBase,IEntity
    {
        public int Amount{ get; set; }
        //public ExpenseType ExpenseType { get; set; }
        //public int ExpenseId{ get; set; }
        public bool IsDaily { get; set; }
        public bool IsIncome { get; set; } = false;

    }
}
