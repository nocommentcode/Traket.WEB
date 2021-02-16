using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Spendings.WEB.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Spendings.WEB.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IConfiguration _config;
        private readonly IApiClientService _apiClientService;

        public ExpenseService(IConfiguration config,
            IApiClientService apiClientService)
        {
            _apiClientService = apiClientService;
            _config = config;
        }

        public async Task<HttpResponseMessage> DeleteExpense(HttpContext context, long id)
        {
            var client = await _apiClientService.GetClient(context);
            var url = $"{_config.GetValue<string>("Api:Url")}/delete-expense/{id}";
            var response = await client.DeleteAsync(url);

            return await HandleResponce(response);

        }

        public async Task<HttpResponseMessage> UpdateExpense(HttpContext context, Expense expense)
        {
            var client = await _apiClientService.GetClient(context);
            var url = $"{_config.GetValue<string>("Api:Url")}/edit-expense";
            var content = new StringContent(JsonConvert.SerializeObject(expense), Encoding.UTF8, "application/json");

            var response = await client.PutAsync(url, content);

            return await HandleResponce(response);

        }
        public async Task<HttpResponseMessage> CreateExpense(HttpContext context, Expense expense)
        {
            var client = await _apiClientService.GetClient(context);
            var url = $"{_config.GetValue<string>("Api:Url")}/new-expense";
            var content = new StringContent(JsonConvert.SerializeObject(expense), Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);

            return await HandleResponce(response);
        }

        public async Task<List<DashboardInfo>> GetQuickInfo(HttpContext context)
        {
            var client = await _apiClientService.GetClient(context);
            var url = $"{_config.GetValue<string>("Api:Url")}/expenses/expense-quick-info";
            var response = await client.GetAsync(url);

            return await HandleResponce<List<DashboardInfo>>(response);

        }

        public async Task<List<MonthlySummary>> GetMonthlySummary(HttpContext context)
        {
            var client = await _apiClientService.GetClient(context);
            var url = $"{_config.GetValue<string>("Api:Url")}/monthly-summary";
            var response = await client.GetAsync(url);

            return await HandleResponce<List<MonthlySummary>>(response);
        }

        public async Task<List<Expense>> GetExpenses(HttpContext context, DateTime? startDate, DateTime? endDate)
            {
            var client = await _apiClientService.GetClient(context);
            var url = $"{_config.GetValue<string>("Api:Url")}/list-expenses";
            if (startDate.HasValue)
            {
                url = $"{url}?startDate={startDate.Value.ToString("yyyy-MM-ddTHH:mm:ss")}";
            }
            if (endDate.HasValue && !startDate.HasValue)
            {
                url = $"{url}?endDate={endDate.Value.ToString("yyyy-MM-ddTHH:mm:ss")}";
            }
            else if (endDate.HasValue)
            {
                url = $"{url}&endDate={endDate.Value.ToString("yyyy-MM-ddTHH:mm:ss")}";
            }

            var response = await client.GetAsync(url);

            return await HandleResponce<List<Expense>>(response);
        }

        public async Task<List<string>> ImportExpenses(HttpContext httpContext, IFormFile file)
        {
            var client = await _apiClientService.GetClient(httpContext);
            var url = $"{_config.GetValue<string>("Api:Url")}/import-expenses";

            byte[] data;
            using (var br = new BinaryReader(file.OpenReadStream()))
            {
                data = br.ReadBytes((int)file.OpenReadStream().Length);
            }
            ByteArrayContent bytes = new ByteArrayContent(data);
            MultipartFormDataContent multiContent = new MultipartFormDataContent();
            multiContent.Add(bytes, "file", file.FileName);

            var response = await client.PostAsync(url, multiContent);

            return await HandleResponce<List<string>>(response);
        }

        private async Task<T> HandleResponce<T>(HttpResponseMessage response) where T: new()
        {
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync());
            }
            else if ((int)response.StatusCode == 401)
            {

                throw new UnauthorizedAccessException($"{await response.Content.ReadAsStringAsync()}");
            }
            else
            {
                var error = await response.Content.ReadAsStringAsync();
                return new T();
            }
        }

        private async Task<HttpResponseMessage> HandleResponce(HttpResponseMessage response)
        {
            if ((int)response.StatusCode == 401)
            {

                throw new UnauthorizedAccessException($"{await response.Content.ReadAsStringAsync()}");
            }
            else
            {
                return response;
            }
        }

        public async Task<GraphVm> GetGraph(HttpContext httpContext)
        {
            var client = await _apiClientService.GetClient(httpContext);
            var url = $"{_config.GetValue<string>("Api:Url")}/expense-graph";
            var response = await client.GetAsync(url);

            return await HandleResponce<GraphVm>(response);
        }
    }
    public class DashboardInfo
    {
        public string Title { get; set; }
        public string comparisonText { get; set; }
        public decimal CurrentValue { get; set; }
        public decimal ComparisonValue { get; set; }
    }
    public class GraphSeries
    {
        public List<int> Days { get; set; } = new List<int>();
        public List<decimal> Data { get; set; } = new List<decimal>();
    }

    public class GraphVm
    {
        public List<int> Days { get; set; } = new List<int>();
        public List<decimal> Actual { get; set; } = new List<decimal>();
        public List<decimal> Predicted { get; set; } = new List<decimal>();
    }

}
