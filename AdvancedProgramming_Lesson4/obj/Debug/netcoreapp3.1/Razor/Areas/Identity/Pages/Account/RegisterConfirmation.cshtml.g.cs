#pragma checksum "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a01451dd31ebe684b40d5d0d62ce8d4f3216269"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_RegisterConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
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
#line 1 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\_ViewImports.cshtml"
using AdvancedProgramming_Lesson4.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\_ViewImports.cshtml"
using AdvancedProgramming_Lesson4.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using AdvancedProgramming_Lesson4.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a01451dd31ebe684b40d5d0d62ce8d4f3216269", @"/Areas/Identity/Pages/Account/RegisterConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d86c34102bf816fb19dc5e1bd52650f3e9c7ee6", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"751f5223ec62c075f24bc1de9bab6898ce94ab26", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_RegisterConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    ViewData["Title"] = @SharedLocalizer["Register confirmation"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 13 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 14 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
  
    if (@Model.DisplayConfirmAccountLink)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
#nullable restore
#line 18 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
   Write(SharedLocalizer["This app does not currently have a real email sender registered, see"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a href=\"https://aka.ms/aspaccountconf\">\r\n            ");
#nullable restore
#line 19 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
       Write(SharedLocalizer["these docs"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a> ");
#nullable restore
#line 20 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
        Write(SharedLocalizer["for how to configure a real email sender."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 21 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
   Write(SharedLocalizer["Normally this would be emailed:"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a id=\"confirm - link\"");
            BeginWriteAttribute("href", " href=\"", 786, "\"", 820, 1);
#nullable restore
#line 21 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
WriteAttributeValue("", 793, Model.EmailConfirmationUrl, 793, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
                                                                                                                 Write(SharedLocalizer["Click here to confirm your account"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n</p>\r\n");
#nullable restore
#line 23 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    ");
#nullable restore
#line 27 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
Write(SharedLocalizer["Please check your email to confirm your account."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
#nullable restore
#line 29 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\RegisterConfirmation.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer ViewLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<AdvancedProgramming_Lesson4.Resource> SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterConfirmationModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegisterConfirmationModel>)PageContext?.ViewData;
        public RegisterConfirmationModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
