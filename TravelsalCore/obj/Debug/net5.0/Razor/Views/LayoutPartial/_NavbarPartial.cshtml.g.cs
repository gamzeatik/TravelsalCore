#pragma checksum "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Views\LayoutPartial\_NavbarPartial.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a97f5d1bf63bfc3f0cc8c79baa34ea42e849496437178d337fdd51c933fb6361"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LayoutPartial__NavbarPartial), @"mvc.1.0.view", @"/Views/LayoutPartial/_NavbarPartial.cshtml")]
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
#line 1 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Views\_ViewImports.cshtml"
using TravelsalCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Views\_ViewImports.cshtml"
using TravelsalCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a97f5d1bf63bfc3f0cc8c79baa34ea42e849496437178d337fdd51c933fb6361", @"/Views/LayoutPartial/_NavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0ac57599c935658642ab2ca790e39256a948782ce58d4627ae7d33137c7c7557", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LayoutPartial__NavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<header id=""site-header"" class=""fixed-top"">
    <div class=""container"">
        <nav class=""navbar navbar-expand-lg stroke"">
            <h1>
                <a class=""navbar-brand mr-lg-5"" href=""/Default/Index/"">
                    Travel
                </a>
            </h1>
            <!-- if logo is image enable this
            <a class=""navbar-brand"" href=""#index.html"">
                <img src=""image-path"" alt=""Your logo"" title=""Your logo"" style=""height:35px;"" />
            </a> -->
            <button class=""navbar-toggler  collapsed bg-gradient"" type=""button"" data-toggle=""collapse""
                    data-target=""#navbarTogglerDemo02"" aria-controls=""navbarTogglerDemo02"" aria-expanded=""false""
                    aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon fa icon-expand fa-bars""></span>
                <span class=""navbar-toggler-icon fa icon-close fa-times""></span>
            </button>

            <div class=""collapse navbar-collapse"" id=");
            WriteLiteral(@"""navbarTogglerDemo02"">
                <ul class=""navbar-nav mr-auto"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""/Default/Index/"">Home <span class=""sr-only"">(current)</span></a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""about.html"">About</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Destination/Index/"">Destinations</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Guide/Index/"">Guides</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Contact/Index/"">Contact</a>
                    </li>

                </ul>
            </div>
            <div class=""d-lg-block d-none"">
                <a href=""/Login/Signin/"" class=""btn btn-style btn-sec");
            WriteLiteral(@"ondary"">Reservation</a>
            </div>
            <!-- toggle switch for light and dark theme -->
            <div class=""mobile-position"">
                <nav class=""navigation"">
                    <div class=""theme-switch-wrapper"">
                        <label class=""theme-switch"" for=""checkbox"">
                            <input type=""checkbox"" id=""checkbox"">
                            <div class=""mode-container"">
                                <i class=""gg-sun""></i>
                                <i class=""gg-moon""></i>
                            </div>
                        </label>
                    </div>
                </nav>
            </div>
            <!-- //toggle switch for light and dark theme -->
        </nav>
    </div>
</header>
");
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
