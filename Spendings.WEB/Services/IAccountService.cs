using Microsoft.AspNetCore.Http;
using Spendings.WEB.Controllers;
using Spendings.WEB.Models;
using System.Threading.Tasks;

namespace Spendings.WEB.Services
{
    public interface IAccountService
    {
        Task GetTokenFromCookies(HttpContext context);
        Task<LoginResultVm> LoginAsync(LoginVm vm);
        Task<LoginResultVm> RefreshToken(string token, string refreshToken);
        Task<LoginResultVm> RegisterAsync(RegisterVm vm);
        void RemoveTokenCookies(HttpContext context);
        void SetTokenCookies(HttpContext context, AccountService.RefreshTokenModel model);
    }
}