#pragma checksum "C:\Users\c822499\source\repos\Rajanell.NetCoreTechStack\Rajanell.TechStack.Client.Store\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44acb37951608e205be7660d481dbecabd843803"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44acb37951608e205be7660d481dbecabd843803", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5ce5b711f92966d33d950d1629e78f1d1b41ef8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("mail/mail.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Start Contact -->
<section id=""contact-us"" class=""contact-us section"">
    <div class=""container"">
        <div class=""contact-head"">
            <div class=""row"">
                <div class=""col-lg-8 col-12"">
                    <div class=""form-main"">
                        <div class=""title"">
                            <h4>Get in touch</h4>
                            <h3>Write us a message</h3>
                        </div>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44acb37951608e205be7660d481dbecabd8438034846", async() => {
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-lg-6 col-12"">
                                    <div class=""form-group"">
                                        <label>Your Name<span>*</span></label>
                                        <input name=""name"" type=""text""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 985, "\"", 999, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""col-lg-6 col-12"">
                                    <div class=""form-group"">
                                        <label>Your Subjects<span>*</span></label>
                                        <input name=""subject"" type=""text""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1369, "\"", 1383, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""col-lg-6 col-12"">
                                    <div class=""form-group"">
                                        <label>Your Email<span>*</span></label>
                                        <input name=""email"" type=""email""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1749, "\"", 1763, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""col-lg-6 col-12"">
                                    <div class=""form-group"">
                                        <label>Your Phone<span>*</span></label>
                                        <input name=""company_name"" type=""text""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2135, "\"", 2149, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </div>
                                </div>
                                <div class=""col-12"">
                                    <div class=""form-group message"">
                                        <label>your message<span>*</span></label>
                                        <textarea name=""message""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2508, "\"", 2522, 0);
                EndWriteAttribute();
                WriteLiteral(@"></textarea>
                                    </div>
                                </div>
                                <div class=""col-12"">
                                    <div class=""form-group button"">
                                        <button type=""submit"" class=""btn "">Send Message</button>
                                    </div>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                <div class=""col-lg-4 col-12"">
                    <div class=""single-head"">
                        <div class=""single-info"">
                            <i class=""fa fa-phone""></i>
                            <h4 class=""title"">Call us Now:</h4>
                            <ul>
                                <li>+123 456-789-1120</li>
                                <li>+522 672-452-1120</li>
                            </ul>
                        </div>
                        <div class=""single-info"">
                            <i class=""fa fa-envelope-open""></i>
                            <h4 class=""title"">Email:</h4>
                            <ul>
                                <li><a href=""mailto:info@yourwebsite.com"">info@yourwebsite.com</a></li>
                                <li><a href=""mailto:info@yourwebsite.com"">support@yourwebsite.com</a></li>
                            </ul>
                        <");
            WriteLiteral(@"/div>
                        <div class=""single-info"">
                            <i class=""fa fa-location-arrow""></i>
                            <h4 class=""title"">Our Address:</h4>
                            <ul>
                                <li>KA-62/1, Travel Agency, 45 Grand Central Terminal, New York.</li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--/ End Contact -->
");
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
