#pragma checksum "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Finaceiros\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb493169f196fbb9e98a0ac6447f32c117492712"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Teste_Piloto.Client.Pages.Finaceiros
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\_Imports.razor"
using Teste_Piloto.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\_Imports.razor"
using Teste_Piloto.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\_Imports.razor"
using Faculdade_FUP_Project.Server.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\_Imports.razor"
using Teste_Piloto.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/financeiros/details/{id:int}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Finaceiros\Details.razor"
        
    private Financeiro financeiro = new Financeiro();
        [Parameter] public int id { get; set; }
            protected override async Task OnParametersSetAsync() // é chamado qd o roteamento passar o valor para a propriedade
            {
                financeiro = await http.GetFromJsonAsync<Financeiro>($"api/financeiros/{id}");
            }

            async Task DetalhesFinaceiro()
            {
                await http.PutAsJsonAsync("api/financeiro", financeiro);
                navigation.NavigateTo("financeiro");
            } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
