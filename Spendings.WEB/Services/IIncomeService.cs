using Microsoft.AspNetCore.Http;
using Spendings.WEB.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Spendings.WEB.Services
{
    public interface IIncomeService
    {
        Task<HttpResponseMessage> CreateIncome(HttpContext context, Income income);
        Task<HttpResponseMessage> DeleteIncome(HttpContext context, long id);
        Task<List<Income>> GetIncomes(HttpContext context, DateTime? startDate, DateTime? endDate);
        Task<HttpResponseMessage> UpdateIncome(HttpContext context, Income income);
    }
}