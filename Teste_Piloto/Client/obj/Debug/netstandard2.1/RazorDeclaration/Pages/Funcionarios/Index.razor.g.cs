#pragma checksum "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Funcionarios\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5387c5175b0971c6d23d459c5f487cad0c283d89"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Teste_Piloto.Client.Pages.Funcionarios
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
#nullable restore
#line 2 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Funcionarios\Index.razor"
using Faculdade_FUP_Project.Server.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Funcionarios")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Funcionarios\Index.razor"
       
    public List<Funcionario> funcionarios;
    protected override async Task OnInitializedAsync()
    {
        await LoadFuncionarios();
    }
    async Task LoadFuncionarios()
    {
        funcionarios = await http.GetFromJsonAsync<List<Funcionario>>("api/funcionarios");
    }
    async Task ExcluirFuncionario(int id)
    {
        await http.DeleteAsync($"api/funcionarios/{id}");
        await LoadFuncionarios();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
