#pragma checksum "D:\хранилище\SN\SpeechNet\Views\Files\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fa0596e0410be01edd44e77ef1c4ac11b209f5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Files_Index), @"mvc.1.0.view", @"/Views/Files/Index.cshtml")]
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
#line 1 "D:\хранилище\SN\SpeechNet\Views\_ViewImports.cshtml"
using SpeechNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\хранилище\SN\SpeechNet\Views\_ViewImports.cshtml"
using SpeechNet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\хранилище\SN\SpeechNet\Views\_ViewImports.cshtml"
using SpeechNet.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fa0596e0410be01edd44e77ef1c4ac11b209f5d", @"/Views/Files/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"671b813d2dc113d7651f3782577bb6880901bae1", @"/Views/_ViewImports.cshtml")]
    public class Views_Files_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\хранилище\SN\SpeechNet\Views\Files\Index.cshtml"
  
    ViewData["Title"] = "Files Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\хранилище\SN\SpeechNet\Views\Files\Index.cshtml"
 foreach (var item in Model.Files)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"text-center text-light\">");
#nullable restore
#line 8 "D:\хранилище\SN\SpeechNet\Views\Files\Index.cshtml"
                                 Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 9 "D:\хранилище\SN\SpeechNet\Views\Files\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
