#pragma checksum "C:\Users\Hringald\Desktop\Cars\Cars\Cars\Views\Shared\_SlideShowPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af7e3b553dd518a1f6e3ca9571769edeb2fbaf96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SlideShowPartial), @"mvc.1.0.view", @"/Views/Shared/_SlideShowPartial.cshtml")]
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
#line 1 "C:\Users\Hringald\Desktop\Cars\Cars\Cars\Views\_ViewImports.cshtml"
using Cars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hringald\Desktop\Cars\Cars\Cars\Views\_ViewImports.cshtml"
using Cars.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hringald\Desktop\Cars\Cars\Cars\Views\_ViewImports.cshtml"
using Cars.Models.Cars;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af7e3b553dd518a1f6e3ca9571769edeb2fbaf96", @"/Views/Shared/_SlideShowPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b09b58cb68732768f1ec16961771ad5fb12bcaad", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SlideShowPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/slideShow.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/slideShow.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "af7e3b553dd518a1f6e3ca9571769edeb2fbaf964411", async() => {
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
            WriteLiteral(@"
<div class=""w3-content w3-display-container"">
    <img class=""mySlides"" src=""https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/ar019-002gu6dmoqp1ek70otfhg1minfrlqlp-1555940486.jpg?crop=0.973xw:0.893xh;0,0.0255xh&resize=980:*"" style=""width:100%"">
    <img class=""mySlides"" src=""https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/bmw-m240i-xdrive-1548878106.jpg?crop=1.00xw:0.918xh;0,0.0842xh&resize=980:*"" style=""width:100%"">
    <img class=""mySlides"" src=""https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2019-chevrolet-camaro-2ss-10at-104-1544548407.jpg?crop=0.781xw:0.780xh;0.131xw,0.220xh&resize=980:*"" style=""width:100%"">
    <img class=""mySlides"" src=""https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/dg019-252cld542030log8qfi1aglkrd5gcup-1555947016.jpg?crop=1xw:0.9162085623854739xh;center,top&resize=980:*"" style=""width:100%"">
    <img class=""mySlides"" src=""https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/dg019-052chrr36i6jkaku5afkmp187tmhip2-15562204");
            WriteLiteral(@"90.jpg?crop=0.872xw:1.00xh;0.0391xw,0&resize=980:*"" style=""width:100%"">
    <img class=""mySlides"" src=""https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/19mustangecoboostpp1-02-1555947352.jpg?crop=0.808xw:0.887xh;0.150xw,0.113xh&resize=980:*"" style=""width:100%"">
    <img class=""mySlides"" src=""https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/img-1236-1555953308.jpg?crop=1.00xw:0.918xh;0,0.0842xh&resize=980:*"" style=""width:100%"">
    <img class=""mySlides"" src=""https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/img-6151-1555953404.jpg?crop=1.00xw:0.918xh;0,0.0842xh&resize=980:*"" style=""width:100%"">
    <img class=""mySlides"" src=""https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/large-30985-2019velosterr-specturbo-1555953143.jpg?crop=0.929xw:0.852xh;0,0&resize=980:*"" style=""width:100%"">
    <img class=""mySlides"" src=""https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/large-31042-2019velostern-1555953143.jpg?crop=1xw:0.9166666666666666xh;center,top&resize=");
            WriteLiteral(@"980:*"" style=""width:100%"">
    <img class=""mySlides"" src=""https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/jp019-051wr27r1bh8m85k3j35lhg2i0l0kch-1555953558.jpg?crop=1xw:0.9166666666666666xh;center,top&resize=980:*"" style=""width:100%"">
    <img class=""mySlides"" src=""https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/15106-2020-stinger-gts-1555953830.jpg?crop=0.825xw:0.755xh;0.148xw,0.168xh&resize=980:*"" style=""width:100%"">
    <img class=""mySlides"" src=""https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2019-mazda-mx-5-miata-30th-anniversary-104-1549483389.jpg?crop=0.908xw:0.908xh;0.0918xw,0.0919xh&resize=980:*"" style=""width:100%"">
    <img class=""mySlides"" src=""https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2019-nissan-370z-heritage-edition-22-1548865607.jpg?crop=0.974xw:1.00xh;0.0255xw,0.00286xh&resize=980:*"" style=""width:100%"">
    <img class=""mySlides"" src=""https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/9-2019-wrx-premium-1555954321.jpg?crop=");
            WriteLiteral(@"0.656xw:0.540xh;0.0272xw,0.0618xh&resize=980:*"" style=""width:100%"">
    <img class=""mySlides"" src=""https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/5-2019-wrx-sti-1556114877.jpg?crop=0.920xw:0.844xh;0.0799xw,0.0867xh&resize=768:*&keepGifs=1"" style=""width:100%"">
    <img class=""mySlides"" src=""https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2019-toyota-86-trd-special-edition-37-1d54c58de2a151720562c3f0bc51ab6f16eca782-1552656602.jpg?crop=1xw:0.863831788257423xh;center,top&resize=768:*&keepGifs=1"" style=""width:100%"">
    <img class=""mySlides"" src=""https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2020-tacoma-trd-pro-07-a931a5f28df34dc30b46e9cf839d01db1a5d30f2-1553870934.jpg?crop=1.00xw:0.865xh;0,0.113xh&resize=768:*&keepGifs=1"" style=""width:100%"">
    <img class=""mySlides"" src=""https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2019-gti-rabbit-edition-large-9336-1552657111.jpg?crop=1xw:1xh;center,top&resize=768:*&keepGifs=1"" style=""width:100%"">
    <img class=""m");
            WriteLiteral(@"ySlides"" src=""https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/2019-volkswagen-jetta-gli-static-1554925025.jpg?crop=0.940xw:0.942xh;0,0.0585xh&resize=768:*&keepGifs=1"" style=""width:100%"">

    <button class=""w3-button w3-black w3-display-left"" onclick=""plusDivs(-1)"">&#10094;</button>
    <button class=""w3-button w3-black w3-display-right"" onclick=""plusDivs(1)"">&#10095;</button>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af7e3b553dd518a1f6e3ca9571769edeb2fbaf9610282", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591