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
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ICategoryService _cat;

        public CategoryController(ILogger<CategoryController> logger, ICategoryService cat)
        {
            _cat = cat;
            _logger = logger;
        }

        public async Task<IActionResult> Index(DateTime? startDate = null, DateTime? endDate = null)
        {
            try
            {
                var categories = await _cat.GetCategories(HttpContext, startDate, endDate);
                return View(categories);

            }
            catch (UnauthorizedAccessException e )
            {
                return RedirectToAction("LoginRegister", "Account", new { returnUrl = "/Category" });
            }
        }

        [HttpPost("/delete-category-ajax")]
        public async Task<IActionResult> DeleteCategoryAjax(long id)
        {
            var result = await _cat.DeleteCategory(HttpContext, id);
            return Ok(result);
        }

        [HttpPost("/update-category-ajax")]
        public async Task<IActionResult> UpdateCategoryAjax(Category category)
        {

            var result = await _cat.updateCategory(HttpContext, category);
            return Ok(result);
        }

        [HttpPost("/create-category-ajax")]
        public async Task<IActionResult> CreateCategoryAjax(Category category)
        {
            var result = await _cat.CreateCategory(HttpContext, category);

            return Json(new
            {
                isSuccessStatusCode = result.IsSuccessStatusCode,
                content = JsonConvert.DeserializeObject<Category>(await result.Content.ReadAsStringAsync())
            });
        }
    }
}
