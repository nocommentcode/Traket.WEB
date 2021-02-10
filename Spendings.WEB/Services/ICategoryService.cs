using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Spendings.WEB.Services
{
    public interface ICategoryService
    {
        Task<HttpResponseMessage> CreateCategory(HttpContext context, Category category);
        Task<HttpResponseMessage> DeleteCategory(HttpContext context, long id);
        Task<List<Category>> GetCategories(HttpContext context, System.DateTime? startDate, System.DateTime? endDate);
        Task<HttpResponseMessage> updateCategory(HttpContext context, Category category);
    }
}