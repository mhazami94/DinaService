#pragma checksum "D:\Workspace\DinaService\Webapp\Views\Article\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faa45014f27d921ff0c51ebdc24a08a4a5c9eb2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_Index), @"mvc.1.0.view", @"/Views/Article/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faa45014f27d921ff0c51ebdc24a08a4a5c9eb2a", @"/Views/Article/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce3a71612e69fc10737a96f8c595a5706b09fa6e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Article_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Article>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Workspace\DinaService\Webapp\Views\Article\Index.cshtml"
  
    ViewData["Title"] = "Articles";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n\r\n    <!-- Page Heading -->\r\n    <div class=\"d-sm-flex align-items-center justify-content-between mb-4\">\r\n        <h1 class=\"h3 mb-0 text-gray-800\">Articles</h1>\r\n");
            WriteLiteral(@"    </div>

    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">

            <div class=""mr-1 d-inline"">
                <a href=""/Article/Create"" class=""btn btn-primary text-white"">New Blog</a>
            </div>
        </div>
        <div class=""card-body"">
");
#nullable restore
#line 23 "D:\Workspace\DinaService\Webapp\Views\Article\Index.cshtml"
             if (Model.Count() > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>Title</th>
                                <th>Is published?</th>
                                <th>Url</th>
                                <th>Register Date</th>
                                <th></th>
                            </tr>
                        </thead>
                        <tfoot>
                            <tr>
                                <th>Title</th>
                                <th>Is published?</th>
                                <th>Url</th>
                                <th>Register Date</th>
                                <th></th>
                            </tr>
                        </tfoot>
                        <tbody>
");
#nullable restore
#line 46 "D:\Workspace\DinaService\Webapp\Views\Article\Index.cshtml"
                               foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 49 "D:\Workspace\DinaService\Webapp\Views\Article\Index.cshtml"
                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 50 "D:\Workspace\DinaService\Webapp\Views\Article\Index.cshtml"
                                        Write(item.Publish?"Yes":"No");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 51 "D:\Workspace\DinaService\Webapp\Views\Article\Index.cshtml"
                                       Write(item.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 52 "D:\Workspace\DinaService\Webapp\Views\Article\Index.cshtml"
                                       Write(item.RegisterDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2281, "\"", 2310, 2);
            WriteAttributeValue("", 2288, "/Article/Edit/", 2288, 14, true);
#nullable restore
#line 55 "D:\Workspace\DinaService\Webapp\Views\Article\Index.cshtml"
WriteAttributeValue("", 2302, item.Id, 2302, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-sm\">Edit</a>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2396, "\"", 2428, 2);
            WriteAttributeValue("", 2403, "/Article/Details/", 2403, 17, true);
#nullable restore
#line 56 "D:\Workspace\DinaService\Webapp\Views\Article\Index.cshtml"
WriteAttributeValue("", 2420, item.Id, 2420, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\">Details</a>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 2520, "\"", 2551, 2);
            WriteAttributeValue("", 2527, "/Article/Delete/", 2527, 16, true);
#nullable restore
#line 57 "D:\Workspace\DinaService\Webapp\Views\Article\Index.cshtml"
WriteAttributeValue("", 2543, item.Id, 2543, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\">Delete</a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 60 "D:\Workspace\DinaService\Webapp\Views\Article\Index.cshtml"
                                } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                        </tbody>\r\n                    </table>\r\n                </div> ");
#nullable restore
#line 66 "D:\Workspace\DinaService\Webapp\Views\Article\Index.cshtml"
                       }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"text-center\">\r\n                    Message not registered\r\n                </div>");
#nullable restore
#line 71 "D:\Workspace\DinaService\Webapp\Views\Article\Index.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Article>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
