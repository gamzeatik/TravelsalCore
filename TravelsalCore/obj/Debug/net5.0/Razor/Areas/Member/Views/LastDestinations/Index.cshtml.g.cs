#pragma checksum "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\LastDestinations\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3bda9b9584690e5779f44659f91fee74e76d1b89baf80a6fecc6090d5701a745"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_LastDestinations_Index), @"mvc.1.0.view", @"/Areas/Member/Views/LastDestinations/Index.cshtml")]
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
#line 3 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3bda9b9584690e5779f44659f91fee74e76d1b89baf80a6fecc6090d5701a745", @"/Areas/Member/Views/LastDestinations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"00f1d891c511cbd5228e8bcc2be9f6b7b0a0efb3c9efbbad95fea3c2d8438aa3", @"/Areas/Member/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Member_Views_LastDestinations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image placeholder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/soft-ui-dashboard/assets/img/team-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/soft-ui-dashboard/assets/img/team-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/soft-ui-dashboard/assets/img/team-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/soft-ui-dashboard/assets/img/team-4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\LastDestinations\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MemberLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-12 mt-4"">
    <div class=""card mb-4"">
        <div class=""card-header pb-0 p-3"">
            <h6 class=""mb-1"">Son Rotalar</h6>
            <p class=""text-sm""> En Son Eklenen Seyahat Rotaları</p>
        </div>
        <div class=""card-body p-3"">
            <div class=""row"">
");
#nullable restore
#line 16 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\LastDestinations\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-xl-3 col-md-6 mb-xl-0 mb-4"">
                        <div class=""card card-blog card-plain"">
                            <div class=""position-relative"">
                                <a class=""d-block shadow-xl border-radius-xl"">
                                    <img");
            BeginWriteAttribute("src", " src=\"", 780, "\"", 797, 1);
#nullable restore
#line 22 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\LastDestinations\Index.cshtml"
WriteAttributeValue("", 786, item.Image, 786, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""width:400px; height:200px;"" alt=""img-blur-shadow"" class=""img-fluid shadow border-radius-xl"">
                                </a>
                            </div>
                            <div class=""card-body px-1 pb-0"">
                                <p class=""text-gradient text-dark mb-2 text-sm"">");
#nullable restore
#line 26 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\LastDestinations\Index.cshtml"
                                                                           Write(item.DayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 26 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\LastDestinations\Index.cshtml"
                                                                                            Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</p>\n                                <a href=\"javascript:;\">\n                                    <h5>\n                                        ");
#nullable restore
#line 29 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\LastDestinations\Index.cshtml"
                                   Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </h5>\n                                </a>\n                                <p class=\"mb-4 text-sm\">\n                                    ");
#nullable restore
#line 33 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\LastDestinations\Index.cshtml"
                               Write(item.Details2.Substring(0, 100));

#line default
#line hidden
#nullable disable
            WriteLiteral("...\n                                </p>\n                                <div class=\"d-flex align-items-center justify-content-between\">\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1675, "\"", 1733, 2);
            WriteAttributeValue("", 1682, "/Destination/DestinationDetails/", 1682, 32, true);
#nullable restore
#line 36 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\LastDestinations\Index.cshtml"
WriteAttributeValue("", 1714, item.DestinationID, 1714, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-outline-primary btn-sm mb-0"">Tur Detayları</a>
                                    <div class=""avatar-group mt-2"">
                                        <a href=""javascript:;"" class=""avatar avatar-xs rounded-circle"" data-bs-toggle=""tooltip"" data-bs-placement=""bottom"" title=""Elena Morison"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3bda9b9584690e5779f44659f91fee74e76d1b89baf80a6fecc6090d5701a74510027", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </a>
                                        <a href=""javascript:;"" class=""avatar avatar-xs rounded-circle"" data-bs-toggle=""tooltip"" data-bs-placement=""bottom"" title=""Ryan Milly"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3bda9b9584690e5779f44659f91fee74e76d1b89baf80a6fecc6090d5701a74511438", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </a>
                                        <a href=""javascript:;"" class=""avatar avatar-xs rounded-circle"" data-bs-toggle=""tooltip"" data-bs-placement=""bottom"" title=""Nick Daniel"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3bda9b9584690e5779f44659f91fee74e76d1b89baf80a6fecc6090d5701a74512850", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </a>
                                        <a href=""javascript:;"" class=""avatar avatar-xs rounded-circle"" data-bs-toggle=""tooltip"" data-bs-placement=""bottom"" title=""Peterson"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3bda9b9584690e5779f44659f91fee74e76d1b89baf80a6fecc6090d5701a74514259", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        </a>\n                                    </div>\n                                </div>\n                            </div>\n                        </div>\n                    </div>");
#nullable restore
#line 54 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\LastDestinations\Index.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
