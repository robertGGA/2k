#pragma checksum "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/Settings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a79cb45b1ae646d3ccd72212db256e5dc7b12a1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(semWork.Pages.Pages_Settings), @"mvc.1.0.razor-page", @"/Pages/Settings.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/Settings/{handler?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a79cb45b1ae646d3ccd72212db256e5dc7b12a1f", @"/Pages/Settings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2853ff0ca9020134a200ba17069f15246e8179d0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Settings : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/Settings.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 4 "/Users/gadelshinrr/Desktop/2kGit/2k/2021/2k/1sem/semWork/Pages/Settings.cshtml"
   ViewData["Title"] = "Settings"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"first_container first-container-wrapper\">\r\n    <h1>\r\n        Настройки аккаунта\r\n    </h1>\r\n    <div class=\"settings-container\">\r\n        <h2>Изменить данные</h2>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a79cb45b1ae646d3ccd72212db256e5dc7b12a1f4056", async() => {
                WriteLiteral(@"
            <label for=""login"">
                Логин
            </label>
            <input class=""input-example"" id=""login"" type=""text"" />
            <label for=""password"">
                Пароль
            </label>
            <input class=""input-example"" id=""password"" type=""password"" />
            <label for=""age"">
                Возраст
            </label>
            <input class=""input-example"" id=""age"" type=""number"" min=""4"" max=""100"" />
            <input type=""submit"" class=""submit-button"" placeholder=""Изменить"" />
        ");
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
            WriteLiteral(@"


    </div>
</div>
<script src=""https://code.jquery.com/jquery-3.5.1.js"" integrity=""sha256-QWo7LDvxbWT2tbbQ97B53yJnYU3WhH/C8ycbRAkjPDc="" crossorigin=""anonymous""></script>
<script>const form = document.querySelector('.form-container');
    const login = document.querySelector('#login');
    const pass = document.querySelector('#password');
    const age = document.querySelector('#age');
    const reg = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z]{8,}$/;
    form.addEventListener('submit', (event) => {
        event.preventDefault();
        console.log(reg.test(pass.value))
        console.log(pass.value)
        if (login.value.lenght != """" && reg.test(pass.value)) {
            const data = {
                Login: login.value,
                Password: pass.value,
                Age: age.value
            }


            $.ajax({
                type: ""POST"",
                url: '/Settings?handler=ChangeUserParams',
                beforeSend: function (xhr) {
                 ");
            WriteLiteral(@"   xhr.setRequestHeader(""XSRF-TOKEN"",
                        $('input:hidden[name=""__RequestVerificationToken""]').val());
                },
                data: JSON.stringify(data),
                dataType: ""json"",
                contentType: ""application/json; charset=utf-8""
            }).done(function (comment) {
                alert('done!');
            });
        }
    });</script>

");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"../../css/settings.css\">\r\n    <link rel=\"stylesheet\" href=\"../../css/mainPage.css\" />\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<semWork.Pages.SettingsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<semWork.Pages.SettingsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<semWork.Pages.SettingsModel>)PageContext?.ViewData;
        public semWork.Pages.SettingsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
