#pragma checksum "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Clients\SiteForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "176723cab18eb41c22a297cfe272569abedf8f6a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCableReel.Client.Pages.Maintenance.Clients
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\_Imports.razor"
using BlazorCableReel.Client;

#line default
#line hidden
#line 7 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\_Imports.razor"
using BlazorCableReel.Client.Shared;

#line default
#line hidden
#line 8 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\_Imports.razor"
using BlazorCableReel.Shared.Models;

#line default
#line hidden
    public partial class SiteForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 38 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Clients\SiteForm.razor"
       

    [Parameter] public Site Site { get; set; }
    [Parameter] public string ButtonText { get; set; } = "Save Site";
    [Parameter] public EventCallback OnValidSubmit { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
