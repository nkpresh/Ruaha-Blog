#pragma checksum "C:\Users\Precious\source\repos\RuahaBlog\RuahaBlog\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a5ba0166eee68d986382e1e678bf46e4054d4b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\Precious\source\repos\RuahaBlog\RuahaBlog\Views\_ViewImports.cshtml"
using RuahaBlog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Precious\source\repos\RuahaBlog\RuahaBlog\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Precious\source\repos\RuahaBlog\RuahaBlog\Views\_ViewImports.cshtml"
using RuahaBlog.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Precious\source\repos\RuahaBlog\RuahaBlog\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a5ba0166eee68d986382e1e678bf46e4054d4b6", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b45a465570d00e840616e860771ee1b87e976b0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/author-thumb.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("more-links"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("wide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("body-content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Precious\source\repos\RuahaBlog\RuahaBlog\Views\Home\Details.cshtml"
  
    ViewBag.Title = "Ruaha Post";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a5ba0166eee68d986382e1e678bf46e4054d4b67413", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"row justify-content-center m-lg-2\">\r\n            <div class=\"col-sm-12\">\r\n                <div class=\"blog-post\">\r\n                    <div class=\"item-thumbs\">\r\n");
#nullable restore
#line 14 "C:\Users\Precious\source\repos\RuahaBlog\RuahaBlog\Views\Home\Details.cshtml"
                          
                            var photoPath = "/images/" + (Model.BlogPost.PhotoPaths ?? "error/Colorlib.jpg");

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <img");
                BeginWriteAttribute("src", " src=\"", 523, "\"", 539, 1);
#nullable restore
#line 16 "C:\Users\Precious\source\repos\RuahaBlog\RuahaBlog\Views\Home\Details.cshtml"
WriteAttributeValue("", 529, photoPath, 529, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Slider Image\">\r\n");
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"blog-outer\">\r\n                        <div class=\"meta\">\r\n                            <span><a href=\"#\"><i class=\"fa fa-tag\"></i> ");
#nullable restore
#line 23 "C:\Users\Precious\source\repos\RuahaBlog\RuahaBlog\Views\Home\Details.cshtml"
                                                                   Write(Model.BlogPost.Category.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></span>\r\n                            <span class=\"date\">");
#nullable restore
#line 24 "C:\Users\Precious\source\repos\RuahaBlog\RuahaBlog\Views\Home\Details.cshtml"
                                          Write(Model.BlogPost.PostTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            <span><a href=\"#\" data-toggle=\"tooltip\"");
                BeginWriteAttribute("title", " title=\"", 978, "\"", 986, 0);
                EndWriteAttribute();
                WriteLiteral(" data-original-title=\"25\" class=\"like-icons\"><i class=\"fa fa-heart-o\"></i></a></span>\r\n                            <span><a href=\"#\" data-toggle=\"tooltip\"");
                BeginWriteAttribute("title", " title=\"", 1141, "\"", 1149, 0);
                EndWriteAttribute();
                WriteLiteral(" data-original-title=\"12\" class=\"comments-icon\"><i class=\"fa fa-comments-o\"></i></a></span>\r\n                        </div>\r\n                        <h3 class=\"blog-title\">");
#nullable restore
#line 28 "C:\Users\Precious\source\repos\RuahaBlog\RuahaBlog\Views\Home\Details.cshtml"
                                          Write(Model.BlogPost.Headline);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                        <div class=\"admin-text\">\r\n                            <p>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5a5ba0166eee68d986382e1e678bf46e4054d4b610635", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</p>\r\n                            <i>By ");
#nullable restore
#line 31 "C:\Users\Precious\source\repos\RuahaBlog\RuahaBlog\Views\Home\Details.cshtml"
                             Write(Model.BlogPost.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</i>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"blog-text\">\r\n                        ");
#nullable restore
#line 35 "C:\Users\Precious\source\repos\RuahaBlog\RuahaBlog\Views\Home\Details.cshtml"
                   Write(Model.BlogPost.WriteUp);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"blog-bottom\">\r\n                        <div class=\"social-icons pull-left\">\r\n                            <ul>\r\n                                <li><a href=\"#\" data-toggle=\"tooltip\"");
                BeginWriteAttribute("title", " title=\"", 1957, "\"", 1965, 0);
                EndWriteAttribute();
                WriteLiteral(" data-original-title=\"Twitter\"><i class=\"fa fa-twitter\"></i></a></li>\r\n                                <li><a href=\"#\" data-toggle=\"tooltip\"");
                BeginWriteAttribute("title", " title=\"", 2106, "\"", 2114, 0);
                EndWriteAttribute();
                WriteLiteral(" data-original-title=\"Facebook\"><i class=\"fa fa-facebook\"></i></a></li>\r\n                                <li><a href=\"#\" data-toggle=\"tooltip\"");
                BeginWriteAttribute("title", " title=\"", 2257, "\"", 2265, 0);
                EndWriteAttribute();
                WriteLiteral(" data-original-title=\"Pinterest\"><i class=\"fa fa-pinterest\"></i></a></li>\r\n                                <li><a href=\"#\" data-toggle=\"tooltip\"");
                BeginWriteAttribute("title", " title=\"", 2410, "\"", 2418, 0);
                EndWriteAttribute();
                WriteLiteral(" data-original-title=\"Google Plus\"><i class=\"fa fa-google-plus\"></i></a></li>\r\n                            </ul>\r\n                        </div>\r\n                        <div class=\"pull-right\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a5ba0166eee68d986382e1e678bf46e4054d4b614113", async() => {
                    WriteLiteral("Back Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</div>
                        <div class=""clearfix""></div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""panel panel-default widget"">
                        <div class=""panel-heading"">
                            <span class=""comments-icon""></span>
                            <h3 class=""panel-title"">
                                Recent Comments
                            </h3>
                            <span class=""label""></span>
                        </div>
                        <div class=""panel-body"">
                            <ul class=""list-group"">
                                <li class=""list-group-item"">
                                    <div class=""row"">
                                        <div class=""col-xl-2 col-md-1"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a5ba0166eee68d986382e1e678bf46e4054d4b616551", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                        <div class=""col-xs-2 col-md-11"">
                                            <div>
                                                nothing yet
                                            </div>
                                        </div>
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public BlogComments comment { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
