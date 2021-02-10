using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Spendings.WEB.Models;
using Spendings.WEB.Services;

namespace Spendings.WEB.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ILogger<ExpenseController> _logger;
        private readonly IExpenseService _expenseService;
        private readonly ICategoryService _categoryService;

        public ExpenseController(ILogger<ExpenseController> logger,
            IExpenseService expenseService,
            ICategoryService categoryService)
        {
            _categoryService = categoryService; 
            _expenseService = expenseService;
            _logger = logger;
        }

        public async Task<IActionResult> Index(bool isCreateScreen = false, DateTime? startDate=null, DateTime? endDate=null)
        {
            try
            {
                var model = new ExpenseVm()
                {
                    Expenses = await _expenseService.GetExpenses(HttpContext, startDate, endDate),
                    Categories = await _categoryService.GetCategories(HttpContext, startDate, endDate),
                    isCreateScreen = isCreateScreen,
                    StartDate = startDate,
                    EndDate = endDate
                };
                return View(model);

            }
            catch (UnauthorizedAccessException)
            {
                return RedirectToAction("LoginRegister", "Account", new {returnUrl = "/Expense"});
            }
        }

        [HttpPost("/delete-expense-ajax")]
        public async Task<IActionResult> DeleteExpenseAjax(long id)
        {
            var result = await _expenseService.DeleteExpense(HttpContext, id);
            try
            {
                return Json(new
                {
                    isSuccessStatusCode = result.IsSuccessStatusCode,
                    content = JsonConvert.DeserializeObject<Expense>(await result.Content.ReadAsStringAsync())
                });
            }
            catch
            {
                return Json(new
                {
                    isSuccessStatusCode = false,
                    details = await result.Content.ReadAsStringAsync(),
                    reasonPhrase = $"an Error Occured {(int)result.StatusCode}"
                });
            }
        }

        [HttpPost("/update-expense-ajax")]
        public async Task<IActionResult> UpdateExpenseAjax(Expense expense)
        {
            expense.Date = expense.Date.LocalDateTime;
            var result = await _expenseService.UpdateExpense(HttpContext, expense);
            try
            {
                return Json(new
                {
                    isSuccessStatusCode = result.IsSuccessStatusCode,
                    content = JsonConvert.DeserializeObject<Expense>(await result.Content.ReadAsStringAsync())
                });
            }
            catch
            {
                return Json(new
                {
                    isSuccessStatusCode = false,
                    details = await result.Content.ReadAsStringAsync(),
                    reasonPhrase = $"an Error Occured {(int)result.StatusCode}"
                });
            }
        }

        [HttpPost("/create-expense-ajax")]
        public async Task<IActionResult> CreateExpenseAjax(Expense expense)
        {
            expense.Date = expense.Date.LocalDateTime;
            var result = await _expenseService.CreateExpense(HttpContext, expense);

            try
            {
                return Json(new
                {
                    isSuccessStatusCode = result.IsSuccessStatusCode,
                    content = JsonConvert.DeserializeObject<Expense>(await result.Content.ReadAsStringAsync())
                });
            }
            catch
            {
                return Json(new
                {
                    isSuccessStatusCode = false,
                    details = await result.Content.ReadAsStringAsync(),
                    reasonPhrase = $"an Error Occured {(int)result.StatusCode}"
                });
            }
        }
        [HttpGet("/get-expense-graph")]
        public async Task<IActionResult> GetGraph()
        {
            var result = await _expenseService.GetGraph(HttpContext);

            return Ok(result);
        }


        [HttpGet]
        public IActionResult Import()
        {
            return View();
        }


        [HttpPost("/import-expenses")]
        public async Task<IActionResult> Import(IFormFile file)
        {
            var result = await _expenseService.ImportExpenses(HttpContext, file);

            return Ok(result);
        }

        
    }
    public class ImportForm
    {
        public IFormFile File { get; set; }
    }
}
