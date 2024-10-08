#pragma checksum "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\City\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c2277ab6b57187076a1e78cbf3412c2b79eb2420a6ab2bb404580e5bc000804e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_City_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/City/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c2277ab6b57187076a1e78cbf3412c2b79eb2420a6ab2bb404580e5bc000804e", @"/Areas/Admin/Views/City/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"68f690cfba64daa740a914bc04b7433e9467f5c07aea8dc7c0c8f3b3756b3240", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_City_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\gamze\source\repos\TravelsalCore\TravelsalCore\Areas\Admin\Views\City\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
<h2>Destinations</h2>
<br />
<button type=""button"" id=""btngetlist"" class=""btn btn-outline-info"">Destination List</button>
<button type=""button"" id=""btngetbyid1"" class=""btn btn-outline-primary"">Get the Destination</button>
<button type=""button"" id=""btnaddcity1"" class=""btn btn-outline-success"">Add new Destination</button>
<button type=""button"" id=""btndeletecity1"" class=""btn btn-outline-danger"">Delete the Destination</button>
<button type=""button"" id=""btnupdatecity"" class=""btn btn-outline-warning"">Update the Destination</button>
<br />
");
            WriteLiteral("<div id=\"citylist\"> </div> <br />\r\n");
            WriteLiteral("<div id=\"getbyidbutton\">\r\n    <input type=\"text\" id=\"txtid\" placeholder=\"Id\" class=\"form-control\" /><br />\r\n    <button type=\"button\" id=\"btngetbyid\" class=\"btn btn-outline-primary\">Get</button>\r\n</div><br />\r\n\r\n");
            WriteLiteral("<div id=\"destinationlistbyid\"> </div><br />\r\n");
            WriteLiteral("<div id=\"getbyidbuttonfordelete\">\r\n    <input type=\"text\" id=\"txtcityid\" placeholder=\"Id\" class=\"form-control\" /><br />\r\n    <button type=\"button\" id=\"btndeletecity\" class=\"btn btn-outline-primary\">Delete</button>\r\n</div>\r\n<br />\r\n\r\n");
            WriteLiteral(@"<div id=""addcityfield"">
    <input type=""text"" id=""txtcity"" placeholder=""Destination"" class=""form-control""/><br />
    <input type=""text"" id=""txtdaynight"" placeholder=""DayNight"" class=""form-control"" /><br />
    <input type=""text"" id=""txtprice"" placeholder=""Price"" class=""form-control"" /><br />
    <input type=""text"" id=""txtcapacity"" placeholder=""Capacity"" class=""form-control"" /><br />
    <button type=""button"" id=""btnaddcity"" class=""btn btn-outline-success"">Add</button>
</div><br />
");
            WriteLiteral(@"<div id=""editcity"">
    <input type=""text"" id=""txtcityidedit"" placeholder=""Id"" class=""form-control"" /><br />
    <input type=""text"" id=""txtcitynameedit"" placeholder=""Destination"" class=""form-control"" /><br />
    <input type=""text"" id=""txtcitydaynightedit"" placeholder=""DayNight"" class=""form-control"" /><br />
    <input type=""text"" id=""txtcitypriceedit"" placeholder=""Price"" class=""form-control"" /><br />
    <input type=""text"" id=""txtcitycapacityedit"" placeholder=""Capacity"" class=""form-control"" /><br />
    <button type=""button"" id=""btneditcity1"" class=""btn btn-outline-success"">Update</button>
</div>
<br />


<button type=""button"" id=""btnclose"" class=""btn btn-outline-danger"">Close Tabs</button>
<script>
    $(function () {
        $(""#addcityfield"")
            .hide();
        $(""#getbyidbutton"")
            .hide();
        $(""#btnclose"")
            .hide();
        $(""#getbyidbuttonfordelete"")
            .hide();
        $(""#editcity"")
            .hide();
    });

    $(""#btngetli");
            WriteLiteral(@"st"").click(function() {
        $(""#citylist"")
            .show();
        $(""#btnclose"")
            .show();
        $.ajax({
            contentType:""application/json"",
            dataType:""json"",
            type:""Get"",
            url:""/Admin/City/CityList/"",
            success:function(func){
                let w=jQuery.parseJSON(func);
                console.log(w);
                let tablehtml = ""<table class=table table-bordered> <tr><th>Id</th><th>Destination</th><th>DayNight</th><th>Price</th><tr>"";
                $.each(w,(index,value)=>{
                    tablehtml += `<tr><td>${value.DestinationID}</td><td>${value.City}</td><td>${value.DayNight}</td><td>${value.Price} $ </td></tr>`
                });
                tablehtml+=""</table>"";
                $(""#citylist"").html(tablehtml);
            }
        });
    });

    $(""#btnaddcity1"").click(function(){
        $(""#addcityfield"").show();
    });
    $(""#btnaddcity"").click(function() {
        $(""#btnclo");
            WriteLiteral(@"se"")
            .show();
        let cityvalues={
            City:$(""#txtcity"").val(),
            DayNight:$(""#txtdaynight"").val(),
            Price:$(""#txtprice"").val(),
            Capacity:$(""#txtcapacity"").val()
        };
        $.ajax({
            type:""post"",
            url: ""/Admin/City/AddCityDestination/"",
            data:cityvalues,
            success:function(func){
                let result=jQuery.parseJSON(func);
                alert(""Destination added succesfuly."");
            }
        });
    });

    $(""#btnclose"").click(function(){
        $(""#addcityfield"")
            .hide();
        $(""#citylist"")
            .hide();
        $(""#destinationlistbyid"")
            .hide();
        $(""#getbyidbutton"")
            .hide();
        $(""#getbyidbuttonfordelete"")
            .hide();
        $(""#editcity"")
            .hide();
        $(""#btnclose"")
            .hide();
    });

    $(""#btngetbyid1"").click(function () {
        $(""#getbyidbutton");
            WriteLiteral(@""")
        .show();
        $(""#btnclose"")
            .show();
    });
    $(""#btngetbyid"").click(x=>{        
        let id=$(""#txtid"").val();
        $.ajax({
            contentType: ""application/json"",
            dataType: ""json"",
            type: ""Get"",
            url: ""/Admin/City/GetById/"",
            data:{DestinationID:id},
            success:function(fun2){
            let result=jQuery.parseJSON(fun2);
            console.log(result);
                let htmlstr = `<table class=table table-bordered><tr><th>Destination</th><th>DayNight</th><th>Price</th></tr><tr><td>${result.City}</td><td>${result.DayNight}</td><td>${result.Price}</td></tr></table>`;
                $(""#destinationlistbyid"").html(htmlstr);
            }
        });
    });

    $(""#btndeletecity1"").click(function () {        
        $(""#getbyidbuttonfordelete"")
            .show();
        $(""#btnclose"")
            .show();
    });
    $(""#btndeletecity"").click(x=>{
        let id = $(""#txtcityi");
            WriteLiteral(@"d"").val();
        $.ajax({
            url: ""/Admin/City/DeleteCity/""+id,
            type:""Post"",
            contentType: ""application/json"",
            dataType:""json"",
            success:function(func3){                
                alert(""Deleted!"");
            }
        });
    });

    $(""#btnupdatecity"").click(function () {
        $(""#editcity"")
            .show();
        $(""#btnclose"")
            .show();
    });
    $(""#btneditcity1"").click(function () {
        let values={
            DestinationID: $(""#txtcityidedit"").val(),
            City: $(""#txtcitynameedit"").val(),
            DayNight: $(""#txtcitydaynightedit"").val(),
            Price: $(""#txtcitypriceedit"").val(),
            Capacity: $(""#txtcitycapacityedit"").val()
        };
        $.ajax({
            type: ""Post"",
            url: ""/Admin/City/UpdateCity/"",
            data:values,
            succes:function(fun4){
                alert(""Updated!"");
            }
        });
    });
</");
            WriteLiteral("script>");
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
