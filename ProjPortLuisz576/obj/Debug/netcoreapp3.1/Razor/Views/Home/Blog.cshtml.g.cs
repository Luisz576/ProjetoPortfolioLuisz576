#pragma checksum "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ef94f7a6a662b3e3221fab8172b944ff0273556"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Blog), @"mvc.1.0.view", @"/Views/Home/Blog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ef94f7a6a662b3e3221fab8172b944ff0273556", @"/Views/Home/Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc59671820634987c4d7240ade4c2ef2ee903c20", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BlogItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: #fff;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovoPostBlog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
  
    ViewData["Title"] = "Blog";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--BLOG-->\r\n<section class=\"container\">\r\n    <h2>MyBlog.exe</h2>\r\n");
#nullable restore
#line 8 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
     if(Model != null){
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
         if(Model.Count > 0){
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
             foreach (BlogItem blog in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card\" style=\"width: 100%; margin-bottom: 20px;\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 14 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
                                          Write(blog.titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
                                                             if(ViewBag.logged){

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ef94f7a6a662b3e3221fab8172b944ff02735566262", async() => {
                WriteLiteral(" - EDITAR");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 461, "~/Home/EditarBlogPost?id=", 461, 25, true);
#nullable restore
#line 14 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
AddHtmlAttributeValue("", 486, blog.id, 486, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ef94f7a6a662b3e3221fab8172b944ff02735567928", async() => {
                WriteLiteral(" - REMOVE");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 540, "~/Home/RemovePostBlog?id=", 540, 25, true);
#nullable restore
#line 14 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
AddHtmlAttributeValue("", 565, blog.id, 565, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
                                                                                                                                                                                                                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text conteudo-blog\">");
#nullable restore
#line 15 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
                                                      Write(Html.Raw(blog.conteudo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 18 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"grid-16\">\r\n");
#nullable restore
#line 20 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
                 if(ViewBag.previousPage > 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ef94f7a6a662b3e3221fab8172b944ff027355611143", async() => {
                WriteLiteral("<button type=\"button\" class=\"btn btn-dark\">Anterior</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 886, "~/Home/Blog?page=", 886, 17, true);
#nullable restore
#line 21 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
AddHtmlAttributeValue("", 903, ViewBag.previousPage, 903, 21, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
                }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\" class=\"btn btn-dark\" disabled>Anterior</button>\r\n");
#nullable restore
#line 24 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
                 if(ViewBag.nextPage > 1){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ef94f7a6a662b3e3221fab8172b944ff027355613687", async() => {
                WriteLiteral("<button type=\"button\" class=\"btn btn-dark\">Próximo</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1199, "~/Home/Blog?page=", 1199, 17, true);
#nullable restore
#line 26 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
AddHtmlAttributeValue("", 1216, ViewBag.nextPage, 1216, 17, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
                }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"button\" class=\"btn btn-dark\" disabled>Próximo</button>\r\n");
#nullable restore
#line 29 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 31 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
        }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>Nenhum post encontrado :(</h2>\r\n");
#nullable restore
#line 33 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
         
    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>Blog indisponivel no momento :(</h2>\r\n");
#nullable restore
#line 36 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
     if(ViewBag.logged){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"grid-16\" style=\"height: 20px; margin-bottom: 80px;\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ef94f7a6a662b3e3221fab8172b944ff027355617397", async() => {
                WriteLiteral("<button type=\"button\" class=\"btn btn-primary\">Novo Post</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 41 "C:\Users\lrfer\OneDrive\Documentos\Luiz Ricardo Ferlin Alves\Tecnico\Módulo II\Projeto Integrador\Etapa 5\Views\Home\Blog.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BlogItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
