#pragma checksum "C:\Users\Murad\Desktop\ILearnCore\Views\User\GetTutorSchedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c95f6162165398befee80705c39d7379b5bfa816"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_GetTutorSchedule), @"mvc.1.0.view", @"/Views/User/GetTutorSchedule.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c95f6162165398befee80705c39d7379b5bfa816", @"/Views/User/GetTutorSchedule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"907e38622cfb845b4eee5255df780c43d411cd46", @"/Views/_ViewImports.cshtml")]
    public class Views_User_GetTutorSchedule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.datetimepicker.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.datetimepicker.full.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "red", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "blue", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "black", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "green", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-12 form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Murad\Desktop\ILearnCore\Views\User\GetTutorSchedule.cshtml"
  
    ViewData["Title"] = "GetTutorSchedule";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c95f6162165398befee80705c39d7379b5bfa8167242", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c95f6162165398befee80705c39d7379b5bfa8167504", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c95f6162165398befee80705c39d7379b5bfa8168682", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c95f6162165398befee80705c39d7379b5bfa8169781", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Raleway"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">

    <style>
        ");
                WriteLiteral("@media (max-width: 700px){\r\n            .form-control {\r\n                margin-left: 0px;\r\n                width: 280px\r\n            }\r\n            .ilearnCalendar {\r\n                margin-top: 50px;\r\n            }\r\n        }\r\n    </style>\r\n");
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

<div id=""calender"" class=""ilearnCalendar""></div>

<div id=""myModal"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 class=""modal-title""><span id=""eventTitle""></span></h4>
            </div>
            <div class=""modal-body"">
                <button id=""btnDelete"" class=""btn btn-default btn-sm pull-right"">
                    <span class=""glyphicon glyphicon-remove""></span> Remove
                </button>
                <button id=""btnEdit"" class=""btn btn-default btn-sm pull-right"" style=""margin-right:5px;"">
                    <span class=""glyphicon glyphicon-pencil""></span> Edit
                </button>
                <p id=""pDetails""></p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Clo");
            WriteLiteral(@"se</button>
            </div>
        </div>
    </div>
</div>

<div id=""myModalSave"" class=""modal fade"" role=""dialog"" style=""overflow: auto;"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c95f6162165398befee80705c39d7379b5bfa81613751", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" id=""hdEventID"" value=""0"" />
                    <div class=""form-group"">
                        <label>Subject</label>
                        <!--margin-left: -5px; width: 290px;-->
                        <input type=""text"" id=""txtSubject"" class=""form-control"" />
                    </div>
                    <div class=""form-group"">
                        <label>Start</label>
                        <div class=""input-group date"" id=""dtp1"">
                            <input type=""text"" id=""txtStart"" class=""form-control"">
                            <script>
                                $(""#txtStart"").datetimepicker({
                                    step: 5,
                                    format: 'Y-m-d H:i A'
                                });
                            </script>
                            <span class=""input-group-addon"">
                                <span class=""glyphicon glyphicon-calendar""></span>
         ");
                WriteLiteral(@"                   </span>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""checkbox"">
                            <label><input type=""checkbox"" id=""chkIsFullDay"" checked=""checked"" />  Is Full Day event</label>
                        </div>
                    </div>
                    <div class=""form-group"" id=""divEndDate"" style=""display:none"">
                        <label>End</label>
                        <div class=""input-group date"" id=""dtp2"">
                            <input type=""text"" id=""txtEnd"" class=""form-control"" />
                            <script>
                                $(""#txtEnd"").datetimepicker({
                                    step: 5,
                                    format: 'Y-m-d H:i A'
                                });
                            </script>
                            <span class=""input-group-addon"">
                                <spa");
                WriteLiteral(@"n class=""glyphicon glyphicon-calendar""></span>
                            </span>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label>Description</label>
                        <textarea id=""txtDescription"" rows=""3"" class=""form-control""></textarea>
                    </div>
                    <div class=""form-group"">
                        <label>Theme Color</label>
                        <select id=""ddThemeColor"" class=""form-control"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c95f6162165398befee80705c39d7379b5bfa81616772", async() => {
                    WriteLiteral("Default");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c95f6162165398befee80705c39d7379b5bfa81618025", async() => {
                    WriteLiteral("Red");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c95f6162165398befee80705c39d7379b5bfa81619274", async() => {
                    WriteLiteral("Blue");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c95f6162165398befee80705c39d7379b5bfa81620524", async() => {
                    WriteLiteral("Black");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c95f6162165398befee80705c39d7379b5bfa81621775", async() => {
                    WriteLiteral("Green");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </select>
                    </div>
                    <div class=""form-group"">
                        <label id=""paymentLabel"">Price in Paypal currency</label>
                        <input type=""text"" id=""txtPrice"" class=""form-control"" />
                    </div>
                    <div class=""form-group"">
                        <input type=""radio"" id=""cashPayment"" onclick=""ChangePaymentText()"" name=""payment"" value=""Cash"">
                        <label for=""male"">Cash</label><br>
                        <input type=""radio"" id=""paypalPayment"" onclick=""ChangePaymentText()"" name=""payment"" checked=""checked"" value=""Paypal"">
                        <label for=""female"">Paypal</label><br>

                        <script>
                            function ChangePaymentText() {
                                var cashPayCheck = document.getElementById(""cashPayment"");
                                var paypalPayCheck = document.getElementById(""paypalPayment"");
  ");
                WriteLiteral(@"                              if (cashPayCheck.checked && !paypalPayCheck.checked ) {
                                    document.getElementById('paymentLabel').innerHTML = ""Price with currency"";
                                } else if (!cashPayCheck.checked && paypalPayCheck.checked) {
                                    document.getElementById('paymentLabel').innerHTML = ""Price in Paypal currency"";
                                }
                            }
                        </script>
                    </div>
                    <button type=""button"" id=""btnSave"" class=""btn btn-success"">Save</button>
                    <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<link href=""//cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.4.0/fullcalendar.min.css"" rel=""stylesheet"" />
<link href=""//cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.4.0/fullcalendar.print.css"" rel=""stylesheet"" media=""print"" />
<link href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.47/css/bootstrap-datetimepicker.min.css"" rel=""stylesheet"" />
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.18.1/moment.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.4.0/fullcalendar.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.47/js/bootstrap-datetimepicker.min.js""></script>
    <script>
        $(document).ready(function () {
            var events = [];
            var selectedEvent = null;
            FetchEventAndRenderCalendar();
            function FetchEventAndRenderCalendar() {
                events = [];
                $.ajax({
                    type: ""GET"",
                    url: ""/User/GetEvents"",
                    success: function (data) {
                        $.each(data, function (i, v) {
                            events.push({
                                eventID: v.eventId,
                                title: v.text,
                                description: v.description");
                WriteLiteral(@",
                                start: moment(v.start_date),
                                end: v.end_date != null ? moment(v.end_date) : null,
                                color: v.ThemeColor,
                                allDay: v.IsFullDay,
                                price: v.price,
                                payment: v.payment
                            });
                        })
                        GenerateCalender(events);
                    },
                    error: function (error) {
                        alert(error.status);
                    }
                })
            }
            function GenerateCalender(events) {
                $('#calender').fullCalendar('destroy');
                $('#calender').fullCalendar({
                    contentHeight: 350,
                    defaultDate: new Date(),
                    timeFormat: 'h(:mm)a',
                    header: {
                        left: 'prev,next today',
            ");
                WriteLiteral(@"            center: 'title',
                        right: 'month,basicWeek,basicDay,agenda'
                    },
                    eventLimit: true,
                    eventColor: '#378006',
                    events: events,
                    eventClick: function (calEvent, jsEvent, view) {
                        selectedEvent = calEvent;
                        $('#myModal #eventTitle').text(calEvent.title);
                        var $description = $('<div/>');
                        $description.append($('<p/>').html('<b>Start: </b>' + calEvent.start.format(""DD-MMM-YYYY HH:mm a"")));
                        if (calEvent.end != null) {
                            $description.append($('<p/>').html('<b>End: </b>' + calEvent.end.format(""DD-MMM-YYYY HH:mm a"")));
                        }
                        $description.append($('<p/>').html('<b>Description: </b>' + calEvent.description));
                        $('#myModal #pDetails').empty().html($description);
             ");
                WriteLiteral(@"           $('#myModal').modal();
                    },
                    selectable: true,
                    select: function (start, end) {
                        selectedEvent = {
                            eventID: 0,
                            title: '',
                            description: '',
                            start: start,
                            end: end,
                            allDay: false,
                            color: '',
                            price: 0,
                            payment: """"
                        };
                        openAddEditForm();
                        $('#calendar').fullCalendar('unselect');
                    },
                    editable: true,
                    eventDrop: function (event) {
                        var data = {
                            EventID: event.eventID,
                            text: event.title,
                            start_date: event.start.format('YYYY-MM-");
                WriteLiteral(@"DD HH:mm A'),
                            end_date: event.end != null ? event.end.format('YYYY-MM-DD HH:mm A') : null,
                            description: event.description,
                            ThemeColor: event.color,
                            isFullDay: event.allDay,
                            price: event.price,
                            payment: event.payment
                        };
                        SaveEvent(data);
                    }
                })
            }
            $('#btnEdit').click(function () {
                //Open modal dialog for edit event
                openAddEditForm();
            })
            $('#btnDelete').click(function () {
                if (selectedEvent != null && confirm('Are you sure?')) {
                    alert('Course deleted!');
                    $.ajax({
                        type: ""POST"",
                        url: '/User/DeleteEvent',
                        data: { 'eventID': selectedEvent.eventID");
                WriteLiteral(@" },
                        success: function (data) {
                            if (data.status) {
                                //Refresh the calender
                                FetchEventAndRenderCalendar();
                                $('#myModal').modal('hide');
                            }
                        },
                        error: function () {
                            alert('Failed 2');
                        }
                    })
                }
            })
            $('#dtp1,#dtp2').datetimepicker({
                format: 'YYYY-MM-DD HH:mm A'
            });
            $('#chkIsFullDay').change(function () {
                if ($(this).is(':checked')) {
                    $('#divEndDate').hide();
                }
                else {
                    $('#divEndDate').show();
                }
            });
            function openAddEditForm() {
                if (selectedEvent != null) {
                    $('#hdEve");
                WriteLiteral(@"ntID').val(selectedEvent.eventID);
                    $('#txtSubject').val(selectedEvent.title);
                    $('#txtStart').val(selectedEvent.start.format('YYYY-MM-DD HH:mm A'));
                    $('#chkIsFullDay').prop(""checked"", selectedEvent.allDay || false);
                    $('#chkIsFullDay').change();
                    $('#txtEnd').val(selectedEvent.end != null ? selectedEvent.end.format('YYYY-MM-DD HH:mm A') : '');
                    $('#txtDescription').val(selectedEvent.description);
                    $('#ddThemeColor').val(selectedEvent.color);
                    $('#txtPrice').val(selectedEvent.price);
                    if (selectedEvent.payment == ""Paypal"") { $(""#paypalPayment"").prop(""checked"", true); }
                    else if (selectedEvent.payment == ""Cash"") { $(""#cashPayment"").prop(""checked"", true); }
                }
                $('#myModal').modal('hide');
                $('#myModalSave').modal();
            }

            function isInt(str) ");
                WriteLiteral(@"{
                return !isNaN(str) && Number.isInteger(parseFloat(str));
            }


            function generateToken(size) {
                var origin = ""abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"".split("""");
                var generated = [];
                for (var i = 0; i < size; i++) {
                    var j = (Math.random() * (origin.length - 1)).toFixed(0);
                    generated[i] = origin[j];
                }
                return generated.join("""");
            }
            $('#btnSave').click(function () {
                //Validation/
                if ($('#txtSubject').val().trim() == """") {
                    alert('Subject required');
                    return;
                }

                if ($('#txtStart').val().trim() == """") {
                    alert('Start date required');
                    return;
                }

                if ($('#chkIsFullDay').is(':checked') == false && $('#txtEnd').val().trim() ");
                WriteLiteral(@"== """") {
                    alert('End date required');
                    return;
                }
                else {
                    var startDate = moment($('#txtStart').val(), ""YYYY-MM-DD HH:mm A"").toDate();
                    var endDate = moment($('#txtEnd').val(), ""YYYY-MM-DD HH:mm A"").toDate();
                    if (startDate > endDate) {
                        alert('Invalid end date');
                        return;
                    }
                }

                var radiosPayment = document.getElementsByName('payment');
                var myPayment = """";
                for (var i = 0, length = radiosPayment.length; i < length; i++) {
                    if (radiosPayment[i].checked) {
                        myPayment = radiosPayment[i].value;
                        break;
                    }
                }

                if (document.getElementById(""paypalPayment"").checked) {
                    if (!isInt($('#txtPrice').val())) {
        ");
                WriteLiteral(@"                alert(""Specify number only!"")
                        return;
                    } else {
                        if ($('#txtPrice').val().trim() == """") {
                            alert('Price required');
                            return;
                        }
                    }
                }

                var data = {
                    EventId: $('#hdEventID').val(),
                    text: $('#txtSubject').val().trim(),
                    start_date: $('#txtStart').val().trim(),
                    end_date: $('#chkIsFullDay').is(':checked') ? null : $('#txtEnd').val().trim(),
                    description: $('#txtDescription').val(),
                    themeColor: $('#ddThemeColor').val(),
                    isFullDay: $('#chkIsFullDay').is(':checked'),
                    price: $('#txtPrice').val().trim(),
                    payment: myPayment,
                    token: generateToken(100)
                }
                SaveEvent(data");
                WriteLiteral(@");
                // call function for submit data to the server
            })
            function SaveEvent(data) {
                alert('Course successfully saved!');
                $.ajax({
                    type: ""POST"",
                    url: '/User/SaveEvent',
                    data: data,
                    success: function (data) {
                        if (data.status) {
                            //Refresh the calender
                            FetchEventAndRenderCalendar();
                            $('#myModalSave').modal('hide');
                        }
                    },
                    error: function () {
                        alert('Failed 3');
                    }
                })
            }
        })
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
