#pragma checksum "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Orcamento\OrcamentoView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1317b1e4696465728d39ac9299fc8b1c34e62985"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orcamento_OrcamentoView), @"mvc.1.0.view", @"/Views/Orcamento/OrcamentoView.cshtml")]
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
#line 1 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\_ViewImports.cshtml"
using Etapa_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\_ViewImports.cshtml"
using Etapa_3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1317b1e4696465728d39ac9299fc8b1c34e62985", @"/Views/Orcamento/OrcamentoView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc59671820634987c4d7240ade4c2ef2ee903c20", @"/Views/_ViewImports.cshtml")]
    public class Views_Orcamento_OrcamentoView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrcamentoPedido>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orcamento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TodosOrcamentos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Orcamento\OrcamentoView.cshtml"
  
    ViewData["Title"] = "Orçamentos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"view-orcamento margin-left\">\r\n    <h2>Nome: ");
#nullable restore
#line 7 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Orcamento\OrcamentoView.cshtml"
         Write(Model.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h3>Contato: ");
#nullable restore
#line 8 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Orcamento\OrcamentoView.cshtml"
            Write(Model.email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 8 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Orcamento\OrcamentoView.cshtml"
                           Write(Model.telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h3>Porpriedades:</h3>\r\n    <span>\r\n        iOs ");
#nullable restore
#line 11 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Orcamento\OrcamentoView.cshtml"
             if(Model.ios){

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>✔</span> ");
#nullable restore
#line 11 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Orcamento\OrcamentoView.cshtml"
                                           }else{

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>✖</span> ");
#nullable restore
#line 11 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Orcamento\OrcamentoView.cshtml"
                                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n        Android ");
#nullable restore
#line 12 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Orcamento\OrcamentoView.cshtml"
                 if(Model.android){

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>✔</span> ");
#nullable restore
#line 12 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Orcamento\OrcamentoView.cshtml"
                                                   }else{

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>✖</span> ");
#nullable restore
#line 12 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Orcamento\OrcamentoView.cshtml"
                                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n        Web ");
#nullable restore
#line 13 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Orcamento\OrcamentoView.cshtml"
             if(Model.web){

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>✔</span> ");
#nullable restore
#line 13 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Orcamento\OrcamentoView.cshtml"
                                           }else{

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>✖</span> ");
#nullable restore
#line 13 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Orcamento\OrcamentoView.cshtml"
                                                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n    </span>\r\n    <h3>Descrição:</h3>\r\n    <p class=\"box-view\">");
#nullable restore
#line 16 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Orcamento\OrcamentoView.cshtml"
                   Write(Model.descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 17 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Orcamento\OrcamentoView.cshtml"
     if(!Model.lido){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Marcar como ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1317b1e4696465728d39ac9299fc8b1c34e629858946", async() => {
                WriteLiteral("✔");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 607, "~/Orcamento/OrcamentoLido?id=", 607, 29, true);
#nullable restore
#line 18 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Orcamento\OrcamentoView.cshtml"
AddHtmlAttributeValue("", 636, Model.id, 636, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n");
#nullable restore
#line 19 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Orcamento\OrcamentoView.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1317b1e4696465728d39ac9299fc8b1c34e6298510816", async() => {
                WriteLiteral("Todos os orcamentos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrcamentoPedido> Html { get; private set; }
    }
}
#pragma warning restore 1591
