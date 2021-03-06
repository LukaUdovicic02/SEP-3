#pragma checksum "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor3/Shared/LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6a5d3aef67c639e6f8ef5e1d2e8e0e1b4d94949"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor3.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor3/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor3/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor3/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor3/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor3/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor3/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor3/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor3/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor3/_Imports.razor"
using Blazor3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor3/_Imports.razor"
using Blazor3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor3/Shared/LoginDisplay.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor3/Shared/LoginDisplay.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\n        Hello, ");
                __builder2.AddContent(3, 
#nullable restore
#line 9 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor3/Shared/LoginDisplay.razor"
                context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(4, "!\n        ");
                __builder2.OpenElement(5, "button");
                __builder2.AddAttribute(6, "class", "nav-link btn btn-link");
                __builder2.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor3/Shared/LoginDisplay.razor"
                                                        BeginSignOut

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(8, "Log out");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(9, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "<a href=\"authentication/login\">Log in</a>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/Blazor3/Shared/LoginDisplay.razor"
      

    private async Task BeginSignOut(MouseEventArgs args)
    {
        await SignOutManager.SetSignOutState();
        Navigation.NavigateTo("authentication/logout");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignOutSessionStateManager SignOutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
