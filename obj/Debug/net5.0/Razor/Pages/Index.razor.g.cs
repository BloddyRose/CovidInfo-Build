#pragma checksum "/home/bloddyrose/Projects/CovidInfoStatic/CovidInfo/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77306c16d9523d30dcbce2b97a5a6bd4547f24e6"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<!DOCTYPE html>\n\n\n");
            __builder.OpenElement(1, "html");
            __builder.AddAttribute(2, "data-wf-domain", "bloddys-covid-info.webflow.io");
            __builder.AddAttribute(3, "data-wf-page", "608d62a11024a2458fa43632");
            __builder.AddAttribute(4, "data-wf-site", "608d62a11024a2963ba43631");
            __builder.AddAttribute(5, "data-wf-status", "1");
            __builder.AddMarkupContent(6, @"<head><meta charset=""utf-8"">
    <title>Bloddy&#x27;s Covid Info</title>
    <meta content=""width=device-width, initial-scale=1"" name=""viewport"">
    <meta content=""Webflow"" name=""generator"">
    <link href=""css/style.css"" rel=""stylesheet"" type=""text/css"">
    <link rel=""apple-touch-icon"" sizes=""180x180"" href=""image/apple-touch-icon.png"">
    <link rel=""icon"" type=""image/png"" sizes=""32x32"" href=""images/favicon-32x32.png"">
    <link rel=""icon"" type=""image/png"" sizes=""16x16"" href=""images/favicon-16x16.png"">
    <link rel=""manifest"" href=""images/site.webmanifest"">
    <link rel=""stylesheet"" href=""css/nav.css"" type=""text/css""></head>

");
            __builder.OpenElement(7, "body");
            __builder.AddAttribute(8, "class", "body");
            __builder.AddMarkupContent(9, @"<header id=""nav"" class=""sticky-nav""><div class=""topnav""><a href=""#home"" class=""active"">Covid Info</a>
   
   <div id=""myLinks""><a href>Github</a>
     
     <a href=""https://github.com/BloddyRose"" target=""_blank"">About</a></div>
   
   <a href=""javascript:void(0);"" class=""icon"" onclick=""myFunction()""><i class=""fa fa-bars""></i></a></div></header>
    ");
            __builder.AddMarkupContent(10, "<div class=\"section sectiontext\"><h1 class=\"heading-2\">Romania</h1>\n        <img src=\"images/RO-Romania-Flag-icon.png\" loading=\"lazy\" width=\"70\" alt class=\"image\"></div>\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "container w-container");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "columns w-row");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "column-2 w-col w-col-3");
            __builder.AddMarkupContent(17, "<h1 class=\"heading-3\">Date</h1>\n                ");
            __builder.OpenElement(18, "div");
            __builder.AddContent(19, 
#nullable restore
#line 48 "/home/bloddyrose/Projects/CovidInfoStatic/CovidInfo/Pages/Index.razor"
                      date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "column-3 w-col w-col-3");
            __builder.AddMarkupContent(23, "<h1 class=\"heading-4\">Recoverd</h1>\n                ");
            __builder.OpenElement(24, "div");
            __builder.AddContent(25, 
#nullable restore
#line 52 "/home/bloddyrose/Projects/CovidInfoStatic/CovidInfo/Pages/Index.razor"
                      recovered

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n            ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "column-4 w-col w-col-3");
            __builder.AddMarkupContent(29, "<h1 class=\"heading-5\">Cases</h1>\n                ");
            __builder.OpenElement(30, "div");
            __builder.AddContent(31, 
#nullable restore
#line 56 "/home/bloddyrose/Projects/CovidInfoStatic/CovidInfo/Pages/Index.razor"
                      cases

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "column4 w-col w-col-3");
            __builder.AddMarkupContent(35, "<h1 class=\"heading-6\">Deaths</h1>\n                ");
            __builder.OpenElement(36, "div");
            __builder.AddContent(37, 
#nullable restore
#line 60 "/home/bloddyrose/Projects/CovidInfoStatic/CovidInfo/Pages/Index.razor"
                      deaths

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n    ");
            __builder.AddMarkupContent(39, "<footer id=\"footer\" class=\"footer\"><div class=\"w-container\"><div>Copyright ?? 2020 BloddyRose. All rights reserved.</div></div></footer>\n    ");
            __builder.AddMarkupContent(40, "<style>\n        .tip {\n            text-align: center;\n            text-decoration: underline;\n        }\n    </style>\n    ");
            __builder.AddMarkupContent(41, "<p class=\"tip\">Tip : If the data was not loaded press a second time on the button or refresh the page!</p>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "/home/bloddyrose/Projects/CovidInfoStatic/CovidInfo/Pages/Index.razor"
 
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
