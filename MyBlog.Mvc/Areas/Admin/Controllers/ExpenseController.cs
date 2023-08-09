using Microsoft.AspNetCore.Mvc;
using MyBlog.Services.Abstract;
using MyBlog.Shared.Utilities.Results.ComplexTypes;
using MyBlog.Mvc.Areas.Admin.Models;
using AutoMapper;
using MyBlog.Entities.ComplexTypes;
using MyBlog.Entities.Dtos;
using MyBlog.Mvc.Halpers.Abstract;
using Microsoft.AspNetCore.Identity;
using MyBlog.Entities.Concrete;
using System.Text.Json.Serialization;
using System.Text.Json;
using NToastNotify;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using MyBlog.Entities.Dtos.CustomerReferanceDtos;
using MyBlog.Entities.Dtos.ExpenseDtos;
using MyBlog.Shared.Utilities.Extensions;
using MyBlog.Shared.Utilities.Messages.NotificationMessages;
using MyBlog.Mvc.Consts;
using MyBlog.Services.Utilities;

namespace MyBlog.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "SuperAdmin, Editor")]

    public class ExpenseController : BaseController
    {
        private readonly IExpenseService _expenseService;
        private readonly IToastNotification _toastNotification;
        private readonly INotificationService _notificationService;


        public ExpenseController(
            INotificationService notificationService,
            IExpenseService expenseService,
            UserManager<User> userManager,
            IMapper mapper, IImageHelper imageHelper, IToastNotification toastNotification) : base(userManager, mapper, imageHelper)
        {
            _notificationService = notificationService;
            _expenseService = expenseService;
            _toastNotification = toastNotification;
        }

        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ExpenseRead}")]
        [HttpGet]
        public async Task<IActionResult> Index(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _expenseService.GetAllByNonDeletedAndActiveAsync(365);
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _expenseService.GetAllByDeletedAsync();
                if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile KArşılaşıldı", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetChartIncomeAndOutcomeData()
        {
            var result = await _expenseService.GetAllByNonDeletedAndActiveAsync(30);

            if (result.ResultStatus == ResultStatus.Success)
            {
                var expenses = result.Data.Expenses;

                // Bugünün tarihini alın
                var today = DateTime.Today;

                // Tüm gelirleri ve giderleri filtreleyin ve toplamlarını hesaplayın
                var totalIncome = expenses.Where(e => e.IsIncome && e.CreatedDate.Date <= today).Sum(e => e.Amount);
                var totalOutcome = expenses.Where(e => !e.IsIncome && e.CreatedDate.Date <= today).Sum(e => e.Amount);

                // Tüm gelir ve gider verilerini almak için gerekli işlemleri yapın
                var incomeData = expenses
                    .Where(e => e.IsIncome)
                    .GroupBy(e => e.CreatedDate.Date)
                    .Select(g => new { Date = g.Key, Amount = g.Sum(e => e.Amount) })
                    .OrderBy(item => item.Date)
                    .ToList();

                var outcomeData = expenses
                    .Where(e => !e.IsIncome)
                    .GroupBy(e => e.CreatedDate.Date)
                    .Select(g => new { Date = g.Key, Amount = g.Sum(e => e.Amount) })
                    .OrderBy(item => item.Date)
                    .ToList();

                // Düne ait geliri toplam gelire ekle
                var yesterdayIncome = incomeData.FirstOrDefault(item => item.Date == today.AddDays(-1));
                if (yesterdayIncome != null)
                    totalIncome += yesterdayIncome.Amount;

                // Dönecek veri nesnesini oluşturun
                var data = new
                {
                    IncomeData = incomeData.Select(item => item.Amount),
                    OutcomeData = outcomeData.Select(item => item.Amount),
                    TotalIncome = totalIncome,
                    TotalOutcome = totalOutcome
                };

                // JavaScript tarafına verileri döndürün
                return Content(Newtonsoft.Json.JsonConvert.SerializeObject(data), "application/json");
            }

            return Json(new { ErrorMessage = "Kayıtlar bulunamadı." });
        }





        [HttpGet]
        public async Task<JsonResult> GetAllExpenses(string tableType)
        {
            ViewBag.TableType = tableType;
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var employeeTypes = await _expenseService.GetAllByNonDeletedAndActiveAsync();
                var employeeTypeResult = JsonSerializer.Serialize(employeeTypes, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(employeeTypeResult);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _expenseService.GetAllByDeletedAsync();
                var rmployeeTypes = JsonSerializer.Serialize(result, new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                });
                return Json(rmployeeTypes);
            }
            _toastNotification.AddErrorToastMessage("Bir Hata ile Karşılaşıldı *", new ToastrOptions
            {
                Title = "Başarısız İşlem!"
            });
            return Json(null);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ExpenseCreate}")]
        [HttpGet]
        public IActionResult Add()
        {
            return PartialView("_ExpenseAddPartial");
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ExpenseCreate}")]
        [HttpPost]
        public async Task<IActionResult> Add(ExpenseAddDto expenseAddDto)
        {
            if (ModelState.IsValid)
            {
                var result = await _expenseService.AddAsync(expenseAddDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    var categoryAddAjaxModel = JsonSerializer.Serialize(new ExpenseAddAjaxViewModel
                    {
                        ExpenseDto = result.Data,
                        ExpenseAddPartial = await this.RenderViewToStringAsync("_ExpenseAddPartial", expenseAddDto)
                    });
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.Added,
TableNamesConstants.Expenses,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.Added), userId: LoggedInUser.Id
);

                    return Json(categoryAddAjaxModel);
                }
            }
            var categoryAddAjaxErrorModel = JsonSerializer.Serialize(new ExpenseAddAjaxViewModel
            {
                ExpenseAddPartial = await this.RenderViewToStringAsync("_ExpenseAddPartial", expenseAddDto)
            });
            return Json(categoryAddAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ExpenseUpdate}")]
        [HttpGet]
        public async Task<IActionResult> Update(int expenseId, string tableType)
        {
            ViewBag.TableType = tableType;
            var result = await _expenseService.GetExpenseUpdateDtoAsync(expenseId);
            if (result.ResultStatus == ResultStatus.Success)
            {
                return PartialView("_ExpenseUpdatePartial", result.Data);
            }
            return NotFound();
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ExpenseUpdate}")]
        [HttpPost]
        public async Task<IActionResult> Update(ExpenseUpdateDto expenseUpdateDto, string tableType)
        {
            ViewBag.tableType = tableType;
            if (ModelState.IsValid)
            {
                var result = await _expenseService.UpdateAsync(expenseUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    await _notificationService.AddAsync(NotificationMessageService.GetMessage(
                        NotificationMessageTypes.Updated,
                        "Marka",
                        result.Data.Expense.ModifiedByName),
                        NotificationMessageService.GetTitle(NotificationMessageTypes.Updated), userId: LoggedInUser.Id
                        );
                    var categoryUpdateAjaxModel = JsonSerializer.Serialize(new ExpenseUpdateAjaxViewModel
                    {
                        ExpenseDto = result.Data,
                        ExpenseUpdatePartial = await this.RenderViewToStringAsync("_ExpenseUpdatePartial", expenseUpdateDto)
                    });
                    return Json(categoryUpdateAjaxModel);
                }
            }
            var categoryUpdateAjaxErrorModel = JsonSerializer.Serialize(new ExpenseUpdateAjaxViewModel
            {
                ExpenseUpdatePartial = await this.RenderViewToStringAsync("_ExpenseUpdatePartial", expenseUpdateDto)
            });
            return Json(categoryUpdateAjaxErrorModel);

        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ExpenseDelete}")]
        [HttpPost]
        public async Task<JsonResult> Delete(int expenseId, string tableType)
        {
            if (tableType == TableReturnTypesConstants.NonDeletedTables)
            {
                var result = await _expenseService.DeleteAsync(expenseId, LoggedInUser.UserName);
                var deletedExpense = JsonSerializer.Serialize(result.Data);
                await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.Deleted,
TableNamesConstants.Expenses,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.Deleted), userId: LoggedInUser.Id
);
                return Json(deletedExpense);
            }
            else if (tableType == TableReturnTypesConstants.DeletedTables)
            {
                var result = await _expenseService.HardDeleteAsync(expenseId);
                var hardDeletedAppointmentResult = JsonSerializer.Serialize(result);
                await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.HardDeleted,
TableNamesConstants.Expenses,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.HardDeleted), userId: LoggedInUser.Id
);
                return Json(hardDeletedAppointmentResult);
            }
            else
            {
                // Hatalı silme türü parametresi durumunda hata döndürme
                return Json("Hatalı silme türü parametresi!");
            }
        }
        [HttpPost]
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ExpenseDelete}")]
        public async Task<JsonResult> UndoDelete(int expenseId)
        {
            var result = await _expenseService.UndoDeleteAsync(expenseId, LoggedInUser.UserName);
            var undoDeletedExpense = JsonSerializer.Serialize(result.Data);
            await _notificationService.AddAsync(NotificationMessageService.GetMessage(
NotificationMessageTypes.UndoDeleted,
TableNamesConstants.Expenses,
LoggedInUser.UserName),
NotificationMessageService.GetTitle(NotificationMessageTypes.UndoDeleted), userId: LoggedInUser.Id
);
            return Json(undoDeletedExpense);
        }
        [Authorize(Roles = $"{AuthorizeDefinitionConstants.SuperAdmin}, {AuthorizeDefinitionConstants.ExpenseDelete}")]
        [HttpGet]
        public async Task<IActionResult> HardDelete(int expenseId)
        {
            var result = await _expenseService.HardDeleteAsync(expenseId);
            var deletedExpense = JsonSerializer.Serialize(result);
            return View(deletedExpense);

        }
    }
}