#pragma checksum "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Views\Guide\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "80f5c3719167a595b6e8a450745daaed3230e6b36dcdb49b2c06465cd8d279c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Guide_Index), @"mvc.1.0.view", @"/Views/Guide/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"80f5c3719167a595b6e8a450745daaed3230e6b36dcdb49b2c06465cd8d279c7", @"/Views/Guide/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0ac57599c935658642ab2ca790e39256a948782ce58d4627ae7d33137c7c7557", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Guide_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EntityLayer.Concrete.Guide>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Views\Guide\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""w3l-team"" id=""team"">
    <div class=""team-block py-5"">
        <div class=""container py-lg-5"">
            <div class=""title-content text-center mb-lg-3 mb-4"">
                <h6 class=""sub-title"">Team</h6>
                <h3 class=""hny-title"">Guides</h3>
            </div>
            <div class=""row"">
");
#nullable restore
#line 15 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Views\Guide\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-3 col-6 mt-lg-5 mt-4\">\r\n                        <div class=\"box16\">\r\n                            <a href=\"#url\"><img");
            BeginWriteAttribute("src", " src=\"", 684, "\"", 710, 1);
#nullable restore
#line 19 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Views\Guide\Index.cshtml"
WriteAttributeValue("", 690, item.GuideListImage, 690, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:330px;width:500px\"");
            BeginWriteAttribute("alt", " alt=\"", 744, "\"", 750, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" /></a>\r\n                            <div class=\"box-content\">\r\n                                <h3 class=\"title\"><a href=\"#url\">");
#nullable restore
#line 21 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Views\Guide\Index.cshtml"
                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                <span class=\"post\">");
#nullable restore
#line 22 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Views\Guide\Index.cshtml"
                                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                <ul class=""social"">
                                    <li>
                                        <a href=""#"" class=""facebook"">
                                            <span class=""fa fa-facebook-f""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"" class=""twitter"">
                                            <span class=""fa fa-twitter""></span>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 38 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Views\Guide\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EntityLayer.Concrete.Guide>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591