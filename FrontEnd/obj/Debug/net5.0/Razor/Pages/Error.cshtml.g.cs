<<<<<<< HEAD
#pragma checksum "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ffacd1099434ca44ac65d6cd23f2ec03eaa373f"
=======
#pragma checksum "C:\Users\Jorge Amado Perdomo\Documents\Julian\U.C (NO SEA SAPO)\Semestre 3\Desarrollo de Software\101310\FrontEnd\Pages\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ffacd1099434ca44ac65d6cd23f2ec03eaa373f"
>>>>>>> 4097a16b05b1ad5a4b6b5b3b36ef60f14b4d682f
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FrontEnd.Pages.Pages_Error), @"mvc.1.0.razor-page", @"/Pages/Error.cshtml")]
namespace FrontEnd.Pages
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
<<<<<<< HEAD
#line 1 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\_ViewImports.cshtml"
=======
#line 1 "C:\Users\Jorge Amado Perdomo\Documents\Julian\U.C (NO SEA SAPO)\Semestre 3\Desarrollo de Software\101310\FrontEnd\Pages\_ViewImports.cshtml"
>>>>>>> 4097a16b05b1ad5a4b6b5b3b36ef60f14b4d682f
using FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ffacd1099434ca44ac65d6cd23f2ec03eaa373f", @"/Pages/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9f31024f321d31a654453198d9422fbb8d2a0cd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Error : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
<<<<<<< HEAD
#line 3 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Error.cshtml"
=======
#line 3 "C:\Users\Jorge Amado Perdomo\Documents\Julian\U.C (NO SEA SAPO)\Semestre 3\Desarrollo de Software\101310\FrontEnd\Pages\Error.cshtml"
>>>>>>> 4097a16b05b1ad5a4b6b5b3b36ef60f14b4d682f
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-danger\">Error.</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n");
#nullable restore
<<<<<<< HEAD
#line 10 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Error.cshtml"
=======
#line 10 "C:\Users\Jorge Amado Perdomo\Documents\Julian\U.C (NO SEA SAPO)\Semestre 3\Desarrollo de Software\101310\FrontEnd\Pages\Error.cshtml"
>>>>>>> 4097a16b05b1ad5a4b6b5b3b36ef60f14b4d682f
 if (Model.ShowRequestId)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
#nullable restore
<<<<<<< HEAD
#line 13 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Error.cshtml"
=======
#line 13 "C:\Users\Jorge Amado Perdomo\Documents\Julian\U.C (NO SEA SAPO)\Semestre 3\Desarrollo de Software\101310\FrontEnd\Pages\Error.cshtml"
>>>>>>> 4097a16b05b1ad5a4b6b5b3b36ef60f14b4d682f
                                      Write(Model.RequestId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</code>\r\n    </p>\r\n");
#nullable restore
<<<<<<< HEAD
#line 15 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Error.cshtml"
=======
#line 15 "C:\Users\Jorge Amado Perdomo\Documents\Julian\U.C (NO SEA SAPO)\Semestre 3\Desarrollo de Software\101310\FrontEnd\Pages\Error.cshtml"
>>>>>>> 4097a16b05b1ad5a4b6b5b3b36ef60f14b4d682f
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to the <strong>Development</strong> environment displays detailed information about the error that occurred.
</p>
<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ErrorModel>)PageContext?.ViewData;
        public ErrorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
