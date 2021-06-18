#pragma checksum "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Products\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6ec775092a0224de1572a268faa4ea584d31704"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Cart), @"mvc.1.0.view", @"/Views/Products/Cart.cshtml")]
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
#line 1 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\_ViewImports.cshtml"
using Rajanell.TechStack.Client.Store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\_ViewImports.cshtml"
using Rajanell.TechStack.Client.Store.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6ec775092a0224de1572a268faa4ea584d31704", @"/Views/Products/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5ce5b711f92966d33d950d1629e78f1d1b41ef8", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rajanell.TechStack.Client.Store.Models.CartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Profile/Checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Products/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Products\Cart.cshtml"
 if (Model.Products != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""shopping-cart section"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <!-- Shopping Summery -->
                    <table class=""table shopping-summery"">
                        <thead>
                            <tr class=""main-hading"">
                                <th>PRODUCT</th>
                                <th>NAME</th>
                                <th class=""text-center"">PRICE</th>
                                <th class=""text-center"">Quantity</th>
                                <th class=""text-center"">TOTAL</th>
                                <th class=""text-center""><i class=""ti-trash remove-icon""></i></th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 22 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Products\Cart.cshtml"
                             foreach (var product in Model.Products)
                            {
                               
                                var imagePath = $"/images/{product.Image}";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"image\" data-title=\"No\"><img");
            BeginWriteAttribute("src", " src=\"", 1261, "\"", 1277, 1);
#nullable restore
#line 27 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Products\Cart.cshtml"
WriteAttributeValue("", 1267, imagePath, 1267, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"#\"> </td>\r\n                                    <td class=\"product-des\" data-title=\"Description\">\r\n                                        <p class=\"product-name\"><a href=\"#\">");
#nullable restore
#line 29 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Products\Cart.cshtml"
                                                                       Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                                        <p class=\"product-des\">");
#nullable restore
#line 30 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Products\Cart.cshtml"
                                                          Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </td>\r\n                                    <td class=\"price\" data-title=\"Price\"><span>$");
#nullable restore
#line 32 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Products\Cart.cshtml"
                                                                           Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></td>\r\n                                    <td class=\"price\" data-title=\"Price\"><span>");
#nullable restore
#line 33 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Products\Cart.cshtml"
                                                                          Write(product.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span></td>\r\n                                    <td class=\"price\" data-title=\"Price\">");
#nullable restore
#line 34 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Products\Cart.cshtml"
                                                                    Write(product.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td class=\"action\" data-title=\"Remove\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6ec775092a0224de1572a268faa4ea584d317048720", async() => {
                WriteLiteral("<i class=\"ti-trash remove-icon\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2017, "~/Products/RemoveFromCart?productId=", 2017, 36, true);
#nullable restore
#line 35 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Products\Cart.cshtml"
AddHtmlAttributeValue("", 2053, product.ProductId, 2053, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 37 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Products\Cart.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </tbody>
                    </table>
                    <!--/ End Shopping Summery -->
                </div>
            </div>
            <div class=""row"">
                <div class=""col-12"">
                    <!-- Total Amount -->
                    <div class=""total-amount"">
                        <div class=""row"">
                            <div class=""col-lg-6 col-md-5 col-12"">
                                <div class=""left"">
              
                                </div>
                            </div>
                            <div class=""col-lg-6 col-md-7 col-12"">
                                <div class=""right"">
                                    <ul>
                                        <li>Cart Subtotal<span>R ");
#nullable restore
#line 58 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Products\Cart.cshtml"
                                                            Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                        <li>Shipping<span>Free</span></li>\r\n                                        <li class=\"last\">You Pay<span>R ");
#nullable restore
#line 60 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Products\Cart.cshtml"
                                                                   Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                    </ul>\r\n                                    <div class=\"button5\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6ec775092a0224de1572a268faa4ea584d3170412440", async() => {
                WriteLiteral("Checkout");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6ec775092a0224de1572a268faa4ea584d3170413641", async() => {
                WriteLiteral("Continue shopping");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!--/ End Total Amount -->
                </div>
            </div>
        </div>
    </div> ");
#nullable restore
#line 74 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Products\Cart.cshtml"
           }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <br />
    <br />
    <div class=""alert alert-primary d-flex align-items-center"" role=""alert"">
        <i class=""fa fa-info-circle"" aria-hidden=""true""></i>
        <div style=""padding-left:50px"">
            Your shopping cart is empty.
        </div>
    </div>
");
#nullable restore
#line 85 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Products\Cart.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rajanell.TechStack.Client.Store.Models.CartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591