using System;

namespace Spendings.WEB.Services
{
    public class LoginResultVm
    {
        public string Token { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RefreshToken { get; set; }
        public DateTime ValidTill { get; set; }

    }
}
