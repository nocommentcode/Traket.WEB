#pragma checksum "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Bill\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "814957a51c1e47f8547efff4ffe078a94233e7d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bill_Index), @"mvc.1.0.view", @"/Views/Bill/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"814957a51c1e47f8547efff4ffe078a94233e7d1", @"/Views/Bill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac500cc65326589653e5231efbfd220bff142d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Bill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Spendings.WEB.Models.Bill>>
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
#nullable restore
#line 2 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Bill\Index.cshtml"
  
    ViewData["Title"] = "Bills";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">

    <div class=""col-12 col-xl-6"">
        <div class=""card"">
            <div class=""card-header"">
                <h1 class=""h3 mb-3"">Bills</h1>
                <table>
                    <tbody>
                        <tr>
                            <td>
                                <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" id=""create-bill-btn"" data-target=""#bill-create-modal"">Create </button>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>


            <div id=""bill-error-message"" class=""alert alert-danger alert-dismissible"" role=""alert"">
                <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
                <div class=""alert-message"" id=""bill-error-message-field"">
                </div>
            </div>
            <table id");
            WriteLiteral(@"=""bill-table"" class=""table table-bordered"">
                <thead>
                    <tr>
                        <th style=""width:30%;"">Billing Start</th>
                        <th style=""width:30%;"">Billing End</th>
                        <th style=""width:30%"">Amount</th>
                        <th style=""width:30%"">Name</th>
                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 42 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Bill\Index.cshtml"
                     foreach (var bill in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("id", " id=\"", 1669, "\"", 1687, 2);
            WriteAttributeValue("", 1674, "bill-", 1674, 5, true);
#nullable restore
#line 44 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Bill\Index.cshtml"
WriteAttributeValue("", 1679, bill.Id, 1679, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td>");
#nullable restore
#line 45 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Bill\Index.cshtml"
                           Write(bill.BillingStart.ToString("dd-MM-yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 46 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Bill\Index.cshtml"
                            Write(bill.BillingEnd.HasValue ? bill.BillingEnd.Value.ToString("dd-MM-yy") : "Ongoing");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>$");
#nullable restore
#line 47 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Bill\Index.cshtml"
                            Write(decimal.Round(bill.Amount,2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 48 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Bill\Index.cshtml"
                           Write(bill.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"table-action\">\r\n                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2099, "\"", 2351, 18);
            WriteAttributeValue("", 2109, "openEditbillModal(\'", 2109, 19, true);
#nullable restore
#line 50 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Bill\Index.cshtml"
WriteAttributeValue("", 2128, bill.Id, 2128, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2136, "\',", 2136, 2, true);
            WriteAttributeValue(" ", 2138, "\'", 2139, 2, true);
#nullable restore
#line 50 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Bill\Index.cshtml"
WriteAttributeValue("", 2140, decimal.Round(bill.Amount,2), 2140, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2169, "\',", 2169, 2, true);
            WriteAttributeValue(" ", 2171, "\'", 2172, 2, true);
#nullable restore
#line 50 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Bill\Index.cshtml"
WriteAttributeValue("", 2173, bill.BillingStart.ToString("yyyy-MM-ddTHH:mm"), 2173, 47, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2220, "\',", 2220, 2, true);
            WriteAttributeValue(" ", 2222, "\'", 2223, 2, true);
#nullable restore
#line 50 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Bill\Index.cshtml"
WriteAttributeValue("", 2224, bill.BillingEnd.HasValue? bill.BillingEnd.Value.ToString("yyyy-MM-ddTHH:mm") : "", 2224, 84, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2308, "\',", 2308, 2, true);
            WriteAttributeValue(" ", 2310, "\'", 2311, 2, true);
#nullable restore
#line 50 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Bill\Index.cshtml"
WriteAttributeValue("", 2312, bill.Name, 2312, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2322, "\',", 2322, 2, true);
            WriteAttributeValue(" ", 2324, "\'", 2325, 2, true);
#nullable restore
#line 50 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Bill\Index.cshtml"
WriteAttributeValue("", 2326, bill.DayOfMonthDebited, 2326, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2349, "\')", 2349, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"align-middle\" data-feather=\"edit-2\"></i></a>\r\n                                <a");
            BeginWriteAttribute("onClick", " onClick=\"", 2443, "\"", 2475, 3);
            WriteAttributeValue("", 2453, "deletebill(\'", 2453, 12, true);
#nullable restore
#line 51 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Bill\Index.cshtml"
WriteAttributeValue("", 2465, bill.Id, 2465, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2473, "\')", 2473, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"align-middle\" data-feather=\"trash\"></i></a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 54 "C:\Users\Malo Hamon\source\repos\Spendings.WEB\Spendings.WEB\Views\Bill\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </tbody>
            </table>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""bill-edit-modal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Edit bill</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body m-3"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "814957a51c1e47f8547efff4ffe078a94233e7d111183", async() => {
                WriteLiteral(@"
                    <input id=""modal-bill-edit-id"" type=""hidden"">
                    <div class=""form-group"">
                        <label class=""form-label"">Billing Start</label>
                        <input id=""modal-bill-edit-start-date"" class=""form-control"" type=""datetime-local"">
                    </div>


                    <div class=""form-group"">
                        <label class=""form-label"">Billing End</label>
                        <input type=""checkbox"" id=""bill-edit-billing-ongoing"" name=""edit-billing-ongoing"" value=""true"">
                        <label for=""bill-edit-billing-ongoing""> Billing ongoing?</label>
                        <br />
                        <input id=""modal-bill-edit-end-date"" class=""form-control"" type=""datetime-local"">
                    </div>

                    <div class=""form-group"">
                        <label class=""form-label"">Amount</label>
                        <input id=""modal-bill-edit-amount"" class=""form-control"" type=""nu");
                WriteLiteral(@"mber"">
                    </div>
                    <div class=""form-group"">
                        <label class=""form-label"">Day Of Month Debited</label>
                        <input id=""modal-bill-edit-dayOfMonth"" class=""form-control"" type=""number"">
                    </div>
                    <div class=""form-group"">
                        <label class=""form-label"">Name</label>
                        <input id=""modal-bill-edit-name"" class=""form-control"" type=""text"">
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

<div class=""modal fade"" id=""bill-create-modal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Create bill</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body m-3"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "814957a51c1e47f8547efff4ffe078a94233e7d114982", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label class=""form-label"">Billing Start</label>
                        <input id=""modal-bill-create-start-date"" class=""form-control"" type=""datetime-local"">
                    </div>
                    <div class=""form-group"">
                        <label class=""form-label"">Billing End</label>
                        <input type=""checkbox"" id=""bill-create-billing-ongoing"" name=""create-billing-ongoing"" value=""true"">
                        <label for=""bill-create-billing-ongoing""> Billing ongoing?</label>
                        <br />
                        <input id=""modal-bill-create-end-date"" class=""form-control"" type=""datetime-local"">
                    </div>
                    <div class=""form-group"">
                        <label class=""form-label"">Amount</label>
                        <input id=""modal-bill-create-amount"" class=""form-control"" type=""number"">
                    </div>
                    <div ");
                WriteLiteral(@"class=""form-group"">
                        <label class=""form-label"">Day Of Month Debited</label>
                        <input id=""modal-bill-create-dayOfMonth"" class=""form-control"" type=""number"">
                    </div>

                    <div class=""form-group"">
                        <label class=""form-label"">Name</label>
                        <input id=""modal-bill-create-name"" class=""form-control"" type=""text"">
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
                <button id=""modal-create-save-changes"" type=""button"" class=""btn btn-primary"">Save</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#bill-tab').addClass(""active"");

            $('#bill-error-message-field').hide();

        });

       
        $('#modal-edit-save-changes').click(function () {

            var name = $('#modal-bill-edit-name').val();
            var amount = $('#modal-bill-edit-amount').val();
            var startDate = new Date($('#modal-bill-edit-start-date').val());
            var endDate = new Date($('#modal-bill-edit-end-date').val());
            var isOngoing = $('#bill-edit-billing-ongoing').prop('checked');
            var id = $('#modal-bill-edit-id').val();
            var dayOfMonth = $('#modal-bill-edit-dayOfMonth').val();

            var bill = {
                name: name,
                id: id,
                amount: amount,
                billingStart: startDate.toISOString(),
                dayOfMonthDebited: dayOfMonth
            };

            if (!isOngoing) {
                bill.billingEnd = e");
                WriteLiteral(@"ndDate.toISOString()
            };

            console.log(bill);

            $.post(""/update-bill-ajax"", bill, function (result) {
                if (result.isSuccessStatusCode) {
                    var childeren = $(""#bill-"" + id).children();
                    var day = (""0"" + date.getDate()).slice(-2);
                    var month = (""0"" + (date.getMonth() + 1)).slice(-2);
                    childeren[0].innerHTML = day + '-' + month + '-' + date.getFullYear().toString().substring(2);
                    childeren[1].innerHTML = '$' + amount.toString();
                    childeren[2].innerHTML = employer;
                }
                else {
                    console.log(result);
                    displayError(""Could not update bill "" + id + "" because an error occured ( "" + result.reasonPhrase + "" )"");
                }
            });

            $('#bill-edit-modal').modal('hide');

        });

        $('#create-bill-btn').click(function () {

            v");
                WriteLiteral(@"ar date = new Date();
            var day = (""0"" + date.getDate()).slice(-2);
            var month = (""0"" + (date.getMonth() + 1)).slice(-2);
            var hour = (""0"" + (date.getHours())).slice(-2);
            var minute = (""0"" + (date.getMinutes())).slice(-2);
            var dateString = date.getFullYear() + ""-"" + month + ""-"" + day + ""T"" + hour + "":"" + minute
            console.log(dateString);
            $('#modal-bill-create-start-date').val(dateString);
            $('#bill-create-billing-ongoing').prop('checked', true);
            $('#modal-bill-create-end-date').hide();

            $('#bill-create-billing-ongoing').click(function () {
                if ($(this).prop('checked')) {
                    $('#modal-bill-create-end-date').hide();

                } else {
                    $('#modal-bill-create-end-date').show();
                }
            });

        });

        $('#modal-create-save-changes').click(function () {
            var name = $('#modal-bill-c");
                WriteLiteral(@"reate-name').val();
            var amount = $('#modal-bill-create-amount').val();
            var startDate = new Date($('#modal-bill-create-start-date').val());
            var endDate = new Date($('#modal-bill-create-end-date').val());
            var isOngoing = $('#bill-create-billing-ongoing').prop('checked');
            var dayOfMonth = $('#modal-bill-create-dayOfMonth').val();

            var bill = {
                name: name,
                amount: amount,
                billingStart: startDate.toISOString(),
                dayOfMonthDebited: dayOfMonth
            };

            if (!isOngoing) {
                bill.billingEnd = endDate.toISOString()
            };

            console.log(bill);

            $.post(""/create-bill-ajax"", bill, function (result) {
                    if (result.isSuccessStatusCode) {
                        $('#bill-create-modal').modal('hide');
                        location.reload();
                    }
                    else ");
                WriteLiteral(@"{
                        displayError(""Could not create bill "" + id + "" because an error occured ( "" + result.reasonPhrase + "" )"");
                    }
                });
            });


        function openEditbillModal(id, amount, startDate, endDate, name, dayOfMonth) {
            $('#modal-bill-edit-id').val(id);
            $('#modal-bill-edit-amount').val(amount);
            $('#modal-bill-edit-name').val(name);
            $('#modal-bill-edit-start-date').val(startDate);
            $('#modal-bill-edit-dayOfMonth').val(dayOfMonth);

            if (endDate == '') {
                $('#bill-edit-billing-ongoing').prop('checked', true);
                $('#modal-bill-edit-end-date').hide();
            } else {
                $('#bill-edit-billing-ongoing').prop('checked', false);
                $('#modal-bill-edit-end-date').val(endDate);
                $('#modal-bill-edit-end-date').show();
            }
            $('#bill-edit-billing-ongoing').click(function () {
 ");
                WriteLiteral(@"               if ($(this).prop('checked')) {
                    $('#modal-bill-edit-end-date').hide();

                } else {
                    $('#modal-bill-edit-end-date').show();
                }
            });

            $('#bill-edit-modal').modal('show');

        }

        function deletebill(id) {
            $.post(""/delete-bill-ajax?id="" + id, function (result) {
                console.log(result);
                if (result.isSuccessStatusCode) {
                    $(""#bill-"" + id).remove();
                }
                else {
                    displayError(""Could not delete bill "" + id + "" because an error occured ( "" + result.reasonPhrase + "" )"");
                }
            });
        }

        function displayError(message) {
            $('#bill-error-message-field').innerHTML = message;
            $('#bill-error-message-field').text(message);
            $('#bill-error-message-field').show();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Spendings.WEB.Models.Bill>> Html { get; private set; }
    }
}
#pragma warning restore 1591
