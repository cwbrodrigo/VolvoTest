#pragma checksum "C:\Users\leona\Documents\Volvo\VolvoTest\TesteVolvo\TesteVolvo.WebApplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b46800d2aec7269b5a725451f9211c9d9d47e5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\leona\Documents\Volvo\VolvoTest\TesteVolvo\TesteVolvo.WebApplication\Views\_ViewImports.cshtml"
using TesteVolvo.WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leona\Documents\Volvo\VolvoTest\TesteVolvo\TesteVolvo.WebApplication\Views\_ViewImports.cshtml"
using TesteVolvo.WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b46800d2aec7269b5a725451f9211c9d9d47e5f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05b5e1ef6c9a6918128a490c5f1a047691cb0b11", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TesteVolvo.Domain.Caminhao>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Insert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    .buttonEdit {
        background-color: Transparent;
        background-repeat: no-repeat;
        border: none;
        cursor: pointer;
        overflow: hidden;
        outline: none;
    }
</style>

<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header card-header-success"">
                    <h4 class=""card-title "">Lista de caminhões</h4>
                    <p class=""card-category""> Listagem de camonhões do sistema</p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b46800d2aec7269b5a725451f9211c9d9d47e5f4830", async() => {
                WriteLiteral("\r\n                        <button class=\"btn float-right btn-success\" title=\"Adicionar novo caminhão\" rel=\"tooltip\"><i class=\"fa fa-plus fa-2x\"></i></button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table table-hover"">
                            <thead class="" text-default"">
                                <tr>
                                    <th>
                                        ID
                                    </th>
                                    <th>
                                        Nome
                                    </th>
                                    <th>
                                        Modelo
                                    </th>
                                    <th>
                                        Ano de Fabricação
                                    </th>
                                    <th>
                                        Modelo
                                    </th>
                                    <th>
                                     ");
            WriteLiteral("   Ações\r\n                                    </th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 51 "C:\Users\leona\Documents\Volvo\VolvoTest\TesteVolvo\TesteVolvo.WebApplication\Views\Home\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 55 "C:\Users\leona\Documents\Volvo\VolvoTest\TesteVolvo\TesteVolvo.WebApplication\Views\Home\Index.cshtml"
                                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 58 "C:\Users\leona\Documents\Volvo\VolvoTest\TesteVolvo\TesteVolvo.WebApplication\Views\Home\Index.cshtml"
                                       Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 61 "C:\Users\leona\Documents\Volvo\VolvoTest\TesteVolvo\TesteVolvo.WebApplication\Views\Home\Index.cshtml"
                                       Write(item.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 64 "C:\Users\leona\Documents\Volvo\VolvoTest\TesteVolvo\TesteVolvo.WebApplication\Views\Home\Index.cshtml"
                                       Write(item.AnoFabricacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 67 "C:\Users\leona\Documents\Volvo\VolvoTest\TesteVolvo\TesteVolvo.WebApplication\Views\Home\Index.cshtml"
                                       Write(item.AnoModelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"td-actions\">\r\n                                            <div");
            BeginWriteAttribute("class", " class=\"", 3073, "\"", 3081, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <button type=\"button\" rel=\"tooltip\" class=\"btn btn-success btn-round\" title=\"Editar\" id=\"btnEdit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3230, "\"", 3306, 3);
            WriteAttributeValue("", 3240, "location.href=\'", 3240, 15, true);
#nullable restore
#line 71 "C:\Users\leona\Documents\Volvo\VolvoTest\TesteVolvo\TesteVolvo.WebApplication\Views\Home\Index.cshtml"
WriteAttributeValue("", 3255, Url.Action("Update", "Home", new { id = item.Id}), 3255, 50, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3305, "\'", 3305, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <i class=""material-icons"">edit</i>
                                                    <div class=""ripple-container""></div>
                                                </button>
                                                <button type=""button"" rel=""tooltip"" class=""btn btn-danger btn-round"" title=""Excluir""");
            BeginWriteAttribute("onclick", " onclick=\"", 3679, "\"", 3756, 3);
            WriteAttributeValue("", 3689, "location.href=\'", 3689, 15, true);
#nullable restore
#line 75 "C:\Users\leona\Documents\Volvo\VolvoTest\TesteVolvo\TesteVolvo.WebApplication\Views\Home\Index.cshtml"
WriteAttributeValue("", 3704, Url.Action("Excluir", "Home", new { id = item.Id}), 3704, 51, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3755, "\'", 3755, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <i class=""material-icons"">close</i>
                                                </button>
                                            </div>
                                        </td>
                                    </tr>
");
#nullable restore
#line 81 "C:\Users\leona\Documents\Volvo\VolvoTest\TesteVolvo\TesteVolvo.WebApplication\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    $(document).ready(function () {\r\n\r\n    })\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TesteVolvo.Domain.Caminhao>> Html { get; private set; }
    }
}
#pragma warning restore 1591
