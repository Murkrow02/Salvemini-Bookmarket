#pragma checksum "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\ProgrammazioneFinale.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa0de1ead0f89ea9de09892410413638b68527e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookMarket.Pages.Pages_ProgrammazioneFinale), @"mvc.1.0.razor-page", @"/Pages/ProgrammazioneFinale.cshtml")]
namespace BookMarket.Pages
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
#line 1 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\_ViewImports.cshtml"
using BookMarket;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa0de1ead0f89ea9de09892410413638b68527e8", @"/Pages/ProgrammazioneFinale.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"620901cba3284544bbc6d0cf3a171f5b1ed390b2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ProgrammazioneFinale : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\ProgrammazioneFinale.cshtml"
  
    ViewData["Title"] = "Programmazione finale";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"padding:20px;\">\r\n    <h1>Ritiro soldi e libri</h1>\r\n    <p>(In ordine alfabetico)</p>\r\n    <ul>\r\n");
#nullable restore
#line 11 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\ProgrammazioneFinale.cshtml"
         foreach (var user in Model.users)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <span>");
#nullable restore
#line 14 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\ProgrammazioneFinale.cshtml"
                 Write(user.Cognome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\ProgrammazioneFinale.cshtml"
                               Write(user.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <span>(");
#nullable restore
#line 15 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\ProgrammazioneFinale.cshtml"
                  Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\r\n                <span>");
#nullable restore
#line 16 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\ProgrammazioneFinale.cshtml"
                 Write(user.AppuntamentoFinale.Value.ToString("dd MMMM alle HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </li>\r\n");
#nullable restore
#line 18 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\ProgrammazioneFinale.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n\r\n\r\n<style>\r\n    footer {\r\n        display: none;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookMarket.Pages.ProgrammazioneFinaleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookMarket.Pages.ProgrammazioneFinaleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookMarket.Pages.ProgrammazioneFinaleModel>)PageContext?.ViewData;
        public BookMarket.Pages.ProgrammazioneFinaleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591