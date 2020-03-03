#pragma checksum "/Users/reneilpascua/Work/medhat/assn2/client/Pages/EditSpeaker.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93ec0fd6cd7c422c59258f2107d9f252e4b24036"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/editspeaker/{id}")]
    public partial class EditSpeaker : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h2");
            __builder.AddContent(1, "Editing Speaker ID ");
            __builder.AddContent(2, 
#nullable restore
#line 5 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/EditSpeaker.razor"
                        ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n");
#nullable restore
#line 6 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/EditSpeaker.razor"
 if (speaker==null) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.AddMarkupContent(5, "<p><em>Loading Speaker Info...</em></p>\n");
#nullable restore
#line 8 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/EditSpeaker.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/EditSpeaker.razor"
                  speaker

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/EditSpeaker.razor"
                                           HandleUpdate

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\n\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "placeholder", "First Name");
                __builder2.AddAttribute(17, "id", "firstName");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/EditSpeaker.razor"
                                                                     speaker.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => speaker.FirstName = __value, speaker.FirstName))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => speaker.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\n    <br>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "placeholder", "Last Name");
                __builder2.AddAttribute(25, "id", "lastName");
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/EditSpeaker.razor"
                                                                   speaker.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => speaker.LastName = __value, speaker.LastName))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => speaker.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\n    <br>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "placeholder", "Email");
                __builder2.AddAttribute(33, "id", "email");
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/EditSpeaker.razor"
                                                            speaker.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => speaker.Email = __value, speaker.Email))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => speaker.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\n    <br>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "placeholder", "Mobile Number");
                __builder2.AddAttribute(41, "id", "mobileNumber");
                __builder2.AddAttribute(42, "class", "form-control");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/EditSpeaker.razor"
                                                                           speaker.MobileNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => speaker.MobileNumber = __value, speaker.MobileNumber))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => speaker.MobileNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\n    <br>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "placeholder", "Specialization");
                __builder2.AddAttribute(49, "id", "specialization");
                __builder2.AddAttribute(50, "class", "form-control");
                __builder2.AddAttribute(51, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/EditSpeaker.razor"
                                                                              speaker.Specialization

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => speaker.Specialization = __value, speaker.Specialization))));
                __builder2.AddAttribute(53, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => speaker.Specialization));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\n    <br>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(55);
                __builder2.AddAttribute(56, "placeholder", "City");
                __builder2.AddAttribute(57, "id", "city");
                __builder2.AddAttribute(58, "class", "form-control");
                __builder2.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/EditSpeaker.razor"
                                                          speaker.City

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => speaker.City = __value, speaker.City))));
                __builder2.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => speaker.City));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\n    <br>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(63);
                __builder2.AddAttribute(64, "placeholder", "Province");
                __builder2.AddAttribute(65, "id", "province");
                __builder2.AddAttribute(66, "class", "form-control");
                __builder2.AddAttribute(67, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/EditSpeaker.razor"
                                                                  speaker.Province

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(68, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => speaker.Province = __value, speaker.Province))));
                __builder2.AddAttribute(69, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => speaker.Province));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\n    <br>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(71);
                __builder2.AddAttribute(72, "placeholder", "Employer");
                __builder2.AddAttribute(73, "id", "employer");
                __builder2.AddAttribute(74, "class", "form-control");
                __builder2.AddAttribute(75, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/EditSpeaker.razor"
                                                                  speaker.Employer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => speaker.Employer = __value, speaker.Employer))));
                __builder2.AddAttribute(77, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => speaker.Employer));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\n    <br>\n    ");
                __builder2.AddMarkupContent(79, "<a href=\"/speakers\"><button class=\"btn btn-primary btn-sm\">Back To Speakers</button></a>\n    ");
                __builder2.AddMarkupContent(80, "<button type=\"submit\" class=\"btn btn-success\">Submit</button>\n  ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(81, "\n");
#nullable restore
#line 32 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/EditSpeaker.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "/Users/reneilpascua/Work/medhat/assn2/client/Pages/EditSpeaker.razor"
       
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

    private async Task HandleUpdate() {
        string endpoint = $"{baseUrl}api/speakers/{speaker.SpeakerId}";

        await httpClient.SendJsonAsync(HttpMethod.Put, endpoint, speaker);

        //todo: navigate to view all page
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