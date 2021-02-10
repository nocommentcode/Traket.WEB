using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Spendings.WEB.Services
{
    public class ApiClientService : IApiClientService
    {
        private readonly HttpClient _client;
        private readonly IAccountService _accountService;
        private readonly IConfiguration _config;

        public ApiClientService(HttpClient client,
            IConfiguration config,
            IAccountService accountService)
        {
            _accountService = accountService;
            _client = client;
            _config = config;
        }

        public async Task<HttpClient> GetClient(HttpContext context)
        {
            // if expired -> refresh
            try
            {
                var ticks = long.Parse(context.Session.GetString("valid_till"));
                var expiry = new DateTime(ticks, DateTimeKind.Utc);
                if (expiry < DateTime.UtcNow.AddMinutes(1))
                {
                    var accessToken = context.Session.GetString("access_token");
                    var refreshToken = context.Session.GetString("refresh_token");
                    var tokens = await _accountService.RefreshToken(accessToken, refreshToken);

                    context.Session.SetString("access_token", tokens.Token);
                    context.Session.SetString("valid_till", tokens.ValidTill.Ticks.ToString());
                }
            }
            catch   
            {
                // could not refresh -> try get from cookies
                await _accountService.GetTokenFromCookies(context);
            }


            // else set header
            var token = context.Session.GetString("access_token");
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            return _client;

        }


        public void RemoveSessionVars(HttpContext context)
        {
            context.Session.Remove("first_name");
            context.Session.Remove("last_name");
            context.Session.Remove("access_token");
            context.Session.Remove("refresh_token");
            context.Session.Remove("valid_till");

        }
    }
}


