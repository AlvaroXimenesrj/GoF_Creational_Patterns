#pragma checksum "C:\NOVOS PROJETOS GIT\SOLID and Design Pt\PATTERNS_GoF\CreationalPatterns\CreationalPatterns\Views\Singleton\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "149aae3ef0c5d039a7336247181a2829131a8522"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Singleton_Index), @"mvc.1.0.view", @"/Views/Singleton/Index.cshtml")]
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
#line 1 "C:\NOVOS PROJETOS GIT\SOLID and Design Pt\PATTERNS_GoF\CreationalPatterns\CreationalPatterns\Views\_ViewImports.cshtml"
using CreationalPatterns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\NOVOS PROJETOS GIT\SOLID and Design Pt\PATTERNS_GoF\CreationalPatterns\CreationalPatterns\Views\_ViewImports.cshtml"
using CreationalPatterns.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"149aae3ef0c5d039a7336247181a2829131a8522", @"/Views/Singleton/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"444115d527af2cd11f0dfd3a2fb7f1f21f405b77", @"/Views/_ViewImports.cshtml")]
    public class Views_Singleton_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreationalPatterns.Models.Singleton.WebsiteMetadata>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\NOVOS PROJETOS GIT\SOLID and Design Pt\PATTERNS_GoF\CreationalPatterns\CreationalPatterns\Views\Singleton\Index.cshtml"
  
    ViewData["Title"] = "View";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Singleton</h1>\r\n<h1>Website Metadata</h1>\r\n<table border=\"1\" cellpadding=\"10\">\r\n    <tr>\r\n        <td>Title :</td>\r\n        <td>");
#nullable restore
#line 13 "C:\NOVOS PROJETOS GIT\SOLID and Design Pt\PATTERNS_GoF\CreationalPatterns\CreationalPatterns\Views\Singleton\Index.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Administrator Email :</td>\r\n        <td>");
#nullable restore
#line 17 "C:\NOVOS PROJETOS GIT\SOLID and Design Pt\PATTERNS_GoF\CreationalPatterns\CreationalPatterns\Views\Singleton\Index.cshtml"
       Write(Model.AdminEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Default Theme :</td>\r\n        <td>");
#nullable restore
#line 21 "C:\NOVOS PROJETOS GIT\SOLID and Design Pt\PATTERNS_GoF\CreationalPatterns\CreationalPatterns\Views\Singleton\Index.cshtml"
       Write(Model.DefaultTheme);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Log Errors :</td>\r\n        <td>");
#nullable restore
#line 25 "C:\NOVOS PROJETOS GIT\SOLID and Design Pt\PATTERNS_GoF\CreationalPatterns\CreationalPatterns\Views\Singleton\Index.cshtml"
       Write(Model.LogErrors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreationalPatterns.Models.Singleton.WebsiteMetadata> Html { get; private set; }
    }
}
#pragma warning restore 1591