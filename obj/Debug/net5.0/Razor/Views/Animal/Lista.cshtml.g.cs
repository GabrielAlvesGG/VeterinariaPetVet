#pragma checksum "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\petVet\Views\Animal\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ec764db1f21a56621dafa5847a5d33b0331254f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Animal_Lista), @"mvc.1.0.view", @"/Views/Animal/Lista.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\petVet\Views\_ViewImports.cshtml"
using petVet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\petVet\Views\_ViewImports.cshtml"
using petVet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ec764db1f21a56621dafa5847a5d33b0331254f", @"/Views/Animal/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb92b3f72e3236039daf744ad8123031be8bfabb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Animal_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Animal>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1 align=""center"">Lista de Serviços</h1>
<table border=""1"" align=""center"" cellpadding=""0"" cellspacing=""0"">
    <thead align=""center"">
        <tr>
            <th colspan=""7"">Tabela de Serviços solicitados</th>
        </tr>
        <tr>
            <th>Nome do dono</th>
            <th>nome do animal</th>
            <th>Idade do animal</th>
            <th>Tipo de animal</th>
            <th>Operadores</th>
            
            
            
        </tr>
    </thead>
    <tbody align=""center"">
");
#nullable restore
#line 20 "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\petVet\Views\Animal\Lista.cshtml"
         foreach (Animal item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\petVet\Views\Animal\Lista.cshtml"
           Write(item.idPet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\petVet\Views\Animal\Lista.cshtml"
           Write(item.nomeAnimal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\petVet\Views\Animal\Lista.cshtml"
           Write(item.idadeAnimal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\petVet\Views\Animal\Lista.cshtml"
           Write(item.tipoAnimal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 800, "\"", 840, 2);
            WriteAttributeValue("", 807, "/Animal/Excluir?idPet=", 807, 22, true);
#nullable restore
#line 28 "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\petVet\Views\Animal\Lista.cshtml"
WriteAttributeValue("", 829, item.idPet, 829, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Remover</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 873, "\"", 915, 2);
            WriteAttributeValue("", 880, "/Animal/Atualizar?idPet=", 880, 24, true);
#nullable restore
#line 29 "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\petVet\Views\Animal\Lista.cshtml"
WriteAttributeValue("", 904, item.idPet, 904, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\alves\OneDrive\Documentos\atividades do senac\mvc\petVet\Views\Animal\Lista.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td colspan=\"7\">Valor total de serviços cobrados :</td>\r\n        </tr>\r\n    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Animal>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
