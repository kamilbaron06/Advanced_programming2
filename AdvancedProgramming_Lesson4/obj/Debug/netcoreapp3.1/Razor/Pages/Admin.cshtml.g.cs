#pragma checksum "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c47d3698391ace2a9c270e51436e8fea59c62230"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AdvancedProgramming_Lesson4.Pages.Pages_Admin), @"mvc.1.0.razor-page", @"/Pages/Admin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c47d3698391ace2a9c270e51436e8fea59c62230", @"/Pages/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f52ce38cc33c453919867474514e0cceb946cb0b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\Admin.cshtml"
  
    ViewData["Title"] = "Admin";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\Admin.cshtml"
   if (User.Identity.Name == "admin@email.com")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Users</h1>\r\n");
            WriteLiteral("        <p>\r\n\r\n        </p>\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 18 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\Admin.cshtml"
                   Write(Html.DisplayNameFor(model => model.AspNetUsers[0].UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 21 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\Admin.cshtml"
                   Write(Html.DisplayNameFor(model => model.AspNetUsers[0].Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\Admin.cshtml"
                 foreach (var item in Model.AspNetUsers)
                {

                  

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 33 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\Admin.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 36 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\Admin.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                      \r\n                    </tr>\r\n");
#nullable restore
#line 40 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\Admin.cshtml"
                   
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 44 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\Admin.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\r\n    <h1 class=\"display-4\">Access Denied</h1>\r\n    </div>\r\n");
#nullable restore
#line 50 "C:\Users\kamil\Desktop\Nowa wersja\AdvancedProgramming_Lesson4\AdvancedProgramming_Lesson4\Pages\Admin.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdvancedProgramming_Lesson4.Pages.AdminModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AdvancedProgramming_Lesson4.Pages.AdminModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AdvancedProgramming_Lesson4.Pages.AdminModel>)PageContext?.ViewData;
        public AdvancedProgramming_Lesson4.Pages.AdminModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591