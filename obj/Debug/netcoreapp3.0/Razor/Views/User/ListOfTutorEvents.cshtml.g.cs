#pragma checksum "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfTutorEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e70b49d3d6554dc184a0844f5cad699f79ddb15e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ListOfTutorEvents), @"mvc.1.0.view", @"/Views/User/ListOfTutorEvents.cshtml")]
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
#line 8 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e70b49d3d6554dc184a0844f5cad699f79ddb15e", @"/Views/User/ListOfTutorEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"907e38622cfb845b4eee5255df780c43d411cd46", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ListOfTutorEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ILearnCoreV19.Areas.Identity.Data.ApplicationEvent>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
  
    ViewData["Title"] = "ListOfTutorEvents";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            text\r\n        </th>\r\n        <th>\r\n            subscriberEmail\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 21 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
           Write(Html.DisplayFor(modelItem => item.text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
           Write(Html.DisplayFor(modelItem => item.subscriberEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 31 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
                 using (Html.BeginForm("AcceptSubscription", "User", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <!-- form goes here -->\r\n");
#nullable restore
#line 34 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
               Write(Html.Hidden("eventId", item.EventId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
               Write(Html.Hidden("returnUrl", "/"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"submit\" value=\"Accept\" class=\"btn btn-success\" style=\"width:200px\" />\r\n");
#nullable restore
#line 37 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br>\r\n");
#nullable restore
#line 39 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
                 using (Html.BeginForm("RejectSubscription", "User", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <!-- form goes here -->\r\n");
#nullable restore
#line 42 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
               Write(Html.Hidden("eventId", item.EventId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
               Write(Html.Hidden("returnUrl", $"http://localhost:59000/User/ListOfEvents/{item.userId}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"submit\" value=\"Reject\" class=\"btn btn-danger\" style=\"width:200px\" />\r\n");
#nullable restore
#line 45 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 48 "C:\University\BSC Thesis\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ILearnCoreV19.Areas.Identity.Data.ApplicationEvent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
