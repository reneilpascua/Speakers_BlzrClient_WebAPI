#pragma checksum "/Users/reneilpascua/Work/medhat/assn2/client/Pages/DeleteSpeaker.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b85a59cb40ae9bdfb16877bbfecb0931ea25068"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "h2");
            __builder.AddMarkupContent(1, "Are you sure you want to delete?? <br>Speaker ID ");
            __builder.AddContent(2, 
#nullable restore
#line 5 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/DeleteSpeaker.razor"
                                                       ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n");
#nullable restore
#line 6 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/DeleteSpeaker.razor"
 if (speaker==null) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.AddMarkupContent(5, "<p><em>Loading Speaker Info...</em></p>\n");
#nullable restore
#line 8 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/DeleteSpeaker.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "p");
            __builder.AddContent(8, 
#nullable restore
#line 9 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/DeleteSpeaker.razor"
        speaker.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, "  ");
            __builder.AddContent(10, 
#nullable restore
#line 9 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/DeleteSpeaker.razor"
                            speaker.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n    ");
            __builder.OpenElement(12, "p");
            __builder.AddContent(13, 
#nullable restore
#line 10 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/DeleteSpeaker.razor"
        speaker.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n    ");
            __builder.OpenElement(15, "p");
            __builder.AddContent(16, 
#nullable restore
#line 11 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/DeleteSpeaker.razor"
        speaker.MobileNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n    ");
            __builder.OpenElement(18, "p");
            __builder.AddContent(19, 
#nullable restore
#line 12 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/DeleteSpeaker.razor"
        speaker.Specialization

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n    ");
            __builder.OpenElement(21, "p");
            __builder.AddContent(22, 
#nullable restore
#line 13 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/DeleteSpeaker.razor"
        speaker.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n    ");
            __builder.OpenElement(24, "p");
            __builder.AddContent(25, 
#nullable restore
#line 14 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/DeleteSpeaker.razor"
        speaker.Province

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n    ");
            __builder.OpenElement(27, "p");
            __builder.AddContent(28, 
#nullable restore
#line 15 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/DeleteSpeaker.razor"
        speaker.Employer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n    ");
            __builder.AddMarkupContent(30, "<a class=\"btn btn-primary btn-sm\" href=\"/speakers\">Back To Speakers</a>\n    ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/DeleteSpeaker.razor"
                                                 () => HandleDelete()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n");
#nullable restore
#line 18 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/DeleteSpeaker.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/DeleteSpeaker.razor"
       
    [Parameter]
    public string ID {get; set;} 

    string baseUrl = "https://localhost:6001/";
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