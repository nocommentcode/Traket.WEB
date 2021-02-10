using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Spendings.WEB.Models;
using Spendings.WEB.Services;

namespace Spendings.WEB.Controllers
{
    public class HistoryController : Controller
    {
        private readonly IExpenseService _expenseService;

        public HistoryController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        
        public async Task<IActionResult> Index()
        {
            try 
            { 
                var vm = new HistoryVm()
                {
                    Months = await _expenseService.GetMonthlySummary(HttpContext)
                };

                return View(vm);

            }
            catch (UnauthorizedAccessException)
            {
                return RedirectToAction("LoginRegister", "Account", new { returnUrl = "/History" });
            }
        }

        public IActionResult Error(string message)
        {
            return View("Error",message);
        }
    }
}
