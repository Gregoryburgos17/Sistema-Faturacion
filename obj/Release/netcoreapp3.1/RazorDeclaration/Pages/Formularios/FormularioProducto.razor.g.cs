// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Sistema_facturacion.Pages.Formularios
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE VI\II. INTR. A LA ING. DE SOFTWARE\MÓDULO VI - PROYECTO\APP\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE VI\II. INTR. A LA ING. DE SOFTWARE\MÓDULO VI - PROYECTO\APP\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE VI\II. INTR. A LA ING. DE SOFTWARE\MÓDULO VI - PROYECTO\APP\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE VI\II. INTR. A LA ING. DE SOFTWARE\MÓDULO VI - PROYECTO\APP\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE VI\II. INTR. A LA ING. DE SOFTWARE\MÓDULO VI - PROYECTO\APP\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE VI\II. INTR. A LA ING. DE SOFTWARE\MÓDULO VI - PROYECTO\APP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE VI\II. INTR. A LA ING. DE SOFTWARE\MÓDULO VI - PROYECTO\APP\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE VI\II. INTR. A LA ING. DE SOFTWARE\MÓDULO VI - PROYECTO\APP\_Imports.razor"
using Sistema_facturacion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE VI\II. INTR. A LA ING. DE SOFTWARE\MÓDULO VI - PROYECTO\APP\_Imports.razor"
using Sistema_facturacion.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE VI\II. INTR. A LA ING. DE SOFTWARE\MÓDULO VI - PROYECTO\APP\Pages\Formularios\FormularioProducto.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE VI\II. INTR. A LA ING. DE SOFTWARE\MÓDULO VI - PROYECTO\APP\Pages\Formularios\FormularioProducto.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FormularioProducto")]
    public partial class FormularioProducto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE VI\II. INTR. A LA ING. DE SOFTWARE\MÓDULO VI - PROYECTO\APP\Pages\Formularios\FormularioProducto.razor"
       
    private Model model = new Model();
    private EditContext editContext;

    protected override void OnInitialized()
    {
        editContext = new EditContext(model);
    }

    private void HandleValidSubmit()
    {
        var modelJson = JsonSerializer.Serialize(model, new JsonSerializerOptions { WriteIndented = true });
        JSRuntime.InvokeVoidAsync("alert", $"SUCCESS!! :-)\n\n{modelJson}");
    }

    private void HandleReset()
    {
        model = new Model();
        editContext = new EditContext(model);
    }

    private class Model
    {
        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Required]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; }

        [Required]
        [Display(Name = "Precio")]
        public string Precio { get; set; }

        [Required]
        [Display(Name = "Fecha")]
        public DateTime? Fecha { get; set; }

        [Required]
        [Display(Name = "Cantidad")]
        public string Cantidad { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
