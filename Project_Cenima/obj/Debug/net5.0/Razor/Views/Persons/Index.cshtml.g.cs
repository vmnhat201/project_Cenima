#pragma checksum "D:\VSCode\Project_Cenima\Project_Cenima\Views\Persons\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c63927cb6970dc7ed6dd69c7e7129eb3bcb63ac5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persons_Index), @"mvc.1.0.view", @"/Views/Persons/Index.cshtml")]
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
#line 1 "D:\VSCode\Project_Cenima\Project_Cenima\Views\_ViewImports.cshtml"
using Project_Cenima;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VSCode\Project_Cenima\Project_Cenima\Views\_ViewImports.cshtml"
using Project_Cenima.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\VSCode\Project_Cenima\Project_Cenima\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\VSCode\Project_Cenima\Project_Cenima\Views\_ViewImports.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c63927cb6970dc7ed6dd69c7e7129eb3bcb63ac5", @"/Views/Persons/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8d92151c132f2b112a2c7b0feaed8302742c979", @"/Views/_ViewImports.cshtml")]
    public class Views_Persons_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>List Preson</h1>\r\n");
#nullable restore
#line 3 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Persons\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c63927cb6970dc7ed6dd69c7e7129eb3bcb63ac53989", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                PersonID
            </th>
            <th>
                FullName
            </th>
            <th>
                Gender
            </th>
            <th>
                Email
            <th>
                Password
            </th>
            <th>
                Type
            </th>
            <th>
                IsActve
            </th>


            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 39 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Persons\Index.cshtml"
         foreach (var item in ViewBag.listP)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Persons\Index.cshtml"
               Write(item.PersonId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Persons\Index.cshtml"
               Write(item.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Persons\Index.cshtml"
               Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Persons\Index.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Persons\Index.cshtml"
               Write(item.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Persons\Index.cshtml"
               Write(item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Persons\Index.cshtml"
               Write(item.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1377, "\"", 1415, 2);
            WriteAttributeValue("", 1384, "/Persons/Edit?id=", 1384, 17, true);
#nullable restore
#line 67 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Persons\Index.cshtml"
WriteAttributeValue("", 1401, item.PersonId, 1401, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n");
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 1602, "\"", 1642, 2);
            WriteAttributeValue("", 1609, "/Persons/Delete?id=", 1609, 19, true);
#nullable restore
#line 70 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Persons\Index.cshtml"
WriteAttributeValue("", 1628, item.PersonId, 1628, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 73 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Persons\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
