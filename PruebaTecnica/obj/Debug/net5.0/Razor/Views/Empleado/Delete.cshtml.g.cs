#pragma checksum "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac37e115c2813fdb04d8388e07ee67ba6b4847d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_Delete), @"mvc.1.0.view", @"/Views/Empleado/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac37e115c2813fdb04d8388e07ee67ba6b4847d5", @"/Views/Empleado/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a34b744f3ad62f6b7bc8573a11f2d93359075252", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleado_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PruebaTecnica.Models.Empleado>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml"
  
    ViewBag.Title = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Empleado</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 15 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NombreCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 19 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NombreCompleto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 23 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 27 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 31 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 35 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 39 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 43 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 47 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaIngreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 51 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FechaIngreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 55 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdJefe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 59 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdJefe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 63 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 67 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 71 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Foto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 75 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Foto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n");
#nullable restore
#line 80 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml"
     using (Html.BeginForm()) {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-default\" /> |\r\n            ");
#nullable restore
#line 85 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml"
       Write(Html.ActionLink("Volver a la lista", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 87 "C:\Users\Jorge Villanueva\Desktop\PruebaTecnica\PruebaTecnica\Views\Empleado\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
