#pragma checksum "D:\Workspace\DinaService\Webapp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0aadc5bc0d3fda55b3b8c093ddf82ed7efc4325e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0aadc5bc0d3fda55b3b8c093ddf82ed7efc4325e", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce3a71612e69fc10737a96f8c595a5706b09fa6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/App_theme/DinaTheme/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "/js/site.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("myFunction()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"fa-IR\" dir=\"rtl\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0aadc5bc0d3fda55b3b8c093ddf82ed7efc4325e5199", async() => {
                WriteLiteral(@"
    <meta name=""google-site-verification"" content=""K9mcaEpSD6D5zcsxQu2YMfc5MlSVb1aCIhAueznOi_o"" />
    <!-- Google Tag Manager -->
    <script>
        (function (w, d, s, l, i) {
            w[l] = w[l] || []; w[l].push({
                'gtm.start':
                    new Date().getTime(), event: 'gtm.js'
            }); var f = d.getElementsByTagName(s)[0],
                j = d.createElement(s), dl = l != 'dataLayer' ? '&l=' + l : ''; j.async = true; j.src =
                    'https://www.googletagmanager.com/gtm.js?id=' + i + dl; f.parentNode.insertBefore(j, f);
        })(window, document, 'script', 'dataLayer', 'GTM-W7MMT4Q');</script>
    <!-- End Google Tag Manager -->
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <link rel=""alternate"" href=""https://dinaservice.com"" hreflang=""fa-IR"" />
    <link rel=""icon"" type=""image/x-icon"" sizes=""16x16"" href=""/16x16.png"" />
    <link rel=""icon"" type=""image/x-icon"" sizes=""32x32"" hr");
                WriteLiteral("ef=\"/32x32.png\" />\r\n    <link rel=\"icon\" type=\"image/x-icon\" sizes=\"96x96\" href=\"/96x96.png\" />\r\n\r\n\r\n    <title>");
#nullable restore
#line 24 "D:\Workspace\DinaService\Webapp\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | دینا سرویس</title>\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 1255, "\"", 1277, 1);
#nullable restore
#line 25 "D:\Workspace\DinaService\Webapp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1265, ViewBag.Des, 1265, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"keywords\"");
                BeginWriteAttribute("content", " content=\"", 1308, "\"", 1330, 1);
#nullable restore
#line 26 "D:\Workspace\DinaService\Webapp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1318, ViewBag.Key, 1318, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <script src=\"/App_theme/DinaTheme/js/jquery-3.1.1.min.js\"></script>\r\n    <link href=\"/App_theme/DinaTheme/css/all.min.css\" rel=\"stylesheet\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0aadc5bc0d3fda55b3b8c093ddf82ed7efc4325e7858", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link href=""/App_theme/DinaTheme/slider/assets/web/assets/mobirise-icons/mobirise-icons.min.css"" rel=""stylesheet"" />
    <link href=""/App_theme/DinaTheme/slider/assets/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"" />
    <link href=""/App_theme/DinaTheme/slider/assets/mobirise/css/mbr-additional.min.css"" rel=""stylesheet"" />
    <link href=""/App_theme/DinaTheme/css/nav-style.min.css"" rel=""stylesheet"" />
    <link href=""/App_theme/DinaTheme/css/owl.carousel.min.css"" rel=""stylesheet"" />
    <link href=""/App_theme/DinaTheme/css/owl.theme.default.min.css"" rel=""stylesheet"" />
    <link href=""/App_theme/DinaTheme/css/aos.min.css"" rel=""stylesheet"" />
    <link href=""/App_theme/DinaTheme/css/style.min.css"" rel=""stylesheet"" />
    <link href=""/App_theme/DinaTheme/css/saba.min.css"" rel=""stylesheet"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0aadc5bc0d3fda55b3b8c093ddf82ed7efc4325e10593", async() => {
                WriteLiteral(@"

    <div id=""myDiv"" class=""animate-bottom main-div"">
        <div class=""container-fluid container-nav"">
            <div class=""row header-nav-panel ordinal-box"">
                <div class=""col-lg-1 col-md-6 col-sm-6 col-xs-4 logo-company item-first"">
                    <a href=""/"">
                        <img src=""/Content/Images/dinaservice.png"" alt=""دینا سرویس"" />
                    </a>
                </div>


                <div class=""col-lg-8 col-md-12 col-xs-12 col-sm-12 navbar-panel  item-third"">
                    <div class=""r-collapse"">
                        <ul class=""icon-nav"">
                            <li class=""bar1""></li>
                            <li class=""bar2""></li>
                            <li class=""bar3""></li>
                        </ul>
                    </div>
                    <ul>
                        <li>
                            <nav class=""r-nav navigation-menu sidenav close-nav "">
                                <div id=""ac");
                WriteLiteral("cordian\" class=\"content-navigation-menu\">\r\n                                    <ul class=\"list-nav\">\r\n\r\n");
                WriteLiteral(@"
                                        <li>
                                            <a href=""/"">
                                                <span>صفحه اصلی</span>
                                            </a>
                                        </li>
                                        <li>
                                            <a>
                                                <span>خدمات</span>
                                            </a>
                                            <ul>
                                                <li>
                                                    <a href=""#"">تعمیر یخچال</a>
                                                </li>
                                                <li>
                                                    <a href=""#"">تعمیر لباسشویی</a>
                                                </li>
                                            </ul>
                                        </li>

   ");
                WriteLiteral(@"                                     <li>
                                            <a href=""/Articles"">
                                                <span>مقالات</span>
                                            </a>
                                        </li>

                                        <li>
                                            <a");
                BeginWriteAttribute("href", " href=\"", 6074, "\"", 6154, 1);
#nullable restore
#line 113 "D:\Workspace\DinaService\Webapp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6081, Url.Action("AboutUs","Home",new { area="",id=1,slug="درباره-دیناسرویس"}), 6081, 73, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""dropdown-btn"">
                                                <span> درباره ی ما</span>

                                            </a>

                                        </li>

                                        <li>
                                            <a");
                BeginWriteAttribute("href", " href=\"", 6449, "\"", 6532, 1);
#nullable restore
#line 121 "D:\Workspace\DinaService\Webapp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6456, Url.Action("ContactUs","Home",new { area="",id=1,slug="تماس-با-دیناسرویس"}), 6456, 76, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""dropdown-btn"">
                                                <span> تماس با ما</span>

                                            </a>

                                        </li>

                                    </ul>
                                </div>

                            </nav>
                        </li>
                    </ul>
                </div>
                ");
#nullable restore
#line 135 "D:\Workspace\DinaService\Webapp\Views\Shared\_Layout.cshtml"
           Write(await Component.InvokeAsync("SearchComponent"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n\r\n\r\n        <main>\r\n\r\n\r\n            ");
#nullable restore
#line 145 "D:\Workspace\DinaService\Webapp\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


            <hr />
            <footer>
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-lg-8 col-md-12 col-sm-12 col-xs-12"">
                            <div class=""row service-footer"">


                                <div class=""col-md-6 col-lg-6 col-xs-6 col-sm-3"">

                                </div>
                                <div class=""col-md-6 col-lg-6 col-xs-6 col-sm-3"">
                                    <ul>
                                        <li>
                                            <span>
                                                <h3>
                                                    شعبات دینا سرویس
                                                </h3>
                                            </span>
                                        </li>
                                        <li>
                                            <span>
                           ");
                WriteLiteral(@"                     <strong>آدرس دفتر شرق دینا سرویس:</strong>
                                                ایـران، تهـران، خیـابان پیروزی، نبش چهارراه فرزانه، پلاک 43
                                                <br />
                                                <strong>تلفن:</strong>
                                                02177478564 | 02177151790 - 3

                                            </span>
                                        </li>
                                        <li>
                                            <span>
                                                <strong>آدرس دفتر غرب دینا سرویس:</strong>
                                                ایـران، تهـران، خیـابان اشرفی اصفهانی، ساختمان هامون، واحد 48
                                                <br />
                                                <strong>تلفن:</strong>
                                                02144239870 - 1

                                            <");
                WriteLiteral(@"/span>
                                        </li>
                                        <li>
                                            <span>
                                                <strong>آدرس دفتر شمال دینا سرویس:</strong>
                                                ایـران، تهـران، اقدسیه، خیـابان سپند، کوچه کامران، پاساژ صاحب قرانیه، واحد 32
                                                <br />
                                                <strong>تلفن:</strong>
                                                02126100783 | 02126120917

                                            </span>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-4 col-md-12 col-sm-12 col-xs-12"">
                            <div class=""left-box-footer"">
                                <ul>
                    ");
                WriteLiteral(@"                <li> <img src=""/Content/Images/dinaservice.png"" alt=""دینا سرویس"" /></li>
                                    <li>
                                        <span>
                                            <strong>آدرس دفتر مرکزی دینا سرویس:</strong>
                                            ایـران، تهـران، خیـابان پیروزی، نبش چهارراه فرزانه، پلاک 43
                                            <br />
                                            <strong>تلفن:</strong>
                                            02177478564 | 02177151790-3

                                        </span>
                                    </li>
                                    <li>

                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>


            </footer>
        </main>
    </div>





    <script src=""/App_theme/DinaTheme/js/modernizr");
                WriteLiteral(@"-2.8.3.min.js""></script>

    <script src=""/App_theme/DinaTheme/js/navbar.min.js""></script>
    <script src=""/App_theme/DinaTheme/slider/assets/bootstrap/js/bootstrap.min.js""></script>
    <script src=""/App_theme/DinaTheme/slider/assets/theme/js/script.min.js""></script>
    <script src=""/App_theme/DinaTheme/slider/assets/bootstrapcarouselswipe/bootstrap-carousel-swipe.min.js""></script>
    <script src=""/App_theme/DinaTheme/js/owl.carousel.min.js""></script>
    <script src=""/App_theme/DinaTheme/js/aos.min.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0aadc5bc0d3fda55b3b8c093ddf82ed7efc4325e20443", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 242 "D:\Workspace\DinaService\Webapp\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 243 "D:\Workspace\DinaService\Webapp\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
