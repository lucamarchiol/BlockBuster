#pragma checksum "C:\Users\bearzi\Desktop\Rainis\GitHubDesk\BlockBuster\BBWebApp\BBWebApp\Views\Attori\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "845ce7ff71cff67a5fb5bde0f69b58ad2c1908e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Attori_Index), @"mvc.1.0.view", @"/Views/Attori/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Attori/Index.cshtml", typeof(AspNetCore.Views_Attori_Index))]
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
#line 1 "C:\Users\bearzi\Desktop\Rainis\GitHubDesk\BlockBuster\BBWebApp\BBWebApp\Views\_ViewImports.cshtml"
using BBWebApp;

#line default
#line hidden
#line 2 "C:\Users\bearzi\Desktop\Rainis\GitHubDesk\BlockBuster\BBWebApp\BBWebApp\Views\_ViewImports.cshtml"
using BBWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"845ce7ff71cff67a5fb5bde0f69b58ad2c1908e0", @"/Views/Attori/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2b9b88f797c35b3c36682d2c0a096edf926d3ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Attori_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BBWebApp.Models.Attore>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\bearzi\Desktop\Rainis\GitHubDesk\BlockBuster\BBWebApp\BBWebApp\Views\Attori\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(91, 226, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Nome attore</th>\r\n            <th>Cognome Attore</th>\r\n            <th>Nazionalità</th>\r\n            <th>Foto</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 17 "C:\Users\bearzi\Desktop\Rainis\GitHubDesk\BlockBuster\BBWebApp\BBWebApp\Views\Attori\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(366, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(415, 39, false);
#line 21 "C:\Users\bearzi\Desktop\Rainis\GitHubDesk\BlockBuster\BBWebApp\BBWebApp\Views\Attori\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.nome));

#line default
#line hidden
            EndContext();
            BeginContext(454, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(510, 42, false);
#line 24 "C:\Users\bearzi\Desktop\Rainis\GitHubDesk\BlockBuster\BBWebApp\BBWebApp\Views\Attori\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.cognome));

#line default
#line hidden
            EndContext();
            BeginContext(552, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(608, 46, false);
#line 27 "C:\Users\bearzi\Desktop\Rainis\GitHubDesk\BlockBuster\BBWebApp\BBWebApp\Views\Attori\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.nazionalita));

#line default
#line hidden
            EndContext();
            BeginContext(654, 59, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 713, "\"", 798, 2);
#line 30 "C:\Users\bearzi\Desktop\Rainis\GitHubDesk\BlockBuster\BBWebApp\BBWebApp\Views\Attori\Index.cshtml"
WriteAttributeValue("\r\n                ", 719, Html.DisplayFor(modelItem => item.urlFoto), 737, 43, false);

#line default
#line hidden
            WriteAttributeValue("\r\n                ", 780, "", 798, 18, true);
            EndWriteAttribute();
            BeginContext(799, 57, true);
            WriteLiteral(" alt=\"foto attore\">\r\n            </td>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 36 "C:\Users\bearzi\Desktop\Rainis\GitHubDesk\BlockBuster\BBWebApp\BBWebApp\Views\Attori\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(867, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BBWebApp.Models.Attore>> Html { get; private set; }
    }
}
#pragma warning restore 1591
