#pragma checksum "D:\Workspace\DinaService\Webapp\Views\Article\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "500474aeaa5ef9d958a55dbb4c57c252114dc608"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Article_Details), @"mvc.1.0.view", @"/Views/Article/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"500474aeaa5ef9d958a55dbb4c57c252114dc608", @"/Views/Article/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce3a71612e69fc10737a96f8c595a5706b09fa6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Article_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Article>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Article/Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Workspace\DinaService\Webapp\Views\Article\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "500474aeaa5ef9d958a55dbb4c57c252114dc6084764", async() => {
                WriteLiteral("\r\n        <div class=\"form-row\">\r\n            <div class=\"col-md-6 mb-3\">\r\n                <label for=\"validationCustom01\">Title</label>\r\n                <label class=\"form-control\">");
#nullable restore
#line 13 "D:\Workspace\DinaService\Webapp\Views\Article\Details.cshtml"
                                       Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col-md-6 mb-3\">\r\n                <label for=\"validationCustom02\">Order </label>\r\n                <label class=\"form-control\">");
#nullable restore
#line 17 "D:\Workspace\DinaService\Webapp\Views\Article\Details.cshtml"
                                       Write(Model.Order);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n        </div>\r\n        <div class=\"form-row\">\r\n            <div class=\"col-md-6 mb-3\">\r\n                <label for=\"validationCustom01\">Page Title</label>\r\n                <label class=\"form-control\">");
#nullable restore
#line 23 "D:\Workspace\DinaService\Webapp\Views\Article\Details.cshtml"
                                       Write(Model.PageTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col-md-6 mb-3\">\r\n                <label for=\"validationCustom02\">Meta Description </label>\r\n                <label class=\"form-control\">");
#nullable restore
#line 27 "D:\Workspace\DinaService\Webapp\Views\Article\Details.cshtml"
                                       Write(Model.MetaDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-row\">\r\n            <div class=\"col-md-6 mb-3\">\r\n                <label for=\"FreeStydy\">Do you wanna publish it ?</label>\r\n                <label class=\"form-control\">");
#nullable restore
#line 34 "D:\Workspace\DinaService\Webapp\Views\Article\Details.cshtml"
                                        Write(Model.Publish?"yes":"no");

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col-md-6 mb-3\">\r\n                <label for=\"validationCustom02\">Url </label>\r\n                <label class=\"form-control\">");
#nullable restore
#line 38 "D:\Workspace\DinaService\Webapp\Views\Article\Details.cshtml"
                                       Write(Model.Url);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <div class=\"form-row\">\r\n            <div class=\"col-md-6 mb-3\">\r\n                <label for=\"validationCustom04\">Banner</label>\r\n                <div class=\"form-control\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 1775, "\"", 1808, 2);
                WriteAttributeValue("", 1781, "/filehanlder/", 1781, 13, true);
#nullable restore
#line 47 "D:\Workspace\DinaService\Webapp\Views\Article\Details.cshtml"
WriteAttributeValue("", 1794, Model.ImageId, 1794, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" width=""150"" />
                </div>
            </div>

        </div>

        <div class=""form-row"">
            <div class=""col-md-12 mb-3"">
                <label for=""FreeStydy"">Abstract</label>
                <div>
                    <label class=""form-control"">");
#nullable restore
#line 57 "D:\Workspace\DinaService\Webapp\Views\Article\Details.cshtml"
                                           Write(Html.Raw(Model.Abstract));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                </div>
            </div>
        </div>

        <div class=""form-row"">
            <div class=""col-md-12 mb-3"">
                <label for=""FreeStydy"">Context</label>
                <div>
                    <label class=""form-control"">");
#nullable restore
#line 66 "D:\Workspace\DinaService\Webapp\Views\Article\Details.cshtml"
                                           Write(Html.Raw(Model.Context));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <a class=\"btn btn-warning\" href=\"/Article/Index\">Return</a>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Article> Html { get; private set; }
    }
}
#pragma warning restore 1591
