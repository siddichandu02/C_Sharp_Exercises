#pragma checksum "C:\Users\BK185139\source\repos\mvc1\mvc1\Views\Blog\post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07ccb653118c1785096026ba2ff443c6f5f9165c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_post), @"mvc.1.0.view", @"/Views/Blog/post.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07ccb653118c1785096026ba2ff443c6f5f9165c", @"/Views/Blog/post.cshtml")]
    public class Views_Blog_post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<mvc1.Models.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\BK185139\source\repos\mvc1\mvc1\Views\Blog\post.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<article class=\"blog-post\">\r\n    <h1>");
#nullable restore
#line 7 "C:\Users\BK185139\source\repos\mvc1\mvc1\Views\Blog\post.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"details\">\r\n        Posted <span>");
#nullable restore
#line 9 "C:\Users\BK185139\source\repos\mvc1\mvc1\Views\Blog\post.cshtml"
                Write(Model.Posted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> by <span>");
#nullable restore
#line 9 "C:\Users\BK185139\source\repos\mvc1\mvc1\Views\Blog\post.cshtml"
                                              Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n    <div class=\"content\">\r\n        ");
#nullable restore
#line 12 "C:\Users\BK185139\source\repos\mvc1\mvc1\Views\Blog\post.cshtml"
   Write(Model.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</article>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mvc1.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591