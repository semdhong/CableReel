#pragma checksum "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Scopes\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42f50c34efcf81b8b5c2d06df2cfc2f2e6a50648"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCableReel.Client.Pages.Maintenance.Scopes
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/maintenance/scopes/edit/{scopeId:int}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Scope</h3>\r\n");
            __builder.OpenComponent<BlazorCableReel.Client.Pages.Maintenance.Scopes.ScopeForm>(1);
            __builder.AddAttribute(2, "Scope", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorCableReel.Shared.Models.Scope>(
#line 6 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Scopes\Edit.razor"
                  scope

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "ButtonText", "Edit Scope");
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 6 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Scopes\Edit.razor"
                                                                 EditScope

#line default
#line hidden
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 8 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Scopes\Edit.razor"
       
    [Parameter] public int scopeId { get; set; }
    Scope scope = new BlazorCableReel.Shared.Models.Scope();

    protected async override Task OnParametersSetAsync()
    {
        scope = await http.GetJsonAsync<Scope>($"scope/{scopeId}");
    }

    async Task EditScope()
    {
        await http.PutJsonAsync("scope", scope);
        navmgr.NavigateTo("/maintenance/scopes");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navmgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
