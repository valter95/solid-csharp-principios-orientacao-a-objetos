#pragma checksum "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e277b487483788f6cfd1cbb6160c64fea1a984d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Leilao_Index), @"mvc.1.0.view", @"/Views/Leilao/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\_ViewImports.cshtml"
using Alura.LeilaoOnline.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\_ViewImports.cshtml"
using Alura.LeilaoOnline.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e277b487483788f6cfd1cbb6160c64fea1a984d", @"/Views/Leilao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b73feb13f73acfcd6ba9bb4378b1af15ffd8e98f", @"/Views/_ViewImports.cshtml")]
    public class Views_Leilao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Leilao>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Leilao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Insert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Inclusão"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pesquisa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Edição"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Inicia", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Finaliza", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
  
    ViewData["Title"] = "Leilões";
    var termo = ViewData["termo"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"card\">\n    <div class=\"card-header d-flex\">\n        <h4 class=\"flex-grow-1\">Leilões</h4>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e277b487483788f6cfd1cbb6160c64fea1a984d8052", async() => {
                WriteLiteral("\n            <i class=\"fa fa-plus\" aria-hidden=\"true\"></i>\n            Novo\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n    <div class=\"card-body\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e277b487483788f6cfd1cbb6160c64fea1a984d9713", async() => {
                WriteLiteral("\n            <input name=\"termo\" class=\"form-control flex-grow-1\"");
                BeginWriteAttribute("value", "\n                    value=\"", 600, "\"", 634, 1);
#nullable restore
#line 19 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
WriteAttributeValue("", 628, termo, 628, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                    placeholder=""Pesquisar por título, categoria ou descrição..."" />
            <button class=""btn btn-outline-secondary ml-2"">
                <i class=""fa fa-search""></i>
                <span class=""d-none d-md-inline"">Pesquisar</span>
            </button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <div class=""row"">
            <div class=""col-12"">
                <table class=""col-12 table table-striped"">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Título</th>
                            <th>Situação</th>
                            <th>Descrição</th>
                            <th>Ações</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 39 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                         foreach(var leilao in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("class", " class=\"", 1523, "\"", 1552, 2);
            WriteAttributeValue("", 1531, "row-leilao-", 1531, 11, true);
#nullable restore
#line 41 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
WriteAttributeValue("", 1542, leilao.Id, 1542, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                <td>");
#nullable restore
#line 42 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                               Write(leilao.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 43 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                               Write(leilao.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>\n");
#nullable restore
#line 45 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                                     switch (leilao.Situacao)
                                    {
                                        case SituacaoLeilao.Rascunho:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>Rascunho</span>\n");
#nullable restore
#line 49 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                                            break;
                                        case SituacaoLeilao.Pregao:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>Pregão iniciado em ");
#nullable restore
#line 51 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                                                                Write(leilao.Inicio.Value.ToString("dd/MM/yyyy hh:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 52 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                                            break;
                                        case SituacaoLeilao.Finalizado:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>Finalizado em ");
#nullable restore
#line 54 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                                                           Write(leilao.Termino.Value.ToString("dd/MM/yyyy hh:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 55 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                                            break;
                                        default:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>");
#nullable restore
#line 57 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                                             Write(leilao.Situacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 58 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                                            break;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\n                                <td>");
#nullable restore
#line 61 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                               Write(leilao.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>\n");
#nullable restore
#line 63 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                                     if (leilao.Situacao == SituacaoLeilao.Rascunho)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e277b487483788f6cfd1cbb6160c64fea1a984d18405", async() => {
                WriteLiteral("\n                                            <i class=\"fa fa-pencil-alt\" aria-hidden=\"true\"></i>\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                                                                                                             WriteLiteral(leilao.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e277b487483788f6cfd1cbb6160c64fea1a984d21223", async() => {
                WriteLiteral("\n                                            <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 3377, "\"", 3395, 1);
#nullable restore
#line 69 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
WriteAttributeValue("", 3385, leilao.Id, 3385, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                            <button class=""btn btn-light"" title=""Iniciar Pregão"">
                                                <i class=""fas fa-play-circle""></i>
                                            </button>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 74 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                                     if (leilao.Situacao != SituacaoLeilao.Pregao)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"btn btn-light btnRemoveLeilao\" data-id=\"");
#nullable restore
#line 77 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                                                                                     Write(leilao.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-titulo=\"");
#nullable restore
#line 77 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                                                                                                              Write(leilao.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" title=\"Exclusão\">\n                                            <i class=\"fa fa-trash\" aria-hidden=\"true\"></i>\n                                        </a>\n");
#nullable restore
#line 80 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                                     if (leilao.Situacao == SituacaoLeilao.Pregao)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e277b487483788f6cfd1cbb6160c64fea1a984d25696", async() => {
                WriteLiteral("\n                                            <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 4429, "\"", 4447, 1);
#nullable restore
#line 84 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
WriteAttributeValue("", 4437, leilao.Id, 4437, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                            <button class=""btn btn-light"" title=""Finalizar Pregão"">
                                                <i class=""fas fa-stop-circle""></i>
                                            </button>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 89 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\n                            </tr>\n");
#nullable restore
#line 92 "C:\Users\Valtinho\Programas\solid-csharp-principios-orientacao-a-objetos\src\Alura.LeilaoOnline.WebApp\Views\Leilao\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Leilao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
