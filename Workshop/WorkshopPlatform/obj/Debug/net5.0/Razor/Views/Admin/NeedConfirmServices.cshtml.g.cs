#pragma checksum "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Admin\NeedConfirmServices.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cca501008f7effcb3474c47dcf6ceadc73de619"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_NeedConfirmServices), @"mvc.1.0.view", @"/Views/Admin/NeedConfirmServices.cshtml")]
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
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cca501008f7effcb3474c47dcf6ceadc73de619", @"/Views/Admin/NeedConfirmServices.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d20155237d2441f696b608e058899312afdc569", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_NeedConfirmServices : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Workshop.Models.Service>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "WorkShops", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imgs/car-service.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Admin\NeedConfirmServices.cshtml"
  
    Layout = "_Layout2";
    ViewData["Title"] = "Confirm Services";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""dashboard"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""container"">
                <div class=""d-flex justify-content-center custom-alert"">
                    <div class=""d-none alert alert-warning alert-dismissible w-75"" role=""alert"" id=""alert-error"">
                        <div class=""row"">
                            <div class=""col-11"">
                                <i class=""fa fa-exclamation-circle mr-3""></i>
                                Service ""<span id=""s-name""></span>"" confirmed successfully
                            </div>
                            <div class=""col-1"">
                                <button type=""button"" class=""close ml-5"" onclick=""$('#alert-error').fadeOut()"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
             ");
            WriteLiteral(@"   <h1 class=""text-info title-4 text-secondary mb-4"">Service - Need confirmation</h1>
                <div class=""table-responsive table-responsive-data2"">
                    <table class=""table table-data2 dt-responsive nowrap"" id=""table"">
                        <thead>
                            <tr>
                                <th>
                                    <label class=""au-checkbox"">
                                        <input type=""checkbox"">
                                        <span class=""au-checkmark""></span>
                                    </label>
                                </th>
                                <th>Title</th>
                                <th>Workshop</th>
                                <th>Description</th>
                                <th>img</th>
                                <th>Add in</th>
                                <th></th>
                                <th></th>
                            </tr>
              ");
            WriteLiteral("          </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 48 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Admin\NeedConfirmServices.cshtml"
                             foreach (var s in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"tr-shadow\"");
            BeginWriteAttribute("id", " id=\"", 2358, "\"", 2368, 1);
#nullable restore
#line 50 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Admin\NeedConfirmServices.cshtml"
WriteAttributeValue("", 2363, s.Id, 2363, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    <td>
                                        <label class=""au-checkbox"">
                                            <input type=""checkbox"">
                                            <span class=""au-checkmark""></span>
                                        </label>
                                    </td>
                                    <td>
                                        <span class=""block-email"">");
#nullable restore
#line 58 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Admin\NeedConfirmServices.cshtml"
                                                             Write(s.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </td>\r\n                                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cca501008f7effcb3474c47dcf6ceadc73de6199505", async() => {
#nullable restore
#line 60 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Admin\NeedConfirmServices.cshtml"
                                                                                                                    Write(s.WorkShop.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Admin\NeedConfirmServices.cshtml"
                                                                                             WriteLiteral(s.WorkShop.Id);

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
            WriteLiteral("</td>\r\n\r\n                                    <td class=\"desc\">");
#nullable restore
#line 62 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Admin\NeedConfirmServices.cshtml"
                                                Write(s.Description.Substring(0, 20));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</td>\r\n                                    <td>\r\n");
#nullable restore
#line 64 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Admin\NeedConfirmServices.cshtml"
                                         if (@s.Image == null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4cca501008f7effcb3474c47dcf6ceadc73de61913109", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 67 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Admin\NeedConfirmServices.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <img");
            BeginWriteAttribute("src", " src=\"", 3570, "\"", 3599, 2);
            WriteAttributeValue("", 3576, "/Upload/images/", 3576, 15, true);
#nullable restore
#line 70 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Admin\NeedConfirmServices.cshtml"
WriteAttributeValue("", 3591, s.Image, 3591, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\">\r\n");
#nullable restore
#line 71 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Admin\NeedConfirmServices.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n                                    <td>");
#nullable restore
#line 73 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Admin\NeedConfirmServices.cshtml"
                                   Write(s.AddedIn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <button class=\"btn btn-secondary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3884, "\"", 3908, 3);
            WriteAttributeValue("", 3894, "confirm(", 3894, 8, true);
#nullable restore
#line 75 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Admin\NeedConfirmServices.cshtml"
WriteAttributeValue("", 3902, s.Id, 3902, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3907, ")", 3907, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">verify</button>
                                    </td>
                                    <td>
                                        <div class=""table-data-feature"">
                                            <button class=""item"" data-toggle=""tooltip"" data-placement=""top"" title=""Delete"">
                                                <i class=""mdi mdi-delete"" aria-hidden=""true""></i>
                                            </button>
                                        </div>
                                    </td>
                                </tr>
");
#nullable restore
#line 85 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Admin\NeedConfirmServices.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n            <!-- END DATA TABLE -->\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        $(function () {
            $('[data-toggle=""tooltip""]').tooltip();

            $('#collapse2').addClass('show');
            $('#collapse1').removeClass('show');
        });

        $('#table').dataTable({
        });

        function confirm(id) {
            $.ajax({
                type: ""GET"",
                url: `/Admin/ConfirmService/${id}`,
                contentType: ""application/json; charset=utf-8"",
                dataType: ""html"",
                success: function (response) {
                    $(`#${id}`).remove();

                    $('#alert-error').removeClass('d-none')
                        .addClass(['fade', 'show']).fadeIn();
                    $('#s-name').html(response);
                    let promise1 = (
                        new Promise((resolve, reject) => {
                            setTimeout(() => resolve(""Welcome !!""), 4500);
                        }))
                        .then(() => $('#alert-error').fadeO");
                WriteLiteral(@"ut().addClass('d-none')
                            .removeClass(['fade', 'show']));
                },
                failure: function (response) {
                    alert(response.responseText);
                },
                error: function (response) {
                    alert(response.responseText);
                }
            });
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Workshop.Models.Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591