#pragma checksum "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Clients\ClientForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22019d8cdc1553edbfe3dcab7687c8a001c11f7c"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class ClientForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 1 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Clients\ClientForm.razor"
                  Client

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 1 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Clients\ClientForm.razor"
                                         OnValidSubmit

#line default
#line hidden
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<label>Business Name</label>\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "class", "col-md-4 form-control");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 6 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Clients\ClientForm.razor"
                                                                   Client.BusinessName

#line default
#line hidden
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Client.BusinessName = __value, Client.BusinessName))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Client.BusinessName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __Blazor.BlazorCableReel.Client.Pages.Maintenance.Clients.ClientForm.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#line 7 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Clients\ClientForm.razor"
                                      () => Client.BusinessName

#line default
#line hidden
                );
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n    ");
                __builder2.AddMarkupContent(24, "<label>Short Name</label>\r\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "class", "col-md-4 form-control");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 13 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Clients\ClientForm.razor"
                                                                   Client.Shortname

#line default
#line hidden
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Client.Shortname = __value, Client.Shortname))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Client.Shortname));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __Blazor.BlazorCableReel.Client.Pages.Maintenance.Clients.ClientForm.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#line 14 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Clients\ClientForm.razor"
                                      () => Client.Shortname

#line default
#line hidden
                );
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.OpenElement(44, "button");
                __builder2.AddAttribute(45, "type", "submit");
                __builder2.AddAttribute(46, "class", "btn btn-dark");
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.AddContent(48, 
#line 19 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Clients\ClientForm.razor"
             ButtonText

#line default
#line hidden
                );
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 25 "D:\Users\semdhong\source\repos\SEMDEVWEB\BlazorCableReel\Client\Pages\Maintenance\Clients\ClientForm.razor"
       

    [Parameter] public Client Client { get; set; }
    [Parameter] public string ButtonText { get; set; } = "Save Client";
    [Parameter] public EventCallback OnValidSubmit { get; set; }

#line default
#line hidden
    }
}
namespace __Blazor.BlazorCableReel.Client.Pages.Maintenance.Clients.ClientForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
