#pragma checksum "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\RequestedServices.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b643fc61d899fd60a3107f0eb6e86b77c852b80c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_RequestedServices), @"mvc.1.0.view", @"/Views/Services/RequestedServices.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b643fc61d899fd60a3107f0eb6e86b77c852b80c", @"/Views/Services/RequestedServices.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d20155237d2441f696b608e058899312afdc569", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_RequestedServices : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WorkshopPlatform.ViewModels.UserServicesViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\RequestedServices.cshtml"
  
    ViewData["Title"] = "RequestedServices";
    Layout = "~/Views/Shared/_Layout1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Page Wrapper -->
<div id=""wrapper"">


    <!-- Content Wrapper -->
    <div id=""content-wrapper"" class=""d-flex flex-column"">

        <!-- Main Content -->
        <div id=""content"">
            <!-- Begin Page Content -->
            <div class=""container-fluid"">
");
#nullable restore
#line 19 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\RequestedServices.cshtml"
                   if (TempData["Done"] != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-primary alert-dismissible\">\r\n                            <button type=\"button\" class=\"close\" data-dismiss=\"alert\">&times;</button>\r\n                            ");
#nullable restore
#line 23 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\RequestedServices.cshtml"
                       Write(TempData["Done"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 25 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\RequestedServices.cshtml"
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <h2> Requested Services </h2><br />
                <!-- DataTales Example -->
                                             <div class=""card shadow mb-4"">

                                                 <div class=""card-body"">
                                                     <div class=""table-responsive"">
                                                         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b643fc61d899fd60a3107f0eb6e86b77c852b80c7192", async() => {
                WriteLiteral(@"

                                                             <table class=""table table-bordered"" id=""mytable"" width=""100%"" cellspacing=""0"">
                                                                 <thead>
                                                                     <tr>
                                                                         <th>Service Title</th>
                                                                         <th>Client User Name</th>
                                                                         <th>Date</th>
                                                                         <th>Finish</th>
                                                                     </tr>
                                                                 </thead>

                                                                 <tbody>
");
#nullable restore
#line 47 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\RequestedServices.cshtml"
                                                                   var i = 0;
                                                                         

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\RequestedServices.cshtml"
                                                                          foreach(var item in Model)
                                                                         {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                             <tr>\r\n                                                                                 <td>\r\n                                                                                     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b643fc61d899fd60a3107f0eb6e86b77c852b80c9393", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                WriteLiteral("data[");
#nullable restore
#line 52 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\RequestedServices.cshtml"
                                                                                            WriteLiteral(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("].Id");
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 52 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\RequestedServices.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\RequestedServices.cshtml"
                                                                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                                                     ");
#nullable restore
#line 53 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\RequestedServices.cshtml"
                                                                                Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                                 </td>
                                                                                 <td>
                                                                                     ");
#nullable restore
#line 56 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\RequestedServices.cshtml"
                                                                                Write(item.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                                 </td>
                                                                                 <td>
                                                                                     ");
#nullable restore
#line 59 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\RequestedServices.cshtml"
                                                                                Write(item.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                                                 </td>

                                                                                 <td>

                                                                                     Finished ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b643fc61d899fd60a3107f0eb6e86b77c852b80c14587", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                WriteLiteral("data[");
#nullable restore
#line 64 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\RequestedServices.cshtml"
                                                                                                                    WriteLiteral(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("].Finished");
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 64 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\RequestedServices.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Finished);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                                                 </td>\r\n\r\n                                                                             </tr>\r\n");
#nullable restore
#line 68 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\RequestedServices.cshtml"
                                                                             i++;
                                                                         }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                                     
                                                                 </tbody>
                                                             </table>
                                                             <div class=""pagination-container"">
                                                                 <nav>
                                                                     <ul class=""pagination""></ul>
                                                                 </nav>
                                                             </div>
                                                             <button formmethod=""post""  type=""submit"" class=""btn btn-primary"" style=""color:white;"">Update</button>
                                          
                                                         ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            WriteLiteral(@"
                                                     </div>
                                                 </div>
                                                 
                                             </div>
               

                <h2> History </h2><br />
                <!-- DataTales Example -->
                <div class=""card shadow mb-4"">

                    <div class=""card-body"">
                        <div class=""table-responsive"">
                                <table class=""table table-bordered"" id=""mytable"" width=""100%"" cellspacing=""0"">
                                    <thead>
                                        <tr>
                                            <th>Service Title</th>
                                            <th>Client User Name</th>
                                            <th>Date</th>

                                        </tr>
                                    </thead>

                                    <tbody>
");
#nullable restore
#line 106 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\RequestedServices.cshtml"
                                         foreach (var item in ViewBag.Historyservices)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 110 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\RequestedServices.cshtml"
                                               Write(item.Service.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 113 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\RequestedServices.cshtml"
                                               Write(item.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 116 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\RequestedServices.cshtml"
                                               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n\r\n\r\n                                            </tr>\r\n");
#nullable restore
#line 121 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\Services\RequestedServices.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tbody>
                                </table>
                            <div class=""pagination-container"">
                                <nav>
                                    <ul class=""pagination""></ul>
                                </nav>
                            </div>
                        </div>
                    </div>
                </div>


            </div>
            <!-- /.container-fluid -->

        </div>
        <!-- End of Main Content -->



    </div>
    <!-- End of Content Wrapper -->

</div>
<!-- End of Page Wrapper -->
<!-- Scroll to Top Button-->
<a class=""scroll-to-top rounded"" href=""#page-top"">
    <i class=""fas fa-angle-up""></i>
</a>



");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
        <script>

            function update(id) {
                //var ide = id;

                $.ajax({
                    type: ""Get"",
                    url: ""/Services/Edit"",
                    data: { id },
                    dataType: ""html"",
                    success: function (res) {
                        //var qqq = $(this).closest('.modal');
                        $(""#myUpdateModal"").html(res);
                        //$("".modal"").modal();
                        $("".updateModal"").modal(""show"");
                    }
                });
            }
           
        </script>
    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WorkshopPlatform.ViewModels.UserServicesViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
