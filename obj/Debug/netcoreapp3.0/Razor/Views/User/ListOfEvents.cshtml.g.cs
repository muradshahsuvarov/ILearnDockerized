#pragma checksum "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e702e0cde39e568c0bed24f912daccc661c6189"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ListOfEvents), @"mvc.1.0.view", @"/Views/User/ListOfEvents.cshtml")]
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
#nullable restore
#line 9 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfEvents.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e702e0cde39e568c0bed24f912daccc661c6189", @"/Views/User/ListOfEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"907e38622cfb845b4eee5255df780c43d411cd46", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ListOfEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ILearnCoreV19.Areas.Identity.Data.ApplicationEvent>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfEvents.cshtml"
  
    ViewData["Title"] = "ListOfEvents";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            text\r\n        </th>\r\n        <th>\r\n            start_date\r\n        </th>\r\n        <th>\r\n            end_date\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 30 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfEvents.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfEvents.cshtml"
           Write(Html.DisplayFor(modelItem => item.text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfEvents.cshtml"
           Write(Html.DisplayFor(modelItem => item.start_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfEvents.cshtml"
           Write(Html.DisplayFor(modelItem => item.end_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 43 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfEvents.cshtml"
                 using (Html.BeginForm("Subscribe", "User", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <!-- form goes here -->\r\n");
#nullable restore
#line 46 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfEvents.cshtml"
               Write(Html.Hidden("userName", item.userId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfEvents.cshtml"
               Write(Html.Hidden("eventId", item.EventId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfEvents.cshtml"
               Write(Html.Hidden("email", User.Identity.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfEvents.cshtml"
               Write(Html.Hidden("returnUrl", "/User/ListOfEvents"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"submit\" value=\"Subscribe\" class=\"btn btn-success\" style=\"width:200px\" />\r\n");
#nullable restore
#line 51 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfEvents.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 54 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfEvents.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
