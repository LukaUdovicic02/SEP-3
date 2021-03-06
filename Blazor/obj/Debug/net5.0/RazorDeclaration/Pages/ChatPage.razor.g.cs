// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/Pages/ChatPage.razor"
using ChatSystem.JsInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ChatPage")]
    public partial class ChatPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/Pages/ChatPage.razor"
       

    private const string _rabbitMQHost = "localhost";
    private const int _rabbitMQPort = 15675;

    private const string _rabbitMQUsername = "guest";
    private const string _rabbitMQPassword = "guest";
    private const string _topic = "chatroom";

    private List<PayloadData> rabbitData { get; set; }
    private string ConnectionStatus { get; set; }
    private string Name { get; set; } = $"User1";
    private bool IsDisabled { get; set; }
    private string Message { get; set; }

    protected override void OnInitialized()
    {
        ConnectionStatus = "Not connected";

        OnConnectionChanged.Action = value =>
        {
            ConnectionStatus = $"{value}";
            StateHasChanged();
        };

        OnMessageReceived.Action = (key, data) =>
        {
            if (rabbitData == null)
            {
                rabbitData = new List<PayloadData>();
            }

            var rabbitDataItem = new PayloadData(key, data);
            rabbitData.Insert(0, rabbitDataItem);

            StateHasChanged();
        };
    }

    public void CreateClientAndConnect()
    {
        IsDisabled = true;
        StateHasChanged();

        mqttInterop.CreateClient(wsHost: _rabbitMQHost, wsPort: _rabbitMQPort, clientId: Name);
        mqttInterop.Connect(topic: _topic, qos: 1, timeout: 3, username: _rabbitMQUsername, password: _rabbitMQPassword);
    }

    public void Disconnect()
    {
        mqttInterop.Disconnect();
        IsDisabled = false;
        StateHasChanged();
    }

    public void PublishMessage()
    {
        if (!string.IsNullOrWhiteSpace(Message))
        {
            string payload = $"{Name} : {Message}";
            mqttInterop.Publish(topic: _topic, payload: payload, qos: 0, retained: false);
            Message = null;
            StateHasChanged();
        }
    }

    class PayloadData
    {
        private string Key { get; set; }
        public string Data { get; set; }
        public string Received { get; set; }

        public PayloadData(string key, string data)
        {
            Key = key;
            Data = data;
            Received = DateTime.Now.ToString("HH:mm:ss");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MqttJsInterop mqttInterop { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
