#pragma checksum "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Materials\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d767575fe8012bfe2e13b538ddcab939f14a127a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCableReel.Client.Pages.Maintenance.Materials
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/maintenance/materials/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create Material</h3>\r\n");
            __builder.OpenComponent<BlazorCableReel.Client.Pages.Maintenance.Materials.MaterialForm>(1);
            __builder.AddAttribute(2, "Material", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorCableReel.Shared.Models.Material>(
#line 6 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Materials\Create.razor"
                         Material

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "ButtonText", "Create Material");
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 6 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Materials\Create.razor"
                                                                                CreateMaterial

#line default
#line hidden
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 8 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Materials\Create.razor"
       

    Material Material = new BlazorCableReel.Shared.Models.Material();

    async Task CreateMaterial()
    {
        await http.PostJsonAsync("materials", Material);
        navmgr.NavigateTo("/maintenance/materials");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navmgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
