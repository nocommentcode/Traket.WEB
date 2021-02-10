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
    public class BillService : IBillService
    {
        private readonly IConfiguration _config;
        private readonly IApiClientService _apiClientService;

        public BillService(IConfiguration config,
            IApiClientService apiClientService)
        {
            _apiClientService = apiClientService;
            _config = config;
        }

        public async Task<HttpResponseMessage> DeleteBill(HttpContext context, long id)
        {
            var client = await _apiClientService.GetClient(context);
            var url = $"{_config.GetValue<string>("Api:Url")}/api/bill/delete/{id}";
            var response = await client.DeleteAsync(url);

            if ((int)response.StatusCode == 401)
            {
                throw new UnauthorizedAccessException();
            }

            return response;
        }

        public async Task<HttpResponseMessage> UpdateBill(HttpContext context, Bill bill)
        {
            var client = await _apiClientService.GetClient(context);
            var url = $"{_config.GetValue<string>("Api:Url")}/api/bill/edit";
            var content = new StringContent(JsonConvert.SerializeObject(bill), Encoding.UTF8, "application/json");

            var response = await client.PutAsync(url, content);

            if ((int)response.StatusCode == 401)
            {
                throw new UnauthorizedAccessException();
            }

            return response;
        }
        public async Task<HttpResponseMessage> CreateBill(HttpContext context, Bill bill)
        {
            var client = await _apiClientService.GetClient(context);
            var url = $"{_config.GetValue<string>("Api:Url")}/api/bill/create";
            var content = new StringContent(JsonConvert.SerializeObject(bill), Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);

            if ((int)response.StatusCode == 401)
            {
                throw new UnauthorizedAccessException();
            }

            return response;
        }

        public async Task<List<Bill>> GetBills(HttpContext context)
        {
            var client = await _apiClientService.GetClient(context);
            var url = $"{_config.GetValue<string>("Api:Url")}/api/bill/list";

            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<List<Bill>>(await response.Content.ReadAsStringAsync());
            }
            else if ((int)response.StatusCode == 401)
            {

                throw new UnauthorizedAccessException($"{await response.Content.ReadAsStringAsync()}");
            }
            else
            {
                return new List<Bill>();
            }
        }
    }
}
