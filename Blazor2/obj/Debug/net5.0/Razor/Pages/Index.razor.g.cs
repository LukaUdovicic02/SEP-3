#pragma checksum "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cf4cd94ee95c0818632475023c916089dd31c80"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor2.Pages
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
#line 2 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Pages/Index.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Pages/Index.razor"
using Blazor2.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Pages/Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "p-4");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.OpenElement(4, "h1");
            __builder.AddContent(5, "Hi ");
            __builder.AddContent(6, 
#nullable restore
#line 9 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Pages/Index.razor"
                AccountService.User.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, "!");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n        ");
            __builder.AddMarkupContent(9, "<p>You\'re logged in with Blazor WebAssembly!!</p>\n        ");
            __builder.OpenElement(10, "p");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(11);
            __builder.AddAttribute(12, "href", "users");
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(14, "Manage Users");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddContent(15, "tle=\"How is Blazor working for you?\"/>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService AccountService { get; set; }
    }
}
#pragma warning restore 1591
