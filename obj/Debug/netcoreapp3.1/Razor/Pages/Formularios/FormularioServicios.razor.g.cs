#pragma checksum "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\Pages\Formularios\FormularioServicios.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71e8221a6f20ebe7e39bc157a24b2b31dc5fc812"
// <auto-generated/>
#pragma warning disable 1591
namespace Sistema_facturacion.Pages.Formularios
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
#nullable restore
#line 2 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\Pages\Formularios\FormularioServicios.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\Pages\Formularios\FormularioServicios.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FormularioServicios")]
    public partial class FormularioServicios : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card m-3");
            __builder.AddMarkupContent(2, "<h4 class=\"card-header\">Servicios</h4>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "EditContext", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Forms.EditContext>(
#nullable restore
#line 9 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\Pages\Formularios\FormularioServicios.razor"
                                editContext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\Pages\Formularios\FormularioServicios.razor"
                                                            HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "onreset", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\Pages\Formularios\FormularioServicios.razor"
                                                                                         HandleReset

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-row");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group col");
                __builder2.AddMarkupContent(16, "<label>Nombre: </label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\Pages\Formularios\FormularioServicios.razor"
                                            model.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Nombre = __value, model.Nombre))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n                    ");
                __Blazor.Sistema_facturacion.Pages.Formularios.FormularioServicios.TypeInference.CreateValidationMessage_0(__builder2, 23, 24, 
#nullable restore
#line 15 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\Pages\Formularios\FormularioServicios.razor"
                                              () => model.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group col");
                __builder2.AddMarkupContent(28, "<label>Descripción: </label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\Pages\Formularios\FormularioServicios.razor"
                                            model.Descripcion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Descripcion = __value, model.Descripcion))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Descripcion));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n                    ");
                __Blazor.Sistema_facturacion.Pages.Formularios.FormularioServicios.TypeInference.CreateValidationMessage_1(__builder2, 35, 36, 
#nullable restore
#line 20 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\Pages\Formularios\FormularioServicios.razor"
                                              () => model.Descripcion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n            ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-row");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group col");
                __builder2.AddMarkupContent(42, "<label>Tipo: </label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(43);
                __builder2.AddAttribute(44, "class", "form-control");
                __builder2.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\Pages\Formularios\FormularioServicios.razor"
                                            model.Tipo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Tipo = __value, model.Tipo))));
                __builder2.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Tipo));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n                    ");
                __Blazor.Sistema_facturacion.Pages.Formularios.FormularioServicios.TypeInference.CreateValidationMessage_2(__builder2, 49, 50, 
#nullable restore
#line 27 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\Pages\Formularios\FormularioServicios.razor"
                                              () => model.Tipo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group col");
                __builder2.AddMarkupContent(54, "<label>Precio: </label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(55);
                __builder2.AddAttribute(56, "type", "password");
                __builder2.AddAttribute(57, "class", "form-control");
                __builder2.AddAttribute(58, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\Pages\Formularios\FormularioServicios.razor"
                                            model.Precio

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Precio = __value, model.Precio))));
                __builder2.AddAttribute(60, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Precio));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n                    ");
                __Blazor.Sistema_facturacion.Pages.Formularios.FormularioServicios.TypeInference.CreateValidationMessage_3(__builder2, 62, 63, 
#nullable restore
#line 32 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\Pages\Formularios\FormularioServicios.razor"
                                              () => model.Precio

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n            ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-row");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "form-group col");
                __builder2.AddMarkupContent(69, "<label>Fecha: </label>\r\n                    ");
                __Blazor.Sistema_facturacion.Pages.Formularios.FormularioServicios.TypeInference.CreateInputDate_4(__builder2, 70, 71, "form-control", 72, 
#nullable restore
#line 38 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\Pages\Formularios\FormularioServicios.razor"
                                            model.Fecha

#line default
#line hidden
#nullable disable
                , 73, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Fecha = __value, model.Fecha)), 74, () => model.Fecha);
                __builder2.AddMarkupContent(75, "\r\n                    ");
                __Blazor.Sistema_facturacion.Pages.Formularios.FormularioServicios.TypeInference.CreateValidationMessage_5(__builder2, 76, 77, 
#nullable restore
#line 39 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\Pages\Formularios\FormularioServicios.razor"
                                              () => model.Fecha

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n            ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "text-center");
                __builder2.AddMarkupContent(81, "<button type=\"submit\" class=\"btn btn-primary mr-1\">Guardar</button>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(82);
                __builder2.AddAttribute(83, "class", "nav-link d-inline");
                __builder2.AddAttribute(84, "href", "servicios");
                __builder2.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(86, "<button type=\"reset\" class=\"btn btn-secondary\">Cancelar</button>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\Legnar Acv2\Desktop\Programacion\Sistema-Facturacion\Pages\Formularios\FormularioServicios.razor"
       
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

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
namespace __Blazor.Sistema_facturacion.Pages.Formularios.FormularioServicios
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591