using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Spendings.WEB.Models;
using Spendings.WEB.Services;
using static Spendings.WEB.Services.AccountService;

namespace Spendings.WEB.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult LoginRegister(string returnUrl=null)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login (RegisterLoginVm vm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var loginresult = await _accountService.LoginAsync(vm.Login);
                    if (vm.Login.RememberMe)
                    {
                         _accountService.SetTokenCookies(HttpContext, new RefreshTokenModel() { Token = loginresult.Token, RefreshToken = loginresult.RefreshToken });
                    }


                    HttpContext.Session.SetString("first_name", loginresult.FirstName);
                    HttpContext.Session.SetString("last_name", loginresult.LastName);
                    HttpContext.Session.SetString("access_token", loginresult.Token);
                    HttpContext.Session.SetString("refresh_token", loginresult.RefreshToken);
                    HttpContext.Session.SetString("valid_till", loginresult.ValidTill.Ticks.ToString());

                    if (vm.ReturnUrl != null)
                    {
                        return Redirect(vm.ReturnUrl);
                    }
                    else
                    {
                        return Redirect("/");

                    }
                }
                catch (Exception e)
                {
                    vm.LoginError =  e.Message;
                    return View("LoginRegister", vm);
                }
            }
            else
            {
                return View("LoginRegister", vm);
            }
           
        }

        [HttpGet]   
        public IActionResult Logoff()
        {
            _accountService.RemoveTokenCookies(HttpContext);

            return RedirectToAction("Index", "Home", new { });


        }



        [HttpPost]
        public async Task<IActionResult> Register(RegisterLoginVm vm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var registerResult = await _accountService.RegisterAsync(vm.Register);

                    HttpContext.Session.SetString("first_name", registerResult.FirstName);
                    HttpContext.Session.SetString("last_name", registerResult.LastName);
                    HttpContext.Session.SetString("access_token", registerResult.Token);
                    HttpContext.Session.SetString("refresh_token", registerResult.RefreshToken);
                    HttpContext.Session.SetString("valid_till", registerResult.ValidTill.Ticks.ToString());

                    return RedirectToAction("Index", "Home", new { });

                }
                catch (Exception e)
                {
                    vm.RegisterError = e.Message;
                    return View("LoginRegister", vm);
                }
            }
            else
            {
                return View("LoginRegister", vm);
            }
        }
    }
}
