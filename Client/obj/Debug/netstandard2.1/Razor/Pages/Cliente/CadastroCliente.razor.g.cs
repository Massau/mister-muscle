#pragma checksum "C:\desenvolvimentos\MisterMuscle\Client\Pages\Cliente\CadastroCliente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a0fbb0e70a1a202740cdead8a1e9a2937206ed5"
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
#line 1 "C:\desenvolvimentos\MisterMuscle\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\desenvolvimentos\MisterMuscle\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\desenvolvimentos\MisterMuscle\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\desenvolvimentos\MisterMuscle\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\desenvolvimentos\MisterMuscle\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\desenvolvimentos\MisterMuscle\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\desenvolvimentos\MisterMuscle\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\desenvolvimentos\MisterMuscle\Client\_Imports.razor"
using MisterMuscle.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\desenvolvimentos\MisterMuscle\Client\_Imports.razor"
using MisterMuscle.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\desenvolvimentos\MisterMuscle\Client\_Imports.razor"
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
            __builder.AddAttribute(7, "class", "card border-secondary");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddMarkupContent(9, "<div class=\"card-header\">\r\n                <h4 class=\"card-title mt-2\">Cadastre-se</h4>\r\n            </div>\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\desenvolvimentos\MisterMuscle\Client\Pages\Cliente\CadastroCliente.razor"
                                  cliente

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onreset", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 11 "C:\desenvolvimentos\MisterMuscle\Client\Pages\Cliente\CadastroCliente.razor"
                                                     HandleReset

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(17, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(18);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n                    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-row");
                __builder2.AddMarkupContent(22, "\r\n                        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group col");
                __builder2.AddMarkupContent(25, "\r\n                            ");
                __builder2.AddMarkupContent(26, "<label>Nome Completo</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "class", "form-control");
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\desenvolvimentos\MisterMuscle\Client\Pages\Cliente\CadastroCliente.razor"
                                                    cliente.Nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Nome = __value, cliente.Nome))));
                __builder2.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Nome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n                            ");
                __Blazor.MisterMuscle.Client.Pages.Cliente.CadastroCliente.TypeInference.CreateValidationMessage_0(__builder2, 33, 34, 
#nullable restore
#line 17 "C:\desenvolvimentos\MisterMuscle\Client\Pages\Cliente\CadastroCliente.razor"
                                                      () => cliente.Nome

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(35, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                    ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-row");
                __builder2.AddMarkupContent(40, "\r\n                        ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group col");
                __builder2.AddMarkupContent(43, "\r\n                            ");
                __builder2.AddMarkupContent(44, "<label>E-mail</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(45);
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\desenvolvimentos\MisterMuscle\Client\Pages\Cliente\CadastroCliente.razor"
                                                    cliente.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Email = __value, cliente.Email))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n                            ");
                __Blazor.MisterMuscle.Client.Pages.Cliente.CadastroCliente.TypeInference.CreateValidationMessage_1(__builder2, 51, 52, 
#nullable restore
#line 24 "C:\desenvolvimentos\MisterMuscle\Client\Pages\Cliente\CadastroCliente.razor"
                                                      () => cliente.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(53, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                    ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-row");
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group col");
                __builder2.AddMarkupContent(61, "\r\n                            ");
                __builder2.AddMarkupContent(62, "<label>CPF</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(63);
                __builder2.AddAttribute(64, "class", "form-control");
                __builder2.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\desenvolvimentos\MisterMuscle\Client\Pages\Cliente\CadastroCliente.razor"
                                                    cliente.Cpf

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Cpf = __value, cliente.Cpf))));
                __builder2.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Cpf));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n                            ");
                __Blazor.MisterMuscle.Client.Pages.Cliente.CadastroCliente.TypeInference.CreateValidationMessage_2(__builder2, 69, 70, 
#nullable restore
#line 31 "C:\desenvolvimentos\MisterMuscle\Client\Pages\Cliente\CadastroCliente.razor"
                                                      () => cliente.Cpf

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(71, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                    ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "form-row");
                __builder2.AddMarkupContent(76, "\r\n                        ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group col");
                __builder2.AddMarkupContent(79, "\r\n                            ");
                __builder2.AddMarkupContent(80, "<label>Telefone Celular</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(81);
                __builder2.AddAttribute(82, "class", "form-control");
                __builder2.AddAttribute(83, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\desenvolvimentos\MisterMuscle\Client\Pages\Cliente\CadastroCliente.razor"
                                                    cliente.Celular

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(84, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Celular = __value, cliente.Celular))));
                __builder2.AddAttribute(85, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Celular));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\r\n                            ");
                __Blazor.MisterMuscle.Client.Pages.Cliente.CadastroCliente.TypeInference.CreateValidationMessage_3(__builder2, 87, 88, 
#nullable restore
#line 38 "C:\desenvolvimentos\MisterMuscle\Client\Pages\Cliente\CadastroCliente.razor"
                                                      () => cliente.Celular

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(89, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                    ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "form-row");
                __builder2.AddMarkupContent(94, "\r\n                        ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "form-group col");
                __builder2.AddMarkupContent(97, "\r\n                            ");
                __builder2.AddMarkupContent(98, "<label>Senha</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(99);
                __builder2.AddAttribute(100, "type", "password");
                __builder2.AddAttribute(101, "class", "form-control");
                __builder2.AddAttribute(102, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "C:\desenvolvimentos\MisterMuscle\Client\Pages\Cliente\CadastroCliente.razor"
                                                                    cliente.Senha

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(103, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Senha = __value, cliente.Senha))));
                __builder2.AddAttribute(104, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Senha));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(105, "\r\n                            ");
                __Blazor.MisterMuscle.Client.Pages.Cliente.CadastroCliente.TypeInference.CreateValidationMessage_4(__builder2, 106, 107, 
#nullable restore
#line 45 "C:\desenvolvimentos\MisterMuscle\Client\Pages\Cliente\CadastroCliente.razor"
                                                      () => cliente.Senha

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(108, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n                    ");
                __builder2.OpenElement(111, "div");
                __builder2.AddAttribute(112, "class", "form-row");
                __builder2.AddMarkupContent(113, "\r\n                        ");
                __builder2.OpenElement(114, "div");
                __builder2.AddAttribute(115, "class", "form-group col");
                __builder2.AddMarkupContent(116, "\r\n                            ");
                __builder2.AddMarkupContent(117, "<label>Confirme sua Senha</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(118);
                __builder2.AddAttribute(119, "type", "password");
                __builder2.AddAttribute(120, "class", "form-control");
                __builder2.AddAttribute(121, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "C:\desenvolvimentos\MisterMuscle\Client\Pages\Cliente\CadastroCliente.razor"
                                                                    cliente.Confirmarsenha

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(122, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cliente.Confirmarsenha = __value, cliente.Confirmarsenha))));
                __builder2.AddAttribute(123, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cliente.Confirmarsenha));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(124, "\r\n                            ");
                __Blazor.MisterMuscle.Client.Pages.Cliente.CadastroCliente.TypeInference.CreateValidationMessage_5(__builder2, 125, 126, 
#nullable restore
#line 52 "C:\desenvolvimentos\MisterMuscle\Client\Pages\Cliente\CadastroCliente.razor"
                                                      () => cliente.Confirmarsenha

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(127, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n                    ");
                __builder2.AddMarkupContent(130, "<div class=\"text-center\">\r\n                        <button type=\"submit\" class=\"btn btn-primary mr-1\">Enviar</button>\r\n                        <button type=\"reset\" class=\"btn btn-secondary\">Resetar</button>\r\n                    </div>\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(131, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\desenvolvimentos\MisterMuscle\Client\Pages\Cliente\CadastroCliente.razor"
       
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
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
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
