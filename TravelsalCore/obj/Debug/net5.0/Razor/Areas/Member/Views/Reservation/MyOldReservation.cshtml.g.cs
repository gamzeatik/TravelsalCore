#pragma checksum "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyOldReservation.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8b64d05007fb365b09436a7d3b7db7f248e72c63c9e2de72bc081a12c2a1b521"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Reservation_MyOldReservation), @"mvc.1.0.view", @"/Areas/Member/Views/Reservation/MyOldReservation.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\_ViewImports.cshtml"
using TravelsalCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\_ViewImports.cshtml"
using TravelsalCore.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8b64d05007fb365b09436a7d3b7db7f248e72c63c9e2de72bc081a12c2a1b521", @"/Areas/Member/Views/Reservation/MyOldReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"00f1d891c511cbd5228e8bcc2be9f6b7b0a0efb3c9efbbad95fea3c2d8438aa3", @"/Areas/Member/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Member_Views_Reservation_MyOldReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
  
    ViewData["Title"] = "MyOldReservation";
    Layout = "~/Views/Shared/_MemberLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title"">Geçmiş Rezervasyonlar</h4>
                <a class=""heading-elements-toggle""><i class=""la la-ellipsis-v font-medium-3""></i></a>
                <div class=""heading-elements"">
                    <ul class=""list-inline mb-0"">
                        <li><a data-action=""collapse""><i class=""ft-minus""></i></a></li>
                        <li><a data-action=""reload""><i class=""ft-rotate-cw""></i></a></li>
                        <li><a data-action=""expand""><i class=""ft-maximize""></i></a></li>
                        <li><a data-action=""close""><i class=""ft-x""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""card-content collapse show"">
                <div class=""card-body"">
                    <p class=""card-text"">Web Sitemiz Traversal üzerinde daha önce yapmış olduğunuz geçmiş rezervasyon listenize aşağıdan eriş");
            WriteLiteral(@"ebilirsiniz. </p>
                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Lokasyon</th>
                                    <th>Kişi Sayısı</th>
                                    <th>Rezervasyon Tarihi</th>
                                    <th>Durum</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 39 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
                                 foreach (var item in Model)
                                {
                                    count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td>");
#nullable restore
#line 43 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
                                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 44 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
                                   Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 45 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
                                   Write(item.PersonCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 46 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
                                    Write(((DateTime)item.ReservationDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 47 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
                                   Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                </tr>\n");
#nullable restore
#line 49 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Reservation\MyOldReservation.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </tbody>\n                        </table>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
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
