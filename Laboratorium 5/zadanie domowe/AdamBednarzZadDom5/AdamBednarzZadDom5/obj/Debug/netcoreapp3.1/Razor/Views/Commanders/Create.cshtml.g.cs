#pragma checksum "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Commanders\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b32c8d7344d0019e4a203c73aa866c26ef19c7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Commanders_Create), @"mvc.1.0.view", @"/Views/Commanders/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b32c8d7344d0019e4a203c73aa866c26ef19c7e", @"/Views/Commanders/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3126feba86e54ae0a3092087466718c09357c464", @"/Views/_ViewImports.cshtml")]
    public class Views_Commanders_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Commander>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Commanders\Create.cshtml"
 using (Html.BeginForm("Create", "Commanders", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 7 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Commanders\Create.cshtml"
   Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md\">\r\n            ");
#nullable restore
#line 9 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Commanders\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 14 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Commanders\Create.cshtml"
   Write(Html.LabelFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md\">\r\n            ");
#nullable restore
#line 16 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Commanders\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 21 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Commanders\Create.cshtml"
   Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Commanders\Create.cshtml"
       Write(Html.TextBoxFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"Dodaj dow??dc??\" class=\"btn btn-primary\" />\r\n");
#nullable restore
#line 28 "C:\Users\Adam\source\repos\AdamBednarzZadDom5\AdamBednarzZadDom5\Views\Commanders\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Commander> Html { get; private set; }
    }
}
#pragma warning restore 1591
