#pragma checksum "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d88e9d341d2292e7206c544e88f4f6a27ce5abb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ItemManagements1_Delete), @"mvc.1.0.view", @"/Views/ItemManagements1/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ItemManagements1/Delete.cshtml", typeof(AspNetCore.Views_ItemManagements1_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d88e9d341d2292e7206c544e88f4f6a27ce5abb8", @"/Views/ItemManagements1/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"749970a88128639386c6969e6ead41ee120cd815", @"/Views/_ViewImports.cshtml")]
    public class Views_ItemManagements1_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assesment_2.Models.ItemManagement>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(86, 184, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>ItemManagement</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(271, 46, false);
#line 15 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CatagoryId));

#line default
#line hidden
            EndContext();
            BeginContext(317, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(381, 42, false);
#line 18 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CatagoryId));

#line default
#line hidden
            EndContext();
            BeginContext(423, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(486, 40, false);
#line 21 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(526, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(590, 36, false);
#line 24 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(626, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(689, 47, false);
#line 27 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(736, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(800, 43, false);
#line 30 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(843, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(906, 44, false);
#line 33 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(950, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1014, 40, false);
#line 36 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1054, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1117, 45, false);
#line 39 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Costprice));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1226, 41, false);
#line 42 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Costprice));

#line default
#line hidden
            EndContext();
            BeginContext(1267, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1330, 45, false);
#line 45 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Saleprice));

#line default
#line hidden
            EndContext();
            BeginContext(1375, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1439, 41, false);
#line 48 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Saleprice));

#line default
#line hidden
            EndContext();
            BeginContext(1480, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1543, 45, false);
#line 51 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Mainlmage));

#line default
#line hidden
            EndContext();
            BeginContext(1588, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1652, 41, false);
#line 54 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Mainlmage));

#line default
#line hidden
            EndContext();
            BeginContext(1693, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1756, 44, false);
#line 57 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Itemcode));

#line default
#line hidden
            EndContext();
            BeginContext(1800, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1864, 40, false);
#line 60 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Itemcode));

#line default
#line hidden
            EndContext();
            BeginContext(1904, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1967, 45, false);
#line 63 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Maincolor));

#line default
#line hidden
            EndContext();
            BeginContext(2012, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2076, 41, false);
#line 66 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Maincolor));

#line default
#line hidden
            EndContext();
            BeginContext(2117, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2180, 42, false);
#line 69 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2222, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2286, 38, false);
#line 72 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2324, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2362, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d88e9d341d2292e7206c544e88f4f6a27ce5abb814383", async() => {
                BeginContext(2388, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2398, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d88e9d341d2292e7206c544e88f4f6a27ce5abb814776", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 77 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2434, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2517, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d88e9d341d2292e7206c544e88f4f6a27ce5abb816712", async() => {
                    BeginContext(2539, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2555, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2568, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assesment_2.Models.ItemManagement> Html { get; private set; }
    }
}
#pragma warning restore 1591