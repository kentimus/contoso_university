#pragma checksum "C:\Users\kent\source\repos\cu-final\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d56f0f375a7456bc2b7533b8ba1797c0201e1f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\kent\source\repos\cu-final\Views\_ViewImports.cshtml"
using ContosoUniversity;

#line default
#line hidden
#line 2 "C:\Users\kent\source\repos\cu-final\Views\_ViewImports.cshtml"
using ContosoUniversity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d56f0f375a7456bc2b7533b8ba1797c0201e1f3", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd4358eedcd619245030e2e2b4d3f06dd6511943", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContosoUniversity.Models.SchoolViewModels.EnrollmentDateGroup>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(82, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\kent\source\repos\cu-final\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Student Body Statistics";

#line default
#line hidden
            BeginContext(139, 573, true);
            WriteLiteral(@"

    <div class=""row"">
        <div class=""offset-md-4 col-md-8"">
            <div class=""content-block"">
                <h1>Kent Roper University</h1>

                <p>916.505.2110 - rop15001@byui.edu</p>
               

                <h2>Student Body Statistics</h2>

                <table>
                    <tr>
                        <th>
                            Enrollment Date
                        </th>
                        <th>
                            Students
                        </th>
                    </tr>

");
            EndContext();
#line 28 "C:\Users\kent\source\repos\cu-final\Views\Home\About.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(785, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(882, 49, false);
#line 32 "C:\Users\kent\source\repos\cu-final\Views\Home\About.cshtml"
                           Write(Html.DisplayFor(modelItem => item.EnrollmentDate));

#line default
#line hidden
            EndContext();
            BeginContext(931, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1035, 17, false);
#line 35 "C:\Users\kent\source\repos\cu-final\Views\Home\About.cshtml"
                           Write(item.StudentCount);

#line default
#line hidden
            EndContext();
            BeginContext(1052, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 38 "C:\Users\kent\source\repos\cu-final\Views\Home\About.cshtml"
                    }

#line default
#line hidden
            BeginContext(1143, 86, true);
            WriteLiteral("                </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContosoUniversity.Models.SchoolViewModels.EnrollmentDateGroup>> Html { get; private set; }
    }
}
#pragma warning restore 1591