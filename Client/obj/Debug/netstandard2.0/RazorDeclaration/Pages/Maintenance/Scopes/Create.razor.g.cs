#pragma checksum "C:\Users\semdhong\Documents\GitHub\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Scopes\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba5ab8e3f1ae9a474724e7a58351c53647f90dae"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCableReel.Client.Pages.Maintenance.Scopes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\semdhong\Documents\GitHub\SEMDEVWEB\BlazorCableReel\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\semdhong\Documents\GitHub\SEMDEVWEB\BlazorCableReel\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\semdhong\Documents\GitHub\SEMDEVWEB\BlazorCableReel\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\semdhong\Documents\GitHub\SEMDEVWEB\BlazorCableReel\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\semdhong\Documents\GitHub\SEMDEVWEB\BlazorCableReel\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\semdhong\Documents\GitHub\SEMDEVWEB\BlazorCableReel\Client\_Imports.razor"
using BlazorCableReel.Client;

#line default
#line hidden
#line 7 "C:\Users\semdhong\Documents\GitHub\SEMDEVWEB\BlazorCableReel\Client\_Imports.razor"
using BlazorCableReel.Client.Shared;

#line default
#line hidden
#line 8 "C:\Users\semdhong\Documents\GitHub\SEMDEVWEB\BlazorCableReel\Client\_Imports.razor"
using BlazorCableReel.Shared.Models;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/maintenance/scopes/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 8 "C:\Users\semdhong\Documents\GitHub\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Scopes\Create.razor"
       

    Scope scope = new BlazorCableReel.Shared.Models.Scope();

    async Task CreateScope()
    {
        await http.PostJsonAsync("scope", scope);
        navmgr.NavigateTo("/maintenance/scopes");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navmgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
