#pragma checksum "C:\Users\semdhong\Documents\GitHub\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Uom\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45bddfada21a3f581d64d7a58cf39e59d5f93eb0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCableReel.Client.Pages.Maintenance.Uom
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/maintenance/uoms/edit/{uomId:int}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 8 "C:\Users\semdhong\Documents\GitHub\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Uom\Edit.razor"
       
    [Parameter] public int UomId { get; set; }
    Uom Uom = new BlazorCableReel.Shared.Models.Uom();

    protected async override Task OnParametersSetAsync()
    {
        Uom = await http.GetJsonAsync<Uom>($"uom/{UomId}");
    }

    async Task EditUom()
    {
        await http.PutJsonAsync("uom", Uom);
        navmgr.NavigateTo("/maintenance/uoms");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navmgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
