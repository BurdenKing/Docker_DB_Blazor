#pragma checksum "c:\Users\Wei-Han\Desktop\COMP4870Assignment2\SpeakerClient\Pages\Add.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7bcf600ac6616bb68652d6ec572057906d04cea"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SpeakerClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\Wei-Han\Desktop\COMP4870Assignment2\SpeakerClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Wei-Han\Desktop\COMP4870Assignment2\SpeakerClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Wei-Han\Desktop\COMP4870Assignment2\SpeakerClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Wei-Han\Desktop\COMP4870Assignment2\SpeakerClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Wei-Han\Desktop\COMP4870Assignment2\SpeakerClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\Wei-Han\Desktop\COMP4870Assignment2\SpeakerClient\_Imports.razor"
using SpeakerClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\Wei-Han\Desktop\COMP4870Assignment2\SpeakerClient\_Imports.razor"
using SpeakerClient.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Add")]
    public partial class Add : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "c:\Users\Wei-Han\Desktop\COMP4870Assignment2\SpeakerClient\Pages\Add.razor"
       
  private Speaker speaker = new Speaker();

  private async void HandleAdd() {
    string endpoint = "http://localhost:8555/api/Speaker";

    speaker.SpeakerId = Guid.NewGuid().ToString();
    await httpClient.SendJsonAsync(HttpMethod.Post, endpoint, speaker);

    NavigationManager.NavigateTo("/");
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591