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
    public class BillController : Controller
    {
        private readonly ILogger<BillController> _logger;
        private readonly IBillService _billService;

        public BillController(ILogger<BillController> logger, IBillService billService)
        {
            _billService = billService;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var bills = await _billService.GetBills(HttpContext);
                return View(bills);

            }
            catch (UnauthorizedAccessException)
            {
                return RedirectToAction("LoginRegister", "Account", new { returnUrl = "/Bill" });
            }
        }

        [HttpPost("/delete-bill-ajax")]
        public async Task<IActionResult> DeleteBillAjax(long id)
        {
            var result = await _billService.DeleteBill(HttpContext, id);
            return Ok(result);
        }

        [HttpPost("/update-bill-ajax")]
        public async Task<IActionResult> UpdateBillAjax(Bill bill)
        {
            bill.BillingStart = bill.BillingStart.LocalDateTime;
            if (bill.BillingEnd.HasValue) {
                bill.BillingEnd = bill.BillingEnd.Value.LocalDateTime;
            } 
            
            var result = await _billService.UpdateBill(HttpContext, bill);
            return Ok(result);
        }

        [HttpPost("/create-bill-ajax")]
        public async Task<IActionResult> CreateBillAjax(Bill bill)
        {
            bill.BillingStart = bill.BillingStart.LocalDateTime;
            if (bill.BillingEnd.HasValue)
            {
                bill.BillingEnd = bill.BillingEnd.Value.LocalDateTime;
            }

            var result = await _billService.CreateBill(HttpContext, bill);

            return Json(new
            {
                isSuccessStatusCode = result.IsSuccessStatusCode,
                content = JsonConvert.DeserializeObject<Bill>(await result.Content.ReadAsStringAsync())
            });
        }
    }
}
