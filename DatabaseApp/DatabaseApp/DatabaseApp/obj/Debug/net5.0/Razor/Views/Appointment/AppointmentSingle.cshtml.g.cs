#pragma checksum "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\AppointmentSingle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ede900b6b7a2a8af16cdc86ae22c0911085824a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointment_AppointmentSingle), @"mvc.1.0.view", @"/Views/Appointment/AppointmentSingle.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#nullable restore
#line 2 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\AppointmentSingle.cshtml"
using DatabaseApp.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\AppointmentSingle.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\AppointmentSingle.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ede900b6b7a2a8af16cdc86ae22c0911085824a", @"/Views/Appointment/AppointmentSingle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0473f819259c64e585366fb43f159fc707ab7c79", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointment_AppointmentSingle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ede900b6b7a2a8af16cdc86ae22c0911085824a4592", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\AppointmentSingle.cshtml"
     using (var DbContext = new AppointmentContext())
    {
        Appointment app = DbContext.Appointments.Where(x => x.AppointmentId == Model).FirstOrDefault();
        if (app != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <table style=""border: 2px solid black"">
                <tr>
                    <td>
                        Imię  pacjenta:
                    </td>
                    <td>
                        Nazwisko pacjenta:
                    </td>
                    <td>
                        Imię lekarza:
                    </td>
                    <td>
                        Nazwisko lekarza:
                    </td>
                    <td>
                        Termin:
                    </td>

                </tr>

                <tr>
                    <td><input name=""ID"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 1014, "\"", 1040, 1);
#nullable restore
#line 33 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\AppointmentSingle.cshtml"
WriteAttributeValue("", 1022, app.AppointmentId, 1022, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n                    <td>");
#nullable restore
#line 34 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\AppointmentSingle.cshtml"
                   Write(DbContext.Patients.Where(x => x.Id == app.PatientId).FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\AppointmentSingle.cshtml"
                   Write(DbContext.Patients.Where(x => x.Id == app.PatientId).FirstOrDefault().Surname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\AppointmentSingle.cshtml"
                   Write(DbContext.Doctors.Where(x => x.Id == app.DoctorId).FirstOrDefault().Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\AppointmentSingle.cshtml"
                   Write(DbContext.Doctors.Where(x => x.Id == app.DoctorId).FirstOrDefault().Surname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\AppointmentSingle.cshtml"
                   Write(app.Time);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>\r\n                        <button type=\"submit\">Usuń</button>\r\n                    </td>\r\n                </tr>\r\n            }\r\n            </table>\r\n");
#nullable restore
#line 45 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Appointment\AppointmentSingle.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591