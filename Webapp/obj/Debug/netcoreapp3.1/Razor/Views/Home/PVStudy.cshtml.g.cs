#pragma checksum "D:\Workspace\DinaService\Webapp\Views\Home\PVStudy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8427429ec032fac3357f42930da8ce6c489d4da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PVStudy), @"mvc.1.0.view", @"/Views/Home/PVStudy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8427429ec032fac3357f42930da8ce6c489d4da", @"/Views/Home/PVStudy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce3a71612e69fc10737a96f8c595a5706b09fa6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PVStudy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""section-study"">
    <div class=""container"">
        <div class=""row "">
            <div class=""mini-header"">
                <span>مورد مطالعاتی</span>
            </div>
            <div class=""section-header"">
                <h2>
                    از بین بردن چالش های تعمیر لوازم خانگی شما هنر ماست
                </h2>
            </div>

            <div class=""section-content"">
                <div class=""product-item"">
                    <div class=""grid"">


                        <figure class=""effect-slideleft one-half"">
                            <img alt=""تعمیر ظرفشویی"" src=""/Content/Images/Dishwasher-header.jpg"" />
                            <figcaption>
                                <h2>
                                    <span>
                                        <strong>
                                            تعمیرات ظرفشویی
                                        </strong>
                                    </span>

                ");
            WriteLiteral("                </h2>\r\n                                <p></p>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1122, "\"", 1209, 1);
#nullable restore
#line 30 "D:\Workspace\DinaService\Webapp\Views\Home\PVStudy.cshtml"
WriteAttributeValue("", 1129, Url.Action("Category","Content",new { area="",id=2,slug="تعمیر-ماشین-ظرفشویی"}), 1129, 80, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""button"">مشاهده</a>
                            </figcaption>
                        </figure>


                        <figure class=""effect-slideleft one-half"">
                            <img alt=""تعمیر لباسشویی"" src=""/Content/Images/img-washing.jpg"" />
                            <figcaption>
                                <h2>
                                    <span>
                                        <strong>
                                            تعمیرات لباسشویی
                                        </strong>
                                    </span>


                                </h2>
                                <p></p>
                                <a");
            BeginWriteAttribute("href", " href=\"", 1934, "\"", 2022, 1);
#nullable restore
#line 48 "D:\Workspace\DinaService\Webapp\Views\Home\PVStudy.cshtml"
WriteAttributeValue("", 1941, Url.Action("Category","Content",new { area="",id=1,slug="تعمیر-ماشین-لباسشویی"}), 1941, 81, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"button\">مشاهده</a>\r\n                            </figcaption>\r\n                        </figure>\r\n\r\n\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
