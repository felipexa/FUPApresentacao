#pragma checksum "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Finaceiros\Creat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f66e5eb89f475cb12a38a02e7feea39bf7c4de00"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/financeiros/criar")]
    public partial class Creat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Finaceiros\Creat.razor"
        
    private Financeiro financeiro = new Financeiro();
            async Task Criar()
            {
                await http.PostAsJsonAsync("api/financeiros", financeiro);
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
