#pragma checksum "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/Courses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55fc108cd5c4013748bfb30df1dac6d63082947d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(semWork.Pages.Pages_Courses), @"mvc.1.0.razor-page", @"/Pages/Courses.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55fc108cd5c4013748bfb30df1dac6d63082947d", @"/Pages/Courses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2853ff0ca9020134a200ba17069f15246e8179d0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Courses : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("searcher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/Courses.cshtml"
   ViewData["Title"] = "Courses"; 

#line default
#line hidden
#nullable disable
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"./css/ListOfCourses.css\">\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"first_container\">\r\n    <h1>\r\n        Курсы\r\n    </h1>\r\n\r\n    <div class=\"container_of_courses\">\r\n        <div class=\"searcher_wrapper\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55fc108cd5c4013748bfb30df1dac6d63082947d4161", async() => {
                WriteLiteral("\r\n                <i");
                BeginWriteAttribute("class", " class=\"", 368, "\"", 376, 0);
                EndWriteAttribute();
                WriteLiteral(" aria-hidden=\"true\"></i>\r\n                <input class=\"search\" type=\"text\" placeholder=\"Введите имя курса\" id=\"searcher\">\r\n                <input class=\"search_button\" type=\"submit\" value=\"Поиск\" id=\"submitSearch\">\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            <ul class=\"course_list\">\r\n");
#nullable restore
#line 22 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/Courses.cshtml"
                 foreach (var course in Model.courses)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"course\"");
            BeginWriteAttribute("id", " id=\"", 768, "\"", 790, 1);
#nullable restore
#line 24 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/Courses.cshtml"
WriteAttributeValue("", 773, course.course_id, 773, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 824, "\"", 843, 1);
#nullable restore
#line 26 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/Courses.cshtml"
WriteAttributeValue("", 830, course.photo, 830, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"150\" width=\"140\" />\r\n                        <div class=\"course_container\">\r\n\r\n                            <h2>\r\n                                ");
#nullable restore
#line 30 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/Courses.cshtml"
                           Write(course.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </h2>

                            <div class=""rate"">
                                Балл курса:
                            </div>


                            <p class=""description_course"">
                                ");
#nullable restore
#line 39 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/Courses.cshtml"
                           Write(course.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55fc108cd5c4013748bfb30df1dac6d63082947d7929", async() => {
                WriteLiteral("\r\n                                <input type=\"submit\" id=\"to_course\" class=\"to_course\" placeholder=\"Перейти\">\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/Courses.cshtml"
                                                       WriteLiteral(course.course_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n                        </div>\r\n                    </li>\r\n");
#nullable restore
#line 49 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/Courses.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </ul>
        </div>
    </div>

    <script src=""https://code.jquery.com/jquery-3.5.1.js"" integrity=""sha256-QWo7LDvxbWT2tbbQ97B53yJnYU3WhH/C8ycbRAkjPDc="" crossorigin=""anonymous""></script>

    <script>
        jQuery(document).ready(function ($) {
            $(document).on(""click"", ""#submitSearch"", function (e) {
                event.preventDefault();
                let searchValue = $(""#searcher"").val().toLowerCase();

                 $("".course_list"").each(function () {
                    let stringData = $(this).text().toLowerCase();
                    if (stringData.indexOf(searchValue) === -1) {
                        $(this).hide();
                    } else {
                        $(this).show();
                    }
                })
            })
        });

    </script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<semWork.Pages.CoursesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<semWork.Pages.CoursesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<semWork.Pages.CoursesModel>)PageContext?.ViewData;
        public semWork.Pages.CoursesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
