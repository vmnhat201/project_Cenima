#pragma checksum "D:\VSCode\Project_Cenima\Project_Cenima\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d461abba5d96dde7bfff621191e4235d799d167"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d461abba5d96dde7bfff621191e4235d799d167", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8d92151c132f2b112a2c7b0feaed8302742c979", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rate>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Admin\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>List Rate</h1>


<table class=""table"">
    <thead>
        <tr>
            <th>
                MovieID
            </th>
            <th>
                PersonID
            </th>
            <th>
                Comment
            </th>
            <th>
                NumericRating
            </th>
            <th>
                Time
            </th>
           


            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 37 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Admin\Index.cshtml"
         foreach (var item in ViewBag.Rat)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Admin\Index.cshtml"
           Write(item.MovieId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Admin\Index.cshtml"
           Write(item.PersonId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Admin\Index.cshtml"
           Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Admin\Index.cshtml"
           Write(item.NumericRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Admin\Index.cshtml"
           Write(item.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            \r\n\r\n\r\n        </tr>\r\n");
#nullable restore
#line 58 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Admin\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rate> Html { get; private set; }
    }
}
#pragma warning restore 1591