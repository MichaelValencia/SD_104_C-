#pragma checksum "C:\Projects\SD-104 CSharp\MusicStore\MusicStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51ecaba4a9998a8eacf478fb9d48a7abe4b8c5d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Projects\SD-104 CSharp\MusicStore\MusicStore\Views\_ViewImports.cshtml"
using MusicStore;

#line default
#line hidden
#line 2 "C:\Projects\SD-104 CSharp\MusicStore\MusicStore\Views\_ViewImports.cshtml"
using MusicStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51ecaba4a9998a8eacf478fb9d48a7abe4b8c5d2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b8018c2a0b0564885bf042b2edba49f4f4d24c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MusicStore.Models.songs>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projects\SD-104 CSharp\MusicStore\MusicStore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(92, 128, true);
            WriteLiteral("\r\n<div id=\"myCarousel\" class=\"carousel slide\" data-ride=\"carousel\" data-interval=\"6000\">\r\n    <ol class=\"carousel-indicators\">\r\n");
            EndContext();
#line 9 "C:\Projects\SD-104 CSharp\MusicStore\MusicStore\Views\Home\Index.cshtml"
         for (int n = 0; n < Model.Count(); n++)
        {

#line default
#line hidden
            BeginContext(281, 57, true);
            WriteLiteral("            <li data-target=\"#myCarousel\" data-slide-to=\"");
            EndContext();
            BeginContext(339, 1, false);
#line 11 "C:\Projects\SD-104 CSharp\MusicStore\MusicStore\Views\Home\Index.cshtml"
                                                    Write(n);

#line default
#line hidden
            EndContext();
            BeginContext(340, 1, true);
            WriteLiteral("\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 341, "\"", 357, 2);
#line 11 "C:\Projects\SD-104 CSharp\MusicStore\MusicStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 349, n==0, 349, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 356, "?", 356, 1, true);
            EndWriteAttribute();
            BeginContext(358, 21, true);
            WriteLiteral(" active\":\"\")\"></li>\r\n");
            EndContext();
#line 12 "C:\Projects\SD-104 CSharp\MusicStore\MusicStore\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(390, 60, true);
            WriteLiteral("    </ol>\r\n    <div class=\"carousel-inner\" role=\"listbox\">\r\n");
            EndContext();
#line 15 "C:\Projects\SD-104 CSharp\MusicStore\MusicStore\Views\Home\Index.cshtml"
         for (int n = 0; n < Model.Count(); n++)
        {

#line default
#line hidden
            BeginContext(511, 16, true);
            WriteLiteral("            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 527, "\"", 564, 1);
#line 17 "C:\Projects\SD-104 CSharp\MusicStore\MusicStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 535, n==0?" item active":"item", 535, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(565, 23, true);
            WriteLiteral(">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 588, "\"", 623, 1);
#line 18 "C:\Projects\SD-104 CSharp\MusicStore\MusicStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 594, Model.ElementAt(n).ImagePath, 594, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(624, 254, true);
            WriteLiteral(" alt=\"Album Cover\" class=\"img-responsive center-block\" width=\"240\" hdight=\"80\" />\r\n                <div class=\"carousel-caption\" role=\"option\">\r\n                    <p>\r\n                        Download\r\n                        <a class=\"btn btn-default\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 878, "\"", 920, 2);
            WriteAttributeValue("", 885, "ShoppingCart/", 885, 13, true);
#line 22 "C:\Projects\SD-104 CSharp\MusicStore\MusicStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 898, Model.ElementAt(n).ID, 898, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(921, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(953, 24, false);
#line 23 "C:\Projects\SD-104 CSharp\MusicStore\MusicStore\Views\Home\Index.cshtml"
                       Write(Model.ElementAt(n).Price);

#line default
#line hidden
            EndContext();
            BeginContext(977, 102, true);
            WriteLiteral("\r\n                        </a>\r\n                    </p>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 28 "C:\Projects\SD-104 CSharp\MusicStore\MusicStore\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1090, 929, true);
            WriteLiteral(@"    </div>
    <a class=""left carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
        <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""right carousel-control"" href=""#myCarousel"" role=""button"" data-slide=""next"">
        <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>

<div class=""row"">
    <div class=""col-md-4"">
        <h2>What's New</h2>
        <ul>
            <li>Blah Blah</li>
        </ul>
    </div>
    <div class=""col-md-4"">
        <h2>Join Our Mailing List</h2>
        <ul>
            <li></li>
        </ul>
    </div>
    <div class=""col-md-4"">
        <h2>Billboard</h2>
        <ul>
            <li><a href=""http://Billboard.com"">Hot 100</a></li>
        </ul>
    </div>
</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MusicStore.Models.songs>> Html { get; private set; }
    }
}
#pragma warning restore 1591
