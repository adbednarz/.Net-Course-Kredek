#pragma checksum "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6500349138d5e33b54baddb8005efb5b6cce934"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Countries_Index), @"mvc.1.0.view", @"/Views/Countries/Index.cshtml")]
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
#line 1 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\_ViewImports.cshtml"
using AdamBednarzZadDom5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\_ViewImports.cshtml"
using AdamBednarzZadDom5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6500349138d5e33b54baddb8005efb5b6cce934", @"/Views/Countries/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3126feba86e54ae0a3092087466718c09357c464", @"/Views/_ViewImports.cshtml")]
    public class Views_Countries_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Country>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>\r\n    ");
#nullable restore
#line 4 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Index.cshtml"
Write(Html.ActionLink("Dodaj", "Create", "Countries"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 11 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalWinnerBattles));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Index.cshtml"
         foreach (var country in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Index.cshtml"
           Write(Html.DisplayFor(modelItem => country.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Index.cshtml"
           Write(Html.DisplayFor(modelItem => country.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Index.cshtml"
           Write(Html.DisplayFor(modelItem => country.TotalWinnerBattles));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Index.cshtml"
           Write(Html.ActionLink("Edytuj", "Edit", "Countries", routeValues: new { id = country.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 40 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Index.cshtml"
           Write(Html.ActionLink("Usuń", "Delete", "Countries", routeValues: new { id = country.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Country>> Html { get; private set; }
    }
}
#pragma warning restore 1591
