#pragma checksum "C:\University\BSC Thesis\ILearnCore\Views\User\Teachers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "743f3d3c74aaefd52b71ad62fc9f0032ac6dd827"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Teachers), @"mvc.1.0.view", @"/Views/User/Teachers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"743f3d3c74aaefd52b71ad62fc9f0032ac6dd827", @"/Views/User/Teachers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"907e38622cfb845b4eee5255df780c43d411cd46", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Teachers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ILearnCoreV19.Areas.Identity.Data.ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\University\BSC Thesis\ILearnCore\Views\User\Teachers.cshtml"
  
    ViewData["Title"] = "Teachers";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\University\BSC Thesis\ILearnCore\Views\User\Teachers.cshtml"
  
    ViewBag.Title = "Teachers";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table class=""table"">
    <tr>
        <th>
            FirstName
        </th>
        <th>
            LastName
        </th>
        <th>
            Email
        </th>
        <th>
            DateOfBirth
        </th>

        <th></th>
    </tr>

");
#nullable restore
#line 31 "C:\University\BSC Thesis\ILearnCore\Views\User\Teachers.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\University\BSC Thesis\ILearnCore\Views\User\Teachers.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\University\BSC Thesis\ILearnCore\Views\User\Teachers.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\University\BSC Thesis\ILearnCore\Views\User\Teachers.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\University\BSC Thesis\ILearnCore\Views\User\Teachers.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n\r\n                ");
#nullable restore
#line 48 "C:\University\BSC Thesis\ILearnCore\Views\User\Teachers.cshtml"
           Write(Html.ActionLink("Details", "GetDetails", "User", new { id = item.UserName }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 49 "C:\University\BSC Thesis\ILearnCore\Views\User\Teachers.cshtml"
           Write(Html.ActionLink("Schedule", "ListOfEvents", "User", new { id = item.UserName }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 52 "C:\University\BSC Thesis\ILearnCore\Views\User\Teachers.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ILearnCoreV19.Areas.Identity.Data.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
