#pragma checksum "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\ServicesPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7536415f9d0e72036d2937dea6bb13958e260891"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkShops_ServicesPartial), @"mvc.1.0.view", @"/Views/WorkShops/ServicesPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7536415f9d0e72036d2937dea6bb13958e260891", @"/Views/WorkShops/ServicesPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d20155237d2441f696b608e058899312afdc569", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkShops_ServicesPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Workshop.Models.Service>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\ServicesPartial.cshtml"
 foreach (var service in Model)
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\ServicesPartial.cshtml"
     if (service.Verified == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row mb-4\">\r\n            <div class=\"card col-12\">\r\n                <div class=\"card-body row\"");
            BeginWriteAttribute("id", " id=\"", 241, "\"", 262, 2);
            WriteAttributeValue("", 246, "card-", 246, 5, true);
#nullable restore
#line 10 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\ServicesPartial.cshtml"
WriteAttributeValue("", 251, service.Id, 251, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:150px\">\r\n                    <div class=\"col-3 h-100\">\r\n");
#nullable restore
#line 12 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\ServicesPartial.cshtml"
                         if (service.Image != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 446, "\"", 481, 2);
            WriteAttributeValue("", 452, "/Upload/images/", 452, 15, true);
#nullable restore
#line 14 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\ServicesPartial.cshtml"
WriteAttributeValue("", 467, service.Image, 467, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"h-100 w-100\">\r\n");
#nullable restore
#line 15 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\ServicesPartial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img src=\"/imgs/car-service.jpg\" class=\"h-100 w-100\">\r\n");
#nullable restore
#line 19 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\ServicesPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"col-9 pl-3 pt-3\">\r\n\r\n                        <span class=\"text-primary h5\">");
#nullable restore
#line 23 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\ServicesPartial.cshtml"
                                                 Write(service.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                        <span class=\"text-muted\">\r\n                            <span class=\"price\">\r\n                                ");
#nullable restore
#line 27 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\ServicesPartial.cshtml"
                           Write(service.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </span><span class=\"small\">EGP</span>\r\n                        </span><br>\r\n\r\n                        <div class=\"mb-3 small desc\"");
            BeginWriteAttribute("id", " id=\"", 1166, "\"", 1182, 1);
#nullable restore
#line 31 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\ServicesPartial.cshtml"
WriteAttributeValue("", 1171, service.Id, 1171, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 32 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\ServicesPartial.cshtml"
                             if (service.Description == null || service.Description.Length <= 170)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\ServicesPartial.cshtml"
                           Write(service.Description);

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\ServicesPartial.cshtml"
                                                    
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\ServicesPartial.cshtml"
                           Write(service.Description.Substring(0, 170));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"points\">...</span>\r\n");
            WriteLiteral("                                <span class=\"moreText\">\r\n                                    ");
#nullable restore
#line 42 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\ServicesPartial.cshtml"
                               Write(service.Description.Substring(170));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n");
            WriteLiteral("                                <button href=\"#\" class=\"pl-2 textButton\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1851, "\"", 1884, 3);
            WriteAttributeValue("", 1861, "toggleText(", 1861, 11, true);
#nullable restore
#line 45 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\ServicesPartial.cshtml"
WriteAttributeValue("", 1872, service.Id, 1872, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1883, ")", 1883, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    Show More\r\n                                </button>\r\n");
#nullable restore
#line 48 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\ServicesPartial.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <div class=""cart-btn float-right"">
                            <button class=""col-6 col-md-1"">
                                <i class=""fa fa-shopping-cart""></i>
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 60 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\ServicesPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "G:\ITI .Net\Projects\Project 5 - MVC\MVC--Workshops-Platform\Workshop\WorkshopPlatform\Views\WorkShops\ServicesPartial.cshtml"
     
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Workshop.Models.Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591
