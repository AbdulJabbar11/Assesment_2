#pragma checksum "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\UserManagements\AdminDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23eea277689a29bfbcae9c2ef900c94a23dcf8d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserManagements_AdminDashboard), @"mvc.1.0.view", @"/Views/UserManagements/AdminDashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserManagements/AdminDashboard.cshtml", typeof(AspNetCore.Views_UserManagements_AdminDashboard))]
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
#line 1 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\_ViewImports.cshtml"
using Assesment_2;

#line default
#line hidden
#line 2 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\_ViewImports.cshtml"
using Assesment_2.Models;

#line default
#line hidden
#line 4 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23eea277689a29bfbcae9c2ef900c94a23dcf8d3", @"/Views/UserManagements/AdminDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"749970a88128639386c6969e6ead41ee120cd815", @"/Views/_ViewImports.cshtml")]
    public class Views_UserManagements_AdminDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\UserManagements\AdminDashboard.cshtml"
  
    ViewData["Title"] = "AdminDashboard";

#line default
#line hidden
            BeginContext(52, 187, true);
            WriteLiteral("\r\n<h1>AdminDashboard</h1>\r\n\r\n\r\n\r\n<a class=\"btn btn-success\" href=\"/CatagoriesManagement/Index\">CATAGORY LIST</a>\r\n\r\n<a class=\"btn btn-success\" href=\"/ItemManagement/Index\">ITEM LIST</a>\r\n");
            EndContext();
#line 13 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\UserManagements\AdminDashboard.cshtml"
 if (Context.Session.GetString("Role") == "Admin")
{

#line default
#line hidden
            BeginContext(294, 80, true);
            WriteLiteral("    <a class=\"btn btn-success\" href=\"/UserManagements/Create\">EXITING USER</a>\r\n");
            EndContext();
#line 16 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\UserManagements\AdminDashboard.cshtml"
}

#line default
#line hidden
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
