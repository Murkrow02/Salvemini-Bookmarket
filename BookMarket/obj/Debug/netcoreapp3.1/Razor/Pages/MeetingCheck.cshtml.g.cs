#pragma checksum "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\MeetingCheck.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4c70f8de6be956e29bd3337b82cd1f8c3a14e63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookMarket.Pages.Pages_MeetingCheck), @"mvc.1.0.razor-page", @"/Pages/MeetingCheck.cshtml")]
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
#line 1 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\_ViewImports.cshtml"
using BookMarket;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4c70f8de6be956e29bd3337b82cd1f8c3a14e63", @"/Pages/MeetingCheck.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"620901cba3284544bbc6d0cf3a171f5b1ed390b2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MeetingCheck : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\MeetingCheck.cshtml"
  
    ViewData["Title"] = "Appuntamento";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--Top Bar-->
<header>
    <div class=""header-container"">
        <!--Back button-->
        <a href=""dashboard"">
            <i class=""fas fa-chevron-left header-backbutton""></i>
        </a>
        <!--Username-->
        <span onclick=""window.location.href = 'dashboard'"" style=""cursor:pointer;"" class=""header-title-label"">Torna alla dashboard</span>
    </div>
    <!--Separator-->
    <div class=""header-separator""></div>
</header>

<div id=""check-main-container"">
    <div id=""check-horizontalpositioning-container"">
        <div id=""check-verticalpositioning-container"">
            <span id=""check-youarethenumber-span"">Sei il numero</span>
            <span id=""check-number-span"">");
#nullable restore
#line 25 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\MeetingCheck.cshtml"
                                    Write(Model.user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span id=\"check-description-span\">\r\n                Presenta questo numero quando andrai a  ");
#nullable restore
#line 27 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\MeetingCheck.cshtml"
                                                         if (BookMarket.Costants.Fase() == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("consegnare");
#nullable restore
#line 28 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\MeetingCheck.cshtml"
                                        }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("ritirare");
#nullable restore
#line 30 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\MeetingCheck.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                i libri\r\n            </span>\r\n            <span id=\"check-appointment-span\">Appuntamento: ");
#nullable restore
#line 33 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\MeetingCheck.cshtml"
                                                             if (BookMarket.Costants.Fase() == 1)
            {

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\MeetingCheck.cshtml"
        Write(Model.user.AppuntamentoRilascio.Value.ToString("dddd, dd MMMM alle HH:mm"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\MeetingCheck.cshtml"
                                                                                         }
            else
            {

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\MeetingCheck.cshtml"
        Write(Model.user.AppuntamentoRitiro.Value.ToString("dddd, dd MMMM alle HH:mm"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\MeetingCheck.cshtml"
                                                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </span>\r\n            <span>alla sede centrale del Liceo Scientifico Gaetano Salvemini</span>\r\n            <span style=\"color:#ff4040\">RICORDA DI ESSERE PUNTUALE O RISCHIERAI DI PERDERE IL TUO TURNO</span>\r\n");
#nullable restore
#line 40 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\MeetingCheck.cshtml"
             if(BookMarket.Costants.Fase() == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"/UploadBook\" style=\"margin-top:20px\">Clicca qui per caricare un altro libro</a>\r\n");
#nullable restore
#line 43 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\MeetingCheck.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
            WriteLiteral(@"</div>

<div id=""check-piture-absolute-container"">
    <!--Take a picture-->
    <div id=""check-picture-container"">
        <i class=""fas fa-camera"" id=""check-picture-icon-i""></i>
        <span id=""check-picture-span"">Scatta una foto o fai uno screenshot!</span>
    </div>
</div>

<style>
    #check-main-container {
        width: 100%;
        height: calc(100vh - 75px);
        font-family: DefaultSB;
        font-size: 25px;
        color: #BABABA;
        display: flex;
        /* align-items: center; */
        padding-top: 20px;
        flex-direction: column;
    }

    #check-horizontalpositioning-container {
        display: block;
        margin-left: auto;
        margin-right: auto;
    }

    #check-verticalpositioning-container {
        display: flex;
        flex-direction: column;
        text-align: center;
        padding-left: 20px;
        padding-right: 20px;
    }

    #check-youarethenumber-span {
        font-size: 30px;
    }

    #check-numbe");
            WriteLiteral(@"r-span {
        color: #C6A0FC;
        font-size: 100px;
        line-height: 100px;
    }

    #check-description-span {
        font-family: DefaultR;
    }

    #check-appointment-span {
        color: #C6A0FC;
    }

    #check-piture-absolute-container {
        position: absolute;
        display: flex;
        flex-direction: row;
        bottom: 60px;
        align-items: center;
        left: 50%;
        transform: translateX(-50%);
    }

    #check-picture-container {
        display: flex;
        flex-direction: row;
        align-items: center;
        font-size: 25px;
    }

    #check-picture-icon-i {
        color: #C6A0FC;
    }

    #check-picture-span {
        color: #C6A0FC;
        margin-left: 10px;
        font-family: DefaultSB;
    }

    ");
            WriteLiteral(@"@media screen and (max-width:500px) {
        #check-youarethenumber-span {
            font-size: 25px !important;
        }

        #check-number-span {
            color: #C6A0FC !important;
            font-size: 110px !important;
            line-height: 110px !important;
        }

        #check-picture-container {
            font-size: 20px !important;
        }

        #check-main-container {
            font-size: 20px !important;
        }
    }

    ");
            WriteLiteral("@media screen and (max-width:450px) {\r\n        #check-picture-container {\r\n            font-size: 15px !important;\r\n        }\r\n\r\n        #check-piture-absolute-container {\r\n            bottom:80px !important;\r\n        }\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookMarket.Pages.MeetingCheckModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookMarket.Pages.MeetingCheckModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookMarket.Pages.MeetingCheckModel>)PageContext?.ViewData;
        public BookMarket.Pages.MeetingCheckModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
