#pragma checksum "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Destination\GetCitiesSearchByName.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d40d2225c751ae32e833ad80579da81d586a7060a2c3554ff1eb13f06136f26b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Destination_GetCitiesSearchByName), @"mvc.1.0.view", @"/Areas/Member/Views/Destination/GetCitiesSearchByName.cshtml")]
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
#line 1 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Destination\GetCitiesSearchByName.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d40d2225c751ae32e833ad80579da81d586a7060a2c3554ff1eb13f06136f26b", @"/Areas/Member/Views/Destination/GetCitiesSearchByName.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"00f1d891c511cbd5228e8bcc2be9f6b7b0a0efb3c9efbbad95fea3c2d8438aa3", @"/Areas/Member/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Member_Views_Destination_GetCitiesSearchByName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetCitiesSearchByName", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Member", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Destination\GetCitiesSearchByName.cshtml"
  
    ViewData["Title"] = "GetCitiesSearchByName";
    Layout = "~/Views/Shared/_MemberLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12"">
        <div><div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title"">Tur Rotası Arama Sayfası</h4>
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
                    <p class=""card-text"">Alanında uzman rehberlerimiz eşliğinde Balkanlardan Orta Asya'ya, Doğu Avrupa'dan Anadolu'nu");
            WriteLiteral("n dört bir yanına en uygun fiyatlarla sunduğumuz tur listemize ve tur detaylarına aşağıdaki tablodan erişebilirsiniz.</p>\n\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d40d2225c751ae32e833ad80579da81d586a7060a2c3554ff1eb13f06136f26b6314", async() => {
                WriteLiteral("\n                        <div>\n                            <p>\n                                <b>Lütfen Aranacak Şehri Giriniz:</b> <input type=\"text\" name=\"searchString\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1590, "\"", 1624, 1);
#nullable restore
#line 30 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Destination\GetCitiesSearchByName.cshtml"
WriteAttributeValue("", 1598, ViewData["CurrentFilter"], 1598, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                <br />\n                                <input type=\"submit\" value=\"Şehir Ara\" class=\"btn btn-outline-dark\" />\n                            </p>\n                        </div>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                    <div class=""table-responsive"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Şehir</th>
                                    <th>Süre</th>
                                    <th>Kapasite</th>
                                    <th>Fiyat</th>
                                    <th>Detaylar</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 50 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Destination\GetCitiesSearchByName.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 53 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Destination\GetCitiesSearchByName.cshtml"
                       Write(item.DestinationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 54 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Destination\GetCitiesSearchByName.cshtml"
                       Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 55 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Destination\GetCitiesSearchByName.cshtml"
                       Write(item.DayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 56 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Destination\GetCitiesSearchByName.cshtml"
                       Write(item.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 57 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Destination\GetCitiesSearchByName.cshtml"
                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("₺</td>\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 2841, "\"", 2899, 2);
            WriteAttributeValue("", 2848, "/Destination/DestinationDetails/", 2848, 32, true);
#nullable restore
#line 58 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Destination\GetCitiesSearchByName.cshtml"
WriteAttributeValue("", 2880, item.DestinationID, 2880, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Detaylar</a></td>\n                    </tr>\n");
#nullable restore
#line 60 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Member\Views\Destination\GetCitiesSearchByName.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </tbody>\n                        </table>\n                    </div>\n                </div>\n            </div>\n        </div></div>\n    </div>\n</div>\n");
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
