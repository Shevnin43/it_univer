#pragma checksum "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\User\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afbbbbd23b81d78ec5df49849bdc4b0d2f3285fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Edit), @"mvc.1.0.view", @"/Views/User/Edit.cshtml")]
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
#line 1 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\_ViewImports.cshtml"
using It_Univer.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\_ViewImports.cshtml"
using It_Univer.Tasks.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\_ViewImports.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\User\Edit.cshtml"
using It_Univer.Tasks.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\User\Edit.cshtml"
using ITUniversity.Task.API.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\User\Edit.cshtml"
using It_Univer.Tasks.Repositories;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afbbbbd23b81d78ec5df49849bdc4b0d2f3285fb", @"/Views/User/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5dee8dab42800e82a9e27274c0b8fe0c081cdd5", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserEditModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/view-resources/user/scripts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\User\Edit.cshtml"
  
    var roles = RoleAppService.GetAll().Select(role => new SelectListItem { Text = role.Name, Value = role.Id.ToString() });
    var formId = $"user_{Model.Id}";
    var backUrl = Url.Action("Index", "User");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        Редактирование пользователя - ");
#nullable restore
#line 17 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\User\Edit.cshtml"
                                 Write(Model.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"card-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afbbbbd23b81d78ec5df49849bdc4b0d2f3285fb5469", async() => {
                WriteLiteral("\r\n            ");
#nullable restore
#line 21 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\User\Edit.cshtml"
       Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 22 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\User\Edit.cshtml"
       Write(Html.HiddenFor(model => model.Login));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 25 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\User\Edit.cshtml"
           Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 26 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\User\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.Email, string.Empty, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 30 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\User\Edit.cshtml"
           Write(Html.LabelFor(model => model.Role));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 31 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\User\Edit.cshtml"
           Write(Html.DropDownListFor(model => model.Role, roles, string.Empty, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 20 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\User\Edit.cshtml"
AddHtmlAttributeValue("", 562, formId, 562, 7, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "name", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 20 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\User\Edit.cshtml"
AddHtmlAttributeValue("", 577, formId, 577, 7, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 20 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\User\Edit.cshtml"
AddHtmlAttributeValue("", 593, formId, 593, 7, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <a class=\"btn btn-outline-danger\" style=\"float:right\"");
            BeginWriteAttribute("href", " href=\"", 1225, "\"", 1260, 1);
#nullable restore
#line 34 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\User\Edit.cshtml"
WriteAttributeValue("", 1232, Url.Action("Index", "User"), 1232, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Отмена</a>\r\n        <button class=\"btn btn-outline-success\" style=\"float:right\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1341, "\"", 1385, 6);
            WriteAttributeValue("", 1351, "user.update(\'", 1351, 13, true);
#nullable restore
#line 35 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\User\Edit.cshtml"
WriteAttributeValue("", 1364, formId, 1364, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1371, "\',", 1371, 2, true);
            WriteAttributeValue(" ", 1373, "\'", 1374, 2, true);
#nullable restore
#line 35 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\User\Edit.cshtml"
WriteAttributeValue("", 1375, backUrl, 1375, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1383, "\')", 1383, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Сохранить</button>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afbbbbd23b81d78ec5df49849bdc4b0d2f3285fb11530", async() => {
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
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IRoleAppService RoleAppService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserEditModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
