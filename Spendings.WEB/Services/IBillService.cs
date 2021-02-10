using Microsoft.AspNetCore.Http;
using Spendings.WEB.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Spendings.WEB.Services
{
    public interface IBillService
    {
        Task<HttpResponseMessage> CreateBill(HttpContext context, Bill bill);
        Task<HttpResponseMessage> DeleteBill(HttpContext context, long id);
        Task<List<Bill>> GetBills(HttpContext context);
        Task<HttpResponseMessage> UpdateBill(HttpContext context, Bill bill);
    }
}