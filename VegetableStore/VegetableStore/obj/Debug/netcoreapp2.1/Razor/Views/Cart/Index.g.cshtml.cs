#pragma checksum "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ee4fefffa9907f26894e07414f236d260e1c688"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ee4fefffa9907f26894e07414f236d260e1c688", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efbf224aa2ee02a8826725f9c85bf22ab762456e", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/client-app/controllers/cart/index.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Cart";

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(59, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(65, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05c399bb4f2c4be68c2eb9bafb6295c3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 6 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Cart\Index.cshtml"
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
                BeginContext(153, 107, true);
                WriteLiteral("\r\n    <script>\r\n        var cartObj = new CartController();\r\n        cartObj.initialize();\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(263, 621, true);
            WriteLiteral(@"<!-- Main Container -->
    <div class=""breadcrumb_container"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-12"">
                    <nav>
                        <ul>
                            <li><a href=""/"">Home ></a></li>
                            <li>Cart</li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>
    </div>
    <div class=""cart_main_area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    ");
            EndContext();
            BeginContext(884, 5449, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ceb0350bf1bf4fefb71e328da79bd018", async() => {
                BeginContext(901, 5425, true);
                WriteLiteral(@"
                        <div class=""table-content table-responsive"">
                            <table>
                                <thead>
                                    <tr>
                                        <th class=""img-thumbnail"">Image</th>
                                        <th class=""product-name"">Product</th>
                                        <th class=""product-price"">Price</th>
                                        <th class=""product-quantity"">Quantity</th>
                                        <th class=""product-subtotal"">Total</th>
                                        <th class=""product-remove"">Remove</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td class=""product-thumbnail""><img src=""assets/img/product/1.jpg"" alt=""""></td>
                                        <td class=""product-name""");
                WriteLiteral(@"><a href=""#"">Vestibulum suscipit</a></td>
                                        <td class=""product-price""><span class=""amount"">£165.00</span></td>
                                        <td class=""product-quantity"">
                                            <div class=""quickview_plus_minus quick_cart"">
                                                <div class=""quickview_plus_minus_inner"">
                                                    <div class=""cart-plus-minus cart_page"">
                                                        <input type=""text"" value=""02"" name=""qtybutton"" class=""cart-plus-minus-box"">
                                                    </div>
                                                </div>
                                            </div>
                                        </td>
                                        <td class=""product-subtotal"">£165.00</td>
                                        <td class=""product-remove""><a href=""#"">X</a></td>
      ");
                WriteLiteral(@"                              </tr>
                                </tbody>
                                <tbody>
                                    <tr>
                                        <td class=""product-thumbnail""><img src=""assets/img/product/4.jpg"" alt=""""></td>
                                        <td class=""product-name""><a href=""#"">Vestibulum dictum magna</a></td>
                                        <td class=""product-price""><span class=""amount"">£165.00</span></td>
                                        <td class=""product-quantity"">
                                            <div class=""quickview_plus_minus quick_cart"">
                                                <div class=""quickview_plus_minus_inner"">
                                                    <div class=""cart-plus-minus cart_page"">
                                                        <input type=""text"" value=""02"" name=""qtybutton"" class=""cart-plus-minus-box"">
                                             ");
                WriteLiteral(@"       </div>
                                                </div>
                                            </div>
                                        </td>
                                        <td class=""product-subtotal"">£165.00</td>
                                        <td class=""product-remove""><a href=""#"">X</a></td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                        <div class=""row table-responsive_bottom"">
                            <div class=""col-lg-7 col-sm-7 col-md-7"">
                                <div class=""buttons-carts"">
                                    <input value=""Update Cart"" type=""submit"">
                                    <a href=""#"">Continue Shopping</a>
                                </div>
                                <div class=""buttons-carts coupon"">
                                    <h3>Coupon</h3>
                ");
                WriteLiteral(@"                    <p>Enter your coupon code if you have one.</p>
                                    <input placeholder=""Coupon code"" type=""text"">
                                    <input value=""Apply Coupon"" type=""submit"">
                                </div>
                            </div>
                            <div class=""col-lg-5 col-sm-5 col-md-5"">
                                <div class=""cart_totals  text-right"">
                                    <h2>Cart Totals</h2>
                                    <div class=""cart-subtotal"">
                                        <span>Subtotal</span>
                                        <span>£215.00</span>
                                    </div>
                                    <div class=""order-total"">
                                        <span><strong>Total</strong> </span>
                                        <span><strong>£215.00 </strong> </span>
                                    </div>
                  ");
                WriteLiteral(@"                  <div class=""wc-proceed-to-checkout"">
                                        <a href=""#"">Proceed to Checkout</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6333, 72, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591