#pragma checksum "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/User.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0550e9ee82b9ed342dc6b2f651d626ebff3e4f03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(semWork.Pages.Pages_User), @"mvc.1.0.razor-page", @"/Pages/User.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0550e9ee82b9ed342dc6b2f651d626ebff3e4f03", @"/Pages/User.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2853ff0ca9020134a200ba17069f15246e8179d0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_User : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("image_loader"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "LogOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"./css/profilePage.css\" />\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 8 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/User.cshtml"
   ViewData["Title"] = "Profile"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"first_container\">\r\n\r\n    <h1>\r\n        Профиль\r\n    </h1>\r\n\r\n    <div class=\"profile_container\">\r\n        <div class=\"row_of_profile\">\r\n            <div>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 361, "\"", 384, 1);
#nullable restore
#line 21 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/User.cshtml"
WriteAttributeValue("", 367, Model.user.photo, 367, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"300px\" height=\"300px\" alt=\"prf\">\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0550e9ee82b9ed342dc6b2f651d626ebff3e4f035752", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0550e9ee82b9ed342dc6b2f651d626ebff3e4f036028", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 24 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/User.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Photo);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <input type=\"submit\" class=\"img_submit\"/>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"container-info\">\r\n                <div class=\"container-info-column\">\r\n                    <h2 class=\"username_title\">\r\n                        ");
#nullable restore
#line 31 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/User.cshtml"
                   Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h2>\r\n\r\n                    <div class=\"user_info\">\r\n                        <p>\r\n                            <b> Полных лет: ");
#nullable restore
#line 36 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/User.cshtml"
                                       Write(Model.age);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0550e9ee82b9ed342dc6b2f651d626ebff3e4f0310036", async() => {
                WriteLiteral("\r\n                    <button class=\"button_logout\">\r\n                        Выйти\r\n                    </button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("c", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n                <div class=\"courses_container\">\r\n");
#nullable restore
#line 49 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/User.cshtml"
                     if (Model.Courses != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>\r\n                Любимые курсы\r\n            </h2>\r\n");
            WriteLiteral("                            <ul class=\"li_courses\">\r\n");
#nullable restore
#line 56 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/User.cshtml"
                                 foreach (var course in Model.Courses)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"item_courses\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1766, "\"", 1785, 1);
#nullable restore
#line 59 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/User.cshtml"
WriteAttributeValue("", 1772, course.photo, 1772, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50px\" height=\"50px\" />\r\n                                        <div class=\"column_item\">\r\n                                            <a href=\"#\" class=\"label_of_item_course\">\r\n                                                ");
#nullable restore
#line 62 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/User.cshtml"
                                           Write(course.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                                            </a>\r\n                                            <p class=\"item_course_desc\">\r\n                                                ");
#nullable restore
#line 65 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/User.cshtml"
                                           Write(course.description);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                                            </p>\r\n                                        </div>\r\n                                    </li>\r\n");
#nullable restore
#line 69 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/User.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul> ");
#nullable restore
#line 70 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/User.cshtml"
                                  }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h2>\r\n                                                Нет любимых курсов\r\n                                            </h2>\r\n");
#nullable restore
#line 76 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/User.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<semWork.Pages.Users.UserModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<semWork.Pages.Users.UserModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<semWork.Pages.Users.UserModel>)PageContext?.ViewData;
        public semWork.Pages.Users.UserModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
