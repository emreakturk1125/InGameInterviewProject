#pragma checksum "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\Role\EditRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a9d01a533151188d8ccd46e433531a5875ca3b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_EditRole), @"mvc.1.0.view", @"/Views/Role/EditRole.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a9d01a533151188d8ccd46e433531a5875ca3b6", @"/Views/Role/EditRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6add5dbf0f07f9c6f56e998673c07d8e3dc0fbf2", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_EditRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InGameProject.Entities.Concrete.Role>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\Role\EditRole.cshtml"
  
    ViewData["Title"] = "EditRole";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h1>Rol Düzenleme Sayfası</h1>\r\n<br />\r\n");
#nullable restore
#line 10 "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\Role\EditRole.cshtml"
 using (Html.BeginForm("EditRole", "Role", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-group\" style=\"width:800px;margin:auto\">\r\n    ");
#nullable restore
#line 13 "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\Role\EditRole.cshtml"
Write(Html.Hidden("Rol Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 14 "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\Role\EditRole.cshtml"
Write(Html.HiddenFor(x => x.RoleId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 15 "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\Role\EditRole.cshtml"
Write(Html.Label("Rol Adı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 16 "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\Role\EditRole.cshtml"
Write(Html.TextBoxFor(x => x.RoleName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    <br />\r\n    ");
#nullable restore
#line 19 "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\Role\EditRole.cshtml"
Write(Html.Label("Açıklama"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 20 "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\Role\EditRole.cshtml"
Write(Html.TextBoxFor(x => x.RoleDescription, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    <br />\r\n    ");
#nullable restore
#line 23 "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\Role\EditRole.cshtml"
Write(Html.Label("Durum"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 24 "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\Role\EditRole.cshtml"
Write(Html.CheckBoxFor(x => x.IsActive, new { @style = "width:5%" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <br />\r\n\r\n    <button class=\"btn btn-info\">Güncelle</button>\r\n</div>\r\n");
#nullable restore
#line 30 "D:\InGame\InGameInterviewProject\InGameProject.WebUI\Views\Role\EditRole.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InGameProject.Entities.Concrete.Role> Html { get; private set; }
    }
}
#pragma warning restore 1591