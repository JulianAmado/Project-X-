<<<<<<< HEAD
#pragma checksum "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Personas\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e25c8b6de62626944a89d7ed91f0982dcfb6f59"
=======
#pragma checksum "C:\Users\anosc\Desktop\Project-X-\FrontEnd\Pages\Personas\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e25c8b6de62626944a89d7ed91f0982dcfb6f59"
>>>>>>> 82a9ab3f4fb866ca7aa16a2681b5088a91e8c379
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FrontEnd.Pages.Personas.Pages_Personas_List), @"mvc.1.0.razor-page", @"/Pages/Personas/List.cshtml")]
namespace FrontEnd.Pages.Personas
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
#line 1 "C:\Users\anosc\Desktop\Project-X-\FrontEnd\Pages\_ViewImports.cshtml"
>>>>>>> 82a9ab3f4fb866ca7aa16a2681b5088a91e8c379
using FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e25c8b6de62626944a89d7ed91f0982dcfb6f59", @"/Pages/Personas/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9f31024f321d31a654453198d9422fbb8d2a0cd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Personas_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1> Lista de Personas </h1>
<table class=""table"">
    <thead class=""thead-light"">
        <tr>
            <th scope=""col"">Id </th>
            <th scope=""col"">Nombre</th>
            <th scope=""col"">Edad</th>
            <th scope=""col"">Documento</th>
            <th scope=""col"">Telefono</th>
        </tr>
    </thead>
");
#nullable restore
<<<<<<< HEAD
#line 16 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Personas\List.cshtml"
=======
#line 16 "C:\Users\anosc\Desktop\Project-X-\FrontEnd\Pages\Personas\List.cshtml"
>>>>>>> 82a9ab3f4fb866ca7aa16a2681b5088a91e8c379
     foreach (var persona in Model.Personas)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
<<<<<<< HEAD
#line 19 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Personas\List.cshtml"
=======
#line 19 "C:\Users\anosc\Desktop\Project-X-\FrontEnd\Pages\Personas\List.cshtml"
>>>>>>> 82a9ab3f4fb866ca7aa16a2681b5088a91e8c379
           Write(persona.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
<<<<<<< HEAD
#line 20 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Personas\List.cshtml"
=======
#line 20 "C:\Users\anosc\Desktop\Project-X-\FrontEnd\Pages\Personas\List.cshtml"
>>>>>>> 82a9ab3f4fb866ca7aa16a2681b5088a91e8c379
           Write(persona.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
<<<<<<< HEAD
#line 21 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Personas\List.cshtml"
=======
#line 21 "C:\Users\anosc\Desktop\Project-X-\FrontEnd\Pages\Personas\List.cshtml"
>>>>>>> 82a9ab3f4fb866ca7aa16a2681b5088a91e8c379
           Write(persona.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
<<<<<<< HEAD
#line 22 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Personas\List.cshtml"
=======
#line 22 "C:\Users\anosc\Desktop\Project-X-\FrontEnd\Pages\Personas\List.cshtml"
>>>>>>> 82a9ab3f4fb866ca7aa16a2681b5088a91e8c379
           Write(persona.Documento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
<<<<<<< HEAD
#line 23 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Personas\List.cshtml"
=======
#line 23 "C:\Users\anosc\Desktop\Project-X-\FrontEnd\Pages\Personas\List.cshtml"
>>>>>>> 82a9ab3f4fb866ca7aa16a2681b5088a91e8c379
           Write(persona.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 25 "C:\Users\fabianandres\Documents\Programacion\Project X\FrontEnd\Pages\Personas\List.cshtml"
=======
#line 25 "C:\Users\anosc\Desktop\Project-X-\FrontEnd\Pages\Personas\List.cshtml"
>>>>>>> 82a9ab3f4fb866ca7aa16a2681b5088a91e8c379
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.ListModel>)PageContext?.ViewData;
        public MyApp.Namespace.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
