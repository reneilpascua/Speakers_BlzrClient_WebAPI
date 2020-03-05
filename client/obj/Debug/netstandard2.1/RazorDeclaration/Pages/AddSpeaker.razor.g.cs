#pragma checksum "/Users/reneilpascua/Work/medhat/assn2/client/Pages/AddSpeaker.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c66696beb127b5e1148ece88eae0fa6a5362792"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/addspeaker")]
    public partial class AddSpeaker : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/AddSpeaker.razor"
       
    string baseUrl = "http://localhost:6001/";
    private Speaker speaker = new Speaker();

    private async Task HandleAdd() {
        string endpoint = $"{baseUrl}api/speakers";

        speaker.SpeakerId = Guid.NewGuid().ToString();

        await httpClient.SendJsonAsync(HttpMethod.Post, endpoint, speaker);

        // to do: clear model only if valid submit
        // alternative: go to view all speakers page

        // clears the form if you want to stay here... might navigate to all speakers instead
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/AddSpeaker.razor"
                                    
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
