#pragma checksum "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f71079747a400510c2e54ce3d2c0d9d36596aa10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PredidoFacturas_Factura), @"mvc.1.0.view", @"/Views/PredidoFacturas/Factura.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f71079747a400510c2e54ce3d2c0d9d36596aa10", @"/Views/PredidoFacturas/Factura.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f631de54767318e1d6dbe9f06728805a3ae1783", @"/Views/_ViewImports.cshtml")]
    public class Views_PredidoFacturas_Factura : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml"
  
    ViewData["Title"] = "Factura";
    Layout = "~/Views/Shared/facturaLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""control-bar"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-2-4"">
                <div class=""slogan"">Facturación </div>

                <label for=""config_tax"">
                    IVA:
                    <input type=""checkbox"" id=""config_tax"" checked/>
                </label>
                <label for=""config_tax_rate"" class=""taxrelated"">
                    Tasa:
                    <input type=""text"" id=""config_tax_rate"" value=""12"" hidden/>%
                </label>
                <label for=""config_note"">
                    Nota:
                    <input type=""checkbox"" id=""config_note"" />
                </label>

            </div>
            <div class=""col-4 text-right"">
                <a href=""javascript:window.print()"">Imprimir</a>
            </div><!--.col-->
        </div><!--.row-->
    </div><!--.container-->
</div><!--.control-bar-->




<div class=""row section"">

    <div class=""col-2"">
        <h1 con");
            WriteLiteral("tenteditable>Factura</h1>\r\n    </div><!--.col-->\r\n\r\n    <div class=\"col-2 text-right details\">\r\n        <p contenteditable>\r\n            Fecha: <input type=\"date\"");
            BeginWriteAttribute("value", "  value=\"", 1284, "\"", 1320, 1);
#nullable restore
#line 44 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml"
WriteAttributeValue("", 1293, ViewBag.factura.FecEmision, 1293, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/><br>\r\n            Factura #: <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 1370, "\"", 1405, 1);
#nullable restore
#line 45 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml"
WriteAttributeValue("", 1378, ViewBag.factura.CodFactura, 1378, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /><br>\r\n        </p>\r\n    </div><!--.col-->\r\n\r\n\r\n\r\n    <div class=\"col-2\">\r\n\r\n\r\n        <p contenteditable class=\"client\">\r\n            <strong>Facturar a</strong><br>\r\n            Nombre: ");
#nullable restore
#line 56 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml"
               Write(ViewBag.factura.CodClienteNavigation.PrimerNombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n            Apellido: ");
#nullable restore
#line 57 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml"
                 Write(ViewBag.factura.CodClienteNavigation.SegundoNombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n            Direccion: ");
#nullable restore
#line 58 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml"
                  Write(ViewBag.factura.CodClienteNavigation.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n            Telefoo: ");
#nullable restore
#line 59 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml"
                Write(ViewBag.factura.CodClienteNavigation.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div><!--.col-->\r\n\r\n\r\n    <div class=\"col-2\">\r\n\r\n\r\n        <p contenteditable class=\"client\">\r\n            <strong></strong><br>\r\n            DPI: ");
#nullable restore
#line 69 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml"
            Write(ViewBag.factura.CodClienteNavigation.Cui);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n            NIT: ");
#nullable restore
#line 70 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml"
            Write(ViewBag.factura.CodClienteNavigation.Nit);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n            Correo: ");
#nullable restore
#line 71 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml"
               Write(ViewBag.factura.CodClienteNavigation.CorreoElectronico);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br>
        </p>
    </div><!--.col-->



</div><!--.row-->

<div class=""row section"" style=""margin-top:-1rem"">
    <div class=""col-1"">
        <table style='width:100%'>
            <thead contenteditable>
                <tr class=""invoice_detail"">
                    <th width=""70%"" style=""text-align:center"">Empleado</th>
                    <th width=""30%"">Términos y condiciones</th>
                </tr>
            </thead>
            <tbody contenteditable>
                <tr class=""invoice_detail"">
                    <td width=""70%"" style=""text-align:center"">");
#nullable restore
#line 90 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml"
                                                         Write(ViewBag.empleado);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    <td width=""30%"">Pago A Contra Enctrega</td>
                </tr>
            </tbody>
        </table>
    </div>

</div><!--.row-->

<div class=""invoicelist-body"">
    <table>
        <thead contenteditable>
            <tr>
                <th width=""5%"">Código</th>
                <th width=""60%"">Descripción</th>

                <th width=""10%"">Cant.</th>
                <th width=""15%"">Precio</th>
                <th class=""taxrelated"">IVA</th>
                <th width=""10%"">Total</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 113 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml"
              int cont = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml"
             foreach (var item in ViewBag.detalleFactura)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td width=\'5%\'><span contenteditable>");
#nullable restore
#line 117 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml"
                                                    Write(item.CodFactura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                    <td width=\'60%\'><span contenteditable>");
#nullable restore
#line 118 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml"
                                                     Write(item.CodProductoNavigation.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 118 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml"
                                                                                        Write(item.CodProductoNavigation.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                    <td class=\"amount\"><input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3849, "\"", 3871, 1);
#nullable restore
#line 119 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml"
WriteAttributeValue("", 3857, item.Cantidad, 3857, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                    <td class=\"rate\"><input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3937, "\"", 3984, 1);
#nullable restore
#line 120 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml"
WriteAttributeValue("", 3945, item.CodProductoNavigation.PrecioVenta, 3945, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                    <td class=\"tax taxrelated\"></td>\r\n                    <td class=\"sum\">");
#nullable restore
#line 122 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml"
                                Write(item.CodProductoNavigation.PrecioVenta * item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 124 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

        </tbody>
    </table>
</div><!--.invoice-body-->

<div class=""invoicelist-footer"">
    <table contenteditable>
        <tr class=""taxrelated"">
            <td>IVA:</td>
            <td id=""total_tax""></td>
        </tr>
        <tr>
            <td><strong>Total:</strong></td>
            <td>Q.");
#nullable restore
#line 139 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Factura.cshtml"
             Write(ViewBag.factura.TotalVendido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n</div>\r\n\r\n<div class=\"note\" contenteditable>\r\n    <h2>Nota:</h2>\r\n</div><!--.note-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
