#pragma checksum "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\ContactUs\MessageDetail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fe8b1c86c8147181b345587296336b5f4abc73575c95a51e4a0c27d9a2653c75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ContactUs_MessageDetail), @"mvc.1.0.view", @"/Areas/Admin/Views/ContactUs/MessageDetail.cshtml")]
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
#line 1 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\_ViewImports.cshtml"
using TravelsalCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\_ViewImports.cshtml"
using TravelsalCore.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fe8b1c86c8147181b345587296336b5f4abc73575c95a51e4a0c27d9a2653c75", @"/Areas/Admin/Views/ContactUs/MessageDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"68f690cfba64daa740a914bc04b7433e9467f5c07aea8dc7c0c8f3b3756b3240", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ContactUs_MessageDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.ContactUs>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\ContactUs\MessageDetail.cshtml"
  
    ViewData["Title"] = "MessageDetail";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>MessageDetail</h3>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Sender</th>\r\n        <th>Subject</th>\r\n        <th>Date</th>\r\n        <th>Message</th>\r\n    </tr>\r\n\r\n        <tr>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\ContactUs\MessageDetail.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\ContactUs\MessageDetail.cshtml"
           Write(Model.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\ContactUs\MessageDetail.cshtml"
           Write(Model.MessageDate.ToString("dd.MMM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\ContactUs\MessageDetail.cshtml"
           Write(Model.MessageBody);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.ContactUs> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
