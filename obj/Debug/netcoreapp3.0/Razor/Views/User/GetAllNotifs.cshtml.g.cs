#pragma checksum "C:\Users\Murad\Desktop\ILearnCore\Views\User\GetAllNotifs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51c31a167fe9319694de9dc86bb8b9e085d47b68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_GetAllNotifs), @"mvc.1.0.view", @"/Views/User/GetAllNotifs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51c31a167fe9319694de9dc86bb8b9e085d47b68", @"/Views/User/GetAllNotifs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"907e38622cfb845b4eee5255df780c43d411cd46", @"/Views/_ViewImports.cshtml")]
    public class Views_User_GetAllNotifs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ILearnCoreV19.Areas.Identity.Data.ApplicationNotif>>
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
#line 3 "C:\Users\Murad\Desktop\ILearnCore\Views\User\GetAllNotifs.cshtml"
  
    ViewData["Title"] = "Users";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51c31a167fe9319694de9dc86bb8b9e085d47b683371", async() => {
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
                Name
            </th>
            <th>
                Description
            </th>
            <th>
                Time
            </th>
            <th>
                Read
            </th>
            <th></th>
        </tr>

");
#nullable restore
#line 32 "C:\Users\Murad\Desktop\ILearnCore\Views\User\GetAllNotifs.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\Murad\Desktop\ILearnCore\Views\User\GetAllNotifs.cshtml"
               Write(Html.DisplayFor(modelItem => item.Header));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\Murad\Desktop\ILearnCore\Views\User\GetAllNotifs.cshtml"
               Write(Html.Raw(item.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\Murad\Desktop\ILearnCore\Views\User\GetAllNotifs.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\Murad\Desktop\ILearnCore\Views\User\GetAllNotifs.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsRead));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 48 "C:\Users\Murad\Desktop\ILearnCore\Views\User\GetAllNotifs.cshtml"
                      
                        /*
                        @Html.ActionLink("Edit", "Edit", new { id = item.UserID })
                        @Html.ActionLink("Details", "GetDetails", "User", new { id = item.UserID }, null)
                        @Html.ActionLink("Delete", "Delete", new { id = item.UserID })
                        */
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Murad\Desktop\ILearnCore\Views\User\GetAllNotifs.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ILearnCoreV19.Areas.Identity.Data.ApplicationNotif>> Html { get; private set; }
    }
}
#pragma warning restore 1591
