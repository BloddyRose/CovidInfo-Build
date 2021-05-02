// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CovidInfo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/bloddyrose/Projects/CovidInfoStatic/CovidInfo/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/bloddyrose/Projects/CovidInfoStatic/CovidInfo/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/bloddyrose/Projects/CovidInfoStatic/CovidInfo/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/bloddyrose/Projects/CovidInfoStatic/CovidInfo/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/bloddyrose/Projects/CovidInfoStatic/CovidInfo/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/bloddyrose/Projects/CovidInfoStatic/CovidInfo/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/bloddyrose/Projects/CovidInfoStatic/CovidInfo/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/bloddyrose/Projects/CovidInfoStatic/CovidInfo/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/bloddyrose/Projects/CovidInfoStatic/CovidInfo/_Imports.razor"
using CovidInfo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/bloddyrose/Projects/CovidInfoStatic/CovidInfo/_Imports.razor"
using CovidInfo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/bloddyrose/Projects/CovidInfoStatic/CovidInfo/_Imports.razor"
using RestSharp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/bloddyrose/Projects/CovidInfoStatic/CovidInfo/_Imports.razor"
using CovidInfo.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/bloddyrose/Projects/CovidInfoStatic/CovidInfo/_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "/home/bloddyrose/Projects/CovidInfoStatic/CovidInfo/Pages/Index.razor"
 
    private string date { get; set; }
    private string recovered { get; set; }
    private string cases { get; set; }
    private string deaths { get; set; }



protected async override Task OnInitializedAsync()
    {
        await RequestData();
    }

    private async Task RequestData()
    {
         try
         {
using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = await client.GetAsync("https://www.trackcorona.live/api/countries/ro");

                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                {
                    Console.Write("Error" + response.StatusCode);

                }
                string r = await response.Content.ReadAsStringAsync();

                DataSource data = DataSource.FromJson(r);

                    foreach(var item in data.Data)
                    {
                        date = item.Updated.ToString("dddd, dd MMMM yyyy");
                        recovered = item.Recovered .ToString("#,##0");
                        cases = item.Confirmed.ToString("#,##0");
                        deaths = item.Dead.ToString("#,##0");
                    }

            }
        

         }

         catch(Exception e)
         {
             Console.WriteLine(e.Message);
         }
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591