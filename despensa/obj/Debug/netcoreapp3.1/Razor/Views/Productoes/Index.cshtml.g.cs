#pragma checksum "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\Productoes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83e3e2d7e0b61c00094e8d5d819c04d137153008"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productoes_Index), @"mvc.1.0.view", @"/Views/Productoes/Index.cshtml")]
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
#nullable restore
#line 2 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\Productoes\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\Productoes\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83e3e2d7e0b61c00094e8d5d819c04d137153008", @"/Views/Productoes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f631de54767318e1d6dbe9f06728805a3ae1783", @"/Views/_ViewImports.cshtml")]
    public class Views_Productoes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<despensa.Models.Producto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("link-product-add-cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-new-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\Productoes\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""ads-grid"">
    <div class=""container"">
        <!-- tittle heading -->
        <h3 class=""tittle-w3l"">
            Productos
            <span class=""heading-style"">
                <i></i>
                <i></i>
                <i></i>
            </span>
        </h3>
        <!-- //tittle heading -->
        <!-- product left -->
        <!-- //product left -->
        <!-- product right -->
        <div class=""agileinfo-ads-display col-md-16"">
            <div class=""wrapper"">
                <!-- first section (nuts) -->
                <div class=""product-sec1"">
                    <h3 class=""heading-tittle"">Productos</h3>
");
#nullable restore
#line 26 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\Productoes\Index.cshtml"
                     foreach (var item in ViewBag.pagina)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-md-4 product-men"">
                            <div class=""men-pro-item simpleCart_shelfItem"">
                                <div class=""men-thumb-item"">
                                    <div class=""cuadrado_imagen""");
            BeginWriteAttribute("style", " style=\"", 1147, "\"", 1243, 6);
            WriteAttributeValue("", 1155, "background-image:", 1155, 17, true);
            WriteAttributeValue(" ", 1172, "url(\'", 1173, 6, true);
#nullable restore
#line 31 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\Productoes\Index.cshtml"
WriteAttributeValue("", 1178, Url.Content("~/image/" + item.Imagen), 1178, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1216, "\');", 1216, 3, true);
            WriteAttributeValue(" ", 1219, "background-size:", 1220, 17, true);
            WriteAttributeValue(" ", 1236, "cover;", 1237, 7, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                    <div class=\"men-cart-pro\">\r\n                                        <div class=\"inner-men-cart-pro\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83e3e2d7e0b61c00094e8d5d819c04d1371530087218", async() => {
                WriteLiteral("ver más");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\Productoes\Index.cshtml"
                                                                      WriteLiteral(item.CodProducto);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83e3e2d7e0b61c00094e8d5d819c04d1371530089619", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\Productoes\Index.cshtml"
                                                                                   WriteLiteral(item.CodProducto);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"item-info-product \">\r\n                                    <h4>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83e3e2d7e0b61c00094e8d5d819c04d13715300812096", async() => {
                WriteLiteral(" ");
#nullable restore
#line 42 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\Productoes\Index.cshtml"
                                                                                             Write(item.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 42 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\Productoes\Index.cshtml"
                                                                                                           Write(item.Peso);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\Productoes\Index.cshtml"
                                                                  WriteLiteral(item.CodProducto);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </h4>\r\n                                    <div class=\"info-product-price\">\r\n                                        <span class=\"item_price\">$");
#nullable restore
#line 45 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\Productoes\Index.cshtml"
                                                             Write(item.PrecioVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                                    </div>\r\n                                    <div class=\"snipcart-details top_brand_home_details item_add single-item hvr-outline-out\">\r\n                                        <button class=\"button2\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2509, "\"", 2553, 3);
            WriteAttributeValue("", 2519, "agregarProducto(", 2519, 16, true);
#nullable restore
#line 49 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\Productoes\Index.cshtml"
WriteAttributeValue("", 2535, item.CodProducto, 2535, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2552, ")", 2552, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Añadir al Carrito 1</button>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 54 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\Productoes\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"clearfix\"></div>\r\n                </div>\r\n                ");
#nullable restore
#line 58 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\Productoes\Index.cshtml"
           Write(Html.PagedListPager((IPagedList)ViewBag.pagina, page => Url.Action("Index", new { page = page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <!-- //product right -->\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n<script>\r\n    function agregarProducto(txt) {\r\n        $.ajax({\r\n            url: \"/cart/compra/\",\r\n            data: { \"id\": txt },\r\n            success: function () {\r\n                obtenerCarrito();\r\n            }\r\n        });\r\n    }\r\n</script>\r\n");
#nullable restore
#line 79 "D:\proyectosvisual\Despensa-Virtual1\despensa\Views\Productoes\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<despensa.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
