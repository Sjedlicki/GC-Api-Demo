#pragma checksum "X:\Visual Studio Repos\MockAssessment7DonutApi\MockAssessment7DonutApi\Views\GrandCircus\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc2e85f2f2fe90471ff7e45ec152bdc3288aa0c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GrandCircus_Index), @"mvc.1.0.view", @"/Views/GrandCircus/Index.cshtml")]
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
#line 1 "X:\Visual Studio Repos\MockAssessment7DonutApi\MockAssessment7DonutApi\Views\_ViewImports.cshtml"
using MockAssessment7DonutApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "X:\Visual Studio Repos\MockAssessment7DonutApi\MockAssessment7DonutApi\Views\_ViewImports.cshtml"
using MockAssessment7DonutApi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc2e85f2f2fe90471ff7e45ec152bdc3288aa0c7", @"/Views/GrandCircus/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bfb070364ddfe91db4c5ba9d215556e871e53f1", @"/Views/_ViewImports.cshtml")]
    public class Views_GrandCircus_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GrandCircus>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "X:\Visual Studio Repos\MockAssessment7DonutApi\MockAssessment7DonutApi\Views\GrandCircus\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Grand Circus</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 13 "X:\Visual Studio Repos\MockAssessment7DonutApi\MockAssessment7DonutApi\Views\GrandCircus\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Organization));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <td>\r\n            ");
#nullable restore
#line 16 "X:\Visual Studio Repos\MockAssessment7DonutApi\MockAssessment7DonutApi\Views\GrandCircus\Index.cshtml"
       Write(Html.DisplayFor(model => model.Organization));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 21 "X:\Visual Studio Repos\MockAssessment7DonutApi\MockAssessment7DonutApi\Views\GrandCircus\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Ceo.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <td>\r\n            ");
#nullable restore
#line 24 "X:\Visual Studio Repos\MockAssessment7DonutApi\MockAssessment7DonutApi\Views\GrandCircus\Index.cshtml"
       Write(Html.DisplayFor(model => model.Ceo.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 27 "X:\Visual Studio Repos\MockAssessment7DonutApi\MockAssessment7DonutApi\Views\GrandCircus\Index.cshtml"
       Write(Html.DisplayFor(model => model.Ceo.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 32 "X:\Visual Studio Repos\MockAssessment7DonutApi\MockAssessment7DonutApi\Views\GrandCircus\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Rooms));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n    </tr>\r\n");
#nullable restore
#line 35 "X:\Visual Studio Repos\MockAssessment7DonutApi\MockAssessment7DonutApi\Views\GrandCircus\Index.cshtml"
     foreach (var room in Model.Rooms)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td></td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "X:\Visual Studio Repos\MockAssessment7DonutApi\MockAssessment7DonutApi\Views\GrandCircus\Index.cshtml"
           Write(Html.DisplayFor(modelItem => room.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "X:\Visual Studio Repos\MockAssessment7DonutApi\MockAssessment7DonutApi\Views\GrandCircus\Index.cshtml"
           Write(Html.DisplayFor(modelItem => room.Level));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 46 "X:\Visual Studio Repos\MockAssessment7DonutApi\MockAssessment7DonutApi\Views\GrandCircus\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 50 "X:\Visual Studio Repos\MockAssessment7DonutApi\MockAssessment7DonutApi\Views\GrandCircus\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Languages));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n");
#nullable restore
#line 52 "X:\Visual Studio Repos\MockAssessment7DonutApi\MockAssessment7DonutApi\Views\GrandCircus\Index.cshtml"
         foreach (var item in Model.Languages)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 55 "X:\Visual Studio Repos\MockAssessment7DonutApi\MockAssessment7DonutApi\Views\GrandCircus\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "X:\Visual Studio Repos\MockAssessment7DonutApi\MockAssessment7DonutApi\Views\GrandCircus\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Creator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 60 "X:\Visual Studio Repos\MockAssessment7DonutApi\MockAssessment7DonutApi\Views\GrandCircus\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GrandCircus> Html { get; private set; }
    }
}
#pragma warning restore 1591
