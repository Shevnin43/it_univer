#pragma checksum "C:\univer\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Task\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0817c00801f37ad28c5763b429f2100762b31985"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Task_Create), @"mvc.1.0.view", @"/Views/Task/Create.cshtml")]
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
#line 1 "C:\univer\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\_ViewImports.cshtml"
using It_Univer.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\univer\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\_ViewImports.cshtml"
using It_Univer.Tasks.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\univer\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\_ViewImports.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\univer\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Task\Create.cshtml"
using It_Univer.Tasks.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0817c00801f37ad28c5763b429f2100762b31985", @"/Views/Task/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5dee8dab42800e82a9e27274c0b8fe0c081cdd5", @"/Views/_ViewImports.cshtml")]
    public class Views_Task_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskCreateModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n");
#nullable restore
#line 7 "C:\univer\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Task\Create.cshtml"
         using (Html.BeginForm("Create", "Task"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div id=\"modUser\" class=\"modal fade\">\r\n                <div id=\"dialogUser\" class=\"modal-dialog\"></div>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h4> Создание новой задачи: </h4>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                        ");
#nullable restore
#line 19 "C:\univer\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Task\Create.cshtml"
                   Write(Html.LabelFor(model => model.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 20 "C:\univer\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Task\Create.cshtml"
                   Write(Html.TextAreaFor(model => model.Subject, new {@class= "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 21 "C:\univer\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Task\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 24 "C:\univer\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Task\Create.cshtml"
                   Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 25 "C:\univer\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Task\Create.cshtml"
                   Write(Html.TextAreaFor(model => model.Description, new {@class= "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    ");
#nullable restore
#line 27 "C:\univer\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Task\Create.cshtml"
               Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"modal-footer\">\r\n                    <input type=\"submit\" class=\"btn btn-success\" value=\"Создать\" />\r\n                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1329, "\"", 1364, 1);
#nullable restore
#line 31 "C:\univer\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Task\Create.cshtml"
WriteAttributeValue("", 1336, Url.Action("Index", "Task"), 1336, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Отмена</a>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 34 "C:\univer\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Task\Create.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0817c00801f37ad28c5763b429f2100762b319857887", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0817c00801f37ad28c5763b429f2100762b319858986", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskCreateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
