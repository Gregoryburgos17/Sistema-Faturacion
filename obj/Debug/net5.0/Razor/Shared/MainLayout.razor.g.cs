#pragma checksum "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64f02dc2821b8f46a56b6074b344f0f6e3379544"
// <auto-generated/>
#pragma warning disable 1591
namespace Sistema_facturacion.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\_Imports.razor"
using Sistema_facturacion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\_Imports.razor"
using Sistema_facturacion.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.OpenComponent<Sistema_facturacion.Shared.NavMenu>(2);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "main");
            __builder.AddMarkupContent(6, @"<div class=""top-row px-4 navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow""><ul class=""navbar-nav ml-auto""><li class=""nav-item dropdown no-arrow mx-1""><a class=""nav-link dropdown-toggle"" href id=""messagesDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""><i class=""oi oi-bell""></i>
                    
                    <span class=""badge badge-danger badge-counter"">6</span></a></li>

            <li class=""nav-item""><a class=""nav-link"" href>Contactos</a></li>

            <li class=""nav-item dropdown""><a class=""nav-link dropdown-toggle"" data-bs-toggle=""dropdown"" href role=""button"" aria-expanded=""false"">Opciones</a>
                <ul class=""dropdown-menu""><li><a class=""dropdown-item"" href=""#"">Action</a></li>
                    <li><a class=""dropdown-item"" href=""#"">Another action</a></li>
                    <li><a class=""dropdown-item"" href=""#"">Something else here</a></li>
                    <li><hr class=""dropdown-divider""></li>
                    <li><a class=""dropdown-item"" href=""#"">Separated link</a></li></ul></li></ul></div>

    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "content px-4");
            __builder.AddContent(9, 
#nullable restore
#line 42 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591