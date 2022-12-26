#pragma checksum "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d8c5c981758db7fb375584e67015707fa22434f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Reservation_MyCurrentReservation), @"mvc.1.0.view", @"/Areas/Member/Views/Reservation/MyCurrentReservation.cshtml")]
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
#line 1 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\_ViewImports.cshtml"
using TravelsalCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\_ViewImports.cshtml"
using TravelsalCore.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d8c5c981758db7fb375584e67015707fa22434f", @"/Areas/Member/Views/Reservation/MyCurrentReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bb8d108b65426a559a3fe7fb9a9670fae1567ce", @"/Areas/Member/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Member_Views_Reservation_MyCurrentReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
  
    ViewData["Title"] = "MyCurrentReservation";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Aktif Rezervasyonlarım</h1>\r\n");
            WriteLiteral("    <table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Lokasyon</th>\r\n        <th>Kişi Sayısı</th>\r\n        <th>Rezervasyon Tarihi</th>\r\n        <th>Durum</th>\r\n    </tr>\r\n");
#nullable restore
#line 20 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
           Write(item.ReservationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
           Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
           Write(item.PersonCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
           Write(item.ReservationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n");
#nullable restore
#line 31 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
}
else {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <h2> Aktif Rezervasyon Bulunmamaktadır</h2>\r\n");
#nullable restore
#line 34 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
