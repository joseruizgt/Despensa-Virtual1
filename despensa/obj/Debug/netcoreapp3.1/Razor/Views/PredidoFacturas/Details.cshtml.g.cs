#pragma checksum "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28cbef728711f177bedb381fd01a9980d93bdba7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PredidoFacturas_Details), @"mvc.1.0.view", @"/Views/PredidoFacturas/Details.cshtml")]
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
#line 1 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\_ViewImports.cshtml"
using despensa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\_ViewImports.cshtml"
using despensa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28cbef728711f177bedb381fd01a9980d93bdba7", @"/Views/PredidoFacturas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f631de54767318e1d6dbe9f06728805a3ae1783", @"/Views/_ViewImports.cshtml")]
    public class Views_PredidoFacturas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<despensa.Models.PredidoFactura>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PedidosPendientes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TodosPedidos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h3 class=""tittle-w3l"">
    Mi Pedido
    <span class=""heading-style"">
        <i></i>
        <i></i>
        <i></i>
    </span>
</h3>
<div class=""container"">

    <style>
        .dato-cliente {
            padding: 15px;
            padding-right: 25px;
            padding-left: 25px;
            background-color: transparent;
            border: 2px solid blue;
            margin: 10px;
            border-radius: 10px;
            background-color: rgba(0, 110, 255, 0.2);
        }

        .dato-empleado {
            padding: 15px;
            padding-right: 25px;
            padding-left: 25px;
            background-color: transparent;
            border: 2px solid #ff5722;
            margin: 10px;
            border-radius: 10px;
            background-color: rgba(255, 87, 34, 0.2);
        }

        .titulo {
            width: 50px;
            font-size: 18px;
            margin-top: -12px;
            margin-left: 7px;
            background: white;
     ");
            WriteLiteral(@"   }
    </style>
    <!-- Stack the columns on mobile by making one full-width and the other half-width -->
    <div class=""dato-cliente"">
        <div class=""row"">
            <div class=""col-6 col-md-4"">
                <div>Fecha de Emisión</div>
                <div class=""well""><span>");
#nullable restore
#line 52 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.FecEmision));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n            </div>\r\n            <div class=\"col-6 col-md-4\">\r\n                <div>Nombres</div>\r\n                <div class=\"well\"><span>");
#nullable restore
#line 56 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.CodClienteNavigation.PrimerNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 56 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
                                                                                                      Write(Html.DisplayFor(model => model.CodClienteNavigation.SegundoNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n            </div>\r\n            <div class=\"col-6 col-md-4\">\r\n                <div>Apellidos</div>\r\n                <div class=\"well\"><span>");
#nullable restore
#line 60 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.CodClienteNavigation.PrimerApellido));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 60 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
                                                                                                        Write(Html.DisplayFor(model => model.CodClienteNavigation.SegundoApellido));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
            </div>
        </div>
    </div>
    <!-- Columns are always 50% wide, on mobile and desktop -->
    <div class=""dato-empleado"">
        <div class=""row"">
            <div class=""col-6 col-md-6"">
                <div>Nombres</div>
                <div class=""well""><span>");
#nullable restore
#line 69 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.CodEmpleadoNavigation.PrimerNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 69 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
                                                                                                       Write(Html.DisplayFor(model => model.CodEmpleadoNavigation.SegundoNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n            </div>\r\n            <div class=\"col-6 col-md-6\">\r\n                <div>Apellidos</div>\r\n                <div class=\"well\"><span>");
#nullable restore
#line 73 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.CodEmpleadoNavigation.PrimerApellido));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 73 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
                                                                                                         Write(Html.DisplayFor(model => model.CodEmpleadoNavigation.SegundoApellido));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
            </div>
        </div>
    </div>
</div>
<div class=""privacy "" style=""padding-top:0px;"">
    <div class=""container"">
        <!-- tittle heading -->
        <!-- //tittle heading -->
        <div class=""checkout-right"">
            <h4>
                Este Pedido Tienes
                <span>");
#nullable restore
#line 85 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
                 Write(ViewBag.detalleFactura.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Articulos</span>
            </h4>
            <div class=""table-responsive"">
                <table class=""timetable_sub"">
                    <thead>
                        <tr>
                            <th>No.</th>
                            <th>Producto</th>
                            <th>Cantidad</th>
                            <th>Descripción</th>
                            <th>Precio Unitario</th>
                            <th>Subtotal</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 100 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
                          int cont = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
                         foreach (var item in ViewBag.detalleFactura)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 105 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
                                Write(cont++);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"invert-image\">\r\n                                    <a>\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 4133, "\"", 4199, 1);
#nullable restore
#line 109 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
WriteAttributeValue("", 4139, Url.Content("~/image/" + item.CodProductoNavigation.Imagen), 4139, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\" \" class=\"img-responsive\">\r\n                                    </a>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 113 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
                               Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 116 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
                               Write(item.CodProductoNavigation.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 116 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
                                                                  Write(item.CodProductoNavigation.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 119 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
                               Write(item.CodProductoNavigation.PrecioVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 122 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
                                Write(item.CodProductoNavigation.PrecioVenta * item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 125 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                    <tfoot>\r\n                        <tr>\r\n                            <td colspan=\"4\">Total</td>\r\n                            <td>");
#nullable restore
#line 130 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Details.cshtml"
                           Write(Html.DisplayFor(model => model.TotalVendido));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        </tr>
                    </tfoot>
                </table>
            </div>
        </div>
        <div class=""checkout-left"">
            <div class=""address_form_agile"">    
            </div>
            <div class=""clearfix""> </div>
        </div>
    </div>
</div>
<div>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28cbef728711f177bedb381fd01a9980d93bdba714855", async() => {
                WriteLiteral("Regresar a Pendientes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28cbef728711f177bedb381fd01a9980d93bdba716030", async() => {
                WriteLiteral("Regresar a Todos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<despensa.Models.PredidoFactura> Html { get; private set; }
    }
}
#pragma warning restore 1591
