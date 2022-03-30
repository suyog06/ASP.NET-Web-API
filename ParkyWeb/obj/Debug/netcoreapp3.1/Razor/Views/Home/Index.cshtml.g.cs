#pragma checksum "D:\C# learning\Parky\ParkyWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37910645316cb97247418eef3a5c0cc2788133fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\C# learning\Parky\ParkyWeb\Views\_ViewImports.cshtml"
using ParkyWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C# learning\Parky\ParkyWeb\Views\_ViewImports.cshtml"
using ParkyWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37910645316cb97247418eef3a5c0cc2788133fa", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bcb7748360e1430599a0955dc17d19f99604859", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ParkyWeb.Models.ViewModel.IndexVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"container border-5\">\r\n    <div class=\"row pb-4 backgroundWhite\">\r\n");
#nullable restore
#line 6 "D:\C# learning\Parky\ParkyWeb\Views\Home\Index.cshtml"
         foreach (var nationaPark in Model.NationalParkList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""container backgroundWhite pb-4 border-4"">
                <div class=""card border"">
                    <div class=""card-header bg-dark text-info ml-0 row container"">
                        <div class=""col-12 col-md-6"">
                            <h1 class=""text-warning"">");
#nullable restore
#line 12 "D:\C# learning\Parky\ParkyWeb\Views\Home\Index.cshtml"
                                                Write(nationaPark.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        </div>\r\n                        <div class=\"col-12 col-md-6 text-md-right\">\r\n                            <h1 class=\"text-warning\">State : ");
#nullable restore
#line 15 "D:\C# learning\Parky\ParkyWeb\Views\Home\Index.cshtml"
                                                        Write(nationaPark.State);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div class=""container rounded p-2"">
                            <div class=""row"">
                                <div class=""col-12 col-lg-8"">
                                    <div class=""row"">
                                        <div class=""col-12"">
                                            <h3 style=""color:#bbb9b9"">Established: ");
#nullable restore
#line 24 "D:\C# learning\Parky\ParkyWeb\Views\Home\Index.cshtml"
                                                                              Write(nationaPark.Established.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                        </div>\r\n                                        <div class=\"col-12\">\r\n");
#nullable restore
#line 27 "D:\C# learning\Parky\ParkyWeb\Views\Home\Index.cshtml"
                                             if (Model.TrailList.Where(u => u.NationalParkId == nationaPark.Id).Count() > 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <table class=""table table-striped"" style=""border:1px solid #808080 "">
                                                    <tr class=""table-secondary"">
                                                        <th>
                                                            Trail
                                                        </th>
                                                        <th>Distance</th>
                                                        <th>Elevation Gain</th>
                                                        <th>Difficulty</th>
                                                    </tr>

");
#nullable restore
#line 39 "D:\C# learning\Parky\ParkyWeb\Views\Home\Index.cshtml"
                                                     foreach (var trails in Model.TrailList.Where(u => u.NationalParkId == nationaPark.Id))
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <tr>\r\n                                                            <td>");
#nullable restore
#line 42 "D:\C# learning\Parky\ParkyWeb\Views\Home\Index.cshtml"
                                                           Write(trails.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 43 "D:\C# learning\Parky\ParkyWeb\Views\Home\Index.cshtml"
                                                           Write(trails.Distance);

#line default
#line hidden
#nullable disable
            WriteLiteral(" miles</td>\r\n                                                            <td>");
#nullable restore
#line 44 "D:\C# learning\Parky\ParkyWeb\Views\Home\Index.cshtml"
                                                           Write(trails.Elevation);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ft</td>\r\n                                                            <td>");
#nullable restore
#line 45 "D:\C# learning\Parky\ParkyWeb\Views\Home\Index.cshtml"
                                                           Write(trails.Difficulty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        </tr>\r\n");
#nullable restore
#line 47 "D:\C# learning\Parky\ParkyWeb\Views\Home\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </table>\r\n");
#nullable restore
#line 49 "D:\C# learning\Parky\ParkyWeb\Views\Home\Index.cshtml"
                                            }
                                            else 
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p>No Trails Exists!!</p>\r\n");
#nullable restore
#line 53 "D:\C# learning\Parky\ParkyWeb\Views\Home\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"col-12 col-lg-4 text-center\">\r\n");
#nullable restore
#line 59 "D:\C# learning\Parky\ParkyWeb\Views\Home\Index.cshtml"
                                       
                                        var base64 = Convert.ToBase64String(nationaPark.Picture);
                                        var imgsrc = string.Format("data:image/jpg;base64,{0}", base64);
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <img");
            BeginWriteAttribute("src", " src=\"", 3783, "\"", 3796, 1);
#nullable restore
#line 63 "D:\C# learning\Parky\ParkyWeb\Views\Home\Index.cshtml"
WriteAttributeValue("", 3789, imgsrc, 3789, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top p-2 rounded\" width=\"100\" />\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 70 "D:\C# learning\Parky\ParkyWeb\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ParkyWeb.Models.ViewModel.IndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591