using Microsoft.AspNetCore.Http;
using Spendings.WEB.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Spendings.WEB.Services
{
    public interface IExpenseService
    {
        Task<HttpResponseMessage> CreateExpense(HttpContext context, Expense expense);
        Task<HttpResponseMessage> DeleteExpense(HttpContext context, long id);
        Task<List<Expense>> GetExpenses(HttpContext context, System.DateTime? startDate, System.DateTime? endDate);
        Task<HttpResponseMessage> UpdateExpense(HttpContext context, Expense expense);
        Task<List<string>> ImportExpenses(HttpContext httpContext, IFormFile file);
        Task<ExpensesQuickInfo> GetQuickInfo(HttpContext context);
        Task<GraphVm> GetGraph(HttpContext httpContext);
        Task<List<MonthlySummary>> GetMonthlySummary(HttpContext context);
    }
}