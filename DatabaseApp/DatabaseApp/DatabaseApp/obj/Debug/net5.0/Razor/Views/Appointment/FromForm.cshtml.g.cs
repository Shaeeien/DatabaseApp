#pragma checksum "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\FromForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dff03e0f38bd1de918524861b2026ac2505c7d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointment_FromForm), @"mvc.1.0.view", @"/Views/Appointment/FromForm.cshtml")]
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
#line 1 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\_ViewImports.cshtml"
using DatabaseApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\_ViewImports.cshtml"
using DatabaseApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dff03e0f38bd1de918524861b2026ac2505c7d1", @"/Views/Appointment/FromForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0473f819259c64e585366fb43f159fc707ab7c79", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointment_FromForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppointmentList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteAppointment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Appointment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Zarejestrowane wizyty</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7dff03e0f38bd1de918524861b2026ac2505c7d13959", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\FromForm.cshtml"
     foreach (Appointment app in Model.appointments)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h2>Imię: ");
#nullable restore
#line 6 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\FromForm.cshtml"
             Write(app.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n        <h2>Nazwisko: ");
#nullable restore
#line 7 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\FromForm.cshtml"
                 Write(app.Surname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n        <h2>Numer telefonu: ");
#nullable restore
#line 8 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\FromForm.cshtml"
                       Write(app.PhoneNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 339, "\"", 358, 1);
#nullable restore
#line 9 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\FromForm.cshtml"
WriteAttributeValue("", 347, app.Number, 347, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"ID\" />\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 402, "\"", 419, 1);
#nullable restore
#line 10 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\FromForm.cshtml"
WriteAttributeValue("", 410, app.Name, 410, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Name\" />\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 465, "\"", 485, 1);
#nullable restore
#line 11 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\FromForm.cshtml"
WriteAttributeValue("", 473, app.Surname, 473, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Surname\" />\r\n        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 534, "\"", 558, 1);
#nullable restore
#line 12 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\FromForm.cshtml"
WriteAttributeValue("", 542, app.PhoneNumber, 542, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Phone\" />\r\n        <input type=\"submit\" value=\"Usuń\" />\r\n        <br />\r\n");
#nullable restore
#line 15 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\FromForm.cshtml"
    }

#line default
#line hidden
#nullable disable
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<br />\r\n<a href=\"/Appointment/Index\">Powrót</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppointmentList> Html { get; private set; }
    }
}
#pragma warning restore 1591
