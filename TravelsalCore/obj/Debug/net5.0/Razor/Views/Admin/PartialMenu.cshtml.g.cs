#pragma checksum "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Views\Admin\PartialMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0be4ace76979a06af39a70eb94a81bd3123f8289"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_PartialMenu), @"mvc.1.0.view", @"/Views/Admin/PartialMenu.cshtml")]
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
#line 1 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Views\_ViewImports.cshtml"
using TravelsalCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Views\_ViewImports.cshtml"
using TravelsalCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0be4ace76979a06af39a70eb94a81bd3123f8289", @"/Views/Admin/PartialMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f4008ecfd31c84a5b621170f430129f0c2cfa6c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_PartialMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<ul class=""menu-inner py-1"">
    <li class=""menu-item"">
        <a href=""/Admin/Dashboard/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-home-circle""></i>
            <div data-i18n=""Analytics"">Dashboard</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/Admin/Comment/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-comment-dots""></i>
            <div data-i18n=""Analytics"">Yorumlar</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/Admin/Destination/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-map-alt""></i>
            <div data-i18n=""Analytics"">Rotalar</div>
        </a>
    </li>

    <li class=""menu-item"">
        <a href=""/Admin/User/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bxs-group""></i>
            <div data-i18n=""Analytics"">Misafirler</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/Admin/Contact");
            WriteLiteral(@"Us/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-chat""></i>
            <div data-i18n=""Analytics"">Mesajlar</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""/Admin/Guide/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-user""></i>
            <div data-i18n=""Analytics"">Rehberler</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""#"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bxs-report""></i>
            <div data-i18n=""Analytics"">Raporlar</div>
        </a>
");
            WriteLiteral(@"       
    </li>
    <li class=""menu-item"">
        <a href=""/Admin/Mail/Index/"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-chat""></i>
            <div data-i18n=""Analytics"">Mail Gönder</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bxs-pin""></i>
            <div data-i18n=""Analytics"">Öne Çıkanlar</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bxs-contact""></i>
            <div data-i18n=""Analytics"">Referanslar</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-book-open""></i>
            <div data-i18n=""Analytics"">Alt Hakkında</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon ");
            WriteLiteral(@"tf-icons bx bx-receipt""></i>
            <div data-i18n=""Analytics"">Rezervasyonlar</div>
        </a>
    </li>
        <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bx-box""></i>
            <div data-i18n=""Analytics"">Mail Listesi</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bxs-pin""></i>
            <div data-i18n=""Analytics"">Öne Çıkanlar 2</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bxs-key""></i>
            <div data-i18n=""Analytics"">Şifre İşlemleri</div>
        </a>
    </li>
    <li class=""menu-item"">
        <a href=""index.html"" class=""menu-link"">
            <i class=""menu-icon tf-icons bx bxs-id-card""></i>
            <div data-i18n=""Analytics"">Rol İşlemleri</div>
        </a>
    </li>
    <li class=""");
            WriteLiteral("menu-item\">\r\n        <a href=\"index.html\" class=\"menu-link\">\r\n            <i class=\"menu-icon tf-icons bx bxs-log-out\"></i>\r\n            <div data-i18n=\"Analytics\">Çıkış Yap</div>\r\n        </a>\r\n    </li>\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
