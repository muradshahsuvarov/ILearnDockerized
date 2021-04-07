#pragma checksum "C:\Users\Murad\Desktop\ILearnCore\Views\User\ManageSubscription.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c037c7fb9a70fb5ed17342bae944debe9ec1c458"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ManageSubscription), @"mvc.1.0.view", @"/Views/User/ManageSubscription.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c037c7fb9a70fb5ed17342bae944debe9ec1c458", @"/Views/User/ManageSubscription.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"907e38622cfb845b4eee5255df780c43d411cd46", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ManageSubscription : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ILearnCoreV19.Data.AuthDbContext>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckCoursePayment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ManageSubscription.cshtml"
  
    ViewData["Title"] = "Payment";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ManageSubscription.cshtml"
  
    var _context = Model;
    var myEvents = _context.Events.Where(e => e.userId == User.Identity.Name && e.status == "ACCEPTED" && e.start_date >= DateTime.Now);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c037c7fb9a70fb5ed17342bae944debe9ec1c4584903", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Raleway"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">

    <style>
        ");
                WriteLiteral(@"@import url('https://fonts.googleapis.com/css?family=Muli&display=swap');

        .courses-container {
        }

        .course {
            background-color: #fff;
            border-radius: 10px;
            box-shadow: 0 10px 10px rgba(0, 0, 0, 0.2);
            display: flex;
            max-width: 100%;
            margin: 20px;
            overflow: hidden;
            width: 700px;
        }

            .course h6 {
                opacity: 0.6;
                margin: 0;
                letter-spacing: 1px;
                text-transform: uppercase;
            }

            .course h2 {
                letter-spacing: 1px;
                margin: 10px 0;
            }

        .course-preview {
            background-color: #2A265F;
            color: #fff;
            padding: 30px;
            max-width: 250px;
        }

            .course-preview a {
                color: #fff;
                display: inline-block;
                font-size: 12px;
 ");
                WriteLiteral(@"               opacity: 0.6;
                margin-top: 30px;
                text-decoration: none;
            }

        .course-info {
            padding: 30px;
            position: relative;
            width: 100%;
        }

        .progress-container {
            position: absolute;
            top: 30px;
            right: 30px;
            text-align: right;
            width: 150px;
        }

        .progress {
            background-color: #ddd;
            border-radius: 3px;
            height: 5px;
            width: 100%;
        }

            .progress::after {
                border-radius: 3px;
                background-color: #2A265F;
                content: '';
                position: absolute;
                top: 0;
                left: 0;
                height: 5px;
                width: 66%;
            }

        .progress-text {
            font-size: 10px;
            opacity: 0.6;
            letter-spacing: 1px;
        }
");
                WriteLiteral(@"
        .btn {
            background-color: #2A265F;
            border: 0;
            border-radius: 50px;
            box-shadow: 0 10px 10px rgba(0, 0, 0, 0.2);
            color: #fff;
            font-size: 16px;
            padding: 12px 25px;
            position: absolute;
            bottom: 30px;
            right: 30px;
            letter-spacing: 1px;
        }

        /* SOCIAL PANEL CSS */
        .social-panel-container {
            position: fixed;
            right: 0;
            bottom: 80px;
            transform: translateX(100%);
            transition: transform 0.4s ease-in-out;
        }

            .social-panel-container.visible {
                transform: translateX(-10px);
            }

        .social-panel {
            background-color: #fff;
            border-radius: 16px;
            box-shadow: 0 16px 31px -17px rgba(0,31,97,0.6);
            border: 5px solid #001F61;
            display: flex;
            flex-direction: column;
 ");
                WriteLiteral(@"           justify-content: center;
            align-items: center;
            font-family: 'Muli';
            position: relative;
            height: 169px;
            width: 370px;
            max-width: calc(100% - 10px);
        }

            .social-panel button.close-btn {
                border: 0;
                color: #97A5CE;
                cursor: pointer;
                font-size: 20px;
                position: absolute;
                top: 5px;
                right: 5px;
            }

                .social-panel button.close-btn:focus {
                    outline: none;
                }

            .social-panel p {
                background-color: #001F61;
                border-radius: 0 0 10px 10px;
                color: #fff;
                font-size: 14px;
                line-height: 18px;
                padding: 2px 17px 6px;
                position: absolute;
                top: 0;
                left: 50%;
                margin: 0");
                WriteLiteral(@";
                transform: translateX(-50%);
                text-align: center;
                width: 235px;
            }

                .social-panel p i {
                    margin: 0 5px;
                }

                .social-panel p a {
                    color: #FF7500;
                    text-decoration: none;
                }

            .social-panel h4 {
                margin: 20px 0;
                color: #97A5CE;
                font-family: 'Muli';
                font-size: 14px;
                line-height: 18px;
                text-transform: uppercase;
            }

            .social-panel ul {
                display: flex;
                list-style-type: none;
                padding: 0;
                margin: 0;
            }

                .social-panel ul li {
                    margin: 0 10px;
                }

                    .social-panel ul li a {
                        border: 1px solid #DCE1F2;
                  ");
                WriteLiteral(@"      border-radius: 50%;
                        color: #001F61;
                        font-size: 20px;
                        display: flex;
                        justify-content: center;
                        align-items: center;
                        height: 50px;
                        width: 50px;
                        text-decoration: none;
                    }

                        .social-panel ul li a:hover {
                            border-color: #FF6A00;
                            box-shadow: 0 9px 12px -9px #FF6A00;
                        }

        .floating-btn {
            border-radius: 26.5px;
            background-color: #001F61;
            border: 1px solid #001F61;
            box-shadow: 0 16px 22px -17px #03153B;
            color: #fff;
            cursor: pointer;
            font-size: 16px;
            line-height: 20px;
            padding: 12px 20px;
            position: fixed;
            bottom: 20px;
            right: 20px;");
                WriteLiteral(@"
            z-index: 999;
        }

            .floating-btn:hover {
                background-color: #ffffff;
                color: #001F61;
            }

            .floating-btn:focus {
                outline: none;
            }

        .floating-text {
            background-color: #001F61;
            border-radius: 10px 10px 0 0;
            color: #fff;
            font-family: 'Muli';
            padding: 7px 15px;
            position: fixed;
            bottom: 0;
            left: 50%;
            transform: translateX(-50%);
            text-align: center;
            z-index: 998;
        }

            .floating-text a {
                color: #FF7500;
                text-decoration: none;
            }

        ");
                WriteLiteral(@"@media screen and (max-width: 700px) {

            .social-panel-container.visible {
                transform: translateX(0px);
            }

            .floating-btn {
                right: 10px;
            }

            .ilearnCourseContainer {
                width: 900px;
            }
        }
    </style>
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
            WriteLiteral("\r\n\r\n<div class=\"courses-container\">\r\n    <div style=\"height: 500px; overflow: auto;\">\r\n        <div class=\"ilearnCourseContainer\" style=\"height: 500px; overflow: auto;\">\r\n");
#nullable restore
#line 282 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ManageSubscription.cshtml"
             foreach (var item in myEvents)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"course\" style=\"resize: vertical; height: 167px; min-height: 167px; max-height: 560px; width: 90%\">\r\n                    <div class=\"course-preview\">\r\n                        <h6>Course</h6>\r\n                        <h2>");
#nullable restore
#line 287 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ManageSubscription.cshtml"
                       Write(item.text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <a>Paid: ");
#nullable restore
#line 288 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ManageSubscription.cshtml"
                            Write(item.IsPaid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <br />\r\n                        <a>Payment: ");
#nullable restore
#line 290 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ManageSubscription.cshtml"
                               Write(item.payment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <br />\r\n                        <a>Price: ");
#nullable restore
#line 292 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ManageSubscription.cshtml"
                             Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <a>Start: ");
#nullable restore
#line 293 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ManageSubscription.cshtml"
                             Write(item.start_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <a>End: ");
#nullable restore
#line 294 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ManageSubscription.cshtml"
                           Write(item.end_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <a>Subscriber Email: ");
#nullable restore
#line 295 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ManageSubscription.cshtml"
                                        Write(item.subscriberEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <a>Subscriber First Name: ");
#nullable restore
#line 296 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ManageSubscription.cshtml"
                                             Write(item.subscriberFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <a>Subscriber Last Name: ");
#nullable restore
#line 297 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ManageSubscription.cshtml"
                                            Write(item.subscriberLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </div>\r\n                    <div class=\"course-info\">\r\n                        <h6>Description</h6>\r\n                        <h2>");
#nullable restore
#line 301 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ManageSubscription.cshtml"
                       Write(item.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c037c7fb9a70fb5ed17342bae944debe9ec1c45817477", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 307 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ManageSubscription.cshtml"
                             if (!item.IsPaid)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input class=\"btn\" type=\"submit\" value=\"Switch\" />\r\n");
#nullable restore
#line 310 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ManageSubscription.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input class=\"btn\" type=\"submit\" disabled=\"disabled\" value=\"Switch\" />\r\n");
#nullable restore
#line 314 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ManageSubscription.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-eventId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 305 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ManageSubscription.cshtml"
                                     WriteLiteral(item.EventId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["eventId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-eventId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["eventId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 318 "C:\Users\Murad\Desktop\ILearnCore\Views\User\ManageSubscription.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ILearnCoreV19.Data.AuthDbContext> Html { get; private set; }
    }
}
#pragma warning restore 1591
