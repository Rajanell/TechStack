#pragma checksum "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Profile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a17bb10e9b5815971ba3865e1850dbcbfd47b53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Index), @"mvc.1.0.view", @"/Views/Profile/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a17bb10e9b5815971ba3865e1850dbcbfd47b53", @"/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5ce5b711f92966d33d950d1629e78f1d1b41ef8", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Rajanell.TechStach.Core.Model.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 5 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Profile\Index.cshtml"
 if (Model.Any())
{
    foreach (var order in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul class=\"list-group\">\r\n            <li class=\"list-group-item active\">\r\n                <i class=\"fa fa-calendar\"></i> ");
#nullable restore
#line 11 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Profile\Index.cshtml"
                                          Write(order.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"pull-right font-weight-light\"> ");
#nullable restore
#line 11 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Profile\Index.cshtml"
                                                                                                  Write(order.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
            </li>
            <li class=""list-group-item"">
                <div class=""row"">
                    <div class=""col-4"">
                        <b>Product Name</b>
                    </div>
                    <div class=""col-2"">
                        <b>Price</b>
                    </div>
                    <div class=""col-2"">
                        <b>Quantity</b>
                    </div>
                    <div class=""col-2"">
                        <b>TotalPrice</b>
                    </div>
                </div>

            </li>
");
#nullable restore
#line 30 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Profile\Index.cshtml"
             foreach (var orderDetail in order.OrderDetails)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-4\">\r\n                            ");
#nullable restore
#line 35 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Profile\Index.cshtml"
                       Write(orderDetail.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-2\">\r\n                            ");
#nullable restore
#line 38 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Profile\Index.cshtml"
                       Write(orderDetail.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-2\">\r\n                            ");
#nullable restore
#line 41 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Profile\Index.cshtml"
                       Write(orderDetail.Quantiry);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-2\">\r\n                            ");
#nullable restore
#line 44 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Profile\Index.cshtml"
                       Write(orderDetail.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                </li>\r\n");
#nullable restore
#line 49 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Profile\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </ul>\r\n");
#nullable restore
#line 52 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Profile\Index.cshtml"
    }

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
            No orders found.
        </div>
    </div>
");
#nullable restore
#line 65 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Profile\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Rajanell.TechStach.Core.Model.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
