#pragma checksum "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Account\LoginError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4498314d2c63b6eb2e2d25ad2fded331e1090a2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_LoginError), @"mvc.1.0.view", @"/Views/Account/LoginError.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4498314d2c63b6eb2e2d25ad2fded331e1090a2a", @"/Views/Account/LoginError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0473f819259c64e585366fb43f159fc707ab7c79", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_LoginError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Błąd logowania! Kod błędu: ");
#nullable restore
#line 2 "E:\dotNETProjekty\DatabaseApp\DatabaseApp\DatabaseApp\DatabaseApp\Views\Account\LoginError.cshtml"
                          Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>");
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
