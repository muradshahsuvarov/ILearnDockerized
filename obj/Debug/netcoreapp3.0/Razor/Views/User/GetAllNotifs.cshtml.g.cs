#pragma checksum "C:\University\BSC Thesis\ILearnCore\Views\User\GetAllNotifs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec55bec240ac92390012160aabd6edd9cdd71dc0"
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
#line 1 "C:\University\BSC Thesis\ILearnCore\Views\_ViewImports.cshtml"
using ILearnCoreV19;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\University\BSC Thesis\ILearnCore\Views\_ViewImports.cshtml"
using ILearnCoreV19.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec55bec240ac92390012160aabd6edd9cdd71dc0", @"/Views/User/GetAllNotifs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"907e38622cfb845b4eee5255df780c43d411cd46", @"/Views/_ViewImports.cshtml")]
    public class Views_User_GetAllNotifs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ILearnCoreV19.Areas.Identity.Data.ApplicationNotif>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\University\BSC Thesis\ILearnCore\Views\User\GetAllNotifs.cshtml"
  
    ViewData["Title"] = "Users";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 11 "C:\University\BSC Thesis\ILearnCore\Views\User\GetAllNotifs.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 14 "C:\University\BSC Thesis\ILearnCore\Views\User\GetAllNotifs.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 17 "C:\University\BSC Thesis\ILearnCore\Views\User\GetAllNotifs.cshtml"
       Write(Html.DisplayNameFor(model => model.Header));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 20 "C:\University\BSC Thesis\ILearnCore\Views\User\GetAllNotifs.cshtml"
       Write(Html.DisplayNameFor(model => model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 23 "C:\University\BSC Thesis\ILearnCore\Views\User\GetAllNotifs.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 26 "C:\University\BSC Thesis\ILearnCore\Views\User\GetAllNotifs.cshtml"
       Write(Html.DisplayNameFor(model => model.IsRead));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 31 "C:\University\BSC Thesis\ILearnCore\Views\User\GetAllNotifs.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 35 "C:\University\BSC Thesis\ILearnCore\Views\User\GetAllNotifs.cshtml"
   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 38 "C:\University\BSC Thesis\ILearnCore\Views\User\GetAllNotifs.cshtml"
   Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 41 "C:\University\BSC Thesis\ILearnCore\Views\User\GetAllNotifs.cshtml"
   Write(Html.DisplayFor(modelItem => item.Header));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 44 "C:\University\BSC Thesis\ILearnCore\Views\User\GetAllNotifs.cshtml"
   Write(Html.DisplayFor(modelItem => item.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 47 "C:\University\BSC Thesis\ILearnCore\Views\User\GetAllNotifs.cshtml"
   Write(Html.DisplayFor(modelItem => item.CreatedAt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 50 "C:\University\BSC Thesis\ILearnCore\Views\User\GetAllNotifs.cshtml"
   Write(Html.DisplayFor(modelItem => item.IsRead));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n");
#nullable restore
#line 53 "C:\University\BSC Thesis\ILearnCore\Views\User\GetAllNotifs.cshtml"
          
            /*
            @Html.ActionLink("Edit", "Edit", new { id = item.UserID })
            @Html.ActionLink("Details", "GetDetails", "User", new { id = item.UserID }, null)
            @Html.ActionLink("Delete", "Delete", new { id = item.UserID })
            */
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </td>\r\n</tr>\r\n");
#nullable restore
#line 62 "C:\University\BSC Thesis\ILearnCore\Views\User\GetAllNotifs.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n\r\n");
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