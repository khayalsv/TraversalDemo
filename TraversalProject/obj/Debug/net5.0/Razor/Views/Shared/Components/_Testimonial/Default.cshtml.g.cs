#pragma checksum "C:\Users\selim\Desktop\TraversalDemo\TraversalProject\Views\Shared\Components\_Testimonial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "618e1ce1f3f0eed12eb9a4798d0e72d44750dfc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__Testimonial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_Testimonial/Default.cshtml")]
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
#line 1 "C:\Users\selim\Desktop\TraversalDemo\TraversalProject\Views\_ViewImports.cshtml"
using TraversalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\Desktop\TraversalDemo\TraversalProject\Views\_ViewImports.cshtml"
using TraversalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\selim\Desktop\TraversalDemo\TraversalProject\Views\Shared\Components\_Testimonial\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"618e1ce1f3f0eed12eb9a4798d0e72d44750dfc0", @"/Views/Shared/Components/_Testimonial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f278c2e195091e15ef6b360e804c00589ff5a5c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__Testimonial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""w3l-clients"" id=""clients"">
    <div class=""cusrtomer-layout py-5"">
        <div class=""container py-lg-4 py-md-3 pb-lg-0"">
            <div class=""heading text-center mx-auto"">
                <h6 class=""sub-title text-center"">Musterilerin reyleri</h6>
                <h3 class=""hny-title mb-md-5 mb-4"">Dusunceleriniz bizim ucun qiymetlidir</h3>
            </div>
            <div class=""testimonial-width"">
                <div id=""owl-demo1"" class=""owl-two owl-carousel owl-theme"">
");
#nullable restore
#line 13 "C:\Users\selim\Desktop\TraversalDemo\TraversalProject\Views\Shared\Components\_Testimonial\Default.cshtml"
                    foreach (var item in Model)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""item"">
                        <div class=""testimonial-content"">
                            <div class=""testimonial"">
                                <blockquote>
                                    <span class=""fa fa-quote-left"" aria-hidden=""true""></span>
                                     ");
#nullable restore
#line 20 "C:\Users\selim\Desktop\TraversalDemo\TraversalProject\Views\Shared\Components\_Testimonial\Default.cshtml"
                                Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </blockquote>\r\n                                <div class=\"testi-des\">\r\n                                    <div class=\"test-img\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1194, "\"", 1211, 1);
#nullable restore
#line 24 "C:\Users\selim\Desktop\TraversalDemo\TraversalProject\Views\Shared\Components\_Testimonial\Default.cshtml"
WriteAttributeValue("", 1200, item.Image, 1200, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"client-img\">\r\n                                    </div>\r\n                                    <div class=\"peopl align-self\">\r\n                                        <h3>");
#nullable restore
#line 27 "C:\Users\selim\Desktop\TraversalDemo\TraversalProject\Views\Shared\Components\_Testimonial\Default.cshtml"
                                       Write(item.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                                        <p class=""indentity"">Example City</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 34 "C:\Users\selim\Desktop\TraversalDemo\TraversalProject\Views\Shared\Components\_Testimonial\Default.cshtml"

                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n       \r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonial>> Html { get; private set; }
    }
}
#pragma warning restore 1591
