#pragma checksum "C:\Users\SONY\source\repos\FelicanoWeb\FelicanoWeb\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00bc0543ea92fd106b3bde4332089a647e55c5ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\SONY\source\repos\FelicanoWeb\FelicanoWeb\Views\_ViewImports.cshtml"
using feli_website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SONY\source\repos\FelicanoWeb\FelicanoWeb\Views\_ViewImports.cshtml"
using feli_website.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00bc0543ea92fd106b3bde4332089a647e55c5ff", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"913e2f4ad2d070d34d85873f02c42da8e6f9a9bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FelicanoWeb.Models.Contact>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div>
    <section class=""hero-wrap hero-wrap-2"" style=""background-image: url(/images/bg_3.jpg);""
             data-stellar-background-ratio=""0.5"">
        <div class=""overlay""></div>
        <div class=""container"">
            <div class=""row no-gutters slider-text align-items-end justify-content-center"">
                <div class=""col-md-9 ftco-animate text-center mb-4"">
                    <h1 class=""mb-2 bread"">Contact</h1>
                </div>
            </div>
        </div>
    </section>
");
#nullable restore
#line 15 "C:\Users\SONY\source\repos\FelicanoWeb\FelicanoWeb\Views\Contact\Index.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <section class=""ftco-section ftco-no-pt ftco-no-pb contact-section"">
            <div class=""container"">
                <div class=""row d-flex align-items-stretch no-gutters"">
                    <div class=""col-md-6 pt-5 px-2 pb-2 p-md-5 order-md-last"">
                        <h2 class=""h4 mb-2 mb-md-5 font-weight-bold"">Contact Us</h2>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00bc0543ea92fd106b3bde4332089a647e55c5ff5529", async() => {
                WriteLiteral(@"
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control"" placeholder=""Your Name"">
                            </div>
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control"" placeholder=""Your Email"">
                            </div>
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control"" placeholder=""Subject"">
                            </div>
                            <div class=""form-group"">
                                <textarea");
                BeginWriteAttribute("name", " name=\"", 1658, "\"", 1665, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1666, "\"", 1671, 0);
                EndWriteAttribute();
                WriteLiteral(@" cols=""30"" rows=""7"" class=""form-control""
                                          placeholder=""Message""></textarea>
                            </div>
                            <div class=""form-group"">
                                <input type=""submit"" value=""Send Message"" class=""btn btn-primary py-3 px-5"">
                            </div>
                        ");
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
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-6 d-flex align-items-stretch\">\r\n                        <div id=\"map\"></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n");
#nullable restore
#line 47 "C:\Users\SONY\source\repos\FelicanoWeb\FelicanoWeb\Views\Contact\Index.cshtml"
         foreach (var contact in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <section class=""ftco-section contact-section"">
                <div class=""container"">
                    <div class=""row d-flex contact-info"">
                        <div class=""col-md-12 mb-4"">
                            <h2 class=""h4 font-weight-bold"">Contact Information</h2>
                        </div>
                        <div class=""w-100""></div>
                        <div class=""col-md-4 d-flex"">
                            <div class=""dbox"">
                                <p><span>Address:</span>");
#nullable restore
#line 58 "C:\Users\SONY\source\repos\FelicanoWeb\FelicanoWeb\Views\Contact\Index.cshtml"
                                                   Write(contact.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-3 d-flex\">\r\n                            <div class=\"dbox\">\r\n                                <p><span>Phone:</span> <a");
            BeginWriteAttribute("href", " href=\"", 3141, "\"", 3174, 2);
            WriteAttributeValue("", 3148, "tel://", 3148, 6, true);
#nullable restore
#line 63 "C:\Users\SONY\source\repos\FelicanoWeb\FelicanoWeb\Views\Contact\Index.cshtml"
WriteAttributeValue("", 3154, contact.PhoneNumber, 3154, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 63 "C:\Users\SONY\source\repos\FelicanoWeb\FelicanoWeb\Views\Contact\Index.cshtml"
                                                                                       Write(contact.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-3 d-flex\">\r\n                            <div class=\"dbox\">\r\n                                <p><span>Email:</span> <a");
            BeginWriteAttribute("href", " href=\"", 3434, "\"", 3462, 2);
            WriteAttributeValue("", 3441, "mailto:", 3441, 7, true);
#nullable restore
#line 68 "C:\Users\SONY\source\repos\FelicanoWeb\FelicanoWeb\Views\Contact\Index.cshtml"
WriteAttributeValue("", 3448, contact.Email, 3448, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 68 "C:\Users\SONY\source\repos\FelicanoWeb\FelicanoWeb\Views\Contact\Index.cshtml"
                                                                                  Write(contact.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </section>\r\n");
#nullable restore
#line 74 "C:\Users\SONY\source\repos\FelicanoWeb\FelicanoWeb\Views\Contact\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\SONY\source\repos\FelicanoWeb\FelicanoWeb\Views\Contact\Index.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Không tìm thấy trong database!</p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00bc0543ea92fd106b3bde4332089a647e55c5ff12101", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 80 "C:\Users\SONY\source\repos\FelicanoWeb\FelicanoWeb\Views\Contact\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FelicanoWeb.Models.Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
