#pragma checksum "/Users/reneilpascua/Work/medhat/assn2/client/Pages/DeleteSpeaker.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8df9de156ac5549f6ff16464a4211c467a7a7d7f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/deletespeaker/{id}")]
    public partial class DeleteSpeaker : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/DeleteSpeaker.razor"
       
    [Parameter]
    public string ID {get; set;} 

    string baseUrl = "http://localhost:6001/";
    private Speaker speaker;

    protected override async Task OnInitializedAsync() {
        await load(ID);
    }
    public async Task load(string id) {
        speaker = await httpClient.GetJsonAsync<Speaker>($"{baseUrl}api/speakers/{id}");
    }
    
    protected async Task HandleDelete() {
      string endpoint = $"{baseUrl}api/speakers/{speaker.SpeakerId}";
      await httpClient.SendJsonAsync(HttpMethod.Delete, endpoint, null);
      nm.NavigateTo("speakers");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nm { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
