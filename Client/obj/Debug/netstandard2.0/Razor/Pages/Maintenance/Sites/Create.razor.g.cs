#pragma checksum "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Sites\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "999cd90b3d28a1f944d935403612d4134e99f173"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCableReel.Client.Pages.Maintenance.Sites
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/maintenance/sites/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create Sites</h3>\r\n");
            __builder.OpenComponent<BlazorCableReel.Client.Pages.Maintenance.Sites.SiteForm>(1);
            __builder.AddAttribute(2, "Site", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorCableReel.Shared.Models.Site>(
#line 6 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Sites\Create.razor"
                 site

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "ButtonText", "Create Site");
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 6 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Sites\Create.razor"
                                                                CreateSite

#line default
#line hidden
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 8 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Sites\Create.razor"
       

    Site site = new BlazorCableReel.Shared.Models.Site();

    async Task CreateSite()
    {
        await http.PostJsonAsync("sites", site);
        navmgr.NavigateTo("/maintenance/sites");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navmgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
