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
#line 2 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/Pages/ContactsPage.razor"
using Syncfusion.Blazor.Lists;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/Pages/ContactsPage.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ContactsPage")]
    public partial class ContactsPage : Syncfusion.Blazor.SfBaseComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/Pages/ContactsPage.razor"
      

    List<DataModel> ListData = new List<DataModel>();

    protected override void OnInitialized()
    {
        base.OnInitialized();
        ListData.Add(new DataModel { Name = "Nancy", Icon = "N", Id = "0", Category = "Contacts"});
        ListData.Add(new DataModel { Name = "Andrew", Icon = "A", Id = "1", Category = "Contacts" });
        ListData.Add(new DataModel { Name = "Janet", Icon = "J", Id = "2", Category = "Friends" });
        ListData.Add(new DataModel { Name = "Margaret", Icon = "", Category = "Contacts", Id = "3" });
        ListData.Add(new DataModel { Name = "Steven", Icon = "S", Id = "4", Category = "Contacts" });
        ListData.Add(new DataModel { Name = "Laura", Icon = "", Category = "Contacts", Id = "5" });
        ListData.Add(new DataModel { Name = "Robert", Icon = "R", Id = "6", Category = "Friends" });
        ListData.Add(new DataModel { Name = "Michael", Icon = "M", Id = "7", Category = "Contacts" });
        ListData.Add(new DataModel { Name = "Albert", Icon = "", Category = "Contacts", Id = "8" });
        ListData.Add(new DataModel { Name = "Nolan", Icon = "N", Id = "9", Category = "Friends" });
    }

    public class DataModel
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Id { get; set; }
        public string Category { get; set; }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591