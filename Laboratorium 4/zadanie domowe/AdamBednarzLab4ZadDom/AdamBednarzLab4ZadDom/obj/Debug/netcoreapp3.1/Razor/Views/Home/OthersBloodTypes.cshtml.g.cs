#pragma checksum "C:\Users\Adam\Documents\GitHub\adam_bednarz_cpc2021-1\Laboratorium 4\zadanie domowe\AdamBednarzLab4ZadDom\AdamBednarzLab4ZadDom\Views\Home\OthersBloodTypes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6442992436332348697ec5c8e12458211c001011"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OthersBloodTypes), @"mvc.1.0.view", @"/Views/Home/OthersBloodTypes.cshtml")]
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
#line 1 "C:\Users\Adam\Documents\GitHub\adam_bednarz_cpc2021-1\Laboratorium 4\zadanie domowe\AdamBednarzLab4ZadDom\AdamBednarzLab4ZadDom\Views\_ViewImports.cshtml"
using AdamBednarzLab4ZadDom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Adam\Documents\GitHub\adam_bednarz_cpc2021-1\Laboratorium 4\zadanie domowe\AdamBednarzLab4ZadDom\AdamBednarzLab4ZadDom\Views\_ViewImports.cshtml"
using AdamBednarzLab4ZadDom.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6442992436332348697ec5c8e12458211c001011", @"/Views/Home/OthersBloodTypes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a0f3144bffcebcdfad606c47a86c83e9447bf7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OthersBloodTypes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BloodViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<b>Przeciwny współczynnik Rh dla Twojej grupy:</b>\r\n<p>");
#nullable restore
#line 5 "C:\Users\Adam\Documents\GitHub\adam_bednarz_cpc2021-1\Laboratorium 4\zadanie domowe\AdamBednarzLab4ZadDom\AdamBednarzLab4ZadDom\Views\Home\OthersBloodTypes.cshtml"
Write(ViewBag.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 5 "C:\Users\Adam\Documents\GitHub\adam_bednarz_cpc2021-1\Laboratorium 4\zadanie domowe\AdamBednarzLab4ZadDom\AdamBednarzLab4ZadDom\Views\Home\OthersBloodTypes.cshtml"
            Write(ViewBag.Rh);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n<p>");
#nullable restore
#line 6 "C:\Users\Adam\Documents\GitHub\adam_bednarz_cpc2021-1\Laboratorium 4\zadanie domowe\AdamBednarzLab4ZadDom\AdamBednarzLab4ZadDom\Views\Home\OthersBloodTypes.cshtml"
Write(ViewBag.percentRh);

#line default
#line hidden
#nullable disable
            WriteLiteral(" % populacji posiada tę grupę krwi</p>\r\n<hr />\r\n<ul>\r\n    <!-- Iterowanie po modelach grup krwi i wypisywanie wszystkich właściwośći -->\r\n");
#nullable restore
#line 10 "C:\Users\Adam\Documents\GitHub\adam_bednarz_cpc2021-1\Laboratorium 4\zadanie domowe\AdamBednarzLab4ZadDom\AdamBednarzLab4ZadDom\Views\Home\OthersBloodTypes.cshtml"
     foreach (var typeBlood in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <p> Grupa krwi: <b>");
#nullable restore
#line 13 "C:\Users\Adam\Documents\GitHub\adam_bednarz_cpc2021-1\Laboratorium 4\zadanie domowe\AdamBednarzLab4ZadDom\AdamBednarzLab4ZadDom\Views\Home\OthersBloodTypes.cshtml"
                          Write(typeBlood.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n            <p> Rh+: ");
#nullable restore
#line 14 "C:\Users\Adam\Documents\GitHub\adam_bednarz_cpc2021-1\Laboratorium 4\zadanie domowe\AdamBednarzLab4ZadDom\AdamBednarzLab4ZadDom\Views\Home\OthersBloodTypes.cshtml"
                Write(typeBlood.PercentRhPlus);

#line default
#line hidden
#nullable disable
            WriteLiteral("% populacji posiada tę grupę krwi</p>\r\n            <p> Rh-: ");
#nullable restore
#line 15 "C:\Users\Adam\Documents\GitHub\adam_bednarz_cpc2021-1\Laboratorium 4\zadanie domowe\AdamBednarzLab4ZadDom\AdamBednarzLab4ZadDom\Views\Home\OthersBloodTypes.cshtml"
                Write(typeBlood.PercentRhMinus);

#line default
#line hidden
#nullable disable
            WriteLiteral("% populacji posiada tę grupę krwi</p>\r\n            <p style=\"font-style: italic;\"> ");
#nullable restore
#line 16 "C:\Users\Adam\Documents\GitHub\adam_bednarz_cpc2021-1\Laboratorium 4\zadanie domowe\AdamBednarzLab4ZadDom\AdamBednarzLab4ZadDom\Views\Home\OthersBloodTypes.cshtml"
                                       Write(typeBlood.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </li>\r\n");
#nullable restore
#line 18 "C:\Users\Adam\Documents\GitHub\adam_bednarz_cpc2021-1\Laboratorium 4\zadanie domowe\AdamBednarzLab4ZadDom\AdamBednarzLab4ZadDom\Views\Home\OthersBloodTypes.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
#nullable restore
#line 21 "C:\Users\Adam\Documents\GitHub\adam_bednarz_cpc2021-1\Laboratorium 4\zadanie domowe\AdamBednarzLab4ZadDom\AdamBednarzLab4ZadDom\Views\Home\OthersBloodTypes.cshtml"
Write(Html.ActionLink("Wróć do strony głównej", "Index", "Home", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BloodViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
