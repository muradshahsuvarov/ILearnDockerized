#pragma checksum "C:\Users\Murad\Desktop\ILearnCore\Views\User\StudentSubjects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7aa3593780585d208881b94c058d898d449e0c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_StudentSubjects), @"mvc.1.0.view", @"/Views/User/StudentSubjects.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Murad\Desktop\ILearnCore\Views\_ViewImports.cshtml"
using ILearnCoreV19;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Murad\Desktop\ILearnCore\Views\_ViewImports.cshtml"
using ILearnCoreV19.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Murad\Desktop\ILearnCore\Views\User\StudentSubjects.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7aa3593780585d208881b94c058d898d449e0c9", @"/Views/User/StudentSubjects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"907e38622cfb845b4eee5255df780c43d411cd46", @"/Views/_ViewImports.cshtml")]
    public class Views_User_StudentSubjects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ILearnCoreV19.Areas.Identity.Data.ApplicationEvent>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Murad\Desktop\ILearnCore\Views\User\StudentSubjects.cshtml"
  
    ViewData["Title"] = "Student Requests";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7aa3593780585d208881b94c058d898d449e0c93572", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Raleway"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
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
            WriteLiteral(@"

<div style=""height: 500px; overflow: auto;"">
    <table class=""table"">
        <tr>
            <th>
                Class
            </th>
            <th>
                Description
            </th>
            <th>
                Start Date
            </th>
            <th>
                End Date
            </th>
            <th>
                Status
            </th>
            <th>
                Price
            </th>
            <th>
                Paid
            </th>
            <th>
                Subscriber Email
            </th>
            <th></th>
        </tr>

");
#nullable restore
#line 46 "C:\Users\Murad\Desktop\ILearnCore\Views\User\StudentSubjects.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 50 "C:\Users\Murad\Desktop\ILearnCore\Views\User\StudentSubjects.cshtml"
       Write(Html.DisplayFor(modelItem => item.text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 53 "C:\Users\Murad\Desktop\ILearnCore\Views\User\StudentSubjects.cshtml"
       Write(Html.DisplayFor(modelItem => item.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 56 "C:\Users\Murad\Desktop\ILearnCore\Views\User\StudentSubjects.cshtml"
       Write(Html.DisplayFor(modelItem => item.start_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 59 "C:\Users\Murad\Desktop\ILearnCore\Views\User\StudentSubjects.cshtml"
       Write(Html.DisplayFor(modelItem => item.end_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 62 "C:\Users\Murad\Desktop\ILearnCore\Views\User\StudentSubjects.cshtml"
       Write(Html.DisplayFor(modelItem => item.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 65 "C:\Users\Murad\Desktop\ILearnCore\Views\User\StudentSubjects.cshtml"
       Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("€\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 68 "C:\Users\Murad\Desktop\ILearnCore\Views\User\StudentSubjects.cshtml"
       Write(Html.DisplayFor(modelItem => item.IsPaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 71 "C:\Users\Murad\Desktop\ILearnCore\Views\User\StudentSubjects.cshtml"
       Write(Html.DisplayFor(modelItem => item.subscriberEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n");
#nullable restore
#line 74 "C:\Users\Murad\Desktop\ILearnCore\Views\User\StudentSubjects.cshtml"
             using (Html.BeginForm("StudentRejectSubscription", "User", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <!-- form goes here -->\r\n");
#nullable restore
#line 77 "C:\Users\Murad\Desktop\ILearnCore\Views\User\StudentSubjects.cshtml"
           Write(Html.Hidden("eventId", item.EventId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\Murad\Desktop\ILearnCore\Views\User\StudentSubjects.cshtml"
           Write(Html.Hidden("returnUrl", $"~/User/StudentSubjects"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"submit\" value=\"Reject\" class=\"btn btn-danger\" style=\"width:200px\" />\r\n");
#nullable restore
#line 80 "C:\Users\Murad\Desktop\ILearnCore\Views\User\StudentSubjects.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </td>\r\n    </tr>\r\n");
#nullable restore
#line 83 "C:\Users\Murad\Desktop\ILearnCore\Views\User\StudentSubjects.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ILearnCoreV19.Areas.Identity.Data.ApplicationEvent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
