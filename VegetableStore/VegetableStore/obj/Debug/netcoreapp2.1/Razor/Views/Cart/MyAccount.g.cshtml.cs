#pragma checksum "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Cart\MyAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b6e4f1090e6bac8104050123217eb81dc4531c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_MyAccount), @"mvc.1.0.view", @"/Views/Cart/MyAccount.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/MyAccount.cshtml", typeof(AspNetCore.Views_Cart_MyAccount))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b6e4f1090e6bac8104050123217eb81dc4531c9", @"/Views/Cart/MyAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efbf224aa2ee02a8826725f9c85bf22ab762456e", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_MyAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BillViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Cart\MyAccount.cshtml"
  
    var username = UserManager.GetUserName(User).ToString();
    var bills = Model.Where(x => x.CustomerId.ToString() == UserManager.GetUserId(User));
    var user = UserManager.Users.FirstOrDefault(x => x.FullName == username);

#line default
#line hidden
            BeginContext(309, 2567, true);
            WriteLiteral(@"<div class=""breadcrumb_container"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <nav>
                    <ul>
                        <li><a href=""#"">Trang chủ</a> ></li>
                        <li>Tài khoản</li>
                    </ul>
                </nav>
            </div>
        </div>
    </div>
</div>
<section class=""main-content-area my-account ptb-100"">
    <div class=""container"">
        <div class=""account-dashboard"">
            <div class=""row"">
                <div class=""col-sm-12 col-md-3 col-lg-3"">
                    <!-- Nav tabs -->
                    <ul role=""tablist"" class=""nav flex-column dashboard-list"">
                        <li><a href=""#dashboard"" data-toggle=""tab"" class=""nav-link active"">Bảng điều khiển</a></li>
                        <li> <a href=""#orders"" data-toggle=""tab"" class=""nav-link"">Đặt hàng</a></li>
                        <li><a href=""#account-details"" data-toggle=""tab"" clas");
            WriteLiteral(@"s=""nav-link"">Thông tin tài khoản</a></li>
                        <li><a href=""#"" class=""nav-link"" onclick=""logout()"">Đăng xuất</a></li>
                    </ul>
                </div>
                <div class=""col-sm-12 col-md-9 col-lg-9"">
                    <!-- Tab panes -->
                    <div class=""tab-content dashboard-content"">
                        <div class=""tab-pane fade show active"" id=""dashboard"">
                            <h3>Bảng điều khiển </h3>
                            <p>Từ bảng điều khiển tài khoản của bạn. bạn có thể dễ dàng kiểm tra và xem các đơn đặt hàng gần đây, quản lý địa chỉ giao hàng và thanh toán cũng như Chỉnh sửa mật khẩu và chi tiết tài khoản của bạn.</a></p>
                        </div>
                        <div class=""tab-pane fade"" id=""orders"">
                            <h3>Đơn hàng</h3>
                            <div class=""organic-table-area table-responsive"">
                                <table class=""table"">
                   ");
            WriteLiteral(@"                 <thead>
                                        <tr>
                                            <th>ID</th>
                                            <th>Ngày tạo</th>
                                            <th>Trạng thái</th>
                                            <th>Tổng cộng</th>
                                            <th>Hủy</th>
                                        </tr>
                                    </thead>
                                    <tbody>

");
            EndContext();
#line 57 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Cart\MyAccount.cshtml"
                                         foreach (var item in bills)
                                        {

#line default
#line hidden
            BeginContext(2989, 102, true);
            WriteLiteral("                                            <tr>\r\n                                                <td>");
            EndContext();
            BeginContext(3092, 7, false);
#line 60 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Cart\MyAccount.cshtml"
                                               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3099, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(3159, 16, false);
#line 61 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Cart\MyAccount.cshtml"
                                               Write(item.DateCreated);

#line default
#line hidden
            EndContext();
            BeginContext(3175, 81, true);
            WriteLiteral("</td>\r\n                                                <td><span class=\"success\">");
            EndContext();
            BeginContext(3257, 15, false);
#line 62 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Cart\MyAccount.cshtml"
                                                                     Write(item.BillStatus);

#line default
#line hidden
            EndContext();
            BeginContext(3272, 68, true);
            WriteLiteral("</span></td>\r\n                                                <td> $");
            EndContext();
            BeginContext(3341, 62, false);
#line 63 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Cart\MyAccount.cshtml"
                                                 Write(item.BillDetails.Sum(x => x.Quantity * x.Price).ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(3403, 5, true);
            WriteLiteral(" for ");
            EndContext();
            BeginContext(3409, 48, false);
#line 63 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Cart\MyAccount.cshtml"
                                                                                                                     Write(item.BillDetails.Count(x => x.BillId == item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(3457, 93, true);
            WriteLiteral(" items </td>\r\n                                                <td><a  class=\"remove\"data-id=\"");
            EndContext();
            BeginContext(3551, 7, false);
#line 64 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Cart\MyAccount.cshtml"
                                                                          Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3558, 65, true);
            WriteLiteral("\">X</a></td>\r\n                                            </tr>\r\n");
            EndContext();
#line 66 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Cart\MyAccount.cshtml"
                                        }

#line default
#line hidden
            BeginContext(3666, 536, true);
            WriteLiteral(@"

                                    </tbody>
                                </table>
                            </div>
                        </div>                
                        <div class=""tab-pane fade"" id=""account-details"">
                            <h3>Thông tin tài khoản </h3>
                            <div class=""login"">
                                <div class=""login-form-container"">
                                    <div class=""account-login-form"">
                                        ");
            EndContext();
            BeginContext(4202, 1169, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46f0ef054cd445f68efd3e84183653aa", async() => {
                BeginContext(4219, 300, true);
                WriteLiteral(@"
                                            <label>Họ và tên</label>
                                            <input type=""text"" name=""full-name"">
                                            <label>Email</label>
                                            <input type=""text"" name=""email-name""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4519, "\"", 4541, 1);
#line 82 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Cart\MyAccount.cshtml"
WriteAttributeValue("", 4527, user.FullName, 4527, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4542, 507, true);
                WriteLiteral(@">
                                            <label>Ngày sinh</label>
                                            <input type=""text"" placeholder=""MM/DD/YYYY"" value="""" name=""birthday"">
                                            <span class=""example"">
                                                (E.g.: 05/31/1970)
                                            </span>
                                            <label>Địa chỉ</label>
                                            <input type=""text""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5049, "\"", 5070, 1);
#line 89 "C:\Users\pthanhnam\Downloads\VegetableStore (1)\VegetableStore\VegetableStore\Views\Cart\MyAccount.cshtml"
WriteAttributeValue("", 5057, user.Address, 5057, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5071, 293, true);
                WriteLiteral(@" name=""birthday"">
                                            <div class=""order-button"">
                                                <button type=""submit"" class=""button pull-right"">Lưu</button>
                                            </div>
                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5371, 268, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BillViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591