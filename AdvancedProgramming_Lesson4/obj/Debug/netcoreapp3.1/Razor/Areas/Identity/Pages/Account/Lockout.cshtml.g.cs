#pragma checksum "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\Lockout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af88ce508134087ef46334256804899b025bfa5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Lockout), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Lockout.cshtml")]
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
#line 2 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\Lockout.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\Lockout.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\Lockout.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af88ce508134087ef46334256804899b025bfa5a", @"/Areas/Identity/Pages/Account/Lockout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d86c34102bf816fb19dc5e1bd52650f3e9c7ee6", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"751f5223ec62c075f24bc1de9bab6898ce94ab26", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Lockout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\Lockout.cshtml"
  
    ViewData["Title"] = @SharedLocalizer["Locked out"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header>\r\n    <h1 class=\"text-danger\">");
#nullable restore
#line 14 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\Lockout.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p class=\"text-danger\">");
#nullable restore
#line 15 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Areas\Identity\Pages\Account\Lockout.cshtml"
                      Write(SharedLocalizer["This account has been locked out, please try again later."]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</header>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LockoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LockoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LockoutModel>)PageContext?.ViewData;
        public LockoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591