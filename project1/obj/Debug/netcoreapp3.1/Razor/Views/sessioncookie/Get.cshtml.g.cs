#pragma checksum "D:\work\project1\project1\Views\sessioncookie\Get.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99786b2bae0efd0cecf0ee9fb61e7734fe7b8cff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_sessioncookie_Get), @"mvc.1.0.view", @"/Views/sessioncookie/Get.cshtml")]
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
#line 1 "D:\work\project1\project1\Views\_ViewImports.cshtml"
using project1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\work\project1\project1\Views\_ViewImports.cshtml"
using project1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\work\project1\project1\Views\sessioncookie\Get.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99786b2bae0efd0cecf0ee9fb61e7734fe7b8cff", @"/Views/sessioncookie/Get.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee5cc777859ddb072dc9ba748efb6e247b95c7fc", @"/Views/_ViewImports.cshtml")]
    public class Views_sessioncookie_Get : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\work\project1\project1\Views\sessioncookie\Get.cshtml"
  
    ViewData["Title"] = "Get";

    var name = HttpContextAccessor.HttpContext.Session.GetString("Name");
  //  var address = string.Empty;
    //if (HttpContextAccessor.HttpContext.Request.Cookies["Address"] != null)
    //{
    //    address = HttpContextAccessor.HttpContext.Request.Cookies["Address"].ToString();
    //}
    //else
    //{
    //    address = "BABAJI";
    //}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Get</h1>\r\n");
#nullable restore
#line 19 "D:\work\project1\project1\Views\sessioncookie\Get.cshtml"
Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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
