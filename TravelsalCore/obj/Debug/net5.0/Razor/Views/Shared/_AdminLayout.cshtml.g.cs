#pragma checksum "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Views\Shared\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b58d3a028b22a4913c7816ce70ed81d10a1083ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Views/Shared/_AdminLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b58d3a028b22a4913c7816ce70ed81d10a1083ad", @"/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f4008ecfd31c84a5b621170f430129f0c2cfa6c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Views\Shared\_AdminLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b58d3a028b22a4913c7816ce70ed81d10a1083ad3721", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>_AdminLayout</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b58d3a028b22a4913c7816ce70ed81d10a1083ad4787", async() => {
                WriteLiteral("\r\n    <!DOCTYPE html>\r\n    <html lang=\"en\"\r\n          class=\"light-style layout-menu-fixed\"\r\n          dir=\"ltr\"\r\n          data-theme=\"theme-default\"\r\n          data-assets-path=\"../assets/\"\r\n          data-template=\"vertical-menu-template-free\">\r\n\r\n    ");
#nullable restore
#line 19 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Views\Shared\_AdminLayout.cshtml"
Write(await Html.PartialAsync("/Views/Admin/PartialHeader.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b58d3a028b22a4913c7816ce70ed81d10a1083ad5613", async() => {
                    WriteLiteral("\r\n        <div class=\"layout-wrapper layout-content-navbar\">\r\n            <div class=\"layout-container\">\r\n                <aside id=\"layout-menu\" class=\"layout-menu menu-vertical menu bg-menu-theme\">\r\n                    \r\n                    ");
#nullable restore
#line 26 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Views\Shared\_AdminLayout.cshtml"
               Write(await Html.PartialAsync("/Views/Admin/PartialAppBrand.cshtml"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\r\n                    <div class=\"menu-inner-shadow\"></div>\r\n\r\n                    ");
#nullable restore
#line 30 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Views\Shared\_AdminLayout.cshtml"
               Write(await Html.PartialAsync("/Views/Admin/PartialMenu.cshtml"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\r\n                </aside>\r\n                <div class=\"layout-page\">\r\n\r\n                    ");
#nullable restore
#line 35 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Views\Shared\_AdminLayout.cshtml"
               Write(await Html.PartialAsync("/Views/Admin/PartialNavBar.cshtml"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\r\n                    <div class=\"content-wrapper\">\r\n                        <div class=\"container-xxl flex-grow-1 container-p-y\">\r\n                            ");
#nullable restore
#line 39 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Views\Shared\_AdminLayout.cshtml"
                       Write(RenderBody());

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                        </div>\r\n\r\n                        ");
#nullable restore
#line 42 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Views\Shared\_AdminLayout.cshtml"
                   Write(await Html.PartialAsync("/Views/Admin/PartialFooter.cshtml"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\r\n                        <div class=\"content-backdrop fade\"></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"layout-overlay layout-menu-toggle\"></div>\r\n        </div>\r\n\r\n        ");
#nullable restore
#line 51 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Views\Shared\_AdminLayout.cshtml"
   Write(await Html.PartialAsync("/Views/Admin/PartialScript.cshtml"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n</html>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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