#pragma checksum "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "348908dfa667f82922fe3a950e7e9e88d3e6e170"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\_ViewImports.cshtml"
using TravelsalCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\_ViewImports.cshtml"
using TravelsalCore.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\User\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"348908dfa667f82922fe3a950e7e9e88d3e6e170", @"/Areas/Admin/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bb8d108b65426a559a3fe7fb9a9670fae1567ce", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int sayac = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Kullanıcılar</h1>
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Ad Soyad</th>
        <th>Kullanıcı Adı</th>
        <th>E mail</th>
        <th>Yorumlar</th>
        <th>Tur Geçmişi</th>
        <th>Düzenle</th>
        <th>Sil</th>
    </tr>
");
#nullable restore
#line 21 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\User\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
#nullable restore
#line 24 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\User\Index.cshtml"
              
                sayac = sayac + 1;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 27 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\User\Index.cshtml"
           Write(sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\User\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\User\Index.cshtml"
                      Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\User\Index.cshtml"
           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\User\Index.cshtml"
           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 744, "\"", 783, 2);
            WriteAttributeValue("", 751, "/Admin/User/CommentUser/", 751, 24, true);
#nullable restore
#line 31 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 775, item.Id, 775, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\" style=\"width:100%\">Yorumlar</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 870, "\"", 913, 2);
            WriteAttributeValue("", 877, "/Admin/User/ReservationUser/", 877, 28, true);
#nullable restore
#line 32 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 905, item.Id, 905, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\" style=\"width:100%\">Tur Geçmişi</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1006, "\"", 1042, 2);
            WriteAttributeValue("", 1013, "/Admin/User/EditUser/", 1013, 21, true);
#nullable restore
#line 33 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 1034, item.Id, 1034, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\" style=\"width:100%\">Düzenle</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1131, "\"", 1169, 2);
            WriteAttributeValue("", 1138, "/Admin/User/DeleteUser/", 1138, 23, true);
#nullable restore
#line 34 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 1161, item.Id, 1161, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\" style=\"width:100%\">Sil</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "C:\Users\MINAD\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\User\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Login/SignUp/\" class=\"btn btn-outline-primary\">Yeni Kullanıcı Ekle</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591