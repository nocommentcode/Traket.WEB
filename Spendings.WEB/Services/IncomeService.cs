using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Spendings.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Spendings.WEB.Services
{
    public class IncomeService : IIncomeService
    {
        private readonly IConfiguration _config;
        private readonly IApiClientService _apiClientService;

        public IncomeService(IConfiguration config,
            IApiClientService apiClientService)
        {
            _apiClientService = apiClientService;
            _config = config;
        }

        public async Task<HttpResponseMessage> DeleteIncome(HttpContext context, long id)
        {
            var client = await _apiClientService.GetClient(context);
            var url = $"{_config.GetValue<string>("Api:Url")}/api/income/delete/{id}";
            var response = await client.DeleteAsync(url);

            if ((int)response.StatusCode == 401)
            {
                throw new UnauthorizedAccessException();
            }

            return response;
        }

        public async Task<HttpResponseMessage> UpdateIncome(HttpContext context, Income income)
        {
            var client = await _apiClientService.GetClient(context);
            var url = $"{_config.GetValue<string>("Api:Url")}/api/income/edit";
            var content = new StringContent(JsonConvert.SerializeObject(income), Encoding.UTF8, "application/json");

            var response = await client.PutAsync(url, content);

            if ((int)response.StatusCode == 401)
            {
                throw new UnauthorizedAccessException();
            }

            return response;
        }
        public async Task<HttpResponseMessage> CreateIncome(HttpContext context, Income income)
        {
            var client = await _apiClientService.GetClient(context);
            var url = $"{_config.GetValue<string>("Api:Url")}/api/income/create";
            var content = new StringContent(JsonConvert.SerializeObject(income), Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);

            if ((int)response.StatusCode == 401)
            {
                throw new UnauthorizedAccessException();
            }

            return response;
        }

        public async Task<List<Income>> GetIncomes(HttpContext context, DateTime? startDate, DateTime? endDate)
        {
            var client = await _apiClientService.GetClient(context);
            var url = $"{_config.GetValue<string>("Api:Url")}/api/income/list";

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

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<Income>>(await response.Content.ReadAsStringAsync());
            }
            else if ((int)response.StatusCode == 401)
            {

                throw new UnauthorizedAccessException($"{await response.Content.ReadAsStringAsync()}");
            }
            else
            {
                return new List<Income>();
            }
        }
    }
}
