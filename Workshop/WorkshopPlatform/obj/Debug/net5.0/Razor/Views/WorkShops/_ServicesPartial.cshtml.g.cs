#pragma checksum "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "403187e0e1b7556d5bbd411ec4aa03207bceb982"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkShops__ServicesPartial), @"mvc.1.0.view", @"/Views/WorkShops/_ServicesPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"403187e0e1b7556d5bbd411ec4aa03207bceb982", @"/Views/WorkShops/_ServicesPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef9b5f32b559d91f5339a2d3b419c1b94e291f40", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkShops__ServicesPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Workshop.Models.Service>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
  
    var userServices = ((List<UserServices>)ViewBag.UserServices);
    var userService = new UserServices();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row justify-content-center small py-5\" style=\"color:#aaa\">\r\n        There is no services yet\r\n    </div>\r\n");
#nullable restore
#line 12 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
     for (int i = 0; i < Model.Count; i = i + 2)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row mb-4 service-row\">\r\n            <div class=\"col-12 col-md-6 wrapper\">\r\n                <div class=\"container\">\r\n");
#nullable restore
#line 20 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                     if (Model[i].Image != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"top\"");
            BeginWriteAttribute("style", " style=\"", 625, "\"", 688, 4);
            WriteAttributeValue("", 633, "background-image:", 633, 17, true);
            WriteAttributeValue(" ", 650, "url(\'/Upload/images/", 651, 21, true);
#nullable restore
#line 22 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
WriteAttributeValue("", 671, Model[i].Image, 671, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 686, "\')", 686, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 23 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"top\"></div>\r\n");
#nullable restore
#line 27 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"bottom\"");
            BeginWriteAttribute("id", " id=\"", 883, "\"", 900, 1);
#nullable restore
#line 29 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
WriteAttributeValue("", 888, Model[i].Id, 888, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 30 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                          
                            userService = userServices.Where(s => s.ServiceId == Model[i].Id).FirstOrDefault();
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                         if (userService != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"hidden\" class=\"ordered\"");
            BeginWriteAttribute("value", " value=\"", 1214, "\"", 1234, 1);
#nullable restore
#line 35 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
WriteAttributeValue("", 1222, Model[i].Id, 1222, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 36 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row left\">\r\n                            <div class=\"col-8 details\">\r\n                                <h5 class=\"text-primary\">");
#nullable restore
#line 39 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                                                    Write(Model[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"small\">EGP<span>");
#nullable restore
#line 40 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                                                     Write(Model[i].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                            </div>\r\n");
#nullable restore
#line 42 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                             if (User.IsInRole("User"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"col-4 text-center buy\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1725, "\"", 1759, 3);
            WriteAttributeValue("", 1735, "buyClicked(", 1735, 11, true);
#nullable restore
#line 44 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
WriteAttributeValue("", 1746, Model[i].Id, 1746, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1758, ")", 1758, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <i class=\"mdi mdi-cart-plus\" aria-hidden=\"true\"></i>\r\n                                </div>\r\n");
#nullable restore
#line 47 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>

                        <div class=""right d-none"">
                            <div class=""done"">
                                <i class=""mdi mdi-check"" aria-hidden=""true""></i>
                            </div>
                            <div class=""details"">
                                <h5 class=""text-primary"">");
#nullable restore
#line 55 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                                                    Write(Model[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <small>Added to your cart</small>\r\n                            </div>\r\n                            <div class=\"remove\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2456, "\"", 2493, 3);
            WriteAttributeValue("", 2466, "removeClicked(", 2466, 14, true);
#nullable restore
#line 58 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
WriteAttributeValue("", 2480, Model[i].Id, 2480, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2492, ")", 2492, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                <i class=""mdi mdi-close"" aria-hidden=""true""></i>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""inside"">
                    <div class=""icon"">
                        <i class=""mdi mdi-information-outline"" aria-hidden=""true""></i>
                    </div>
                    <div class=""contents"">
                        ");
#nullable restore
#line 69 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                   Write(Model[i].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n");
#nullable restore
#line 74 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
             if (i + 1 < Model.Count && Model[i + 1] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12 col-md-6 wrapper\">\r\n                    <div class=\"container\">\r\n");
#nullable restore
#line 78 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                         if (Model[i + 1].Image != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"top\"");
            BeginWriteAttribute("style", " style=\"", 3365, "\"", 3430, 4);
            WriteAttributeValue("", 3373, "background-image:", 3373, 17, true);
            WriteAttributeValue(" ", 3390, "url(\'/Upload/images/", 3391, 21, true);
#nullable restore
#line 80 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
WriteAttributeValue("", 3411, Model[i+1].Image, 3411, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3428, "\')", 3428, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 81 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"top\"></div>\r\n");
#nullable restore
#line 85 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"bottom\"");
            BeginWriteAttribute("id", " id=\"", 3647, "\"", 3666, 1);
#nullable restore
#line 86 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
WriteAttributeValue("", 3652, Model[i+1].Id, 3652, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 87 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                              
                                userService = userServices.Where(s => s.ServiceId == Model[i + 1].Id).FirstOrDefault();
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                             if (userService != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input type=\"hidden\" class=\"ordered\"");
            BeginWriteAttribute("value", " value=\"", 4008, "\"", 4030, 1);
#nullable restore
#line 92 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
WriteAttributeValue("", 4016, Model[i+1].Id, 4016, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 93 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"row left\">\r\n                                <div class=\"col-8 details\">\r\n                                    <h5 class=\"text-primary\">");
#nullable restore
#line 96 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                                                        Write(Model[i + 1].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <p class=\"small\">EGP<span>");
#nullable restore
#line 97 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                                                         Write(Model[i + 1].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                </div>\r\n");
#nullable restore
#line 99 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                                 if (User.IsInRole("User"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-4 text-center buy\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4565, "\"", 4603, 3);
            WriteAttributeValue("", 4575, "buyClicked(", 4575, 11, true);
#nullable restore
#line 101 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
WriteAttributeValue("", 4586, Model[i + 1].Id, 4586, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4602, ")", 4602, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <i class=\"mdi mdi-cart-plus\" aria-hidden=\"true\"></i>\r\n                                    </div>\r\n");
#nullable restore
#line 104 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                            <div class=""right d-none"">
                                <div class=""done text-center"">
                                    <i class=""mdi mdi-check"" aria-hidden=""true""></i>
                                </div>
                                <div class=""details"">
                                    <h5 class=""text-primary"">");
#nullable restore
#line 111 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                                                        Write(Model[i + 1].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <small>Added to your cart</small>\r\n                                </div>\r\n                                <div class=\"remove text-center\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5378, "\"", 5417, 3);
            WriteAttributeValue("", 5388, "removeClicked(", 5388, 14, true);
#nullable restore
#line 114 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
WriteAttributeValue("", 5402, Model[i+1].Id, 5402, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5416, ")", 5416, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <i class=""mdi mdi-close"" aria-hidden=""true""></i>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""inside"">
                        <div class=""icon"">
                            <i class=""mdi mdi-information-outline"" aria-hidden=""true""></i>
                        </div>
                        <div class=""contents"">
                            ");
#nullable restore
#line 125 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
                       Write(Model[i + 1].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 129 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 131 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
     if (Model.Count > 3)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <nav aria-label=""row Page navigation"">
            <input type=""hidden"" id=""service-index"" value=""2"">
            <ul class=""pagination row justify-content-center"">
                <li class=""page-item"">
                    <button class=""prev"" id=""prev"" onclick=""services(-1)"">
                        <i class=""fa fa-chevron-left""></i>
                    </button>
                </li>
                <li class=""page-item"">
                    <button class=""next"" id=""next"" onclick=""services(1)"">
                        <i class=""fa fa-chevron-right""></i>
                    </button>
                </li>
            </ul>
        </nav>
");
#nullable restore
#line 150 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 150 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\_ServicesPartial.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Workshop.Models.Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591
