#pragma checksum "C:\desenvolvimentos\MisterMuscle\Client\Pages\Cliente\CadastroCliente.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a0fbb0e70a1a202740cdead8a1e9a2937206ed5"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591
