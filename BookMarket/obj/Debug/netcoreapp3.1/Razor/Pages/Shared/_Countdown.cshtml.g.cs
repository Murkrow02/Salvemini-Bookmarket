#pragma checksum "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\Shared\_Countdown.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6eadeda5f90b267a384f487019d71d505d1615d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookMarket.Pages.Shared.Pages_Shared__Countdown), @"mvc.1.0.view", @"/Pages/Shared/_Countdown.cshtml")]
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
#line 1 "C:\Users\Marco\Desktop\Coding\Repos\Salvemini\BookMarket\BookMarket\Pages\_ViewImports.cshtml"
using BookMarket;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6eadeda5f90b267a384f487019d71d505d1615d", @"/Pages/Shared/_Countdown.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"620901cba3284544bbc6d0cf3a171f5b1ed390b2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Countdown : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!-- Display the countdown timer in an element -->
    <div class=""countdown-container"" style=""display:flex; margin-left:auto; flex-direction:column;"">
        <span style=""color:#939393"" id=""title""></span>
        <p style=""color: #c6a0fc; text-align:end; margin:0 !important;  font-family: DefaultSB;"" id=""demo""></p>
    </div>


<script>// Set the date we're counting down to

    function getCountdownDate(currentDate) {

        //Caricamento libri
        if (currentDate < new Date(""Aug 30, 2021 09:00:00"").getTime()) {
            document.getElementById(""title"").innerHTML = ""Scadenza caricamento libri"";
            return new Date(""Aug 30, 2021 09:00:00"").getTime();
        }

        //Ritiro libri    
        if (currentDate < new Date(""Aug 31, 2020 13:00:00"").getTime()) {
            document.getElementById(""title"").innerHTML = ""Scadenza ritiro libri"";
            return new Date(""Aug 31, 2020 13:00:00"").getTime();
        }

        //Prenotazione libri
        if (currentDate");
            WriteLiteral(@" < new Date(""Sep 2, 2021 10:00:00"").getTime()) {
            document.getElementById(""title"").innerHTML = ""Scadenza prenotazione libri"";
            return new Date(""Sep 2, 2021 10:00:00"").getTime();
        }

        //Vendita libri
        if (currentDate < new Date(""Sep 3, 2021 13:00:00"").getTime()) {
            document.getElementById(""title"").innerHTML = ""Scadenza vendita libri"";
            return new Date(""Sep 3, 2021 13:00:00"").getTime();
        }

        //Ritiro libri e soldi 
        if (currentDate < new Date(""Sep 7, 2021 13:00:00"").getTime()) {
            document.getElementById(""title"").innerHTML = ""Scadenza consegna soldi"";
            return new Date(""Sep 7, 2021 13:00:00"").getTime();
        }
    }


    var countDownDate = getCountdownDate(new Date().getTime());
    

    // Update the count down every 1 second
    var x = setInterval(function () {

        // Get today's date and time
        var now = new Date().getTime();

        // Find the distance bet");
            WriteLiteral(@"ween now and the count down date
        var distance = countDownDate - now;

        // Time calculations for days, hours, minutes and seconds
        var days = Math.floor(distance / (1000 * 60 * 60 * 24));
        var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
        var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
        var seconds = Math.floor((distance % (1000 * 60)) / 1000);

        // Display the result in the element with id=""demo""
        document.getElementById(""demo"").innerHTML = days + ""g "" + hours + ""h ""
            + minutes + ""m "" + seconds + ""s "";

        // If the count down is finished, write some text
        if (distance < 0) {
            clearInterval(x);
            document.getElementById(""demo"").innerHTML = """";
        }
    }, 1000);</script>
");
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
