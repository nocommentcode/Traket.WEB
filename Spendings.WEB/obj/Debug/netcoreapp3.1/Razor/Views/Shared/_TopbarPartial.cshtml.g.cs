#pragma checksum "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Shared\_TopbarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8384ffa7ae29894f42dc59a45284c37b92c4916"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TopbarPartial), @"mvc.1.0.view", @"/Views/Shared/_TopbarPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\_ViewImports.cshtml"
using Spendings.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\_ViewImports.cshtml"
using Spendings.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8384ffa7ae29894f42dc59a45284c37b92c4916", @"/Views/Shared/_TopbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac500cc65326589653e5231efbfd220bff142d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TopbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Shared\_TopbarPartial.cshtml"
  
    byte[] firstNamebytes = null;
    byte[] lastNameBytes = null;
    string firstName = "";
    string lastName = "";
    var isLoggedIn = Context.Session.TryGetValue("first_name", out firstNamebytes) && Context.Session.TryGetValue("last_name", out lastNameBytes);
    if (isLoggedIn) {
        firstName = System.Text.Encoding.UTF8.GetString(firstNamebytes);
        lastName = System.Text.Encoding.UTF8.GetString(lastNameBytes);
    }


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<nav class=""navbar navbar-expand navbar-light navbar-bg"">
    <a class=""sidebar-toggle d-flex"">
        <i class=""hamburger align-self-center""></i>
    </a>


    <div class=""navbar-collapse collapse"">

        <ul class=""navbar-nav navbar-align"">
");
#nullable restore
#line 23 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Shared\_TopbarPartial.cshtml"
             if (isLoggedIn)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li class=""nav-item dropdown"">
                    <a class=""nav-icon dropdown-toggle d-inline-block d-sm-none"" href=""#"" data-toggle=""dropdown"">
                        <i class=""align-middle"" data-feather=""plus""></i>
                    </a>

                    <a class=""nav-link dropdown-toggle d-none d-sm-inline-block"" href=""#"" data-toggle=""dropdown"">
                        <i class=""align-middle"" data-feather=""plus""></i>
                    </a>

                    <div class=""dropdown-menu dropdown-menu-right"">
                        <a class=""dropdown-item"" href=""/Expense?isCreateScreen=true""><i class=""align-middle mr-1"" data-feather=""credit-card""></i> Expense</a>
                        <div class=""dropdown-divider""></div>
                    </div>
                </li>
                <li class=""nav-item dropdown"">
                    <a class=""nav-icon dropdown-toggle d-inline-block d-sm-none"" href=""#"" data-toggle=""dropdown"">
                        <i class=""alig");
            WriteLiteral("n-middle\" data-feather=\"settings\"></i>\r\n                    </a>\r\n\r\n                    <a class=\"nav-link dropdown-toggle d-none d-sm-inline-block\" href=\"#\" data-toggle=\"dropdown\">\r\n                        <span class=\"text-dark\">");
#nullable restore
#line 45 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Shared\_TopbarPartial.cshtml"
                                           Write(firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 45 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Shared\_TopbarPartial.cshtml"
                                                      Write(lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"">
                        <a class=""dropdown-item"" href=""pages-profile.html""><i class=""align-middle mr-1"" data-feather=""user""></i> Profile</a>
                        <div class=""dropdown-divider""></div>
                        <a class=""dropdown-item"" href=""/Account/Logoff"">Log out</a>
                    </div>
                </li>
");
#nullable restore
#line 53 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Shared\_TopbarPartial.cshtml"

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <li class=""nav-item dropdown"">
                    <a class=""nav-icon dropdown-toggle d-inline-block d-sm-none"" href=""#"" data-toggle=""dropdown"">
                        <i class=""align-middle"" data-feather=""settings""></i>
                    </a>

                    <a class=""nav-link dropdown-toggle d-none d-sm-inline-block"" href=""#"" data-toggle=""dropdown"">
                        <span class=""text-dark"">Account</span>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"">
                        <a class=""dropdown-item"" href=""/Account/LoginRegister""><i class=""align-middle mr-1"" data-feather=""user""></i> Log In</a>
                        <div class=""dropdown-divider""></div>
                    </div>
                </li>
");
#nullable restore
#line 70 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Shared\_TopbarPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n</nav>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
