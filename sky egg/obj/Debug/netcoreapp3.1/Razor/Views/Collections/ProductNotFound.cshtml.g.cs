#pragma checksum "C:\Users\mbark\OneDrive\Documents\GitHub\sky-egg\sky egg\Views\Collections\ProductNotFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "487a436ceafcd8ddfcb54450ca59f4d48e05adc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Collections_ProductNotFound), @"mvc.1.0.view", @"/Views/Collections/ProductNotFound.cshtml")]
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
#line 1 "C:\Users\mbark\OneDrive\Documents\GitHub\sky-egg\sky egg\Views\_ViewImports.cshtml"
using sky_egg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mbark\OneDrive\Documents\GitHub\sky-egg\sky egg\Views\_ViewImports.cshtml"
using sky_egg.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mbark\OneDrive\Documents\GitHub\sky-egg\sky egg\Views\_ViewImports.cshtml"
using sky_egg.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"487a436ceafcd8ddfcb54450ca59f4d48e05adc6", @"/Views/Collections/ProductNotFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d8893a5e31389f1eafd8a552f037ce9411218a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Collections_ProductNotFound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mbark\OneDrive\Documents\GitHub\sky-egg\sky egg\Views\Collections\ProductNotFound.cshtml"
   
    ViewBag.Title = "Product Not Found";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    We could not found a product with the Id = ");
#nullable restore
#line 6 "C:\Users\mbark\OneDrive\Documents\GitHub\sky-egg\sky egg\Views\Collections\ProductNotFound.cshtml"
                                          Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
