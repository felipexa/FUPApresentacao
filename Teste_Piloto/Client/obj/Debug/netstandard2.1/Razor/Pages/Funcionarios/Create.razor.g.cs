#pragma checksum "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Funcionarios\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0caeff497355d8af12cafdb2eaa94d99982730c6"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/funcionarios/criar")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CADASTRAR NOVO FUNCIONÁRIO</h3>\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Teste_Piloto.Client.Pages.Funcionarios.PageFuncionario>(1);
            __builder.AddAttribute(2, "Funcionario", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Faculdade_FUP_Project.Server.Models.Funcionario>(
#nullable restore
#line 9 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Funcionarios\Create.razor"
                              funcionario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ButtonText", "Adicionar");
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Funcionarios\Create.razor"
                                                                                  Criar

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Funcionarios\Create.razor"
       
    private Funcionario funcionario = new Funcionario();
    async Task Criar()
    {
        await http.PostAsJsonAsync("api/funcionarios", funcionario);
        navigation.NavigateTo("funcionarios");
    }
    //private async Task Criar()
    //{
    //    Console.WriteLine("Create method");
    //    Console.WriteLine(curso.NomeCurso);

    //    try
    //    {
    //        await cursoRepository.CreateCurso(curso);
    //        navigation.NavigateTo("cursos");
    //    }
    //    catch (Exception ex)
    //    {
    //        // ...
    //        Console.WriteLine(ex.Message);
    //    }
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
