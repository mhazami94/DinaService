#pragma checksum "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "705ae446486a86ba8bea2c7e7a8527567ce34d1d"
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
#line 1 "C:\WorkSpace\DinaService\Webapp\Views\_ViewImports.cshtml"
using Webapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\WorkSpace\DinaService\Webapp\Views\_ViewImports.cshtml"
using Webapp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\WorkSpace\DinaService\Webapp\Views\_ViewImports.cshtml"
using DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\WorkSpace\DinaService\Webapp\Views\_ViewImports.cshtml"
using DataStructure.Tools;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"705ae446486a86ba8bea2c7e7a8527567ce34d1d", @"/Views/Brands/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce3a71612e69fc10737a96f8c595a5706b09fa6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Brands_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Contents>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
  
    ViewBag.Title = ViewBag.Des;
    ViewBag.Des = $"تعمیر لوازم خانگی،تعمیر لباسشویی،تعمیر ماشین لباسشویی،تعمیر ماشین ظرفشویی،تعمیر ماشین لباسشویی در تهران، تعمیر ماشین ظرفشویی درتهران،تعمیر لوازم خانگی {ViewBag.Brand}";

    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"product-page\">\n\n\n    <div class=\"head-post \"");
            BeginWriteAttribute("style", " style=\"", 360, "\"", 450, 4);
            WriteAttributeValue("", 368, "background-image:", 368, 17, true);
            WriteAttributeValue(" ", 385, "url(\'", 386, 6, true);
#nullable restore
#line 12 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
WriteAttributeValue("", 391, Url.Action("ShowImage","Home",new { id=ViewBag.FileId}), 391, 56, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 447, "\');", 447, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\n        <div class=\"container\">\n            <div class=\"head-post-title\">\n                <h1>تعمیر لوازم خانگی ");
#nullable restore
#line 15 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                                 Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n            </div>\n\n            <div class=\"head-post-content\">\n                <strong>دینا سرویس ارائه دهنده ی خدمات تعمیر لوازم خانگی در سراسر تهران</strong>\n            </div>\n        </div>\n    </div>\n    <div class=\"des-post row\">\n");
            WriteLiteral("        <div class=\"des-post-content col-lg-12 col-sm-12 col-md-12 col-xs-12\">\n            <h2>تعمیرات لوازم خانگی ");
#nullable restore
#line 28 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                               Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n            <p>\n                آیا نیاز به <strong>تعمیر لوازم خانگی ");
#nullable restore
#line 30 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                 Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> دارید؟ آیا نیاز به <strong>تعمیر ماشین لباسشویی ");
#nullable restore
#line 30 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                         Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>  در محل خود دارید؟ آیا نیاز به <strong>تعمیر ماشین ظرفشویی ");
#nullable restore
#line 30 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                                                                                            Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> در محل خود دارید؟\n                متخصصان دینا سرویس در زمینه <strong>تعمیر ماشین لباسشویی ");
#nullable restore
#line 31 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                    Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> و <strong>تعمیر ماشین ظرفشویی ");
#nullable restore
#line 31 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                          Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> در هر ساعت از شبانه روز آماده ی ارائه خدمات <strong>تعمیر ماشین لباسشویی ");
#nullable restore
#line 31 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                                                                                                           Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> و <strong>تعمیر ماشین ظرفشویی ");
#nullable restore
#line 31 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                                                                                                                                                                 Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> در محل شماهستند\n                <br />\n                <br />\n                <b>کافیست با ما تماس بگیرید</b>\n            </p>\n            <div class=\"items-post\">\n");
            WriteLiteral("                <div>\n                    <h3>\n                        تعمیر ماشین لباسشویی ");
#nullable restore
#line 40 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
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
#line 44 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                          Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> و <strong>تعمیر ماشین ظرفشویی ");
#nullable restore
#line 44 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> قابل ذکر می باشد که تکنیسین های دینا سرویس با توجه\n                        به اینکه آشنایی کامل در رابطه با انواع مدل های <strong>ماشین لباسشویی ");
#nullable restore
#line 45 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                         Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> و <strong>ماشین ظرفشویی ");
#nullable restore
#line 45 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                         Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> دارند و با توجه به گذراندن دوره های تخصصی\n                                                                                                                 <strong>تعمیر لباسشویی ");
#nullable restore
#line 46 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                   Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> و <strong>تعمیرماشین ظرفشویی ");
#nullable restore
#line 46 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                                                                        Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> در تلاش هستند تا بهترین و با کیفیت ترین خدمات را در زمینه ی <strong>تعمیر ماشین لباسشویی ");
#nullable restore
#line 46 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                                                                                                                                                                                         Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> و <strong>تعمیر ماشین ظرفشویی ");
#nullable restore
#line 46 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                                                                                                                                                                                                                                               Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n                        ارائه بدهند.\n                    </p>\n                </div>\n                <div>\n                    <h3>\n                        تعمیر ماشین ظرفشویی ");
#nullable restore
#line 52 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
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
#line 64 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                            Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong> سریع ترین و ارزان ترین
                        و در عین حال با کیفیت ترین خدمات <strong>تعمیر ماشین ظرفشویی</strong> را در محل شما ارائه می دهد.
                        این یک شعار نیست و بازخورد مشتریان ما در ضمینه ی <strong>تعمیر لوازم خانگی</strong> و مشخصا <strong>تعمیر ماشین لباسشویی ");
#nullable restore
#line 66 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                                                                                                            Write(ViewBag.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> و <strong>تعمیر ماشین ظرفشویی ");
#nullable restore
#line 66 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
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
#line 88 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                      
                        foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-4 col-md-6 col-sm-6 col-xs-12\">\n                                <div class=\"study-item\">\n                                    <div>\n                                        <img");
            BeginWriteAttribute("alt", " alt=\"", 5803, "\"", 5820, 1);
#nullable restore
#line 94 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
WriteAttributeValue("", 5809, item.Title, 5809, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 5821, "\"", 5852, 2);
            WriteAttributeValue("", 5827, "/filehanlder/", 5827, 13, true);
#nullable restore
#line 94 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
WriteAttributeValue("", 5840, item.FileId, 5840, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                                    </div>\n\n                                    <div class=\"study-item-body\">\n                                        <h2>");
#nullable restore
#line 98 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                                        <span class=\"des-product\">");
#nullable restore
#line 99 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                                                             Write(Html.Raw(System.Net.WebUtility.HtmlDecode(item.Description)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 6205, "\"", 6249, 4);
            WriteAttributeValue("", 6212, "/", 6212, 1, true);
#nullable restore
#line 100 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
WriteAttributeValue("", 6213, item.Id, 6213, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6221, "/", 6221, 1, true);
#nullable restore
#line 100 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
WriteAttributeValue("", 6222, item.Slug.Replace(' ','-'), 6222, 27, false);

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
#line 106 "C:\WorkSpace\DinaService\Webapp\Views\Brands\List.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n");
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