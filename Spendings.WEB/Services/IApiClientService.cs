using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Threading.Tasks;

namespace Spendings.WEB.Services
{
    public interface IApiClientService
    {
        Task<HttpClient> GetClient(HttpContext context);
    }
}