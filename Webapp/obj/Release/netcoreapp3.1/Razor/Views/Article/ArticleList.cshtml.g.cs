#pragma checksum "D:\Workspace\DinaService\Webapp\Views\Article\ArticleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c160910ef630cf89027420c41ece9f32d64c50b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_ArticleList), @"mvc.1.0.view", @"/Views/Article/ArticleList.cshtml")]
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
#line 1 "D:\Workspace\DinaService\Webapp\Views\_ViewImports.cshtml"
using Webapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Workspace\DinaService\Webapp\Views\_ViewImports.cshtml"
using Webapp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Workspace\DinaService\Webapp\Views\_ViewImports.cshtml"
using DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Workspace\DinaService\Webapp\Views\_ViewImports.cshtml"
using DataStructure.Tools;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c160910ef630cf89027420c41ece9f32d64c50b7", @"/Views/Article/ArticleList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce3a71612e69fc10737a96f8c595a5706b09fa6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Article_ArticleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Article>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Workspace\DinaService\Webapp\Views\Article\ArticleList.cshtml"
  
    ViewBag.Title = "مقالات آموزشی تعمیر لوازم خانگی";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"article-list-page \">\r\n\r\n\r\n    <h1>تعمیر و نگهداری لوازم خانگی</h1>\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 13 "D:\Workspace\DinaService\Webapp\Views\Article\ArticleList.cshtml"
             foreach (var article in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-sm-6 col-md-4 col-xs-12\">\r\n                    <article class=\"des-product\">\r\n                        <h3>");
#nullable restore
#line 17 "D:\Workspace\DinaService\Webapp\Views\Article\ArticleList.cshtml"
                       Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p>\r\n                            ");
#nullable restore
#line 19 "D:\Workspace\DinaService\Webapp\Views\Article\ArticleList.cshtml"
                       Write(Html.Raw(article.Abstract));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 647, "\"", 680, 1);
#nullable restore
#line 21 "D:\Workspace\DinaService\Webapp\Views\Article\ArticleList.cshtml"
WriteAttributeValue("", 654, $"/مقالات{article.Url}", 654, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"button-c\">\r\n                            مشاهده\r\n                        </a>\r\n                    </article>\r\n                </div>\r\n");
#nullable restore
#line 26 "D:\Workspace\DinaService\Webapp\Views\Article\ArticleList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591
