#pragma checksum "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ced8d49902d33011edae73af9f4054b55fea5a97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(semWork.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace semWork.Pages
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
#line 1 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/_ViewImports.cshtml"
using semWork;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ced8d49902d33011edae73af9f4054b55fea5a97", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2853ff0ca9020134a200ba17069f15246e8179d0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/Index.cshtml"
  
    ViewData["Title"] = "FuLearn";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main"">
    <div class=""main_wrapper"">
        <div class=""first_container"">
            <h1>Наш сайт специализируется на учебных курсах</h1>

            <div class=""content_of_first_container"">
                <div class=""row"">
                    <div class=""text_container"">
                        <div class=""subline_for_h3"">
                            <h3>Расширенная библиотека курсов</h3>
                        </div>
                        <p>В нашей базе хранится более тысячи курсов от разных компаний</p>
                    </div>

                    <img src=""books-g1ecf9eb61_1920.jpg"" width=""500"" height=""350"" />
                </div>

                <div class=""row reversed-row"">
                    <div class=""text_container"">
                        <div class=""subline_for_h3"">
                            <h3>Расширенная библиотека курсов</h3>
                        </div>
                        <p>В нашей базе хранится более тысячи курсов от разных компаний</p>
             ");
            WriteLiteral(@"       </div>

                    <img src=""books-g1ecf9eb61_1920.jpg"" width=""500"" height=""350"" />
                </div>

                <div class=""row"">
                    <div class=""text_container"">
                        <div class=""subline_for_h3"">
                            <h3>Расширенная библиотека курсов</h3>
                        </div>
                        <p>В нашей базе хранится более тысячи курсов от разных компаний</p>
                    </div>

                    <img src=""books-g1ecf9eb61_1920.jpg"" width=""500"" height=""350"" />
                </div>
            </div>

            <h1 class=""second_title"">Типы курсов на нашем сайте</h1>

            <div class=""types_of_course"">

            </div>



            <h1 class=""second_title"">Попробуйте прямо сейчас!</h1>

            <div class=""buttons_container"">

                <button class=""button"">
                    Зарегистрироваться
                </button>

");
#nullable restore
#line 63 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/Index.cshtml"
                 foreach (var user in Model.People)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr><td>");
#nullable restore
#line 65 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/Index.cshtml"
                       Write(user.login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 65 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/Index.cshtml"
                                           Write(user.age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\n");
#nullable restore
#line 66 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <button class=\"button\">\n                    Войти\n                </button>\n            </div>\n        </div>\n    </div>\n</main>\n\n<footer class=\"footer_wrapper\">\n    <div class=\"footer\">\n\n    </div>\n</footer>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
