#pragma checksum "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Finaceiros\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd1f3c3cbc9a990d80800cd16cebadac28af702a"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/financeiro")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Finaceiros\Index.razor"
 if (financeiros == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "Carregando!!!");
#nullable restore
#line 5 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Finaceiros\Index.razor"
                               }
else if (financeiros.Count == 0)
{


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<div>\r\n    <a href=\"financeiros/criar\" value=\"Criar\">\r\n        <button class=\"btn-criar roboto rounded-pill border-0 my-5\">Criar</button>\r\n    </a>\r\n</div>\r\n");
#nullable restore
#line 14 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Finaceiros\Index.razor"
     }
else
    {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<div>\r\n    <a href=\"financeiros/criar\" value=\"Criar\">\r\n        <button class=\"btn-criar roboto rounded-pill border-0 my-5\">Criar</button>\r\n    </a>\r\n</div>\r\n");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table roboto text-uppercase font-tabela");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddMarkupContent(6, "<thead>\r\n        <tr>\r\n            <th>Entrada</th>\r\n            <th>Saida</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(7, "tbody");
            __builder.AddAttribute(8, "class", "table roboto text-uppercase font-tabela");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 32 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Finaceiros\Index.razor"
         foreach (var financeiros in financeiros)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 36 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Finaceiros\Index.razor"
                     financeiros.Entrada

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 37 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Finaceiros\Index.razor"
                     financeiros.Saida

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "class", "button-geral");
            __builder.AddAttribute(23, "href", "financeiros/edit/" + (
#nullable restore
#line 39 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Finaceiros\Index.razor"
                                                                    financeiros.FinanceiroId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                \r\n                    ");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "class", "button-geral");
            __builder.AddAttribute(28, "href", "financeiros/details/" + (
#nullable restore
#line 41 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Finaceiros\Index.razor"
                                                                       financeiros.FinanceiroId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Detalhes");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                \r\n                    ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "style", "cursor:pointer");
            __builder.AddAttribute(33, "class", "button-geral");
            __builder.AddAttribute(34, "btn", true);
            __builder.AddAttribute(35, "btn-danger", true);
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Finaceiros\Index.razor"
                                                                                               () => ExcluirFinanceiro(financeiros.FinanceiroId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, " Delete ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 46 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Finaceiros\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 49 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Finaceiros\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\felii\Desktop\BlazorFUPFROnt\BlazorComFrontFUP\Teste_Piloto\Client\Pages\Finaceiros\Index.razor"
       public List<Financeiro> financeiros;
protected override async Task OnInitializedAsync()
{
    await LoadFinanceiro();
}
async Task LoadFinanceiro()
{
    financeiros = await http.GetFromJsonAsync<List<Financeiro>>("api/financeiros");
}
async Task ExcluirFinanceiro(int id)
{
    await http.DeleteAsync($"api/financeiros/{id}");
    await LoadFinanceiro();
}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591