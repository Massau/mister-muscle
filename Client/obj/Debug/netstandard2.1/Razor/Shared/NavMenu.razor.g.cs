<<<<<<< HEAD
#pragma checksum "D:\Univem\Navarro\misterMuscle\mister-muscle\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e8cf3eec814779b96ca6fbe45023d29ef80098d"
=======
#pragma checksum "C:\desenvolvimentos\MisterMuscle\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cac91b0155c1c71b4f920267d1b07f3d14bcdd0"
>>>>>>> 6fa5ad33483019e74c9c61b6eb38207db291e9d7
// <auto-generated/>
#pragma warning disable 1591
namespace MisterMuscle.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Univem\Navarro\misterMuscle\mister-muscle\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Univem\Navarro\misterMuscle\mister-muscle\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Univem\Navarro\misterMuscle\mister-muscle\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Univem\Navarro\misterMuscle\mister-muscle\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Univem\Navarro\misterMuscle\mister-muscle\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Univem\Navarro\misterMuscle\mister-muscle\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Univem\Navarro\misterMuscle\mister-muscle\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Univem\Navarro\misterMuscle\mister-muscle\Client\_Imports.razor"
using MisterMuscle.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Univem\Navarro\misterMuscle\mister-muscle\Client\_Imports.razor"
using MisterMuscle.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Univem\Navarro\misterMuscle\mister-muscle\Client\_Imports.razor"
using MisterMuscle.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>MisterMuscle</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "D:\Univem\Navarro\misterMuscle\mister-muscle\Client\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "D:\Univem\Navarro\misterMuscle\mister-muscle\Client\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\Univem\Navarro\misterMuscle\mister-muscle\Client\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "D:\Univem\Navarro\misterMuscle\mister-muscle\Client\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "li");
            __builder.AddAttribute(29, "class", "nav-item px-3");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "class", "nav-link");
            __builder.AddAttribute(33, "href", "/cadastre-se");
            __builder.AddAttribute(34, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 16 "D:\Univem\Navarro\misterMuscle\mister-muscle\Client\Shared\NavMenu.razor"
                                                                 NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(36, "\r\n                <span class=\"oi oi-plus \" aria-hidden=\"true\"></span> Cadastre-se\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "li");
            __builder.AddAttribute(40, "class", "nav-item px-3");
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(42);
            __builder.AddAttribute(43, "class", "nav-link");
<<<<<<< HEAD
            __builder.AddAttribute(44, "href", "/produto");
            __builder.AddAttribute(45, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 21 "D:\Univem\Navarro\misterMuscle\mister-muscle\Client\Shared\NavMenu.razor"
                                                             NavLinkMatch.All
=======
            __builder.AddAttribute(44, "href", "/Login");
            __builder.AddAttribute(45, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 21 "C:\desenvolvimentos\MisterMuscle\Client\Shared\NavMenu.razor"
                                                           NavLinkMatch.All
>>>>>>> 6fa5ad33483019e74c9c61b6eb38207db291e9d7

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
<<<<<<< HEAD
                __builder2.AddMarkupContent(47, "\r\n                <span class=\"oi oi-plus \" aria-hidden=\"true\"></span> Cadastrar Produto\r\n            ");
=======
                __builder2.AddMarkupContent(47, "\r\n                <span class=\"oi oi-plus \" aria-hidden=\"true\"></span> Fazer Login\r\n            ");
>>>>>>> 6fa5ad33483019e74c9c61b6eb38207db291e9d7
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.CloseElement();
<<<<<<< HEAD
            __builder.AddMarkupContent(49, "       \r\n        \r\n    ");
=======
            __builder.AddMarkupContent(49, "\r\n        \r\n        \r\n    ");
>>>>>>> 6fa5ad33483019e74c9c61b6eb38207db291e9d7
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 29 "D:\Univem\Navarro\misterMuscle\mister-muscle\Client\Shared\NavMenu.razor"
=======
#line 30 "C:\desenvolvimentos\MisterMuscle\Client\Shared\NavMenu.razor"
>>>>>>> 6fa5ad33483019e74c9c61b6eb38207db291e9d7
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
