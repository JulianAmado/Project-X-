#pragma checksum "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Domiciliarios\DetailDomiciliario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4547d29ddd918c300e3829c34c8e0a0bf65f83ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FrontEnd.Pages.Domiciliarios.Pages_Domiciliarios_DetailDomiciliario), @"mvc.1.0.razor-page", @"/Pages/Domiciliarios/DetailDomiciliario.cshtml")]
namespace FrontEnd.Pages.Domiciliarios
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
#line 1 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\_ViewImports.cshtml"
using FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4547d29ddd918c300e3829c34c8e0a0bf65f83ee", @"/Pages/Domiciliarios/DetailDomiciliario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9f31024f321d31a654453198d9422fbb8d2a0cd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Domiciliarios_DetailDomiciliario : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ListDomiciliarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1> Detalle del Domiciliario </h1>\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 10 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Domiciliarios\DetailDomiciliario.cshtml"
       Write(Html.DisplayNameFor(model => Model.domiciliario.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 13 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Domiciliarios\DetailDomiciliario.cshtml"
       Write(Html.DisplayFor(model => Model.domiciliario.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Domiciliarios\DetailDomiciliario.cshtml"
       Write(Html.DisplayNameFor(model => Model.domiciliario.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Domiciliarios\DetailDomiciliario.cshtml"
       Write(Html.DisplayFor(model => Model.domiciliario.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Domiciliarios\DetailDomiciliario.cshtml"
       Write(Html.DisplayNameFor(model => Model.domiciliario.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Domiciliarios\DetailDomiciliario.cshtml"
       Write(Html.DisplayFor(model => Model.domiciliario.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Domiciliarios\DetailDomiciliario.cshtml"
       Write(Html.DisplayNameFor(model => Model.domiciliario.Documento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Domiciliarios\DetailDomiciliario.cshtml"
       Write(Html.DisplayFor(model => Model.domiciliario.Documento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Domiciliarios\DetailDomiciliario.cshtml"
       Write(Html.DisplayNameFor(model => Model.domiciliario.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Domiciliarios\DetailDomiciliario.cshtml"
       Write(Html.DisplayFor(model => Model.domiciliario.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Domiciliarios\DetailDomiciliario.cshtml"
       Write(Html.DisplayNameFor(model => Model.domiciliario.CorreoElectronico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Domiciliarios\DetailDomiciliario.cshtml"
       Write(Html.DisplayFor(model => Model.domiciliario.CorreoElectronico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Domiciliarios\DetailDomiciliario.cshtml"
       Write(Html.DisplayNameFor(model => Model.domiciliario.Cargo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Domiciliarios\DetailDomiciliario.cshtml"
       Write(Html.DisplayFor(model => Model.domiciliario.Cargo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Domiciliarios\DetailDomiciliario.cshtml"
       Write(Html.DisplayNameFor(model => Model.domiciliario.Horario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Domiciliarios\DetailDomiciliario.cshtml"
       Write(Html.DisplayFor(model => Model.domiciliario.Horario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Domiciliarios\DetailDomiciliario.cshtml"
       Write(Html.DisplayNameFor(model => Model.domiciliario.Sueldo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Domiciliarios\DetailDomiciliario.cshtml"
       Write(Html.DisplayFor(model => Model.domiciliario.Sueldo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n         <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Domiciliarios\DetailDomiciliario.cshtml"
       Write(Html.DisplayNameFor(model => Model.domiciliario.Transporte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Domiciliarios\DetailDomiciliario.cshtml"
       Write(Html.DisplayFor(model => Model.domiciliario.Transporte));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4547d29ddd918c300e3829c34c8e0a0bf65f83ee11053", async() => {
                WriteLiteral(" Regresar ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.DetailDomiciliarioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailDomiciliarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailDomiciliarioModel>)PageContext?.ViewData;
        public MyApp.Namespace.DetailDomiciliarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
