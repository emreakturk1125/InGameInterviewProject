#pragma checksum "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "819b51a0375ad2164ac4ff0426c050f7a0516b73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\_ViewImports.cshtml"
using InGameProject.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\_ViewImports.cshtml"
using InGameProject.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"819b51a0375ad2164ac4ff0426c050f7a0516b73", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6add5dbf0f07f9c6f56e998673c07d8e3dc0fbf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "AddProduct";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<div class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h1 class=""m-0 text-dark"">InGame Panel</h1>
            </div><!-- /.col -->
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
                    <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                    <li class=""breadcrumb-item active"">InGame Panel</li>
                </ol>
            </div><!-- /.col -->
        </div><!-- /.row -->
    </div><!-- /.container-fluid -->
</div>

<div class=""container-fluid"">
    <!-- Small boxes (Stat box) -->
    <div class=""row"">
        <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-info"">
                <div class=""inner"">
                    <h3>");
#nullable restore
#line 30 "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\Home\Index.cshtml"
                   Write(ViewBag.ProductCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                    <p>Ürün Sayısı</p>
                </div>
                <div class=""icon"">
                    <i class=""ion ion-bag""></i>
                </div>
                <a href=""/Product/Index/"" class=""small-box-footer"">Detaylı Ürün Bilgisi <i class=""fas fa-arrow-circle-right""></i></a>
            </div>
        </div>
");
#nullable restore
#line 40 "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\Home\Index.cshtml"
         if (User.IsInRole("product_view"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- ./col -->\r\n            <div class=\"col-lg-3 col-6\">\r\n                <!-- small box -->\r\n                <div class=\"small-box bg-success\">\r\n                    <div class=\"inner\">\r\n                        <h3>");
#nullable restore
#line 47 "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\Home\Index.cshtml"
                       Write(ViewBag.RoleCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                        <p>Role Sayısı</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-stats-bars""></i>
                    </div>
                    <a href=""/Role/Index/"" class=""small-box-footer"">Detaylı Rol Bilgisi <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-6"">
                <!-- small box -->
                <div class=""small-box bg-warning"">
                    <div class=""inner"">
                        <h3>");
#nullable restore
#line 62 "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\Home\Index.cshtml"
                       Write(ViewBag.UserCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                        <p>Kullanıcı Sayısı</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-person-add""></i>
                    </div>
                    <a href=""/User/Index/"" class=""small-box-footer"">Detaylı Kullanıcı Bilgisi <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
");
#nullable restore
#line 72 "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- ./col -->\r\n            <div class=\"col-lg-3 col-6\">\r\n                <!-- small box -->\r\n                <div class=\"small-box bg-danger\">\r\n                    <div class=\"inner\">\r\n                        <h3>");
#nullable restore
#line 78 "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\Home\Index.cshtml"
                       Write(ViewBag.CategoryCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                        <p>Kategori Sayısı</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-pie-graph""></i>
                    </div>
                    <a href=""/Category/Index"" class=""small-box-footer"">Detaylı Kategori Bilgisi <i class=""fas fa-arrow-circle-right""></i></a>
                </div>
            </div>
            <!-- ./col -->
        </div>
    <!-- /.row -->
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
