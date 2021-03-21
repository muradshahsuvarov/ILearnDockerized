#pragma checksum "C:\Users\Murad\Desktop\ILearnCore\Views\User\ListOfTutorEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22facc4c928a6c165b454078be24eb33b95cd60d"
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
#line 8 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22facc4c928a6c165b454078be24eb33b95cd60d", @"/Views/User/ListOfTutorEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"907e38622cfb845b4eee5255df780c43d411cd46", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ListOfTutorEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ILearnCoreV19.Areas.Identity.Data.ApplicationEvent>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
  
    ViewData["Title"] = "Subject Requests";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div style=""height: 500px; overflow: auto;"">
    <table class=""table"">
        <tr>
            <th>
                Subject Name
            </th>
            <th>
                Subscriber Email
            </th>
            <th></th>
        </tr>

");
#nullable restore
#line 22 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 26 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
               Write(Html.DisplayFor(modelItem => item.text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
               Write(Html.DisplayFor(modelItem => item.subscriberEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 32 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
                     using (Html.BeginForm("AcceptSubscription", "User", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <!-- form goes here -->\r\n");
#nullable restore
#line 35 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
                   Write(Html.Hidden("eventId", item.EventId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
                   Write(Html.Hidden("returnUrl", "/"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"submit\" value=\"Accept\" class=\"btn btn-success\" style=\"width:200px\" />\r\n");
#nullable restore
#line 38 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <br>\r\n");
#nullable restore
#line 40 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
                     using (Html.BeginForm("RejectSubscription", "User", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <!-- form goes here -->\r\n");
#nullable restore
#line 43 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
                   Write(Html.Hidden("eventId", item.EventId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
                   Write(Html.Hidden("returnUrl", $"http://localhost:59000/User/ListOfEvents/{item.userId}"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"submit\" value=\"Reject\" class=\"btn btn-danger\" style=\"width:200px\" />\r\n");
#nullable restore
#line 46 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 49 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ListOfTutorEvents.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n    </div>");
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
