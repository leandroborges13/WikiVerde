#pragma checksum "C:\Users\leandro.borges\source\repos\wikiVerde\WikiVerde\WikiVerde\Views\Plantas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12fa7bf2b40d8acf19d35693c187536aca1f0590"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Plantas_Index), @"mvc.1.0.view", @"/Views/Plantas/Index.cshtml")]
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
#line 1 "C:\Users\leandro.borges\source\repos\wikiVerde\WikiVerde\WikiVerde\Views\_ViewImports.cshtml"
using WikeVerde;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leandro.borges\source\repos\wikiVerde\WikiVerde\WikiVerde\Views\_ViewImports.cshtml"
using WikeVerde.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12fa7bf2b40d8acf19d35693c187536aca1f0590", @"/Views/Plantas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70b061cd5def9511fbcbf87b17b1683c9656ebcc", @"/Views/_ViewImports.cshtml")]
    public class Views_Plantas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WikiVerde.Models.Planta>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\leandro.borges\source\repos\wikiVerde\WikiVerde\WikiVerde\Views\Plantas\Index.cshtml"
   ViewBag.Title = "Todas as Anotações";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 3 "C:\Users\leandro.borges\source\repos\wikiVerde\WikiVerde\WikiVerde\Views\Plantas\Index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Nome</th>\r\n        <th>Descrição</th>\r\n        <th>Deletar</th>\r\n    </tr>\r\n");
#nullable restore
#line 11 "C:\Users\leandro.borges\source\repos\wikiVerde\WikiVerde\WikiVerde\Views\Plantas\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 346, "\"", 374, 2);
            WriteAttributeValue("", 353, "Plantas/Edit/", 353, 13, true);
#nullable restore
#line 15 "C:\Users\leandro.borges\source\repos\wikiVerde\WikiVerde\WikiVerde\Views\Plantas\Index.cshtml"
WriteAttributeValue("", 366, item.Id, 366, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 16 "C:\Users\leandro.borges\source\repos\wikiVerde\WikiVerde\WikiVerde\Views\Plantas\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 485, "\"", 513, 2);
            WriteAttributeValue("", 492, "Plantas/Edit/", 492, 13, true);
#nullable restore
#line 20 "C:\Users\leandro.borges\source\repos\wikiVerde\WikiVerde\WikiVerde\Views\Plantas\Index.cshtml"
WriteAttributeValue("", 505, item.Id, 505, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 21 "C:\Users\leandro.borges\source\repos\wikiVerde\WikiVerde\WikiVerde\Views\Plantas\Index.cshtml"
               Write(item.NomeCientifico);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 636, "\"", 664, 2);
            WriteAttributeValue("", 643, "Plantas/Edit/", 643, 13, true);
#nullable restore
#line 25 "C:\Users\leandro.borges\source\repos\wikiVerde\WikiVerde\WikiVerde\Views\Plantas\Index.cshtml"
WriteAttributeValue("", 656, item.Id, 656, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 26 "C:\Users\leandro.borges\source\repos\wikiVerde\WikiVerde\WikiVerde\Views\Plantas\Index.cshtml"
               Write(item.DscEspecie);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 783, "\"", 813, 2);
            WriteAttributeValue("", 790, "Plantas/Delete/", 790, 15, true);
#nullable restore
#line 30 "C:\Users\leandro.borges\source\repos\wikiVerde\WikiVerde\WikiVerde\Views\Plantas\Index.cshtml"
WriteAttributeValue("", 805, item.Id, 805, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">deletar</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\leandro.borges\source\repos\wikiVerde\WikiVerde\WikiVerde\Views\Plantas\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WikiVerde.Models.Planta>> Html { get; private set; }
    }
}
#pragma warning restore 1591
