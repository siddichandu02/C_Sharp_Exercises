#pragma checksum "C:\Users\BK185139\source\repos\friends\Views\Friend\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92b790e8317f87886d6a544cfe544ef19d569a88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Friend_Index), @"mvc.1.0.view", @"/Views/Friend/Index.cshtml")]
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
#line 1 "C:\Users\BK185139\source\repos\friends\Views\_ViewImports.cshtml"
using friends;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BK185139\source\repos\friends\Views\_ViewImports.cshtml"
using friends.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b790e8317f87886d6a544cfe544ef19d569a88", @"/Views/Friend/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abb72d3ee96a020ef95aa57f2b17860cd7140a86", @"/Views/_ViewImports.cshtml")]
    public class Views_Friend_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<friends.Models.Friend>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>View Friends</h1>\r\n\r\n<div class=\"friends\">\r\n    <table border=\"1\">\r\n        <tr>\r\n            <th>FriendId</th>\r\n            <th>FriendName</th>\r\n            <th>Place</th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\BK185139\source\repos\friends\Views\Friend\Index.cshtml"
         foreach (var friend in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\BK185139\source\repos\friends\Views\Friend\Index.cshtml"
               Write(friend.FriendId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n                <td>");
#nullable restore
#line 20 "C:\Users\BK185139\source\repos\friends\Views\Friend\Index.cshtml"
               Write(friend.FriendName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n                <td>");
#nullable restore
#line 22 "C:\Users\BK185139\source\repos\friends\Views\Friend\Index.cshtml"
               Write(friend.Place);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\BK185139\source\repos\friends\Views\Friend\Index.cshtml"

            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<friends.Models.Friend>> Html { get; private set; }
    }
}
#pragma warning restore 1591
