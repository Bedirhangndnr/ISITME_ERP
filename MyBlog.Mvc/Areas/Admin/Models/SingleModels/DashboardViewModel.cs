using MyBlog.Entities.Concrete;
using MyBlog.Entities.Dtos.ArticleDtos;
using MyBlog.Entities.Dtos.ExpenseDtos;

namespace MyBlog.Mvc.Areas.Admin.Models.SingleModels
{
    public class DashboardViewModel
    {
        public int SalesCount { get; set; }
        public int AppointmentsCount { get; set; }
        public int ExpensesIncomeCount { get; set; }
        public int ExpensesOutcomeCount { get; set; }
        public int UsersCount { get; set; }
        public ExpenseListDto Expenses{ get; set; }
    }
}
