#pragma checksum "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5060a23c56e753199788b4cca1d31a9f23bfdbc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5060a23c56e753199788b4cca1d31a9f23bfdbc0", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efbf224aa2ee02a8826725f9c85bf22ab762456e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VegetableStore.Models.ViewModels.ListProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/client-app/controllers/product/details.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "drop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("this.form.submit()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/products.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
  
    ViewData["Title"] = Model.Data.CurrentPage;
    ViewData["MetaKeyword"] = Model.Data.CurrentPage;
    ViewData["MetaDescription"] = Model.Data.CurrentPage;

#line default
#line hidden
            BeginContext(234, 22, true);
            WriteLiteral("<!-- Breadcrumbs -->\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(273, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(279, 93, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "504d1ada5fec4cb7a8198150fd94b3cd", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 10 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(372, 128, true);
                WriteLiteral("\r\n    <script>\r\n        var ProductDetail = new ProductDetailController();\r\n        ProductDetail.initialize();\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(503, 1289, true);
            WriteLiteral(@"<div class=""breadcrumb_container"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <nav>
                    <ul>
                        <li>
                            <a href=""/"">Trang chủ ></a>
                        </li>
                        <li>Mua sắm</li>
                    </ul>
                </nav>
            </div>
        </div>
    </div>
</div>
<!-- Breadcrumbs End -->
<!-- Main Container -->
<div class=""organic_food_wrapper"">
    <!--- shop_wrapper area  -->
    <div class=""shop_wrapper ptb-90"">
        <div class=""container-fluid"">
            <div class=""row"">

                <div class=""col-lg-12 col-md-12 col-12"">
                    <div class=""categories_banner"">
                        <div class=""categories_banner_inner"">
                            <img src=""assets/img/banner/shop.jpg"" alt="""">
                        </div>
                        <h3></h3>
                    </div>
");
            WriteLiteral(@"                </div>

            </div>
            <div class=""row"">
                <div class=""col-lg-3 col-md-8 col-12"">
                    <div class=""shop_sidebar"">
                        <div class=""block_categories"">
                            ");
            EndContext();
            BeginContext(1793, 43, false);
#line 54 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
                       Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(1836, 1169, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""col-lg-9 col-md-12 col-12"">
                    <div class=""tav_menu_wrapper"">
                        <div class=""row align-items-center"">
                            <div class=""col-lg-6 col-md-7 col-sm-6"">
                                <div class=""tab_menu shop_menu"">
                                    <div class=""tab_menu_inner"">
                                        <ul class=""nav"" role=""tablist"">
                                            <li><a class=""active"" data-toggle=""tab"" href=""#shop_active"" role=""tab"" aria-controls=""shop_active"" aria-selected=""true""><i class=""fa fa-th"" aria-hidden=""true""></i></a></li>

                                            <li><a data-toggle=""tab"" href=""#featured_active"" role=""tab"" aria-controls=""featured_active"" aria-selected=""false""><i class=""fa fa-list"" aria-hidden=""true""></i></a></li>
                                        </ul>
           ");
            WriteLiteral("                         </div>\r\n                                    <div class=\"tab_menu_right\">\r\n                                        <p>Có ");
            EndContext();
            BeginContext(3006, 26, false);
#line 71 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
                                         Write(Model.Data.Results.Count());

#line default
#line hidden
            EndContext();
            BeginContext(3032, 238, true);
            WriteLiteral(" sản phẩm</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-lg-6 col-md-5 col-sm-6\">\r\n                                 ");
            EndContext();
            BeginContext(3270, 515, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c650373eb92484fbf81c18161ba7227", async() => {
                BeginContext(3313, 183, true);
                WriteLiteral("\r\n\r\n                                    <span>Sắp xếp theo :</span>\r\n                                    <div class=\"dropdown dropdown-shop\">\r\n                                        ");
                EndContext();
                BeginContext(3496, 169, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fcb84df464f4dfe90becf260eca70b5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 80 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SortType);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 81 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.SortTypes;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3665, 113, true);
                WriteLiteral("\r\n                                    </div>                                   \r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3785, 341, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""tab_product_wrapper"">
                        <div class=""tab-content"">
                            <div class=""tab-pane fade show active"" id=""shop_active"">
                                <div class=""row"">
");
            EndContext();
#line 91 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
                                     foreach (var item in Model.Data.Results)
                                    {
                                        var url="";
                                        if (item.CategoryId != 7)
                                        {
                                            url = "/" + item.Name + "-" + "p." + item.Id + ".html";
                                        }
                                        else {
                                            url = "/" + item.Name + "-" + "s." + item.Id + ".html";
                                        }



#line default
#line hidden
            BeginContext(4747, 478, true);
            WriteLiteral(@"                                        <div class=""col-xl-3 col-lg-4 col-md-6 col-sm-6"">

                                            <div class=""single__product"">
                                                <div class=""single_product__inner"">
                                                    <span class=""new_badge"">mới</span>
                                                    <div class=""product_img"">
                                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5225, "\"", 5236, 1);
#line 109 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 5232, url, 5232, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5237, 67, true);
            WriteLiteral(">\r\n                                                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5304, "\"", 5321, 1);
#line 110 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 5310, item.Image, 5310, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5322, 511, true);
            WriteLiteral(@" alt=""""style=""height:253.8px;width:253.8px"">
                                                        </a>
                                                    </div>
                                                    <div class=""product__content text-center"">
                                                        <div class=""produc_desc_info"">
                                                            <div class=""product_title"">
                                                                <h4><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5833, "\"", 5844, 1);
#line 116 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 5840, url, 5840, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5845, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(5847, 9, false);
#line 116 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
                                                                              Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(5856, 235, true);
            WriteLiteral("</a></h4>\r\n                                                            </div>\r\n                                                            <div class=\"product_price\">\r\n                                                                <p>");
            EndContext();
            BeginContext(6092, 10, false);
#line 119 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
                                                              Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(6102, 402, true);
            WriteLiteral(@" vnđ</p>
                                                            </div>
                                                        </div>
                                                        <div class=""product__hover"">
                                                            <ul>
                                                                <li><a href=""#"" class=""cart-order"" data-id=""");
            EndContext();
            BeginContext(6505, 7, false);
#line 124 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
                                                                                                       Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(6512, 173, true);
            WriteLiteral("\"><i class=\"ion-android-cart\" title=\"Thêm vào gỏi\"></i></a></li>\r\n                                                                <li><a class=\"cart-fore\" href=\"#\" data-id=\"");
            EndContext();
            BeginContext(6686, 7, false);
#line 125 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
                                                                                                      Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(6693, 177, true);
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#my_modal\" title=\"Xem Nhanh\"><i class=\"ion-android-open\"></i></a></li>\r\n                                                                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6870, "\"", 6881, 1);
#line 126 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 6877, url, 6877, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6882, 10, true);
            WriteLiteral(" data-id=\"");
            EndContext();
            BeginContext(6893, 7, false);
#line 126 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
                                                                                       Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(6900, 413, true);
            WriteLiteral(@"""><i class=""ion-clipboard"" title=""Xem thông tin""></i></a></li>
                                                            </ul>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>

                                        </div>
");
            EndContext();
#line 134 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(7352, 170, true);
            WriteLiteral("                                </div>\r\n                            </div>\r\n                            <div class=\"tab-pane fade\" id=\"featured_active\" role=\"tabpanel\">\r\n");
            EndContext();
#line 138 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
                                 foreach (var item in Model.Data.Results)
                                {
                                    var url = "/" + item.Name + "-" + "p." + item.Id + ".html";

#line default
#line hidden
            BeginContext(7729, 637, true);
            WriteLiteral(@"                                    <div class=""tab_product_bottom_wrapper"">
                                        <div class=""row"">
                                            <div class=""col-lg-4 col-md-5 col-sm-5"">
                                                <div class=""single_product__inner inner_shop"">
                                                    <span class=""new_badge"">new</span>
                                                    <span class=""discount_price"">-5%</span>
                                                    <div class=""product_img"">
                                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 8366, "\"", 8377, 1);
#line 148 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 8373, url, 8373, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8378, 67, true);
            WriteLiteral(">\r\n                                                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 8445, "\"", 8462, 1);
#line 149 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 8451, item.Image, 8451, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8463, 700, true);
            WriteLiteral(@" alt=""""style=""height:253.8px;width:253.8px"">
                                                        </a>
                                                    </div>

                                                </div>
                                            </div>
                                            <div class=""col-lg-8 col-md-7 col-sm-7"">
                                                <div class=""product__content text-left"">
                                                    <div class=""produc_desc_info"">
                                                        <div class=""product_title title_shop"">
                                                            <h4><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 9163, "\"", 9174, 1);
#line 159 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 9170, url, 9170, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9175, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(9177, 9, false);
#line 159 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
                                                                          Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(9186, 236, true);
            WriteLiteral("</a></h4>\r\n                                                        </div>\r\n                                                        <div class=\"product_price price_shop\">\r\n\r\n                                                            <p>");
            EndContext();
            BeginContext(9423, 10, false);
#line 163 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
                                                          Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(9433, 225, true);
            WriteLiteral("</p>\r\n                                                        </div>\r\n                                                        <div class=\"product_content_shop\">\r\n                                                            <p>");
            EndContext();
            BeginContext(9659, 16, false);
#line 166 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
                                                          Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(9675, 745, true);
            WriteLiteral(@"</p>
                                                        </div>
                                                    </div>
                                                    <div class=""product__hover hover_shop"">
                                                        <div class=""product_addto_cart"">
                                                            <button type=""submit"">ADD TO CART</button>
                                                        </div>
                                                        <div class=""product_cart_icone"">
                                                            <ul>
                                                                <li><a href=""#"" class=""cart-order"" data-id=""");
            EndContext();
            BeginContext(10421, 7, false);
#line 175 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
                                                                                                       Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(10428, 173, true);
            WriteLiteral("\"><i class=\"ion-android-cart\" title=\"Thêm vào gỏi\"></i></a></li>\r\n                                                                <li><a class=\"cart-fore\" href=\"#\" data-id=\"");
            EndContext();
            BeginContext(10602, 7, false);
#line 176 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
                                                                                                      Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(10609, 177, true);
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#my_modal\" title=\"Xem Nhanh\"><i class=\"ion-android-open\"></i></a></li>\r\n                                                                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 10786, "\"", 10797, 1);
#line 177 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
WriteAttributeValue("", 10793, url, 10793, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10798, 10, true);
            WriteLiteral(" data-id=\"");
            EndContext();
            BeginContext(10809, 7, false);
#line 177 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
                                                                                       Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(10816, 457, true);
            WriteLiteral(@"""><i class=""ion-clipboard"" title=""Xem thông tin""></i></a></li>
                                                            </ul>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>

                                        </div>
                                    </div>
");
            EndContext();
#line 186 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(11308, 116, true);
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                    ");
            EndContext();
            BeginContext(11426, 48, false);
#line 190 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
                Write(await Component.InvokeAsync("Pager", Model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(11475, 84, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(11560, 33, false);
#line 197 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Product\Index.cshtml"
Write(Html.Partial("_modalView.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(11593, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VegetableStore.Models.ViewModels.ListProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591