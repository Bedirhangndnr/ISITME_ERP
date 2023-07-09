using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBlog.Entities.Concrete;
using MyBlog.Mvc.Areas.Admin.Models;
using MyBlog.Mvc.Areas.Admin.Models.SingleModels;
using MyBlog.Mvc.Consts;
using MyBlog.Services.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = $"{AuthorizeDefinitikonConstants.SuperAdmin}, {AuthorizeDefinitionConstants.HomeProgramRead}")]
    public class HomeController : Controller
    {
        private readonly ISaleService _saleService;
        private readonly IExpenseService _expenseService;
        private readonly IAppointmentService _appointmentService;
        private readonly UserManager<User> _userManager;

        public HomeController(ISaleService saleService, IExpenseService expenseService, IAppointmentService appointmentService, UserManager<User> userManager)
        {
            _saleService = saleService;
            _expenseService = expenseService;
            _appointmentService = appointmentService;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var salesCountResult= await _saleService.CountByNonDeletedAsync(isRestOfTheMonth:true);
            var expensesIncomeCountResult= await _expenseService.CountByNonDeletedAsync(lastXDays:7, isIncome:true);
            var expensesOutcomeCountResult= await _expenseService.CountByNonDeletedAsync(lastXDays:7, isIncome:false);
            var appointmentsCountResult= await _appointmentService.CountByNonDeletedAsync(isRestOfDay:true);
            var usersCount= await _userManager.Users.CountAsync();
            var expensesResult= await _expenseService.GetAllAsync();
            if (salesCountResult.ResultStatus==ResultStatus.Success&&
                expensesIncomeCountResult.ResultStatus==ResultStatus.Success&&
                expensesOutcomeCountResult.ResultStatus==ResultStatus.Success&&
                appointmentsCountResult.ResultStatus==ResultStatus.Success&&
                expensesResult.ResultStatus==ResultStatus.Success)
            {
                return View(new DashboardViewModel
                {
                    ExpensesIncomeCount = expensesIncomeCountResult.Data,
                    ExpensesOutcomeCount = expensesOutcomeCountResult.Data,
                    SalesCount = salesCountResult.Data,
                    AppointmentsCount = appointmentsCountResult.Data,
                    UsersCount = usersCount,
                    Expenses = expensesResult.Data
                });
            }
            return NotFound();
        }
    }
}
