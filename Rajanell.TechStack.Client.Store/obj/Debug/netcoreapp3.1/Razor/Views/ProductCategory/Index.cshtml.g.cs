#pragma checksum "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\ProductCategory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "344de4338d6d5d46ecb80e5efd9d843aa10b3787"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductCategory_Index), @"mvc.1.0.view", @"/Views/ProductCategory/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"344de4338d6d5d46ecb80e5efd9d843aa10b3787", @"/Views/ProductCategory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5ce5b711f92966d33d950d1629e78f1d1b41ef8", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductCategory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Rajanell.TechStach.Core.Model.ResponseDTO.ProductCategoryResponse>>
    {
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
#line 3 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\ProductCategory\Index.cshtml"
 if (Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul class=\"main-category\">\r\n");
#nullable restore
#line 6 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\ProductCategory\Index.cshtml"
     foreach (var category in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "344de4338d6d5d46ecb80e5efd9d843aa10b37873945", async() => {
#nullable restore
#line 9 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\ProductCategory\Index.cshtml"
                                                                         Write(category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <i class=\"fa fa-angle-right\" aria-hidden=\"true\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 212, "~/Products/Index?categoryId=", 212, 28, true);
#nullable restore
#line 9 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\ProductCategory\Index.cshtml"
AddHtmlAttributeValue("", 240, category.ProductCategoryId, 240, 27, false);

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
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 11 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\ProductCategory\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ul>\r\n");
#nullable restore
#line 14 "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\ProductCategory\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Rajanell.TechStach.Core.Model.ResponseDTO.ProductCategoryResponse>> Html { get; private set; }
    }
}
#pragma warning restore 1591
