#pragma checksum "/Users/reneilpascua/Work/medhat/assn2/client/Pages/Speakers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2817c2a2911c5af77cbfef9c4e4cfaab3a7bd3f3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/reneilpascua/Work/medhat/assn2/client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/reneilpascua/Work/medhat/assn2/client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/reneilpascua/Work/medhat/assn2/client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/reneilpascua/Work/medhat/assn2/client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/reneilpascua/Work/medhat/assn2/client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/reneilpascua/Work/medhat/assn2/client/_Imports.razor"
using client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/reneilpascua/Work/medhat/assn2/client/_Imports.razor"
using client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/reneilpascua/Work/medhat/assn2/client/_Imports.razor"
using client.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/speakers")]
    public partial class Speakers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/Speakers.razor"
       
    Speaker[] speakers;
    string baseUrl = "https://localhost:6001/";


    protected override async Task OnInitializedAsync() {
        await load();
    }

    protected async Task load() {
        speakers = await httpClient.GetJsonAsync<Speaker[]>($"{baseUrl}api/speakers");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591