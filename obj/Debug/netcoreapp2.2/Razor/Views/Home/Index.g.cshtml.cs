#pragma checksum "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\RandomPass\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9c51d5b26c6f72d4dff21fd767cd059d7cd4267"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\RandomPass\Views\_ViewImports.cshtml"
using RandomPass;

#line default
#line hidden
#line 2 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\RandomPass\Views\_ViewImports.cshtml"
using RandomPass.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9c51d5b26c6f72d4dff21fd767cd059d7cd4267", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8d59760f1d967d51ce9427c1e2ee2d17143f992", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 59, true);
            WriteLiteral("<div>\r\n    <h1>Random passcode (Passcode #1)</h1>\r\n    <h1>");
            EndContext();
            BeginContext(60, 10, false);
#line 3 "C:\Users\tjade\OneDrive\Desktop\coding_dojo\CSharp\asp_dot_net\RandomPass\Views\Home\Index.cshtml"
   Write(ViewBag.sb);

#line default
#line hidden
            EndContext();
            BeginContext(70, 60, true);
            WriteLiteral("</h1>\r\n    <button><a href=\"/\">Generate</a></button>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
