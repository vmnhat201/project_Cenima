#pragma checksum "D:\VSCode\Project_Cenima\Project_Cenima\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77d4003098df91f93e087c8ed2e7575977966d97"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77d4003098df91f93e087c8ed2e7575977966d97", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8d92151c132f2b112a2c7b0feaed8302742c979", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project_Cenima.Models.Genre>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Home\Index.cshtml"
  
    ViewBag.Title = "MovieDetail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n\r\n\r\n            <div class=\"col-sm-3\">\r\n                <h3>Thể Loại</h3>\r\n                \r\n                <ul>\r\n");
#nullable restore
#line 17 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Home\Index.cshtml"
                     foreach (var item in ViewBag.Genre)
                    {
                       

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 448, "\"", 483, 2);
            WriteAttributeValue("", 455, "/Home/Genre?Id=", 455, 15, true);
#nullable restore
#line 20 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Home\Index.cshtml"
WriteAttributeValue("", 470, item.GenreId, 470, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> \r\n                            <li>");
#nullable restore
#line 21 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Home\Index.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li> </a>\r\n");
#nullable restore
#line 22 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n               \r\n            </div>\r\n            <div class=\"col-sm-9 padding-right\">\r\n\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 29 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Home\Index.cshtml"
                     foreach (var item in ViewBag.Movie)
                    {
                        int count = 0;
                        double sum = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-3\" style=\"margin-bottom: 13px\">\r\n                            <div class=\"card\">\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "77d4003098df91f93e087c8ed2e7575977966d976489", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1053, "~/img/", 1053, 6, true);
#nullable restore
#line 36 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1059, item.Image, 1059, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"card-body\">\r\n                                    <h5 class=\"card-title\">");
#nullable restore
#line 38 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Home\Index.cshtml"
                                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <div class=\"card-text\">\r\n                                        <p>Năm: ");
#nullable restore
#line 40 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Home\Index.cshtml"
                                           Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p>Loại: ");
#nullable restore
#line 41 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Home\Index.cshtml"
                                            Write(item.Genre.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 42 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Home\Index.cshtml"
                                         foreach (var rate in ViewBag.Rate)
                                        {
                                            if (item.MovieId == rate.MovieId)
                                            {
                                                sum += (double)rate.NumericRating;
                                                count++;
                                            }
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Home\Index.cshtml"
                                         if (sum != 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>Điểm: ");
#nullable restore
#line 52 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Home\Index.cshtml"
                                         Write(Math.Round((double)sum/count,2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 53 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Home\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p>Điểm: </p>\r\n");
#nullable restore
#line 57 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                                <div class=\"text-center\" style=\"padding-bottom: 15px\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2562, "\"", 2598, 2);
            WriteAttributeValue("", 2569, "/Home/Detail?id=", 2569, 16, true);
#nullable restore
#line 61 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Home\Index.cshtml"
WriteAttributeValue("", 2585, item.MovieId, 2585, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <button class=\"btn btn-primary \">Đánh giá</button></a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 65 "D:\VSCode\Project_Cenima\Project_Cenima\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project_Cenima.Models.Genre> Html { get; private set; }
    }
}
#pragma warning restore 1591
