using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Spendings.WEB.Models;
using Spendings.WEB.Services;

namespace Spendings.WEB.Controllers
{
    public class IncomeController : Controller
    {
        private readonly ILogger<IncomeController> _logger;
        private readonly IIncomeService _incomeService;

        public IncomeController(ILogger<IncomeController> logger, IIncomeService incomeService)
        {
            _incomeService = incomeService;
            _logger = logger;
        }

        public async Task<IActionResult> Index(DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                var incomes = await _incomeService.GetIncomes(HttpContext, startDate, endDate);
                return View(incomes);

            }
            catch (UnauthorizedAccessException)
            {
                return RedirectToAction("LoginRegister", "Account", new { returnUrl = "/Income" });
            }
        }

        [HttpPost("/delete-income-ajax")]
        public async Task<IActionResult> DeleteIncomeAjax(long id)
        {
            var result = await _incomeService.DeleteIncome(HttpContext, id);
            return Ok(result);
        }

        [HttpPost("/update-income-ajax")]
        public async Task<IActionResult> UpdateIncomeAjax(Income income)
        {
            income.DateReceived = income.DateReceived.LocalDateTime;
            var result = await _incomeService.UpdateIncome(HttpContext, income);
            return Ok(result);
        }

        [HttpPost("/create-income-ajax")]
        public async Task<IActionResult> CreateIncomeAjax(Income income)
        {
            income.DateReceived = income.DateReceived.LocalDateTime;
            var result = await _incomeService.CreateIncome(HttpContext, income);

            return Json(new
            {
                isSuccessStatusCode = result.IsSuccessStatusCode,
                content = JsonConvert.DeserializeObject<Income>(await result.Content.ReadAsStringAsync())
            });
        }
    }
}
