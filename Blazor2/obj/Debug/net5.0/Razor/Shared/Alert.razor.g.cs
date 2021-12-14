#pragma checksum "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Shared/Alert.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57d01e4ef2828642c21e8a20fd268bf31d789634"
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
#line 1 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Shared/Alert.razor"
using Blazor2.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Shared/Alert.razor"
using Blazor2.Models;

#line default
#line hidden
#nullable disable
    public partial class Alert : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Shared/Alert.razor"
 foreach (var alert in alerts)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 9 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Shared/Alert.razor"
                 CssClass(alert)

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(2, "a");
            __builder.AddAttribute(3, "class", "close");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Shared/Alert.razor"
                                     () => RemoveAlert(alert)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "×");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n        ");
            __builder.OpenElement(7, "span");
            __builder.AddContent(8, 
#nullable restore
#line 11 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Shared/Alert.razor"
               alert.Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 13 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Shared/Alert.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor2/Shared/Alert.razor"
       
    [Parameter]
    public string Id { get; set; } = "default-alert";

    [Parameter]
    public bool Fade { get; set; } = true;

    private List<Models.Alert> alerts = new List<Models.Alert>();

    protected override void OnInitialized()
    {
        // subscribe to new alerts and location change events
        AlertService.OnAlert += OnAlert;
        NavigationManager.LocationChanged += OnLocationChange;
    }

    public void Dispose()
    {
        // unsubscribe from alerts and location change events
        AlertService.OnAlert -= OnAlert;
        NavigationManager.LocationChanged -= OnLocationChange;
    }

    private async void OnAlert(Models.Alert alert)
    {
        // ignore alerts sent to other alert components
        if (alert.Id != Id) 
            return;

        // clear alerts when an empty alert is received
        if (alert.Message == null) 
        {
            // remove alerts without the 'KeepAfterRouteChange' flag set to true
            alerts.RemoveAll(x => !x.KeepAfterRouteChange);

            // set the 'KeepAfterRouteChange' flag to false for the 
            // remaining alerts so they are removed on the next clear
            alerts.ForEach(x => x.KeepAfterRouteChange = false);
        }
        else
        {
            // add alert to array
            alerts.Add(alert);
            StateHasChanged();

            // auto close alert if required
            if (alert.AutoClose)
            {
                await Task.Delay(3000);
                RemoveAlert(alert);
            }
        }

        StateHasChanged();
    }

    private void OnLocationChange(object sender, LocationChangedEventArgs e)
    {
        AlertService.Clear(Id);
    }

    private async void RemoveAlert(Models.Alert alert)
    {
        // check if already removed to prevent error on auto close
        if (!alerts.Contains(alert)) return;

        if (Fade) 
        {
            // fade out alert
            alert.Fade = true;

            // remove alert after faded out
            await Task.Delay(250);
            alerts.Remove(alert);
        } 
        else 
        {
            // remove alert
            alerts.Remove(alert);
        }

        StateHasChanged();
    }

    private string CssClass(Models.Alert alert) 
    {
        if (alert == null) return null;

        var classes = new List<string> { "alert", "alert-dismissable", "mt-4", "container" };

        var alertTypeClass = new Dictionary<AlertType, string>();
        alertTypeClass[AlertType.Success] = "alert-success";
        alertTypeClass[AlertType.Error] = "alert-danger";
        alertTypeClass[AlertType.Info] = "alert-info";
        alertTypeClass[AlertType.Warning] = "alert-warning";

        classes.Add(alertTypeClass[alert.Type]);

        if (alert.Fade)
            classes.Add("fade");

        return string.Join(' ', classes);
    }   

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAlertService AlertService { get; set; }
    }
}
#pragma warning restore 1591