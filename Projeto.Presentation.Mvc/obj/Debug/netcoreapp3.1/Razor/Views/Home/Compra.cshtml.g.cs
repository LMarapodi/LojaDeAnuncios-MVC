#pragma checksum "C:\Users\lucas\Desktop\GHub\ProjetoMvcLoja\Projeto.Presentation.Mvc\Views\Home\Compra.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d76bd8ebc5960cbcf91fcdd7d60917a43ecfb9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Compra), @"mvc.1.0.view", @"/Views/Home/Compra.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d76bd8ebc5960cbcf91fcdd7d60917a43ecfb9a", @"/Views/Home/Compra.cshtml")]
    public class Views_Home_Compra : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projeto.Presentation.Mvc.Models.ProdutoModels.ProdutoCompraModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\lucas\Desktop\GHub\ProjetoMvcLoja\Projeto.Presentation.Mvc\Views\Home\Compra.cshtml"
  
    ViewData["Title"] = "Compra";
    Layout = "~/Views/Shared/LayoutBase.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\lucas\Desktop\GHub\ProjetoMvcLoja\Projeto.Presentation.Mvc\Views\Home\Compra.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container mt-3\">\r\n\r\n\r\n        <h2>Preencha os campos para realizar a compra   </h2>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\lucas\Desktop\GHub\ProjetoMvcLoja\Projeto.Presentation.Mvc\Views\Home\Compra.cshtml"
         if (TempData["MensagemSucesso"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\r\n                <strong>");
#nullable restore
#line 20 "C:\Users\lucas\Desktop\GHub\ProjetoMvcLoja\Projeto.Presentation.Mvc\Views\Home\Compra.cshtml"
                   Write(TempData["MensagemSucesso"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                    <span aria-hidden=\"true\">&times;</span>\r\n                </button>\r\n            </div>\r\n");
#nullable restore
#line 25 "C:\Users\lucas\Desktop\GHub\ProjetoMvcLoja\Projeto.Presentation.Mvc\Views\Home\Compra.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\lucas\Desktop\GHub\ProjetoMvcLoja\Projeto.Presentation.Mvc\Views\Home\Compra.cshtml"
         if (TempData["MensagemErro"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger alert-dismissible fade show\" role=\"alert\">\r\n                <strong>");
#nullable restore
#line 30 "C:\Users\lucas\Desktop\GHub\ProjetoMvcLoja\Projeto.Presentation.Mvc\Views\Home\Compra.cshtml"
                   Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n                    <span aria-hidden=\"true\">&times;</span>\r\n                </button>\r\n            </div>\r\n");
#nullable restore
#line 35 "C:\Users\lucas\Desktop\GHub\ProjetoMvcLoja\Projeto.Presentation.Mvc\Views\Home\Compra.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        <label>Seu Nome:</label>\r\n        ");
#nullable restore
#line 40 "C:\Users\lucas\Desktop\GHub\ProjetoMvcLoja\Projeto.Presentation.Mvc\Views\Home\Compra.cshtml"
   Write(Html.TextBoxFor(model => model.Nome, new
    {
        @class = "form-control col-md-4",
        @placeholder = "Digite Aqui"
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <span class=\"text-danger\">\r\n            ");
#nullable restore
#line 46 "C:\Users\lucas\Desktop\GHub\ProjetoMvcLoja\Projeto.Presentation.Mvc\Views\Home\Compra.cshtml"
       Write(Html.ValidationMessageFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n        <br />\r\n\r\n        <label>Seu Endereço :</label>\r\n        ");
#nullable restore
#line 51 "C:\Users\lucas\Desktop\GHub\ProjetoMvcLoja\Projeto.Presentation.Mvc\Views\Home\Compra.cshtml"
   Write(Html.TextBoxFor(model => model.Local, new
    {
        @class = "form-control col-md-4",
        @placeholder = "Digite Aqui"
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <span class=\"text-danger\">\r\n            ");
#nullable restore
#line 57 "C:\Users\lucas\Desktop\GHub\ProjetoMvcLoja\Projeto.Presentation.Mvc\Views\Home\Compra.cshtml"
       Write(Html.ValidationMessageFor(model => model.Local));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n        <br />\r\n        <label>Cartão para o Pagamento:</label>\r\n        ");
#nullable restore
#line 61 "C:\Users\lucas\Desktop\GHub\ProjetoMvcLoja\Projeto.Presentation.Mvc\Views\Home\Compra.cshtml"
   Write(Html.TextBoxFor(model => model.Cartao, new
    {
        @class = "form-control col-md-4",
        @placeholder = "ex : 12345678"
    }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <span class=\"text-danger\">\r\n            ");
#nullable restore
#line 67 "C:\Users\lucas\Desktop\GHub\ProjetoMvcLoja\Projeto.Presentation.Mvc\Views\Home\Compra.cshtml"
       Write(Html.ValidationMessageFor(model => model.Cartao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </span>\r\n        <br />\r\n        <br />\r\n        <input type=\"submit\" value=\"Realizar a Compra\"\r\n               class=\"btn btn-success btn-sm\" />\r\n    </div>\r\n");
#nullable restore
#line 74 "C:\Users\lucas\Desktop\GHub\ProjetoMvcLoja\Projeto.Presentation.Mvc\Views\Home\Compra.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projeto.Presentation.Mvc.Models.ProdutoModels.ProdutoCompraModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
