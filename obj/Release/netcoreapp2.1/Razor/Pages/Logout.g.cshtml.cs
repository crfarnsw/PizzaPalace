#pragma checksum "C:\Users\pink\Source\Repos\PizzaPalace\Pages\Logout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f936238b6c91ff8ae51d716eef15be4f8eec797"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PizzaPalace.Pages.Pages_Logout), @"mvc.1.0.razor-page", @"/Pages/Logout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Logout.cshtml", typeof(PizzaPalace.Pages.Pages_Logout), null)]
namespace PizzaPalace.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\pink\Source\Repos\PizzaPalace\Pages\_ViewImports.cshtml"
using PizzaPalace;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f936238b6c91ff8ae51d716eef15be4f8eec797", @"/Pages/Logout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e51d8c2d844b1f40b3e916ece93d17ee5426c7e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Logout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\pink\Source\Repos\PizzaPalace\Pages\Logout.cshtml"
  
    ViewData["Title"] = "Logout";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(134, 21, true);
            WriteLiteral("\r\n<h2>Logout</h2>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaPalace.Pages.LogoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PizzaPalace.Pages.LogoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PizzaPalace.Pages.LogoutModel>)PageContext?.ViewData;
        public PizzaPalace.Pages.LogoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
