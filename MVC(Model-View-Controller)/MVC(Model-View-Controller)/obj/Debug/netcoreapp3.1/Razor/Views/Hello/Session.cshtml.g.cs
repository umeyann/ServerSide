#pragma checksum "D:\5_School\4 years\2_[吉川 翔太]Sever Side\Project\MVC(Model-View-Controller)\MVC(Model-View-Controller)\Views\Hello\Session.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95ca8f15cdb756a639bd35f33912a84d36c798f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hello_Session), @"mvc.1.0.view", @"/Views/Hello/Session.cshtml")]
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
#line 1 "D:\5_School\4 years\2_[吉川 翔太]Sever Side\Project\MVC(Model-View-Controller)\MVC(Model-View-Controller)\Views\_ViewImports.cshtml"
using MVC_Model_View_Controller_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\5_School\4 years\2_[吉川 翔太]Sever Side\Project\MVC(Model-View-Controller)\MVC(Model-View-Controller)\Views\_ViewImports.cshtml"
using MVC_Model_View_Controller_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95ca8f15cdb756a639bd35f33912a84d36c798f3", @"/Views/Hello/Session.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51b8124ce55e7fa04cb7033499c2de10fb920280", @"/Views/_ViewImports.cshtml")]
    public class Views_Hello_Session : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\5_School\4 years\2_[吉川 翔太]Sever Side\Project\MVC(Model-View-Controller)\MVC(Model-View-Controller)\Views\Hello\Session.cshtml"
  
    ViewData["Title"] = "Session/Hello";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-left\"\r\n <h1 class=\"display-3\">Session</h1>\r\n <p class=\"h4 mb-4\">");
#nullable restore
#line 6 "D:\5_School\4 years\2_[吉川 翔太]Sever Side\Project\MVC(Model-View-Controller)\MVC(Model-View-Controller)\Views\Hello\Session.cshtml"
               Write(ViewData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n <ul class=\"h5\">\r\n <li>");
#nullable restore
#line 8 "D:\5_School\4 years\2_[吉川 翔太]Sever Side\Project\MVC(Model-View-Controller)\MVC(Model-View-Controller)\Views\Hello\Session.cshtml"
Write(ViewData["id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n <li>");
#nullable restore
#line 9 "D:\5_School\4 years\2_[吉川 翔太]Sever Side\Project\MVC(Model-View-Controller)\MVC(Model-View-Controller)\Views\Hello\Session.cshtml"
Write(ViewData["name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n </ul>\r\n</div>");
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
