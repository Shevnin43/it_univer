#pragma checksum "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Shared\Task\RowDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1116ade759a02df1c373dce6738e0b603a684371"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Task_RowDetails), @"mvc.1.0.view", @"/Views/Shared/Task/RowDetails.cshtml")]
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
#line 1 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Shared\Task\RowDetails.cshtml"
using ITUniversity.Task.API.Services.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Shared\Task\RowDetails.cshtml"
using TaskStatus = It_Univer.Tasks.Enums.TaskStatus;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1116ade759a02df1c373dce6738e0b603a684371", @"/Views/Shared/Task/RowDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5dee8dab42800e82a9e27274c0b8fe0c081cdd5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Task_RowDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Shared\Task\RowDetails.cshtml"
  
    Func<TaskDto, string> calculateCardTitleStyle = task =>
    {
        return $"display: flex;{(string.IsNullOrWhiteSpace(task.Description) ? " margin-bottom: 0px;" : "")}";
    };

    Func<TaskDto, string> calculateBadgeClass = task =>
    {
        return $"badge badge-{(task.Status == It_Univer.Tasks.Enums.TaskStatus.ToDo ? "primary" : "danger")}";
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <div style=\"display: flex\">\r\n            <h5 class=\"card-title\"");
            BeginWriteAttribute("style", " style=\"", 622, "\"", 661, 1);
#nullable restore
#line 22 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Shared\Task\RowDetails.cshtml"
WriteAttributeValue("", 630, calculateCardTitleStyle(Model), 630, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 683, "\"", 743, 1);
#nullable restore
#line 23 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Shared\Task\RowDetails.cshtml"
WriteAttributeValue("", 690, Url.Action("Details", "Task", new { id = Model.Id }), 690, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 24 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Shared\Task\RowDetails.cshtml"
               Write(Model.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n                    <span");
            BeginWriteAttribute("class", " class=\"", 830, "\"", 865, 1);
#nullable restore
#line 26 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Shared\Task\RowDetails.cshtml"
WriteAttributeValue("", 838, calculateBadgeClass(Model), 838, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-left: 5px; margin-top: 5px;\">\r\n                        ");
#nullable restore
#line 27 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Shared\Task\RowDetails.cshtml"
                   Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n            </h5>\r\n            <div style=\"width: 100%\">\r\n                <span class=\"material-icons\" style=\"float: right; cursor: pointer; color: orange;\"> <a");
            BeginWriteAttribute("href", " href=\"", 1140, "\"", 1193, 1);
#nullable restore
#line 31 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Shared\Task\RowDetails.cshtml"
WriteAttributeValue("", 1147, Url.Action("Update", "Task", new {Model.Id }), 1147, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color: orange;\">update</a> </span>\r\n\r\n                <span class=\"material-icons\" style=\"float: right; cursor: pointer; color: red;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1335, "\"", 1375, 4);
            WriteAttributeValue("", 1345, "task.remove(\'", 1345, 13, true);
#nullable restore
#line 33 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Shared\Task\RowDetails.cshtml"
WriteAttributeValue("", 1358, Model.Id, 1358, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1367, "\',", 1367, 2, true);
            WriteAttributeValue(" ", 1369, "this)", 1370, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    delete\r\n                </span>\r\n            </div>\r\n        </div>\r\n        ");
#nullable restore
#line 38 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Shared\Task\RowDetails.cshtml"
   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <span");
            BeginWriteAttribute("class", " class=\"", 1511, "\"", 1546, 1);
#nullable restore
#line 40 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Shared\Task\RowDetails.cshtml"
WriteAttributeValue("", 1519, calculateBadgeClass(Model), 1519, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-right: 5px; margin-bottom: 5px;\">\r\n            ");
#nullable restore
#line 41 "D:\Projects\ItUniver\it_univer\It-univer.Tasks\It_Univer.Tasks\Views\Shared\Task\RowDetails.cshtml"
       Write(Model.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
