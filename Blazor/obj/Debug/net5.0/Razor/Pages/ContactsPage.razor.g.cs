#pragma checksum "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/Pages/ContactsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f11fc63d8ed107a8f7092321ee2fcccdac84281f"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(0);
            __builder.AddAttribute(1, "IconCss", "oi oi-plus");
            __builder.AddAttribute(2, "IconPosition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Buttons.IconPosition>(
#nullable restore
#line 6 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/Pages/ContactsPage.razor"
                                             IconPosition.Right

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "New Contact");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(6);
            __builder.AddAttribute(7, "IconCss", "oi oi-plus");
            __builder.AddAttribute(8, "IconPosition", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Buttons.IconPosition>(
#nullable restore
#line 7 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/Pages/ContactsPage.razor"
                                             IconPosition.Right

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(10, "New Group");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\n\n");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/Pages/ContactsPage.razor"
                    SearchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchTerm = __value, SearchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n\n");
            __Blazor.Blazor.Pages.ContactsPage.TypeInference.CreateSfListView_0(__builder, 16, 17, "list", 18, 
#nullable restore
#line 11 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/Pages/ContactsPage.razor"
                                   EListData

#line default
#line hidden
#nullable disable
            , 19, "e-list-template ui-list", 20, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Lists.ListViewFieldSettings<DataModel>>(21);
                __builder2.AddAttribute(22, "Id", "Id");
                __builder2.AddAttribute(23, "Text", "Name");
                __builder2.AddAttribute(24, "GroupBy", "Category");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Lists.ListViewTemplates<DataModel>>(26);
                __builder2.AddAttribute(27, "Template", (Microsoft.AspNetCore.Components.RenderFragment<DataModel>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(28);
                    __builder3.AddAttribute(29, "href", "chatroom");
                    __builder3.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(31, "div");
                        __builder4.AddAttribute(32, "class", "e-list-wrapper e-list-multi-line e-list-avatar");
                        __builder4.OpenElement(33, "span");
                        __builder4.AddAttribute(34, "id", "showUI");
                        __builder4.AddAttribute(35, "class", "e-avatar e-avatar-circle");
                        __builder4.AddAttribute(36, "icon", 
#nullable restore
#line 17 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/Pages/ContactsPage.razor"
                                                                              context.Icon

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(37, 
#nullable restore
#line 17 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/Pages/ContactsPage.razor"
                                                                                              context.Icon

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(38, "\n                    ");
                        __builder4.OpenElement(39, "span");
                        __builder4.AddAttribute(40, "class", "e-list-content");
                        __builder4.AddContent(41, 
#nullable restore
#line 18 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/Pages/ContactsPage.razor"
                                                  context.Name

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(42, "\n                    ");
                        __builder4.OpenElement(43, "span");
                        __builder4.AddAttribute(44, "class", "e-list-content");
                        __builder4.AddContent(45, 
#nullable restore
#line 19 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/Pages/ContactsPage.razor"
                                                  context.Nickname

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(46, "\n                    ");
                        __builder4.OpenElement(47, "span");
                        __builder4.AddAttribute(48, "class", "status");
                        __builder4.AddContent(49, 
#nullable restore
#line 20 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/Pages/ContactsPage.razor"
                                          context.Status

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(50, "GroupTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Syncfusion.Blazor.Lists.ComposedItemModel<DataModel>>)((context) => (__builder3) => {
                    __builder3.OpenElement(51, "div");
                    __builder3.OpenElement(52, "span");
                    __builder3.AddAttribute(53, "class", "category");
                    __builder3.AddContent(54, 
#nullable restore
#line 26 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/Pages/ContactsPage.razor"
                                        context.Text

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(55, "\n\n\n");
            __builder.AddMarkupContent(56, "<style>\n    /* ListView position alignment */\n    .ui-list.e-listview {\n        margin: auto;\n        margin-top: 20px;\n        max-width: 100%;\n        line-height: initial;\n        border: 1px solid lightgray;\n        overflow: scroll;\n    }\n    /* ListView header alignment */\n    .ui-list.e-listview .e-list-header {\n        height: 50px\n    }\n    .ui-list.e-listview .e-list-header .e-text {\n        line-height: 18px\n    }\n    /* ListView template customization */\n    .ui-list.e-listview #showUI {\n        display: flex;\n    }\n    .ui-list.e-listview .e-list-item {\n        padding: 3px 0;\n        height: 70px;\n        vertical-align: middle;\n    }\n    .ui-list.e-listview [icon=\"R\"] {\n        background: lightgrey;\n    }\n    .ui-list.e-listview [icon=\"M\"] {\n        background: pink;\n    }\n    .ui-list.e-listview [icon=\"A\"] {\n        background: lightgreen;\n    }\n    .ui-list.e-listview [icon=\"S\"] {\n        background: lightskyblue;\n    }\n    .ui-list.e-listview [icon=\"J\"] {\n        background: orange;\n    }\n    .ui-list.e-listview [icon=\"N\"] {\n        background: lightblue;\n    }\n    /* ListView theme customization */\n    .ui-list.e-listview .e-list-item.e-active {\n        background: #ffd939;\n        color: #000000;\n    }\n    .e-list-wrapper {\n        flex: 1;\n        display: block;\n        word-wrap: break-word;\n        white-space: nowrap;\n        padding: 2px;\n        font-size: 14px;\n        overflow: hidden;\n        text-overflow: ellipsis;\n    }\n    .e-list-avatar {\n        top: 0;\n        vertical-align: middle;\n    }\n    .e-avatar {\n        -ms-flex-line-pack: center;\n        align-content: center;\n        -ms-flex-align: center;\n        align-items: center;\n        background-color: #e9ecef;\n        background-position: center;\n        background-repeat: no-repeat;\n        background-size: cover;\n        border-radius: 4px;\n        color: #212529;\n        display: -ms-inline-flexbox;\n        display: inline-flex;\n        font-family: \"Helvetica Neue\", \"Helvetica\", \"Arial\", sans-serif, \"-apple-system\", \"BlinkMacSystemFont\";\n        font-size: 1.05em;\n        font-weight: 400;\n        height: 1.5em;\n        -ms-flex-pack: center;\n        justify-content: center;\n        overflow: hidden;\n        position: relative;\n        top: 0;\n        width:1.5em;\n        vertical-align: middle;\n    }\n    .e-list-content {\n        vertical-align: middle;\n    }\n    .status {\n        right: 0;\n    }\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "/home/c/Desktop/RiderProjects/ChatSystem/Blazor/Pages/ContactsPage.razor"
      
    
    static List<DataModel> ListData = new List<DataModel>();
    
    IEnumerable<DataModel> EListData = ListData.Where(i => i.Name.ToLower().Contains(SearchTerm.ToLower()));
    
    static string SearchTerm { get; set; } = "";
    
    protected override void OnInitialized()
    {
        base.OnInitialized();
        ListData.Add(new DataModel { Name = "Nancy", Icon = "N", Id = "0", Category = "Contacts", Nickname = "", Status = ""});
        ListData.Add(new DataModel { Name = "Andrew", Icon = "A", Id = "1", Category = "Contacts", Nickname = "", Status = ""});
        ListData.Add(new DataModel { Name = "Margaret", Icon = "M", Category = "Contacts", Id = "3", Nickname = "", Status = ""});
        ListData.Add(new DataModel { Name = "$teven2001", Icon = "S", Id = "4", Category = "Contacts", Nickname = "'Steven Thompson'", Status = "online"});
        ListData.Add(new DataModel { Name = "Laura", Icon = "L", Category = "Contacts", Id = "5", Nickname = "", Status = ""});
        ListData.Add(new DataModel { Name = "Michael", Icon = "M", Id = "7", Category = "Contacts", Nickname = "", Status = ""});
        ListData.Add(new DataModel { Name = "Albert", Icon = "A", Category = "Contacts", Id = "8", Nickname = "", Status = ""});
        ListData.Add(new DataModel { Name = "Bums United", Icon = "M", Id = "7", Category = "Groups", Nickname = "", Status = ""});
        ListData.Add(new DataModel { Name = "Amogus", Icon = "A", Category = "Groups", Id = "8", Nickname = "", Status = ""});
        ListData.Add(new DataModel { Name = "DOL", Icon = "N", Id = "9", Category = "Groups", Nickname = "", Status = ""});
    }

    public class DataModel
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Id { get; set; }
        public string Category { get; set; }
        public string Nickname { get; set; }
        public string Status { get; set; }
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Blazor.Pages.ContactsPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfListView_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TValue> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Lists.SfListView<TValue>>(seq);
        __builder.AddAttribute(__seq0, "ID", __arg0);
        __builder.AddAttribute(__seq1, "DataSource", __arg1);
        __builder.AddAttribute(__seq2, "CssClass", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
