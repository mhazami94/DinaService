#pragma checksum "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f846f592b99b2cf8e1f58aa32158e1d7ffbcaaa8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Brands_List), @"mvc.1.0.view", @"/Views/Brands/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f846f592b99b2cf8e1f58aa32158e1d7ffbcaaa8", @"/Views/Brands/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce3a71612e69fc10737a96f8c595a5706b09fa6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Brands_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Contents>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
  
    ViewBag.Title = ViewBag.Des;
    ViewBag.Des = $"تعمیر لوازم خانگی،تعمیر لباسشویی،تعمیر ماشین لباسشویی،تعمیر ماشین ظرفشویی،تعمیر ماشین لباسشویی در تهران، تعمیر ماشین ظرفشویی درتهران،تعمیر لوازم خانگی {ViewBag.Brand}";

    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"product-page\">\r\n\r\n\r\n    <div class=\"head-post \"");
            BeginWriteAttribute("style", " style=\"", 371, "\"", 461, 4);
            WriteAttributeValue("", 379, "background-image:", 379, 17, true);
            WriteAttributeValue(" ", 396, "url(\'", 397, 6, true);
#nullable restore
#line 12 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
WriteAttributeValue("", 402, Url.Action("ShowImage","Home",new { id=ViewBag.FileId}), 402, 56, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 458, "\');", 458, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"container\">\r\n            <div class=\"head-post-title\">\r\n                <h1>تعمیر لوازم خانگی ");
#nullable restore
#line 15 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                 Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n\r\n            <div class=\"head-post-content\">\r\n                <strong>دینا سرویس ارائه دهنده ی خدمات تعمیر لوازم خانگی در سراسر تهران</strong>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"des-post row\">\r\n");
            WriteLiteral("        <div class=\"des-post-content col-lg-12 col-sm-12 col-md-12 col-xs-12\">\r\n            <h2>تعمیرات لوازم خانگی ");
#nullable restore
#line 28 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                               Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <p>\r\n                آیا نیاز به <strong>تعمیر لوازم خانگی ");
#nullable restore
#line 30 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                 Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> دارید؟ آیا نیاز به <strong>تعمیر ماشین لباسشویی ");
#nullable restore
#line 30 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                         Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>  در محل خود دارید؟ آیا نیاز به <strong>تعمیر ماشین ظرفشویی ");
#nullable restore
#line 30 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                                                                                            Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> در محل خود دارید؟\r\n                متخصصان دینا سرویس در زمینه <strong>تعمیر ماشین لباسشویی ");
#nullable restore
#line 31 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                    Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> و <strong>تعمیر ماشین ظرفشویی ");
#nullable restore
#line 31 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                          Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> در هر ساعت از شبانه روز آماده ی ارائه خدمات <strong>تعمیر ماشین لباسشویی ");
#nullable restore
#line 31 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                                                                                                           Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> و <strong>تعمیر ماشین ظرفشویی ");
#nullable restore
#line 31 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                                                                                                                                                                 Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> در محل شماهستند\r\n                <br />\r\n                <br />\r\n                <b>کافیست با ما تماس بگیرید</b>\r\n            </p>\r\n            <div class=\"items-post\">\r\n");
            WriteLiteral("                <div>\r\n                    <h3>\r\n                        تعمیر ماشین لباسشویی ");
#nullable restore
#line 40 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                        Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h3>
                    <p>
                        متخصصان و تکنیسین های دینا سرویس با دارا بودن سال ها تجربه در ضمینه ی <strong>تعمیر لوازم خانگی</strong> و مشخصا <strong>تعمیر ماشین لباسشویی</strong> و <strong>تعمیر ماشین ظرفشویی</strong> در هر ساعت از شبانه روز آماده ی خدمت رسانی به شما همشهریان عزیز
                        میباشند.همچنین در ضمینه ی <strong>تعمیر ماشین لباسشویی ");
#nullable restore
#line 44 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                          Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> و <strong>تعمیر ماشین ظرفشویی ");
#nullable restore
#line 44 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> قابل ذکر می باشد که تکنیسین های دینا سرویس با توجه\r\n                        به اینکه آشنایی کامل در رابطه با انواع مدل های <strong>ماشین لباسشویی ");
#nullable restore
#line 45 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                         Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> و <strong>ماشین ظرفشویی ");
#nullable restore
#line 45 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                         Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> دارند و با توجه به گذراندن دوره های تخصصی\r\n                                                                                                                 <strong>تعمیر لباسشویی ");
#nullable restore
#line 46 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                   Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> و <strong>تعمیرماشین ظرفشویی ");
#nullable restore
#line 46 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                                                                        Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> در تلاش هستند تا بهترین و با کیفیت ترین خدمات را در زمینه ی <strong>تعمیر ماشین لباسشویی ");
#nullable restore
#line 46 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                                                                                                                                                                                         Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> و <strong>تعمیر ماشین ظرفشویی ");
#nullable restore
#line 46 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                                                                                                                                                                                                                                               Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                        ارائه بدهند.\r\n                    </p>\r\n                </div>\r\n                <div>\r\n                    <h3>\r\n                        تعمیر ماشین ظرفشویی ");
#nullable restore
#line 52 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                       Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </h3>
                    <p>
                        به طور مختصر <strong>انواع ماشین ظرفشویی</strong> به شرح زیر می باشند.
                        <br />
                        <strong>ماشین ظرف‌شویی توکار</strong> که داخل کابینت نصب می‌شود و قابل جابه‌جا کردن نیست.
                        <br />
                        <strong>ماشین ظرف‌شویی رومیزی</strong> و سبک قابل جابه‌جا شدن هستند و تنوع رنگیِ بسیار بالایی دارند.
                        <br />
                        <strong>ماشین ظرف‌شویی ایستاده</strong> برای حجم‌های بالاترِ ظروف مورد استفاده است و درست مثل <strong>ماشین لباس‌شویی</strong> به جایگاهی در آشپزخانه برای نصب شدن نیاز دارد.
                        <br />
                        <br />
                        دینا سرویس مفتحر است با سال های تجربه در ضمینه ی <strong>تعمیر ماشین ظرفشویی</strong> و خاصا <strong>تعمیر ماشین ظرفشویی ");
#nullable restore
#line 64 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                            Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong> سریع ترین و ارزان ترین
                        و در عین حال با کیفیت ترین خدمات <strong>تعمیر ماشین ظرفشویی</strong> را در محل شما ارائه می دهد.
                        این یک شعار نیست و بازخورد مشتریان ما در ضمینه ی <strong>تعمیر لوازم خانگی</strong> و مشخصا <strong>تعمیر ماشین لباسشویی ");
#nullable restore
#line 66 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                            Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> و <strong>تعمیر ماشین ظرفشویی ");
#nullable restore
#line 66 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                                                                                  Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                        گواه کار ماست . کافیست با ما تماس بگیرید تا در کوتاه ترین زمان متخصصان ما جهت <strong>تعمیر لوازم خانگی</strong> شما در محل حاضر خواهند بود . رضایت شما افتخار ماست.
                    </p>
                   
                </div>
            </div>

        </div>
    </div>
    <div class=""container"">
        <div class=""section-product"">
            <div class=""row "">
                <div class=""mini-header"">
                    <span>موارد مطالعاتی</span>
                </div>
                <div class=""section-header"">
                    <h2>
                        از بین بردن چالش های تعمیر لوازم خانگی تخصص ماست
                    </h2>
                </div>

                <div class=""section-content"">
");
#nullable restore
#line 88 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                      
                        foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-4 col-md-6 col-sm-6 col-xs-12\">\r\n                                <div class=\"study-item\">\r\n                                    <div>\r\n                                        <img");
            BeginWriteAttribute("alt", " alt=\"", 5896, "\"", 5913, 1);
#nullable restore
#line 94 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
WriteAttributeValue("", 5902, item.Title, 5902, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 5914, "\"", 5945, 2);
            WriteAttributeValue("", 5920, "/filehanlder/", 5920, 13, true);
#nullable restore
#line 94 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
WriteAttributeValue("", 5933, item.FileId, 5933, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    </div>\r\n\r\n                                    <div class=\"study-item-body\">\r\n                                        <h2>");
#nullable restore
#line 98 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                        <span class=\"des-product\">");
#nullable restore
#line 99 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                             Write(Html.Raw(System.Net.WebUtility.HtmlDecode(item.Description)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 6304, "\"", 6348, 4);
            WriteAttributeValue("", 6311, "/", 6311, 1, true);
#nullable restore
#line 100 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
WriteAttributeValue("", 6312, item.Id, 6312, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6320, "/", 6320, 1, true);
#nullable restore
#line 100 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
WriteAttributeValue("", 6321, item.Slug.Replace(' ','-'), 6321, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            <span class=""button-c"">اطلاعات بیشتر را مشاهده کنید</span>
                                        </a>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 106 "D:\Workspace\DinaService\Webapp\Views\Brands\List.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Contents>> Html { get; private set; }
    }
}
#pragma warning restore 1591
