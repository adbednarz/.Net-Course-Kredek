#pragma checksum "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1c58c0bb1d50f98d32c355e57f4e3d938b0d740"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Countries_Delete), @"mvc.1.0.view", @"/Views/Countries/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1c58c0bb1d50f98d32c355e57f4e3d938b0d740", @"/Views/Countries/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3126feba86e54ae0a3092087466718c09357c464", @"/Views/_ViewImports.cshtml")]
    public class Views_Countries_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Country>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Delete.cshtml"
 using (Html.BeginForm("Delete", "Countries", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<dl class=\"row\">\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 7 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Delete.cshtml"
   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 10 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Delete.cshtml"
   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 13 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Delete.cshtml"
   Write(Html.DisplayNameFor(model => model.TotalWinnerBattles));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 16 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Delete.cshtml"
   Write(Html.DisplayFor(model => model.TotalWinnerBattles));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-12\">\r\n        Zostan?? r??wnie?? usuni??te poni??sze bitwy:\r\n    </dt>\r\n");
#nullable restore
#line 21 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Delete.cshtml"
     foreach (var item in Model.Battles)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Delete.cshtml"
       Write(Html.DisplayNameFor(model => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Delete.cshtml"
       Write(Html.DisplayFor(model => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n");
#nullable restore
#line 29 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Delete.cshtml"
     if (Model.Battles.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dd class=\"col-sm-12\">\r\n            Brak bitew\r\n        </dd>\r\n");
#nullable restore
#line 35 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</dl>\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"Usu??\" class=\"btn btn-danger\" />\r\n");
#nullable restore
#line 39 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Countries\Delete.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Country> Html { get; private set; }
    }
}
#pragma warning restore 1591
