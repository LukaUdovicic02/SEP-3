#pragma checksum "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6884a49f15b438bf2341ebfa7a3cc75db29654e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/_Imports.razor"
using BlazorClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/_Imports.razor"
using BlazorClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chatroom")]
    public partial class ChatRoom : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Chat</h1>\n<hr>");
#nullable restore
#line 8 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
 if (!_isChatting)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, 
#nullable restore
#line 10 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
     Chat()

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 10 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
           
    
    // Error messages
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
     if (_message != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "invalid-feedback");
            __builder.AddContent(4, 
#nullable restore
#line 15 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
                                       _message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "small");
            __builder.AddAttribute(7, "id", "emailHelp");
            __builder.AddAttribute(8, "class", "form-text text-muted");
            __builder.AddContent(9, 
#nullable restore
#line 16 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
                                                            _message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 17 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
     
}
else
{
    // display messages

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "id", "scrollbox");
#nullable restore
#line 23 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
         foreach (var item in _messages)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
             if (item.IsNotice)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "alert alert-info");
            __builder.AddContent(14, 
#nullable restore
#line 27 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
                                               item.Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 28 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", 
#nullable restore
#line 31 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
                             item.CSS

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "user");
            __builder.AddContent(19, 
#nullable restore
#line 32 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
                                       item.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "msg");
            __builder.AddContent(23, 
#nullable restore
#line 33 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
                                      item.Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(24, "<hr>\n        ");
            __builder.OpenElement(25, "textarea");
            __builder.AddAttribute(26, "class", "input-lg");
            __builder.AddAttribute(27, "placeholder", "enter your message");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
                                                                            _newMessage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _newMessage = __value, _newMessage));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n        ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "btn btn-default");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
                                                    () => SendAsync(_newMessage)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Send");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "/Users/henrikkoster/Documents/CookAway/ChatSystem-C/BlazorClient/Pages/ChatRoom.razor"
       
    // flag to indicate chat status
    private bool _isChatting = false;
    
    private static int chatId = 1;

    // name of the user who will be chatting
    private static readonly string _username = "CR7";

    // on-screen message
    private string _message;

    // new message input
    private string _newMessage;

    // list of messages in chat
    List<Message> _messages = new List<Message>();

    private string _hubUrl;
    private HubConnection _hubConnection;

    public async Task Chat()
    {
        try
        {
            // Start chatting and force refresh UI.
            _isChatting = true;
            await Task.Delay(1);

            // remove old messages if any
            _messages.Clear();

            // Create the chat client
            string baseUrl = _navigationManager.BaseUri;

            _hubUrl = baseUrl.TrimEnd('/') + ChatRoomHub.HubUrl;

            _hubConnection = new HubConnectionBuilder()
                .WithUrl(_hubUrl)
                .Build();

            _hubConnection.On<string, string>("Broadcast", BroadcastMessage);

            await _hubConnection.StartAsync();

            await SendAsync($"[Notice] {_username} joined chat room.");
        }
        catch (Exception e)
        {
            _message = $"ERROR: Failed to start chat client: {e.Message}";
            _isChatting = false;
        }
    }

    private void BroadcastMessage(string name, string message)
    {
        bool isMine = name.Equals(_username, StringComparison.OrdinalIgnoreCase);

        _messages.Add(new Message(name, message, isMine));

        // Inform blazor the UI needs updating
        StateHasChanged();
    }

    private async Task DisconnectAsync()
    {
        if (_isChatting)
        {
            await SendAsync($"[Notice] {_username} left chat room.");

            await _hubConnection.StopAsync();
            await _hubConnection.DisposeAsync();

            _hubConnection = null;
            _isChatting = false;
        }
    }

    private async Task SendAsync(string message)
    {
        if (_isChatting && !string.IsNullOrWhiteSpace(message))
        {
            await _hubConnection.SendAsync("SendChatMessage", _username, message);

            _newMessage = string.Empty;
        }
    }

    private class Message
    {
        public Message(string username, string body, bool mine)
        {
            Username = username;
            Body = body;
            Mine = mine;
        }

        public string Username { get; set; }
        public string Body { get; set; }
        public bool Mine { get; set; }

        public bool IsNotice => Body.StartsWith("[Notice]");

        public string CSS => Mine ? "sent" : "received";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
