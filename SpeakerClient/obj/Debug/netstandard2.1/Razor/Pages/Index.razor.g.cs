#pragma checksum "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "013750b479133d8be30519a62531b8aa9519248b"
// <auto-generated/>
#pragma warning disable 1591
namespace SpeakerClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\_Imports.razor"
using SpeakerClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\_Imports.razor"
using SpeakerClient.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Wei-Han Chou and Lawrence Zheng\'s Assignment 2</h1>\r\n");
#nullable restore
#line 4 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\Pages\Index.razor"
 if (speakers == null) {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "href", "/add");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(5, "Add");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "  \r\n");
#nullable restore
#line 6 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\Pages\Index.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(7);
            __builder.AddAttribute(8, "class", "btn btn-primary");
            __builder.AddAttribute(9, "href", "/add");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(11, "Add");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "  \r\n");
            __builder.OpenElement(13, "table");
            __builder.AddAttribute(14, "class", "table table-hover");
            __builder.AddMarkupContent(15, "\r\n  ");
            __builder.AddMarkupContent(16, @"<thead>
    <tr>
      <th>First Name</th>
      <th>Last Name</th>
      <th>Email</th>
      <th>Phone</th>
      <th>Area</th>
      <th>City</th>
      <th>Province</th>
      <th>Employer</th>
      <th>Edit</th>
      <th>Delete</th>
    </tr>
  </thead>
  ");
            __builder.OpenElement(17, "tbody");
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 24 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\Pages\Index.razor"
     foreach (var item in speakers) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "    ");
            __builder.OpenElement(20, "tr");
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 26 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\Pages\Index.razor"
             item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 27 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\Pages\Index.razor"
             item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 28 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\Pages\Index.razor"
             item.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 29 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\Pages\Index.razor"
             item.Phone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 30 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\Pages\Index.razor"
             item.AreaSpecification

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 31 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\Pages\Index.razor"
             item.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 32 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\Pages\Index.razor"
             item.Province

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 33 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\Pages\Index.razor"
             item.Employer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "td");
            __builder.OpenElement(47, "a");
            __builder.AddAttribute(48, "type", "button");
            __builder.AddAttribute(49, "class", "btn btn-success");
            __builder.AddAttribute(50, "href", "/edit/" + (
#nullable restore
#line 34 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\Pages\Index.razor"
                                                                  item.SpeakerId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.OpenElement(53, "td");
            __builder.OpenElement(54, "a");
            __builder.AddAttribute(55, "type", "button");
            __builder.AddAttribute(56, "class", "btn btn-danger");
            __builder.AddAttribute(57, "href", "/delete/" + (
#nullable restore
#line 35 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\Pages\Index.razor"
                                                                   item.SpeakerId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(58, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 37 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(61, "  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
#nullable restore
#line 40 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Wei-Han\Desktop\bcit\term4\COMP4870\COMP4870Assignment2\SpeakerClient\Pages\Index.razor"
       
  Speaker[] speakers;
  string baseUrl = "http://localhost:6000/";
  protected override async Task OnInitializedAsync() {
    speakers = await httpClient.GetJsonAsync<Speaker[]>($"{baseUrl}api/Speaker");
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
