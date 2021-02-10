using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Spendings.WEB.Controllers;
using Spendings.WEB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Spendings.WEB.Services
{
    public class AccountService : IAccountService
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _config;

        public AccountService(HttpClient client,
            IConfiguration config)
        {
            _config = config;
            _client = client;
        }

        public async Task<LoginResultVm> LoginAsync(LoginVm vm)
        {
            var url = $"{_config.GetValue<string>("Api:Url")}/api/token/create?includeRefreshToken=true";
            var content = new StringContent(JsonConvert.SerializeObject(vm), Encoding.UTF8, "application/json");

            var response = await _client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<LoginResultVm>(responseString);

                return result;
            }
            else
            {
                if ((int)response.StatusCode >= 500)
                {
                    throw new Exception("Internal Error");
                }
                else
                {
                    throw new Exception($"Invalid login Attempt - {await response.Content.ReadAsStringAsync()}");
                }

            }
        }


        public async Task<LoginResultVm> RefreshToken(string token, string refreshToken)
        {
            var url = $"{_config.GetValue<string>("Api:Url")}/api/token/refresh";
            var model = new RefreshTokenModel() { Token = token, RefreshToken = refreshToken };
            var content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            var response = await _client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<LoginResultVm>(responseString);

                return result;
            }
            else
            {
                throw new Exception("could not refresh token");
            }

        }

        public async Task GetTokenFromCookies(HttpContext context)
        {
            try
            {
                var at_cookieExists = context.Request.Cookies.TryGetValue("_Tracket_App_AT", out string at_cookie);
                var rt_cookieExists = context.Request.Cookies.TryGetValue("_Tracket_App_RT", out string rt_cookie);
                if (at_cookieExists && rt_cookieExists)
                {
                    var tokens = await RefreshToken(at_cookie, rt_cookie);

                    SetTokenCookies(context, new RefreshTokenModel() { Token = tokens.Token, RefreshToken = rt_cookie });

                    context.Session.SetString("access_token", tokens.Token);
                    context.Session.SetString("valid_till", tokens.ValidTill.Ticks.ToString());
                    context.Session.SetString("first_name", tokens.FirstName);
                    context.Session.SetString("last_name", tokens.LastName);
                    context.Session.SetString("refresh_token", rt_cookie);

                }
                else
                {
                    throw new UnauthorizedAccessException($"Error refreshing - cookies dont exist");
                }
            }
            catch (Exception e)
            {
                context.Session.Remove("first_name");
                context.Session.Remove("last_name");
                context.Session.Remove("access_token");
                context.Session.Remove("refresh_token");
                context.Session.Remove("valid_till");

                throw new UnauthorizedAccessException($"Error refreshing - {e.Message}");
            }
        }

        public void SetTokenCookies(HttpContext context, RefreshTokenModel model)
        {
            var cookieOptions = new CookieOptions
            {
                Secure = false,
                HttpOnly = true,
                SameSite = SameSiteMode.Strict,
                Expires = DateTime.UtcNow.AddDays(7)
            };

            // Add the cookie to the response cookie collection
            context.Response.Cookies.Append("_Tracket_App_RT", model.RefreshToken, cookieOptions);
            context.Response.Cookies.Append("_Tracket_App_AT", model.Token, cookieOptions);
        }

        public void RemoveTokenCookies(HttpContext context)
        {
            try
            {
                context.Response.Cookies.Delete("_Tracket_App_RT");
                context.Response.Cookies.Delete("_Tracket_App_AT");
            }
            catch
            {
                // cookies do not exit -> return
            }
            context.Session.Remove("first_name");
            context.Session.Remove("last_name");
            context.Session.Remove("access_token");
            context.Session.Remove("refresh_token");
            context.Session.Remove("valid_till");
        }

        public async Task<LoginResultVm> RegisterAsync(RegisterVm vm)
        {
            vm.UserGuid = new Guid();

            var url = $"{_config.GetValue<string>("Api:Url")}/api/user/register";
            var content = new StringContent(JsonConvert.SerializeObject(vm), Encoding.UTF8, "application/json");

            var response = await _client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<LoginResultVm>(responseString);
                return result;
            }
            else
            {
                if ((int)response.StatusCode >= 500)
                {
                    throw new Exception($"Internal Error - {await response.Content.ReadAsStringAsync()}");
                }
                else
                {
                    throw new Exception($"Invalid register Attempt - {await response.Content.ReadAsStringAsync()}");
                }

            }
        }
        public class RefreshTokenModel
        {
            [Required(ErrorMessage = "The {0} field is required.")]
            public string Token { get; set; }

            [Required(ErrorMessage = "The {0} field is required.")]
            public string RefreshToken { get; set; }
        }


    }
}
