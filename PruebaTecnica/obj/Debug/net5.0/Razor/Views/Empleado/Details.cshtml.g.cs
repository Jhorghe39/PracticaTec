#pragma checksum "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb8bf280f3e10a6f5497ab9d7ef2ac274d3dce33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_Details), @"mvc.1.0.view", @"/Views/Empleado/Details.cshtml")]
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
#line 1 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\_ViewImports.cshtml"
using PruebaTecnica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\_ViewImports.cshtml"
using PruebaTecnica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb8bf280f3e10a6f5497ab9d7ef2ac274d3dce33", @"/Views/Empleado/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a34b744f3ad62f6b7bc8573a11f2d93359075252", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleado_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PruebaTecnica.Models.Empleado>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Empleado</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 14 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NombreCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 18 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Details.cshtml"
       Write(Html.DisplayFor(model => model.NombreCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 22 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 26 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 30 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 34 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Details.cshtml"
       Write(Html.DisplayFor(model => model.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 38 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 42 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 46 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaIngreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 50 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaIngreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 54 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdJefe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 58 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdJefe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 62 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 66 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 70 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Foto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 74 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Details.cshtml"
       Write(Html.DisplayFor(model => model.Foto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n");
            WriteLiteral("    ");
#nullable restore
#line 81 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Details.cshtml"
Write(Html.ActionLink("Volver a la lista", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PruebaTecnica.Models.Empleado> Html { get; private set; }
    }
}
#pragma warning restore 1591
