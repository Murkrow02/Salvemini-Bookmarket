#pragma checksum "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\Admin\Ritiro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52e51c98ebb44c7bfe1491d3525fc569f07eff58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookMarket.Pages.Admin.Pages_Admin_Ritiro), @"mvc.1.0.razor-page", @"/Pages/Admin/Ritiro.cshtml")]
namespace BookMarket.Pages.Admin
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
#line 1 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\_ViewImports.cshtml"
using BookMarket;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52e51c98ebb44c7bfe1491d3525fc569f07eff58", @"/Pages/Admin/Ritiro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"620901cba3284544bbc6d0cf3a171f5b1ed390b2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Ritiro : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div style=\"padding:20px;\">\r\n        <h1>Utenti registrati</h1>\r\n        <ul>\r\n");
#nullable restore
#line 9 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\Admin\Ritiro.cshtml"
             foreach (var user in Model.Users)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <span>");
#nullable restore
#line 12 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\Admin\Ritiro.cshtml"
                 Write(user.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\Admin\Ritiro.cshtml"
                            Write(user.Cognome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <span>(");
#nullable restore
#line 13 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\Admin\Ritiro.cshtml"
                  Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\r\n                <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 353, "\"", 390, 2);
            WriteAttributeValue("", 360, "/admin/libriutente?id=", 360, 22, true);
#nullable restore
#line 14 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\Admin\Ritiro.cshtml"
WriteAttributeValue("", 382, user.Id, 382, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Vedi</a> /\r\n                <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 438, "\"", 478, 2);
            WriteAttributeValue("", 445, "/admin/libriinvenduti?id=", 445, 25, true);
#nullable restore
#line 15 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\Admin\Ritiro.cshtml"
WriteAttributeValue("", 470, user.Id, 470, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Invenduti</a>\r\n            </li>\r\n");
#nullable restore
#line 17 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\Admin\Ritiro.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n\r\n\r\n<style>\r\n    footer{\r\n        display:none;\r\n    }\r\n</style>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookMarket.Pages.Admin.RitiroModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookMarket.Pages.Admin.RitiroModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookMarket.Pages.Admin.RitiroModel>)PageContext?.ViewData;
        public BookMarket.Pages.Admin.RitiroModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
