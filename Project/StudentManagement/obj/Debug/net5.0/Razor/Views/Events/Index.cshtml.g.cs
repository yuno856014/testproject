#pragma checksum "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00553830d53ae750ac6a295603f40950c198425c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Index), @"mvc.1.0.view", @"/Views/Events/Index.cshtml")]
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
#line 1 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement.Models.Accounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement.Models.Events;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00553830d53ae750ac6a295603f40950c198425c", @"/Views/Events/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"146c7ed938449d23bf91621bee62ace6034f1269", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Event>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 65%; border: none; border-bottom: 1px solid tomato; background: none; margin-right: 30px; margin-left: 30px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 65%;border: none; border-bottom:  1px solid tomato; background: none; width: 8%; margin-right: 30px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Events", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
  
    var role = User.IsInRole("Doctor");
    ViewData["Title"] = "Events List";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var users = ViewBag.User as StudentManagement.Entities.User;

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00553830d53ae750ac6a295603f40950c198425c7555", async() => {
                WriteLiteral("<i class=\"bi bi-plus-lg\"></i>Create Event");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<div class=\"card\">\r\n    <div class=\"row\" style=\"margin-left:22px\">\r\n        <span class=\"col-1\">");
#nullable restore
#line 14 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
                       Write(users.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span class=\"col-1\">");
#nullable restore
#line 15 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
                       Write(users.StudentCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        <span class=\"col-1\">");
#nullable restore
#line 16 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
                       Write(ViewBag.SchoolYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n    <hr />\r\n    <div style=\" height: 50px;\" class=\"row\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00553830d53ae750ac6a295603f40950c198425c9872", async() => {
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 20 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.SchoolYearId;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00553830d53ae750ac6a295603f40950c198425c11485", async() => {
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 22 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.ListEventId;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <div class=""col-1"" style="" margin-top: 6px;"">
            <strong>Status</strong>
        </div>
        <div class=""col-md-2"" style=""margin-left: -65px; margin-top: 6px;"">
            <input id=""unverify"" type=""checkbox""><span style=""padding-right:4px;""> Unverify</span>
            <input id=""verifying"" type=""checkbox""><span style=""padding-right:4px;""> Verifying</span>
            <input id=""Verified"" type=""checkbox""><span style=""padding-right:4px;""> Verified</span>
        </div>
        <button class=""col-1"" style=""margin-left: -16px; margin-top: -14px; border: 0; background-color: white; color: blue; font-size: 20px;"">
            <i class=""bi bi-search""></i>
        </button>
    </div>
    <hr style=""margin-top:0px"" />
    <div class=""card-body"">
        <table class=""table table-bordered"">
            <thead class=""thead-dark"" style=""background-color: #3e55df; color: white"">
                <tr>
                    <th style=""text-align:center;"">
                        Scho");
            WriteLiteral(@"ol Year
                    </th>
                    <th style=""text-align:center;"">
                        Event
                    </th>
                    <th style=""text-align:center;"">
                        Status
                    </th>
                    <th style=""text-align:center;"">
                        Comments
                    </th>
                    <th>
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 58 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td style=\"text-align:center;\">");
#nullable restore
#line 61 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
                                                  Write(item.SchoolYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><i");
            BeginWriteAttribute("class", " class=\"", 2805, "\"", 2833, 1);
#nullable restore
#line 62 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
WriteAttributeValue("", 2813, item.ListEvent.Icon, 2813, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> ");
#nullable restore
#line 62 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
                                                            Write(item.ListEvent.ListEventName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"text-align:center;\">\r\n");
#nullable restore
#line 64 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
                             if ((int)item.Status == 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a class=\"btn btn-info rounded-pill\">");
#nullable restore
#line 66 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
                                                                Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 67 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
                            }
                            else if ((int)item.Status == 2)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a class=\"btn btn-warning rounded-pill\">");
#nullable restore
#line 70 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
                                                                   Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 71 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a class=\"btn btn-success rounded-pill\">");
#nullable restore
#line 74 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
                                                                   Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 75 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td style=\"text-align:center\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00553830d53ae750ac6a295603f40950c198425c18424", async() => {
                WriteLiteral("<i class=\"bi bi-bell-fill\" style=\"font-size: 20px; color: #03a9f4\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-eventId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
                                                                                                            WriteLiteral(item.EventId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["eventId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-eventId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["eventId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                        <td style=\"text-align:center\">\r\n");
#nullable restore
#line 79 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
                             if (role)
                            {
                                if ((int)item.Status == 2)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a href=\"#\"><i class=\"bi bi-check-lg\" style=\"color: #03a9f4\"></i></a>\r\n");
#nullable restore
#line 84 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"bi bi-check-lg\" style=\"color:gray\"></i>\r\n");
#nullable restore
#line 88 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"

                                }
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00553830d53ae750ac6a295603f40950c198425c22259", async() => {
                WriteLiteral("<i class=\"bi bi-pencil-fill\" style=\"font-size: 20px; color: #03a9f4\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-eventId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
                                                                                    WriteLiteral(item.EventId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["eventId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-eventId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["eventId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00553830d53ae750ac6a295603f40950c198425c24795", async() => {
                WriteLiteral("<i class=\"bi bi-trash-fill\" style=\"font-size: 20px; color: #e12315 \"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-eventId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
                                                                                      WriteLiteral(item.EventId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["eventId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-eventId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["eventId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 95 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 100 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Events\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <link href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta2/css/all.min.css\" rel=\"stylesheet\" />\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591
