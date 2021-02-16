using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Spendings.WEB.Services;

namespace Spendings.WEB.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IExpenseService _expenseService;

        public DashboardController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        [HttpGet("/")]
        public async Task<IActionResult> Index()
        {
            try 
            { 
                var vm = new DashboardVm()
                {
                    QuickInfo = await _expenseService.GetQuickInfo(HttpContext)
                };

                return View(vm);

            }
            catch (UnauthorizedAccessException)
            {
                return RedirectToAction("LoginRegister", "Account", new { returnUrl = "/" });
            }
        }

        public IActionResult Error(string message)
        {
            return View("Error",message);
        }
    }

    public class DashboardVm
    {
        public List<DashboardInfo> QuickInfo { get; set; }
    }
}
