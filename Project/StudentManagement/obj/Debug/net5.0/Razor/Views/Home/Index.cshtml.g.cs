#pragma checksum "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "671546f6894f8ccb1b9338d8e15833203b77b2b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 6 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\_ViewImports.cshtml"
using StudentManagement.Models.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"671546f6894f8ccb1b9338d8e15833203b77b2b9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"146c7ed938449d23bf91621bee62ace6034f1269", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Home\Index.cshtml"
  
    var user = new User();
    string name = null;
    if (signInManager.IsSignedIn(User))
    {
        user = signInManager.UserManager.FindByNameAsync(User.Identity.Name).Result;
        name = User.Identity.Name;
    }
    var role = User.IsInRole("Student");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Home\Index.cshtml"
 if(role)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h1>");
#nullable restore
#line 16 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Home\Index.cshtml"
               Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 17 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Home\Index.cshtml"
}else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h1>nohope</h1>\r\n");
#nullable restore
#line 20 "C:\Users\buunv\Desktop\testproject\Project\StudentManagement\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
