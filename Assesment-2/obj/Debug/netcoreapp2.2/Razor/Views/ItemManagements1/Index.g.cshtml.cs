#pragma checksum "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec11256ee8a45a6cdf2ecea1c2944e7fd222b023"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ItemManagements1_Index), @"mvc.1.0.view", @"/Views/ItemManagements1/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ItemManagements1/Index.cshtml", typeof(AspNetCore.Views_ItemManagements1_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec11256ee8a45a6cdf2ecea1c2944e7fd222b023", @"/Views/ItemManagements1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"749970a88128639386c6969e6ead41ee120cd815", @"/Views/_ViewImports.cshtml")]
    public class Views_ItemManagements1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Assesment_2.Models.ItemManagement>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/ItemManagements1/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 223, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a href=\"/ItemManagements1/create\" class=\"btn btn-sm btn-success\"><i class=\"fa fa-pencil\"></i>Create New Item</a>\r\n</p>\r\n\r\n<br />\r\n<p>\r\n    To See All Items right (\"all\")  in searchbar\r\n</p>\r\n\r\n");
            EndContext();
            BeginContext(321, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec11256ee8a45a6cdf2ecea1c2944e7fd222b0234583", async() => {
                BeginContext(360, 83, true);
                WriteLiteral("\r\n\r\n    <input type=\"text\" name=\"f\" />\r\n    <input type=\"submit\" name=\"search\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(450, 86, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(537, 46, false);
#line 27 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CatagoryId));

#line default
#line hidden
            EndContext();
            BeginContext(583, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(639, 40, false);
#line 30 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(679, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(735, 47, false);
#line 33 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(782, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(838, 44, false);
#line 36 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(882, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(938, 45, false);
#line 39 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Costprice));

#line default
#line hidden
            EndContext();
            BeginContext(983, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1039, 45, false);
#line 42 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Saleprice));

#line default
#line hidden
            EndContext();
            BeginContext(1084, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1140, 45, false);
#line 45 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mainlmage));

#line default
#line hidden
            EndContext();
            BeginContext(1185, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1241, 44, false);
#line 48 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Itemcode));

#line default
#line hidden
            EndContext();
            BeginContext(1285, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1341, 45, false);
#line 51 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Maincolor));

#line default
#line hidden
            EndContext();
            BeginContext(1386, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1442, 42, false);
#line 54 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1484, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 60 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1619, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1680, 45, false);
#line 64 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CatagoryId));

#line default
#line hidden
            EndContext();
            BeginContext(1725, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1793, 39, false);
#line 67 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1832, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1900, 46, false);
#line 70 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1946, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2014, 43, false);
#line 73 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(2057, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2125, 44, false);
#line 76 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Costprice));

#line default
#line hidden
            EndContext();
            BeginContext(2169, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2237, 44, false);
#line 79 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Saleprice));

#line default
#line hidden
            EndContext();
            BeginContext(2281, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2349, 44, false);
#line 82 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Mainlmage));

#line default
#line hidden
            EndContext();
            BeginContext(2393, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2461, 43, false);
#line 85 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Itemcode));

#line default
#line hidden
            EndContext();
            BeginContext(2504, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2572, 44, false);
#line 88 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Maincolor));

#line default
#line hidden
            EndContext();
            BeginContext(2616, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2684, 41, false);
#line 91 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2725, 69, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2794, "\"", 2835, 2);
            WriteAttributeValue("", 2801, "/ItemManagements1/edit?id=", 2801, 26, true);
#line 94 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
WriteAttributeValue("", 2827, item.Id, 2827, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2836, 113, true);
            WriteLiteral(" class=\"btn btn-sm btn-warning\"><i class=\"fa fa-pencil\" aria-hidden=\"true\"></i>Edit</a> |\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2949, "\"", 2993, 2);
            WriteAttributeValue("", 2956, "/ItemManagements1/details?id=", 2956, 29, true);
#line 95 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
WriteAttributeValue("", 2985, item.Id, 2985, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2994, 135, true);
            WriteLiteral(" class=\"btn btn-sm btn-success\"><i class=\"fa fa-eye\" aria-hidden=\"true\"></i>Details</a>|\r\n                    <a href=\"#\" data-itemid=\"");
            EndContext();
            BeginContext(3130, 7, false);
#line 96 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
                                        Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3137, 134, true);
            WriteLiteral("\" class=\"btn btn-sm btn-danger d\"><i class=\"fa fa-trash\" aria-hidden=\"true\"></i>Delete</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 99 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3282, 28, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3327, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 105 "C:\Users\abdul jabbar\source\repos\AbdulJabbar11\Assesment_2\Assesment-2\Views\ItemManagements1\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(3397, 751, true);
                WriteLiteral(@"
    <script>

        $(function () {
            $('.d').click(function () {
                var DeleteButton = $(this);
                var itemId = DeleteButton.data(""itemid"");
                DeleteButton.text(""Please wait ..."");

                $.ajax({

                    url: '/ItemManagements1/DeleteAirline',
                    type: 'POST',
                    data: {
                        id: itemId
                    },
                    success: function (response) {
                        if (response == ""1"") {
                            DeleteButton.parent().parent().fadeOut(1000);
                        }
                    }
                });
            });

        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(4151, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Assesment_2.Models.ItemManagement>> Html { get; private set; }
    }
}
#pragma warning restore 1591