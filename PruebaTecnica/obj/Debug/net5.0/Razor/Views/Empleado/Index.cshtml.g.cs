#pragma checksum "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f107e95fd7bfcf4f9f11504ebae4a19df637a5c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_Index), @"mvc.1.0.view", @"/Views/Empleado/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f107e95fd7bfcf4f9f11504ebae4a19df637a5c6", @"/Views/Empleado/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a34b744f3ad62f6b7bc8573a11f2d93359075252", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleado_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PruebaTecnica.Models.Empleado>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Index.cshtml"
  
    ViewData["Title"] = "Empleados";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>\r\n    ");
#nullable restore
#line 9 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Index.cshtml"
Write(Html.ActionLink("Nuevo", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 21 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.NombreCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 24 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 27 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 30 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 33 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaIngreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 36 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Foto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 41 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NombreCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaIngreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Foto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Index.cshtml"
           Write(Html.ActionLink("Editar", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 64 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Index.cshtml"
           Write(Html.ActionLink("Detalles", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 65 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Index.cshtml"
           Write(Html.ActionLink("Eliminar", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 68 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PruebaTecnica.Models.Empleado>> Html { get; private set; }
    }
}
#pragma warning restore 1591
