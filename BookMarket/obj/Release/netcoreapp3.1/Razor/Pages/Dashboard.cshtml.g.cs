#pragma checksum "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3be92a353fde618d9949d078250ed2dfd426b30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookMarket.Pages.Pages_Dashboard), @"mvc.1.0.razor-page", @"/Pages/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3be92a353fde618d9949d078250ed2dfd426b30", @"/Pages/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"620901cba3284544bbc6d0cf3a171f5b1ed390b2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Dashboard : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Countdown", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
  
    ViewData["Title"] = "Bookmarket";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
 if (Model.user.MailToken != null || Model.user.AppuntamentoRilascio != null || Model.user.AppuntamentoRitiro != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!--Warning bar-->\r\n    <div class=\"warningBar-container\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3be92a353fde618d9949d078250ed2dfd426b304402", async() => {
                WriteLiteral("\r\n            <h3 class=\"warningBar\">\r\n");
#nullable restore
#line 13 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
                 if (Model.user.MailToken != null)
                {
                    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        Attenzione, il tuo account non è stato ancora verificato, controlla la tua mail per attivarlo. (Se non trovi la mail prova a controllare la cartella ""Spam""). <button style=""border:none;background:none; text-decoration:underline;outline:none; color: #aaaaaa;   font-size: 12px;"" type=""submit"">Invia di nuovo</button>
                    ");
#nullable restore
#line 17 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
                           
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
                 if (Model.user.AppuntamentoRilascio != null && Model.user.AppuntamentoRitiro == null)
                {
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        Ricordati di passare ");
#nullable restore
#line 22 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
                                        Write(Model.user.AppuntamentoRilascio.Value.ToString("dddd, dd MMMM alle HH:mm"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" per portare i tuoi libri, presentandoti in ritardo rischierai di non poterli vendere!\r\n                    ");
#nullable restore
#line 23 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
                           
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
                 if (Model.user.AppuntamentoRitiro != null)
                {
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        Ricordati di passare ");
#nullable restore
#line 28 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
                                        Write(Model.user.AppuntamentoRitiro.Value.ToString("dddd, dd MMMM alle HH:mm"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" per comprare i tuoi libri, presentandoti in ritardo rischierai di non poterli prendere!\r\n                    ");
#nullable restore
#line 29 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
                           
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </h3>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    </div>
    <style>

        .warningBar {
            color: #c6a0fc;
            text-align: center;
            margin: 0;
        }

        .warningBar-container {
            background-color: #f7f7f7;
            border-radius: 10px;
            margin: 10px;
            padding: 4px;
            font-size:20px;
            box-sizing: border-box;
        }
    </style>
");
#nullable restore
#line 52 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--Top Bar-->\r\n\r\n<div class=\"header-container\">\r\n    <!--Username-->\r\n    <span id=\"home-header-username-label\">");
#nullable restore
#line 58 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
                                     Write(Model.user.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 58 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
                                                      Write(Model.user.Cognome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 58 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
                                                                           Write(Model.user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\r\n    <!--Balance-->\r\n");
            WriteLiteral("    <!--Uploaded books-->\r\n    <span style=\"margin-left:auto\" class=\"home-header-value-label\">Libri caricati: ");
#nullable restore
#line 62 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
                                                                              Write(Model.booksCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
</div>
<!--Separator-->
<div class=""header-separator""></div>


<!--Top Bar Style-->
<style>

    #home-header-username-label {
        font-size: 25px;
        font-family: DefaultB;
        color: #C6A0FC;
        text-align: center;
    }

    .home-header-value-label {
        font-size: 25px;
        font-family: DefaultSB;
        color: #A7A7A7;
        text-align: center;
    }
</style>

");
#nullable restore
#line 86 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
 if (Model.user.MailToken == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!--Options-->\r\n    <div id=\"home-options-container\">\r\n");
#nullable restore
#line 90 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
         if (BookMarket.Costants.Fase() == 2 || BookMarket.Costants.Fase() == 3)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <!--Cart-->
            <div class=""home-option-container"" onclick=""window.location.href = 'basket'"">
                <i class=""fas fa-shopping-cart home-option-icon-label""></i>
                <span class=""home-option-label"">Carrello</span>
            </div>
");
#nullable restore
#line 97 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <!--My books-->
            <div class=""home-option-container"" onclick=""window.location.href = 'mybooks'"">
                <i class=""fas fa-book home-option-icon-label""></i>
                <span class=""home-option-label"">I miei libri</span>
            </div>
");
#nullable restore
#line 105 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e3be92a353fde618d9949d078250ed2dfd426b3013064", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n");
#nullable restore
#line 110 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
}


#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!--Home container-->
<div id=""home-main-container"">
    <div id=""home-widgets-horizontal-position-container"">
        <div id=""home-widgets-horizontal-align-container"">
            <!--Upload book-->
            <div class=""home-widget-container"" id=""home-upload-widget"" onclick=""uploadBookPush()"">
                <div class=""home-widget"">
                    <i class=""fas fa-plus home-widget-icon-label""></i>
                </div>
                <span class=""home-widget-label"">Carica libro</span>
            </div>
            <script>
                function uploadBookPush() {
");
#nullable restore
#line 135 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
                     if (Model.user.MailToken != null)
                    {
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    Swal.fire({
                        icon: 'error',
                        title: 'Errore',
                        text: 'Devi verificare il tuo indirizzo mail prima di poter caricare un libro',
                    }).then(result => {
                        //Reload page
                        window.location.href = ""dashboard"";

                    })
                    return;
                ");
#nullable restore
#line 148 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
                       
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    window.location.href = ""uploadbook"";
                }
            </script>
            <!--Search book-->
            <div class=""home-widget-container"" id=""ASDASDhome-search-widget"" onclick=""window.location.href = 'searchbook'"">
                <div class=""home-widget"">
                    <i class=""fas fa-search home-widget-icon-label""></i>
                </div>
                <span class=""home-widget-label"">Cerca libro</span>
            </div>
        </div>
    </div>
</div>

<!--Home style-->
<style>
    #home-main-container {
        width: 100vw;
        /* height: 90vh; */
        display: flex;
        align-items: center;
        margin-top: 100px;
    }

        #home-widgets-horizontal-position-container {
            display: block;
            margin-left: auto;
            margin-right: auto;
        }

    #home-widgets-horizontal-align-container {
        display: flex;
        flex-direction: row;
    }

        .home-widget-contain");
            WriteLiteral("er {\r\n            display: flex;\r\n            text-align: center;\r\n            flex-direction: column;\r\n            cursor: pointer;\r\n        }\r\n\r\n        #home-upload-widget {\r\n");
#nullable restore
#line 193 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
             if (BookMarket.Costants.Fase() == 2 || BookMarket.Costants.Fase() == 3)
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral(" display: none;\r\n            ");
#nullable restore
#line 196 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
                   

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        }\r\n\r\n    #home-search-widget {\r\n");
#nullable restore
#line 202 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
         if (BookMarket.Costants.Fase() == 1 || BookMarket.Costants.Fase() == 3)
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral(" display: none;\r\n        ");
#nullable restore
#line 205 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
               
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    }

        .home-widget {
            background-color: #C6A0FC;
            width: 300px;
            position: relative;
            height: 300px;
            border-radius: 50px;
            box-shadow: 12px 12px 0px 0px rgba(198,160,252,0.6);
            display: flex;
            align-items: center;
            transition-duration: 0.3s;
        }

            .home-widget:hover {
                transform: translate(5px, 5px);
                box-shadow: 5px 5px 0px 0px rgba(198,160,252,0.6);
                transition-duration: 0.3s;
            }

        .home-widget-icon-label {
            font-size: 150px;
            color: white;
            display: block;
            margin-left: auto;
            margin-right: auto;
        }

        .home-widget-label {
            color: #C6A0FC;
            font-size: 25px;
            font-family: DefaultSB;
            width: 300px;
            margin-top: 20px;
        }

    #home-options-container {
        ");
            WriteLiteral(@"display: flex;
        flex-direction: row;
        top: 20px;
        padding-left: 20px;
        padding-right: 20px;
        align-items: center;
        position: relative;
    }

        .home-option-container {
            display: flex;
            flex-direction: row;
            cursor: pointer;
            align-items: center;
        }

        .home-option-icon-label {
            color: #C6A0FC;
            font-size: 25px;
        }

        .home-option-label {
            color: #C6A0FC;
            font-size: 25px;
            margin-left: 10px;
            font-family: DefaultSB;
        }

        #home-logout-container {
            position: fixed;
            display: flex;
            flex-direction: row;
            bottom: 20px;
            align-items: center;
            left: 20px;
            background-color: transparent;
            border: none;
        }
</style>

<!--Main style-->

<style>
    ");
            WriteLiteral(@"@media screen and (max-width:700px) {
        .home-widget {
            width: 250px !important;
            height: 250px !important;
        }

        .home-widget-label {
            width: 250px !important;
        }
        .warningBar {
            font-size: 15px;
        }
    }

    ");
            WriteLiteral(@"@media screen and (max-width:580px) {


        #home-widgets-horizontal-align-container {
            flex-direction: column !important;
        }

        #home-options-container {
            position: initial !important;
            padding: 0 10px !important;
        }

        #home-header-username-label {
            font-size: 15px !important;
        }

        .home-header-value-label {
            font-size: 15px !important;
        }
    }

    body {
        margin-bottom: 100px !important;
    }
</style>


<!--Post form-->
<script>
    $(function () {
        $('form').submit(function (e) {

            //Override normal form submission
            e.preventDefault()

            //Post form with ajax
            postForm($(this), ""Una nuova mail è stata inviata con successo a "" + """);
#nullable restore
#line 337 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Dashboard.cshtml"
                                                                             Write(Model.user.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", \"dashboard\");\r\n        })\r\n    })\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookMarket.Pages.DashboardModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookMarket.Pages.DashboardModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookMarket.Pages.DashboardModel>)PageContext?.ViewData;
        public BookMarket.Pages.DashboardModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
