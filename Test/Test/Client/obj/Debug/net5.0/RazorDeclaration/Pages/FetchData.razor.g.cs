// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Test.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using Test.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/_Imports.razor"
using Test.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/Pages/FetchData.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/Pages/FetchData.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/Pages/FetchData.razor"
using Test.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/Pages/FetchData.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "/Users/nagul/Library/CloudStorage/OneDrive-TemasekPolytechnic/School/Y2S4/FSD-Project/Test/Test/Client/Pages/FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
