#pragma checksum "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Projeto Integrador\mister-muscle\Client\Pages\Cliente\CadastroCliente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5e190f652549c1071b728d4c1c61570c89823ad"
// <auto-generated/>
#pragma warning disable 1591
namespace MisterMuscle.Client.Pages.Cliente
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Projeto Integrador\mister-muscle\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Projeto Integrador\mister-muscle\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Projeto Integrador\mister-muscle\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Projeto Integrador\mister-muscle\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Projeto Integrador\mister-muscle\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Projeto Integrador\mister-muscle\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Projeto Integrador\mister-muscle\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Projeto Integrador\mister-muscle\Client\_Imports.razor"
using MisterMuscle.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Projeto Integrador\mister-muscle\Client\_Imports.razor"
using MisterMuscle.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Projeto Integrador\mister-muscle\Client\_Imports.razor"
using MisterMuscle.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Cadastre-se")]
    public partial class CadastroCliente : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex justify-content-center");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-6");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<div class=\"card-header\">\r\n                <h4 class=\"card-title mt-2\">Cadastre-se</h4>\r\n            </div>\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Projeto Integrador\mister-muscle\Client\Pages\Cliente\CadastroCliente.razor"
                                  cliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n                    ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-row");
                __builder2.AddMarkupContent(19, "\r\n                        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group col");
                __builder2.AddMarkupContent(22, "\r\n                            ");
                __builder2.AddMarkupContent(23, "<label>Nome Completo</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Projeto Integrador\mister-muscle\Client\Pages\Cliente\CadastroCliente.razor"
                                                    cliente.Nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Nome = __value, cliente.Nome))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Nome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                            ");
                __Blazor.MisterMuscle.Client.Pages.Cliente.CadastroCliente.TypeInference.CreateValidationMessage_0(__builder2, 30, 31, 
#nullable restore
#line 16 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Projeto Integrador\mister-muscle\Client\Pages\Cliente\CadastroCliente.razor"
                                                      () => cliente.Nome

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(32, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\heron\OneDrive\Documentos\Área de Trabalho\Univem\Projeto Integrador\mister-muscle\Client\Pages\Cliente\CadastroCliente.razor"
       
    private Cliente cliente = new Cliente();
    private EditContext editContext { get; set; }

    private void HandleReset()
    {
        cliente = new Cliente();
        editContext = new EditContext(cliente);
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.MisterMuscle.Client.Pages.Cliente.CadastroCliente
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
    }
}
#pragma warning restore 1591
