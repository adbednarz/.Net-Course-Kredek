#pragma checksum "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Battles\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ae8956a263c6a4d0e38280c1c115c8ff10ba3cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Battles_Edit), @"mvc.1.0.view", @"/Views/Battles/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ae8956a263c6a4d0e38280c1c115c8ff10ba3cf", @"/Views/Battles/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3126feba86e54ae0a3092087466718c09357c464", @"/Views/_ViewImports.cshtml")]
    public class Views_Battles_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Battle>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Battles\Edit.cshtml"
 using (Html.BeginForm("Edit", "Battles", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Edytuj bitwę</h3>\r\n    <hr />\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 9 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Battles\Edit.cshtml"
   Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md\">\r\n            ");
#nullable restore
#line 11 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Battles\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 16 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Battles\Edit.cshtml"
   Write(Html.LabelFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Battles\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 23 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Battles\Edit.cshtml"
   Write(Html.LabelFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Battles\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.AgeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 30 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Battles\Edit.cshtml"
   Write(Html.LabelFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Battles\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.CountryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 37 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Battles\Edit.cshtml"
   Write(Html.LabelFor(model => model.Commander));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Battles\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.CommanderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 44 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Battles\Edit.cshtml"
   Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md\">\r\n            ");
#nullable restore
#line 46 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Battles\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"Edytuj\" class=\"btn btn-primary\" />\r\n");
#nullable restore
#line 51 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Battles\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Battle> Html { get; private set; }
    }
}
#pragma warning restore 1591
