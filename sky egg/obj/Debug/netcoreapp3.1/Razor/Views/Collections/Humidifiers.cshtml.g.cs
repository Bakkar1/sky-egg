#pragma checksum "C:\Users\mbark\OneDrive\Documents\GitHub\sky-egg\sky egg\Views\Collections\Humidifiers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89d5d6cb884dd90adeed673d52612eb975a4ab7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Collections_Humidifiers), @"mvc.1.0.view", @"/Views/Collections/Humidifiers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89d5d6cb884dd90adeed673d52612eb975a4ab7e", @"/Views/Collections/Humidifiers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d8893a5e31389f1eafd8a552f037ce9411218a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Collections_Humidifiers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SkyEggJoinModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Products.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Collections/Index.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mbark\OneDrive\Documents\GitHub\sky-egg\sky egg\Views\Collections\Humidifiers.cshtml"
  
    ViewData["Title"] = "Humidifiers";

#line default
#line hidden
#nullable disable
            DefineSection("productsStyle", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "89d5d6cb884dd90adeed673d52612eb975a4ab7e4806", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "89d5d6cb884dd90adeed673d52612eb975a4ab7e6051", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 9 "C:\Users\mbark\OneDrive\Documents\GitHub\sky-egg\sky egg\Views\Collections\Humidifiers.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <div>
            <h3>Dry Air, Dry Skin, Poor Sleep</h3>
            <p>
                There are many factors that can deter and inhibit your ability to sleep well at night. You may have noise or dust and pollen in the air. Dreamegg has solutions for those problems. However -- many individuals, especially during the wintertime, have a difficult time because of dry air in their room or homes. Some people need humidifiers all year long because of dry skin, but many people realize they need to implement them into their bedroom during the wintertime.

                Dry air can make it miserable to sleep. You can buy a Cool Mist Humidifier from Dreamegg to help alleviate those issues. Dry air can make it difficult to fall asleep because of your throat, nose, or mouth. This is especially common in those who are sick with the annual cold or flu. It is very common for parents to implement a cool-mist humidifier for baby into their child???s bedroom because the size of a baby's throat and the inside o");
            WriteLiteral(@"f their nose makes it especially difficult and painful to fall asleep during the colder months. Purchasing a cool-mist humidifier for baby can help everyone in the household receive more sleep. The baby receives more sleep because their nostrils and throat are clear enough to breathe well and you receive more sleep simply because your baby is receiving more sleep.
            </p>
        </div>
        <div>
            <h3>Multiple Capacity Sizes for Multiple Room Types and Sizes</h3>
            <p>
                Through Dreamegg, you can purchase a high-quality cool-mist humidifier online and have it sent straight to your home to begin using right away. We offer two different cool-mist humidifiers online and in different sizes, one 2 L and one 4.5 L. This way, you have the right size depending on the size of your bedroom or the location you plan to utilize the machines. Each machine is extremely quiet, so it will not add to those other disturbances that make it difficult for you to sleep. They are");
            WriteLiteral(@" simple and easy to refill and clean and come with a safety/timer and automatic off function. No need to worry about the humidifier running when you do not need it to.

                Dry air can make receiving a full, pleasant night's rest nearly impossible. You may need to implement a Dreamegg or buy a cool-mist humidifier into the dry areas of your home can help every single person in your home get the amount of sleep they need and deserve
            </p>
        </div>
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SkyEggJoinModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
