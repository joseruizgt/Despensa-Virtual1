#pragma checksum "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94b2fce8b364dcc86805740b352eaf444a25042a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PredidoFacturas_Edit), @"mvc.1.0.view", @"/Views/PredidoFacturas/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94b2fce8b364dcc86805740b352eaf444a25042a", @"/Views/PredidoFacturas/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f631de54767318e1d6dbe9f06728805a3ae1783", @"/Views/_ViewImports.cshtml")]
    public class Views_PredidoFacturas_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<despensa.Models.PredidoFactura>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PedidosPendientes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TodosPedidos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h3 class=""tittle-w3l"">
    Atendiendo Pedido
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
            background: white");
            WriteLiteral(@";
        }
    </style>
    <!-- Stack the columns on mobile by making one full-width and the other half-width -->
    <div class=""dato-cliente"">
        <div class=""row"">
            <div class=""col-6 col-md-4"">
                <div>Fecha de Emisión</div>
                <div class=""well""><span>");
#nullable restore
#line 52 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
                                   Write(Html.DisplayFor(model => model.FecEmision));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n            </div>\r\n            <div class=\"col-6 col-md-4\">\r\n                <div>Nombres</div>\r\n                <div class=\"well\"><span>");
#nullable restore
#line 56 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
                                   Write(Html.DisplayFor(model => model.CodClienteNavigation.PrimerNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 56 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
                                                                                                      Write(Html.DisplayFor(model => model.CodClienteNavigation.SegundoNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n            </div>\r\n            <div class=\"col-6 col-md-4\">\r\n                <div>Apellidos</div>\r\n                <div class=\"well\"><span>");
#nullable restore
#line 60 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
                                   Write(Html.DisplayFor(model => model.CodClienteNavigation.PrimerApellido));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 60 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
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
#line 69 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
                                   Write(ViewBag.NombreEmpleado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n            </div>\r\n            <div class=\"col-6 col-md-6\">\r\n                <div>Apellidos</div>\r\n                <div class=\"well\"><span>");
#nullable restore
#line 73 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
                                   Write(ViewBag.ApelldoEmpleado);

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
                <span >");
#nullable restore
#line 86 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
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
#line 101 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
                          int cont = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
                         foreach (var item in ViewBag.detalleFactura)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 106 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
                                Write(cont++);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td class=\"invert-image\">\r\n                                    <a>\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 3920, "\"", 3986, 1);
#nullable restore
#line 110 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
WriteAttributeValue("", 3926, Url.Content("~/image/" + item.CodProductoNavigation.Imagen), 3926, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\" \" class=\"img-responsive\">\r\n                                    </a>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 114 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
                               Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 117 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
                               Write(item.CodProductoNavigation.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 117 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
                                                                  Write(item.CodProductoNavigation.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 120 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
                               Write(item.CodProductoNavigation.PrecioVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 123 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
                                Write(item.CodProductoNavigation.PrecioVenta * item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 126 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                    <tfoot>\r\n                        <tr>\r\n                            <td colspan=\"4\">Total</td>\r\n                            <td>");
#nullable restore
#line 131 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
                           Write(Html.DisplayFor(model => model.TotalCosto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </tfoot>\r\n                </table>\r\n            </div>\r\n        </div>\r\n        <div class=\"checkout-left\">\r\n            <div class=\"address_form_agile\">\r\n");
#nullable restore
#line 139 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
                 if (@User.IsInRole("3"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94b2fce8b364dcc86805740b352eaf444a25042a16236", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "94b2fce8b364dcc86805740b352eaf444a25042a16519", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 142 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CodFactura);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94b2fce8b364dcc86805740b352eaf444a25042a18348", async() => {
                    WriteLiteral("Back to List");
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
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 141 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
                                                WriteLiteral(ViewBag.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 146 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94b2fce8b364dcc86805740b352eaf444a25042a21994", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94b2fce8b364dcc86805740b352eaf444a25042a22273", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 148 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "94b2fce8b364dcc86805740b352eaf444a25042a23962", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 149 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\PredidoFacturas\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CodFactura);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <div class=\"checkout-right-basket\">\r\n                        <input type=\"submit\" value=\"Validadr Pedido\" class=\"btn btn-default\" />\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"clearfix\"> </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94b2fce8b364dcc86805740b352eaf444a25042a27182", async() => {
                WriteLiteral("Regresar a Pendientes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94b2fce8b364dcc86805740b352eaf444a25042a28357", async() => {
                WriteLiteral("Regresar a Todos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
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
