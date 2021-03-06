#pragma checksum "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81cddac4dcf1cb341196b461a543588ade590543"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor2.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/_Imports.razor"
using Blazor2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/_Imports.razor"
using Blazor2.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/_Imports.razor"
using Blazor2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/_Imports.razor"
using Blazor2.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/_Imports.razor"
using Blazor2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Shared/MainLayout.razor"
using Blazor2.Services;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Shared/MainLayout.razor"
 if (LoggedIn)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand navbar-dark bg-dark");
            __builder.AddAttribute(2, "b-88tazg0gst");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "navbar-nav");
            __builder.AddAttribute(5, "b-88tazg0gst");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(6);
            __builder.AddAttribute(7, "href", "");
            __builder.AddAttribute(8, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Shared/MainLayout.razor"
                                    NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "class", "nav-item nav-link");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(11, "Home");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(13);
            __builder.AddAttribute(14, "href", "users");
            __builder.AddAttribute(15, "class", "nav-item nav-link");
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(17, "Users");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(19);
            __builder.AddAttribute(20, "href", "account/logout");
            __builder.AddAttribute(21, "class", "nav-item nav-link");
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(23, "Logout");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 16 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Shared/MainLayout.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "app-container" + " " + (
#nullable restore
#line 18 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Shared/MainLayout.razor"
                            LoggedIn ? "bg-light" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "b-88tazg0gst");
            __builder.OpenComponent<Blazor2.Shared.Alert>(27);
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\n    ");
            __builder.AddContent(29, 
#nullable restore
#line 20 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Shared/MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Shared/MainLayout.razor"
       
    public bool LoggedIn 
    {
        get { return AccountService.User != null; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService AccountService { get; set; }
    }
}
#pragma warning restore 1591
