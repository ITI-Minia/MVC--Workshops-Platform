#pragma checksum "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ed4972143131daade6eb061ef6d9e51fb9cada6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkShops_Emergacy), @"mvc.1.0.view", @"/Views/WorkShops/Emergacy.cshtml")]
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
#line 1 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\_ViewImports.cshtml"
using WorkshopPlatform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\_ViewImports.cshtml"
using WorkshopPlatform.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\_ViewImports.cshtml"
using Workshop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ed4972143131daade6eb061ef6d9e51fb9cada6", @"/Views/WorkShops/Emergacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef9b5f32b559d91f5339a2d3b419c1b94e291f40", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkShops_Emergacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Workshop.Models.WorkShop>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchEmergacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("wsbtn btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
  
    ViewData["Title"] = "Emergacy";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-fluid  emergancy workShops \" id=\"workShops\">\r\n    <div class=\"row justify-content-center searchContent mb-4\">\r\n        <div class=\"col-12 col-md-7\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ed4972143131daade6eb061ef6d9e51fb9cada66381", async() => {
                WriteLiteral("\r\n                <div class=\"input-group\">\r\n");
#nullable restore
#line 12 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                     if (ViewBag.searchText != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input asp-action=\"Search\" type=\"search\" id=\"form1\"");
                BeginWriteAttribute("value", " value=\"", 542, "\"", 569, 1);
#nullable restore
#line 14 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
WriteAttributeValue("", 550, ViewBag.searchText, 550, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control searchInput\" placeholder=\"Search\" name=\"search\" />\r\n");
#nullable restore
#line 15 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input asp-action=\"Search\" type=\"search\" id=\"form1\" class=\"form-control searchInput\" placeholder=\"Search\" name=\"search\" />\r\n");
#nullable restore
#line 20 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""input-group-append"">
                        <button type=""submit"" class=""search-btn"">
                            <i class=""fas fa-search""></i>
                        </button>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <h2 class=\"h5 text-gray-600 row container ml-4 mb-4 pl-lg-5\">Nearest WorkShops</h2>\r\n\r\n");
#nullable restore
#line 33 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
      
        int i = 0;
        int j = 0;
        string address;
        int rate = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
         for (i = 0; i < Model.Count(); i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row justify-content-center pl-lg-5 pr-lg-5\">\r\n                <div class=\"col-md-12 WshopTd\">\r\n                    <div class=\'card shadow-sm\'>\r\n");
#nullable restore
#line 43 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                          
                            rate = (int)Model.ElementAt(i).Rate;
                            if (!string.IsNullOrEmpty(Model.ElementAt(i).Address) && Model.ElementAt(i).Address.Length >= 65)
                                address = Model.ElementAt(i).Address.Substring(0, 65) + "...";
                            else
                                address = Model.ElementAt(i).Address;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                         if (Model.ElementAt(i).Logo != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\'logo\'");
            BeginWriteAttribute("style", " style=\"", 2207, "\"", 2281, 4);
            WriteAttributeValue(" ", 2215, "background-image:", 2216, 18, true);
            WriteAttributeValue(" ", 2233, "url(\'/Upload/images/", 2234, 21, true);
#nullable restore
#line 52 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
WriteAttributeValue("", 2254, Model.ElementAt(i).Logo, 2254, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2278, "\');", 2278, 3, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n");
#nullable restore
#line 54 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\'logo\' style=\" background-image: url(\'/imgs/Workshop-logo-default.png\');\">\r\n                            </div>\r\n");
#nullable restore
#line 59 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\'card-text\'>\r\n");
#nullable restore
#line 62 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                             if (@Model.ElementAt(i).Image != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\'portada\'");
            BeginWriteAttribute("style", " style=\"", 2786, "\"", 2859, 4);
            WriteAttributeValue("", 2794, "background-image:", 2794, 17, true);
            WriteAttributeValue(" ", 2811, "url(\'/Upload/images/", 2812, 21, true);
#nullable restore
#line 64 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
WriteAttributeValue("", 2832, Model.ElementAt(i).Image, 2832, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2857, "\')", 2857, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </div>\r\n");
#nullable restore
#line 66 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\'portada\'>\r\n                                </div>\r\n");
#nullable restore
#line 71 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\'title-total\'>\r\n                                <div class=\'title\'>\r\n");
#nullable restore
#line 74 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                                     for (j = 0; j < rate; j++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\'fa fa-star rate\'></i>\r\n");
#nullable restore
#line 77 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                                     if (Model.ElementAt(i).Rate % 1 >= 0.5)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\'fa fa-star-half-alt rate\'></i>\r\n");
#nullable restore
#line 81 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                                        j++;
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                                     for (; j < 5; j++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\'far fa-star rate\'></i>\r\n");
#nullable restore
#line 86 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>

                                <div class='row container justify-content-center'>
                                    <div class='col-12 col-md-6 '>
                                        <div class=""pleft"">
                                            <h2>
                                                ");
#nullable restore
#line 93 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                                           Write(Model.ElementAt(i).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </h2>\r\n");
#nullable restore
#line 95 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                                             if (Model.ElementAt(i).City != null)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\'address\'>\r\n                                                    <i class=\'bi bi-geo-alt-fill icolor\'> </i>\r\n                                                    &nbsp; ");
#nullable restore
#line 99 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                                                      Write(Model.ElementAt(i).City.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("-  ");
#nullable restore
#line 99 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                                                                                      Write(Model.ElementAt(i).City.Government.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ,  ");
#nullable restore
#line 99 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                                                                                                                                  Write(address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </div>\r\n");
#nullable restore
#line 101 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\'phone\'>\r\n                                                <i class=\'fas  fa-mobile-alt icolor\'> </i>\r\n                                                &nbsp; ");
#nullable restore
#line 104 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                                                  Write(Model.ElementAt(i).User.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                    <div class='col-12 col-md-6 rcorner pt-4'>
                                        <div>
                                            <i class='fas  fa-snowplow icolor'> </i>
                                            &nbsp; Winch service
                                        </div>
                                        <div>
                                            <i class='fas  fa-mobile-alt icolor'> </i>
                                            &nbsp;  &nbsp; Urgent <span> immediate </span>maintenance  service
                                        </div>
                                    </div>
                                </div>

                                <div class='actions mt-auto btn'>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ed4972143131daade6eb061ef6d9e51fb9cada621718", async() => {
                WriteLiteral("<div>Show more</div>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
                                                                                WriteLiteral(Model.ElementAt(i).Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <br />\r\n");
#nullable restore
#line 129 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\Emergacy.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Workshop.Models.WorkShop>> Html { get; private set; }
    }
}
#pragma warning restore 1591
