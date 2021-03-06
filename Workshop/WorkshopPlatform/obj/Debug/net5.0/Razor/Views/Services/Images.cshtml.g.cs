#pragma checksum "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\Images.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d6ad2a3b4afc674e3982e3b4e55f2130d28899f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Images), @"mvc.1.0.view", @"/Views/Services/Images.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d6ad2a3b4afc674e3982e3b4e55f2130d28899f", @"/Views/Services/Images.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef9b5f32b559d91f5339a2d3b419c1b94e291f40", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Images : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Workshop.Models.WorkShop>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn delete-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logoForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\Images.cshtml"
  
    var images = Model.Images.ToList();
    ViewData["Title"] = "Images";
    Layout = "~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""wrapper"" class=""workshop--page"">
    <div id=""content-wrapper"" class=""d-flex flex-column"">
        <div id=""gallery"">
            <div class=""container-fluid"">
                <h2 class=""text-muted""> Images </h2>
                <br />
                <div class=""mt-2 mb-3"">
                    <button type=""button"" class=""btn btn-primary text-white"" data-toggle=""modal"" data-target=""#myModal"">
                        <i class=""fa fa-plus-circle""></i> Add image
                    </button>
                </div>
                <div class=""card setting-card"">
                    <div class=""card-body p-5"">
");
#nullable restore
#line 21 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\Images.cshtml"
                         for (int i = 0; i < images.Count; i = i + 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"row mb-5 images-row justify-content-center\">\r\n                                <div class=\"col-12 col-md-6\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d6ad2a3b4afc674e3982e3b4e55f2130d28899f7609", async() => {
                WriteLiteral("\r\n                                        <i class=\"fas fa-trash-alt\"></i>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\Images.cshtml"
                                                                  WriteLiteral(images[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <button class=\"image--btn\" onclick=\"imageModal(this)\" type=\"button\" data-toggle=\"modal\" data-target=\"#imageModal\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d6ad2a3b4afc674e3982e3b4e55f2130d28899f10225", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1486, "~/Upload/images/", 1486, 16, true);
#nullable restore
#line 29 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\Images.cshtml"
AddHtmlAttributeValue("", 1502, images[i].path, 1502, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 29 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\Images.cshtml"
AddHtmlAttributeValue("", 1524, images[i].path, 1524, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1545, "img-", 1545, 4, true);
#nullable restore
#line 29 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\Images.cshtml"
AddHtmlAttributeValue("", 1549, images[i].Id, 1549, 13, false);

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
            WriteLiteral("\r\n                                    </button>\r\n                                </div>\r\n");
#nullable restore
#line 32 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\Images.cshtml"
                                 if (i + 1 < images.Count && images[i + 1] != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-12 col-md-6\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d6ad2a3b4afc674e3982e3b4e55f2130d28899f13366", async() => {
                WriteLiteral("\r\n                                            <i class=\"fas fa-trash-alt\"></i>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\Images.cshtml"
                                                                      WriteLiteral(images[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <button class=\"image--btn\" onclick=\"imageModal(this)\" type=\"button\" data-toggle=\"modal\" data-target=\"#imageModal\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d6ad2a3b4afc674e3982e3b4e55f2130d28899f16003", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2297, "~/Upload/images/", 2297, 16, true);
#nullable restore
#line 39 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\Images.cshtml"
AddHtmlAttributeValue("", 2313, images[i+1].path, 2313, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 39 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\Images.cshtml"
AddHtmlAttributeValue("", 2337, images[i+1].path, 2337, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2360, "img-", 2360, 4, true);
#nullable restore
#line 39 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\Images.cshtml"
AddHtmlAttributeValue("", 2364, images[i+1].Id, 2364, 15, false);

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
            WriteLiteral("\r\n                                        </button>\r\n                                    </div>\r\n");
#nullable restore
#line 42 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\Images.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n");
#nullable restore
#line 44 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\Images.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\Images.cshtml"
                         if (images.Count > 6)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <nav aria-label=""row Page navigation"">
                                <input type=""hidden"" id=""image-index"" value=""3"">
                                <ul class=""pagination row justify-content-center"">
                                    <li class=""page-item"">
                                        <button class=""prev"" id=""prev3"" onclick=""gallery(-1)"">
                                            <i class=""fa fa-chevron-left""></i>
                                        </button>
                                    </li>
                                    <li class=""page-item"">
                                        <button class=""next"" id=""next3"" onclick=""gallery(1)"">
                                            <i class=""fa fa-chevron-right""></i>
                                        </button>
                                    </li>
                                </ul>
                            </nav>
");
#nullable restore
#line 62 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\Images.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""imageModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""imageModalLabel"" aria-hidden=""true"">
    <div class=""row justify-content-center modal-dialog"" role=""document"">
        <div>
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"" style=""float: right;"">
                <span aria-hidden=""true"">&times;</span>
            </button>
            <div class=""modal-body"">
                <img id=""modal-img""");
            BeginWriteAttribute("src", " src=\"", 4235, "\"", 4241, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
        </div>
    </div>
</div>

<div class=""main-modal"">
    <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">
        <div class=""modal-dialog"" role=""dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h6 class=""modal-title"" id=""myModalLabel"">Upload image</h6>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                </div>
                <div class=""modal-body"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d6ad2a3b4afc674e3982e3b4e55f2130d28899f22215", async() => {
                WriteLiteral(@"
                        <div class=""custom-file"">
                            <input type=""file"" class=""custom-file-input"" name=""image"">
                            <label class=""custom-file-label"" for=""image"">Choose file</label>
                        </div>
                        <div class=""modal-footer mt-4"">
                            <button id=""close-modal"" type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">cancel</button>
                            <button type=""submit"" class=""btn btn-primary"" id=""changePhoto"">Save</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            gallery();

            $('.custom-file-input').on(""change"", function () {
                var fileName = $(this).val().split(""\\"").pop();
                $(this).next('.custom-file-label').html(fileName);
                console.log(fileName);
            });
        });

        function imageModal(button) {
            var img = $(button).children()[0];
            $('#modal-img').attr('src', $(img).attr('src'));
        }

        function gallery(next = 0) {
            var index = eval($('#image-index').val());
            var count = eval($('#gallery .images-row').length);
            var images = $('#gallery .images-row');

            if (next == -1) index -= 6;
            else if (next == 0) index = 0;

            if (count > 3) {
                for (i = index + 3; i < count; i++) {
                    $(images[i]).addClass('d-none');
                }
                for (i = 0; i < index; i++) {
    ");
                WriteLiteral(@"                $(images[i]).addClass('d-none');
                }
                for (i = index; i < index + 3; i++) {
                    $(images[i]).removeClass('d-none');
                }
            }

            index += 3;
            $('#image-index').val(index);

            if (index == 3)
                $('#prev3').prop('disabled', true);
            else
                $('#prev3').prop('disabled', false);

            if (index >= count)
                $('#next3').prop('disabled', true);
            else
                $('#next3').prop('disabled', false);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Workshop.Models.WorkShop> Html { get; private set; }
    }
}
#pragma warning restore 1591
