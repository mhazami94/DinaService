#pragma checksum "D:\Workspace\DinaService\Webapp\Views\Shared\Components\SearchComponent\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6466caf90d08787a741fe8ce52a418c8d1c0250e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SearchComponent_Search), @"mvc.1.0.view", @"/Views/Shared/Components/SearchComponent/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6466caf90d08787a741fe8ce52a418c8d1c0250e", @"/Views/Shared/Components/SearchComponent/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce3a71612e69fc10737a96f8c595a5706b09fa6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SearchComponent_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-lg-3 col-md-6 col-xs-12 col-sm-6 support-box item-second"">
    <ul>
        <li>
            <img src=""/Content/Images/image-message.svg"" alt=""ثبت درخواست تعمیر لوازم خانگی"" />
        </li>
        <li class=""header-info"">
            <ul>
                <li>آیا از ما سوالی دارید</li>
                <li> مشاوره رایگان : <a href=""#"">02126103606</a></li>
            </ul>
        </li>
        <li>
            <div class=""search-box"">
                <a>
                    <i class=""fas fa-search""></i>
                </a>
                <div class=""search-element"">
                    <input type=""text"" name=""name"" id=""txtseach""");
            BeginWriteAttribute("value", " value=\"", 673, "\"", 681, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""جستجو ..."" />
                    <a onclick=""Search()""><i class=""fas fa-search""></i></a>
                </div>
            </div>
        </li>
    </ul>
</div>

<script>
    function Search() {
        var value = $('#txtseach').val();
        var slug = value.replace(/\s+/g, '-');
        var url = '/Content/Result/0/' + slug;
        window.location.href = url;
    }
</script>");
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
