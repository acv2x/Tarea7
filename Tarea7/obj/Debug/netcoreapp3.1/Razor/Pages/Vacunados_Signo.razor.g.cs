#pragma checksum "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3f8182d2385507efe8c69892547f797adef7aab"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea7.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\_Imports.razor"
using Tarea7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\_Imports.razor"
using Tarea7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
using Tarea7.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Vacunados_Signo")]
    public partial class Vacunados_Signo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Lista de Vacunados por Signo Zodiacal</h2>\r\n");
            __builder.AddMarkupContent(1, "<p>\r\n    Inserte el Signo Zodiacal de la personas las cuales desea vizualisar \r\n</p>\r\n");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "text");
            __builder.AddAttribute(4, "placeholder", "Signo Zodiacal");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
                                 signo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => signo = __value, signo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
                  Listar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "class", "btn btn-success btn-lg");
            __builder.AddContent(11, "BUSCAR");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n<br>\r\n<br>\r\n");
#nullable restore
#line 19 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
 if (personas == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "    ");
            __builder.AddMarkupContent(14, "<p>Cargando...</p>\r\n");
#nullable restore
#line 22 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "    ");
            __builder.OpenElement(16, "table");
            __builder.AddAttribute(17, "class", "table table-bordered");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.AddMarkupContent(19, @"<thead>
            <tr>
                <th>ID</th>
                <th>Cedula</th>
                <th>Nombre</th>
                <th>Apellido</th>
                <th>Fecha de Nacimiento</th>
                <th>Sizno Zodiacal</th>
                <th>Vacuna Recibida</th>
                <th>Provincia</th>
                <th>Primera Dosis</th>
                <th>Segunda Dosis</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(20, "tbody");
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 41 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
             foreach (var persona in personas)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "                ");
            __builder.OpenElement(23, "tr");
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 44 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
                         persona.ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 45 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
                         persona.Cedula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 46 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
                         persona.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 47 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
                         persona.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 48 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
                         persona.Fecha_Nacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 49 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
                         persona.Signo_Zodiacal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 50 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
                         persona.Vacuna_Recibida

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 51 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
                         persona.Provincia

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 52 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
                         persona.Primera_Dosis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, 
#nullable restore
#line 53 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
                         persona.Segunda_Dosis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 55 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.OpenElement(59, "p");
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.OpenElement(61, "h4");
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.AddContent(63, 
#nullable restore
#line 60 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
             error

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 63 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\Willy Acevedo\Desktop\Programacion_3\Tarea7\Tarea7\Pages\Vacunados_Signo.razor"
       
    string signo, error;
    private IEnumerable<Personas> personas;
    protected async Task Listar()
    {
        try
        {
            personas = await PersonasSercive.GetPersonasSigno(signo);
        }
        catch (Exception e)
        {
            error = e.Message;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonaService PersonasSercive { get; set; }
    }
}
#pragma warning restore 1591
