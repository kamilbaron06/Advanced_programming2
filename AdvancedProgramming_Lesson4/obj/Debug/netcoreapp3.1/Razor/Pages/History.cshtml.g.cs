#pragma checksum "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\History.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f51e0fe55dbb1b5f5a3c78a902a686a78aa1020"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AdvancedProgramming_Lesson4.Pages.Pages_History), @"mvc.1.0.razor-page", @"/Pages/History.cshtml")]
namespace AdvancedProgramming_Lesson4.Pages
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
#line 1 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\_ViewImports.cshtml"
using AdvancedProgramming_Lesson4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\_ViewImports.cshtml"
using AdvancedProgramming_Lesson4.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\History.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\History.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\History.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f51e0fe55dbb1b5f5a3c78a902a686a78aa1020", @"/Pages/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f52ce38cc33c453919867474514e0cceb946cb0b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_History : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\History.cshtml"
  
    ViewData["Title"] = @SharedLocalizer["History"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 14 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\History.cshtml"
Write(SharedLocalizer["History"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\History.cshtml"
           Write(Html.DisplayNameFor(model => model.ChatMessage[0].User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\History.cshtml"
           Write(Html.DisplayNameFor(model => model.ChatMessage[0].Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\History.cshtml"
         foreach (var item in Model.ChatMessage)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\History.cshtml"
             if (item.Logged == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\History.cshtml"
                   Write(Html.DisplayFor(modelItem => item.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\History.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 43 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\History.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\History.cshtml"
             

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdvancedProgramming_Lesson4.Pages.HistoryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AdvancedProgramming_Lesson4.Pages.HistoryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AdvancedProgramming_Lesson4.Pages.HistoryModel>)PageContext?.ViewData;
        public AdvancedProgramming_Lesson4.Pages.HistoryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
