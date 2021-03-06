#pragma checksum "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\Shared\_BasketList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5680538c51262982d7d4f1cba9eda1ec3df3d92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookMarket.Pages.Shared.Pages_Shared__BasketList), @"mvc.1.0.view", @"/Pages/Shared/_BasketList.cshtml")]
namespace BookMarket.Pages.Shared
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5680538c51262982d7d4f1cba9eda1ec3df3d92", @"/Pages/Shared/_BasketList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"620901cba3284544bbc6d0cf3a171f5b1ed390b2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__BasketList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BookMarket.Models.BookLibri>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\Shared\_BasketList.cshtml"
 if (Model.Count != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!--Create list-->\r\n");
#nullable restore
#line 5 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\Shared\_BasketList.cshtml"
     foreach (var book in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"search-list-element\">\r\n            <div class=\"search-list-element-horizontalalign\">\r\n                <button class=\"fas fa-times deleteButton\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 310, "\"", 340, 3);
            WriteAttributeValue("", 320, "deleteBook(", 320, 11, true);
#nullable restore
#line 9 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\Shared\_BasketList.cshtml"
WriteAttributeValue("", 331, book.Id, 331, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 339, ")", 339, 1, true);
            EndWriteAttribute();
            WriteLiteral(">  </button>\r\n                <div class=\"search-list-element-left-container\">\r\n                    <div class=\"search-list-element-title-container\">\r\n                        <!--Title-->\r\n                        <span class=\"search-list-element-title\">");
#nullable restore
#line 13 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\Shared\_BasketList.cshtml"
                                                           Write(book.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <!--Subject-->\r\n                        <span class=\"uk-badge search-list-element-subject\">");
#nullable restore
#line 15 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\Shared\_BasketList.cshtml"
                                                                      Write(book.Materia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <!--Code-->\r\n                    <span class=\"search-list-element-code\">");
#nullable restore
#line 18 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\Shared\_BasketList.cshtml"
                                                      Write(book.Codice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"search-list-element-right-container\">\r\n                    <!--Price-->\r\n");
#nullable restore
#line 22 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\Shared\_BasketList.cshtml"
                     if (book.Prezzo != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"search-list-element-price\">??? ");
#nullable restore
#line 24 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\Shared\_BasketList.cshtml"
                                                             Write(String.Format("{0:0.00}", BookMarket.Costants.CalculateUserPrice(book.Prezzo.Value)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 25 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\Shared\_BasketList.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </li>\r\n");
#nullable restore
#line 29 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\Shared\_BasketList.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\Shared\_BasketList.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <script>
            Swal.fire({
                icon: 'warning',
                title: 'Attenzione',
                text: ""Non hai aggiunto ancora nessun libro"",
            }).then(result => {
                //Redirect to dashboard
                window.history.back();
            })
    </script>
");
#nullable restore
#line 43 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini-Bookmarket\BookMarket\Pages\Shared\_BasketList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--x style-->
<style>
    .deleteButton {
        font-size: 18px;
        margin-right: 20px;
        color: white;
        background-color: #FF7474;
        border: none;
        outline: none;
        border-radius: 15px;
        width: 30px;
        height: 30px;
        text-align: center;
        box-sizing:border-box;
        padding:0;
    }
        .deleteButton:hover {
            cursor: pointer;
            background-color: #FF4E4E;
        }
</style>
<!--Delete script-->
<script>
    function deleteBook(id) {
        Swal.fire({
            icon: 'warning',
            title: 'Attenzione',
            text: ""Sei sicuro di voler eliminare questo libro?"",
            showCancelButton: true,
            confirmButtonText: 'Elimina',
            cancelButtonText: 'Annulla',
            confirmButtonColor: '#FF7474'
        }).then((result) => {
            if (result.value) {
                //Delete action
                document.getElementById(""bookToDeleteI");
            WriteLiteral("d\").value = id;\r\n                $(\"form\").submit();\r\n            }\r\n               \r\n        })\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BookMarket.Models.BookLibri>> Html { get; private set; }
    }
}
#pragma warning restore 1591
