#pragma checksum "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Blog\blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bd1acf3bab340883e73c30d7c18ae3ee0b2f7a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_blog), @"mvc.1.0.view", @"/Views/Blog/blog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/blog.cshtml", typeof(AspNetCore.Views_Blog_blog))]
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
#line 1 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\_ViewImports.cshtml"
using VegetableStore;

#line default
#line hidden
#line 2 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\_ViewImports.cshtml"
using VegetableStore.Models.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\_ViewImports.cshtml"
using VegetableStore.Models;

#line default
#line hidden
#line 4 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bd1acf3bab340883e73c30d7c18ae3ee0b2f7a3", @"/Views/Blog/blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efbf224aa2ee02a8826725f9c85bf22ab762456e", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListBlogViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Blog\blog.cshtml"
  
    ViewData["Title"] = "blog";

#line default
#line hidden
            BeginContext(66, 535, true);
            WriteLiteral(@"<div class=""breadcrumb_container"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <nav>
                    <ul>
                        <li>
                            <a href=""/"">Trang chủ ></a>
                        </li>
                        <li>Bài viết</li>
                    </ul>
                </nav>
            </div>
        </div>
    </div>
</div>
<div class=""blog_list_area"">
    <div class=""container"">
        <div class=""row"">
");
            EndContext();
#line 24 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Blog\blog.cshtml"
             foreach (var item in Model.Data.Results)
            {
                var url= "/"+"blog"+ "-"+item.Id+".html";

#line default
#line hidden
            BeginContext(730, 192, true);
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 col-sm-12\">\r\n                    <div class=\"single_blog_list\">\r\n                        <div class=\"blog__thumb\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 922, "\"", 933, 1);
#line 30 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Blog\blog.cshtml"
WriteAttributeValue("", 929, url, 929, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(934, 5, true);
            WriteLiteral("><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 939, "\"", 956, 1);
#line 30 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Blog\blog.cshtml"
WriteAttributeValue("", 945, item.Image, 945, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(957, 165, true);
            WriteLiteral(" alt=\"\"style=\"height:273px;width:370px\"></a>\r\n                        </div>\r\n                        <div class=\"post__content\">\r\n                            <h3><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1122, "\"", 1133, 1);
#line 33 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Blog\blog.cshtml"
WriteAttributeValue("", 1129, url, 1129, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1134, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1136, 10, false);
#line 33 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Blog\blog.cshtml"
                                          Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1146, 83, true);
            WriteLiteral("</a></h3>\r\n                            <ul>\r\n                                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1229, "\"", 1240, 1);
#line 35 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Blog\blog.cshtml"
WriteAttributeValue("", 1236, url, 1236, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1241, 75, true);
            WriteLiteral(">Read More</a></li>\r\n                                <li class=\"post_date\">");
            EndContext();
            BeginContext(1317, 21, false);
#line 36 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Blog\blog.cshtml"
                                                 Write(item.DateCreated.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1338, 126, true);
            WriteLiteral("</li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 41 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Blog\blog.cshtml"
            }

#line default
#line hidden
            BeginContext(1479, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5141, 58, true);
            WriteLiteral("                <div class=\"col-12\">\r\n                    ");
            EndContext();
            BeginContext(5201, 48, false);
#line 114 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Blog\blog.cshtml"
                Write(await Component.InvokeAsync("Pager", Model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(5250, 60, true);
            WriteLiteral("\r\n                </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListBlogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
