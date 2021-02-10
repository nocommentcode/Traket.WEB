#pragma checksum "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00479569655fd16556e74ec7404242b8df103be8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Category\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00479569655fd16556e74ec7404242b8df103be8", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac500cc65326589653e5231efbfd220bff142d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Spendings.WEB.Services.Category>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Categories";

    var categoryList = Model.OrderBy(x => x.Total).Select(x => x.Name).ToList();
    var AmountList = Model.OrderBy(x => x.Total).Select(x => x.Total).ToList();
    var categoriesJson = JsonConvert.SerializeObject(categoryList);
    var AmountsJson = JsonConvert.SerializeObject(AmountList);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">

    <div class=""col-12 col-xl-6"">
        <div class=""card"">
            <div class=""card-header"">
                <h1 class=""h3 mb-3"">Categories</h1>

                <table>
                    <tbody>
                        <tr>
                            <td>
                                <button type=""button"" class=""btn btn-primary"" id=""monthly-category-btn"">Monthly</button>
                            </td>
                            <td>
                                <button type=""button"" class=""btn btn-primary"" id=""yearly-category-btn"">Yearly</button>
                            </td>
                            <td>
                                <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#category-create-modal"">Create</button>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>


            <div id=""category-error-message"" cla");
            WriteLiteral(@"ss=""alert alert-danger alert-dismissible"" role=""alert"">
                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
                <div class=""alert-message"" id=""category-error-message-field"">
                </div>
            </div>
            <table id=""category-table"" class=""table table-bordered"">
                <thead>
                    <tr>
                        <th style=""width:40%;"">Name</th>
                        <th style=""width:25%"">Total Amount</th>
                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 54 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Category\Index.cshtml"
                     foreach (var category in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("id", " id=\"", 2264, "\"", 2290, 2);
            WriteAttributeValue("", 2269, "category-", 2269, 9, true);
#nullable restore
#line 56 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Category\Index.cshtml"
WriteAttributeValue("", 2278, category.Id, 2278, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td>");
#nullable restore
#line 57 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Category\Index.cshtml"
                           Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>$");
#nullable restore
#line 58 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Category\Index.cshtml"
                            Write(decimal.Round(category.Total, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"table-action\">\r\n                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2509, "\"", 2569, 6);
            WriteAttributeValue("", 2519, "openEditCatModal(\'", 2519, 18, true);
#nullable restore
#line 60 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Category\Index.cshtml"
WriteAttributeValue("", 2537, category.Id, 2537, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2549, "\',", 2549, 2, true);
            WriteAttributeValue(" ", 2551, "\'", 2552, 2, true);
#nullable restore
#line 60 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Category\Index.cshtml"
WriteAttributeValue("", 2553, category.Name, 2553, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2567, "\')", 2567, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"align-middle\" data-feather=\"edit-2\"></i></a>\r\n                                <a");
            BeginWriteAttribute("onClick", " onClick=\"", 2661, "\"", 2701, 3);
            WriteAttributeValue("", 2671, "deleteCategory(\'", 2671, 16, true);
#nullable restore
#line 61 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Category\Index.cshtml"
WriteAttributeValue("", 2687, category.Id, 2687, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2699, "\')", 2699, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"align-middle\" data-feather=\"trash\"></i></a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Category\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </tbody>
            </table>
        </div>
    </div>

    <div class=""col-12 col-lg-6"">
        <div class=""card"" id=""graph-card"">
            <div class=""card-header"">
                <h1 class=""h3 mb-3"">Category Breakdown</h1>
            </div>
            <div class=""card-body"">
                <div class=""chart chart-lg"">
                    <canvas id=""chartjs-pie""></canvas>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""category-edit-modal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Edit Category</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body m-3""");
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00479569655fd16556e74ec7404242b8df103be810301", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label class=""form-label"">Name</label>
                        <input id=""modal-category-edit-name"" class=""form-control"">
                        <input id=""modal-category-edit-id"" class=""form-control"" type=""hidden"">

                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                <button id=""modal-edit-save-changes"" type=""button"" class=""btn btn-primary"">Save</button>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""category-create-modal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Create Category</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body m-3"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00479569655fd16556e74ec7404242b8df103be812800", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <label class=\"form-label\">Name</label>\r\n                        <input id=\"modal-category-create-name\" class=\"form-control\">\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                <button id=""modal-create-save-changes"" type=""button"" class=""btn btn-primary"">Save</button>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#category-tab\').addClass(\"active\");\r\n\r\n            $(\'#category-error-message-field\').hide();\r\n\r\n            var categories = JSON.parse(\'");
#nullable restore
#line 143 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Category\Index.cshtml"
                                    Write(Html.Raw(categoriesJson));

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n            var amounts = JSON.parse(\'");
#nullable restore
#line 144 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Category\Index.cshtml"
                                 Write(Html.Raw(AmountsJson));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"');

            console.log(categories);
            console.log(amounts);
            if (amounts.length != 0 && categories.length != 0) {
                $(function () {
                    // Pie chart
                    new Chart(document.getElementById(""chartjs-pie""), {
                        type: ""pie"",
                        data: {
                            labels: categories,
                            datasets: [{
                                data: amounts,
                                backgroundColor: palette('tol', amounts.length).map(function (hex) {
                                    return '#' + hex;
                                }),
                                borderColor: ""transparent""
                            }]
                        },
                        options: {
                            maintainAspectRatio: false,
                            legend: {
                                display: true
                            }
    ");
                WriteLiteral(@"                    }
                    });
                });
            } else {
                $('#graph-card').hide();
            }
        });

        $('#yearly-category-btn').click(function () {
            var d = new Date();
            d.setMonth(0);
            d.setDate(1);
            d.setHours(0);
            d.setMinutes(0);
            d.setSeconds(0);
            d.setMilliseconds(0);

            window.location.href = '/Category?startDate=' + d.toISOString();
        });

        $('#monthly-category-btn').click(function () {
            var d = new Date();

            d.setDate(1);
            d.setHours(0);
            d.setMinutes(0);
            d.setSeconds(0);
            d.setMilliseconds(0);
            window.location.href = '/Category?startDate=' + d.toISOString();
        });


        $('#modal-edit-save-changes').click(function () {
            var name = $('#modal-category-edit-name').val();
            var id = $('#modal-category-edi");
                WriteLiteral(@"t-id').val();

            var category = {
                name: name,
                id: id
            };

            $.post(""/update-category-ajax"", category, function (result) {
                if (result.isSuccessStatusCode) {
                    var childeren = $(""#category-"" + id).children();
                    childeren[0].innerHTML = name;
                }
                else {
                    console.log(result);
                    displayError(""Could not update Category "" + id + "" because an error occured ( "" + result.reasonPhrase + "" )"");
                }
            });

            $('#category-edit-modal').modal('hide');

        });

        $('#modal-create-save-changes').click(function () {
                var name = $('#modal-category-create-name').val();

                var category = {
                    name: name
                };

                $.post(""/create-category-ajax"", category, function (result) {
                    if (result.isS");
                WriteLiteral(@"uccessStatusCode) {
                        //$('#category-table tr:last').after(""<tr id=\""category-"" + result.content.Id +""\""><td>"" + result.content.Name + ""</td><td>$0.00</td><td class=\""table-action\""><a onclick=\""openEditCatModal('"" + result.content.Id + ""', '"" + result.content.Name + ""')\""><i class=\""align-middle\"" data-feather=\""edit-2\""></i></a><a onClick=\""deleteCategory('"" + result.content.Id+""')\""><i class=\""align-middle\"" data-feather=\""trash\""></i></a></td></tr>"");
                        $('#category-create-modal').modal('hide');
                        location.reload();
                    }
                    else {
                        displayError(""Could not create Category "" + id + "" because an error occured ( "" + result.reasonPhrase + "" )"");
                    }
                });
            });


        function openEditCatModal(id, name) {
            $('#modal-category-edit-name').val(name);
            $('#modal-category-edit-id').val(id);
            $('#categor");
                WriteLiteral(@"y-edit-modal').modal('show');

        }

        function deleteCategory(id) {
            $.post(""/delete-category-ajax?id="" + id, function (result) {
                console.log(result);
                if (result.isSuccessStatusCode) {
                    $(""#category-"" + id).remove();
                }
                else {
                    displayError(""Could not delete Category "" + id + "" because an error occured ( "" + result.reasonPhrase + "" )"");
                }
            });
        }

        function displayError(message) {
            $('#category-error-message-field').innerHTML = message;
            $('#category-error-message-field').text(message);
            $('#category-error-message-field').show();
        }

    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Spendings.WEB.Services.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
