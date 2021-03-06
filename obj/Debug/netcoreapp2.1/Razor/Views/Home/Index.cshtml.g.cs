#pragma checksum "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ec6d97a8f21bd55fe015d02c22a043c7f587e8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/_ViewImports.cshtml"
using RegistroAlumnosYProfesores;

#line default
#line hidden
#line 2 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/_ViewImports.cshtml"
using RegistroAlumnosYProfesores.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ec6d97a8f21bd55fe015d02c22a043c7f587e8b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a85c8396a612d724d75465ee406e96598841a6b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegistroAlumnosYProfesores.Models.HomeIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Alumnos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Ver", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profesores", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Alumnos y Profesores";

#line default
#line hidden
            BeginContext(119, 390, true);
            WriteLiteral(@"
<div class=""alumnos-section"">
    <h2>Lista de alumnos</h2>
    <table class=""tabla"">
        <thead>
            <tr>
                <th>Matrícula</th>
                <th>Nombre</th>
                <th>Carrera</th>
                <th>Correo electrónico</th>
                <th>Teléfono</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 21 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Home/Index.cshtml"
             foreach (var alumno in Model.Alumnos)
            {

#line default
#line hidden
            BeginContext(576, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(623, 16, false);
#line 24 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Home/Index.cshtml"
                   Write(alumno.Matricula);

#line default
#line hidden
            EndContext();
            BeginContext(639, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(671, 13, false);
#line 25 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Home/Index.cshtml"
                   Write(alumno.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(684, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(716, 14, false);
#line 26 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Home/Index.cshtml"
                   Write(alumno.Carrera);

#line default
#line hidden
            EndContext();
            BeginContext(730, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(762, 12, false);
#line 27 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Home/Index.cshtml"
                   Write(alumno.Email);

#line default
#line hidden
            EndContext();
            BeginContext(774, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(806, 15, false);
#line 28 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Home/Index.cshtml"
                   Write(alumno.Telefono);

#line default
#line hidden
            EndContext();
            BeginContext(821, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(878, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0faead7833364907a416649595d3c5da", async() => {
                BeginContext(956, 12, true);
                WriteLiteral("Ver detalles");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Home/Index.cshtml"
                                                                       WriteLiteral(alumno.Matricula);

#line default
#line hidden
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
            EndContext();
            BeginContext(972, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 33 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Home/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1039, 111, true);
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"6\"><span>Total de registros: ");
            EndContext();
            BeginContext(1151, 19, false);
#line 37 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Home/Index.cshtml"
                                                     Write(Model.Alumnos.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1170, 429, true);
            WriteLiteral(@"</span> </td>
            </tr>
        </tfoot>
    </table>
</div>
<div class=""profesores-section"">
    <h2>Lista de profesores</h2>
    <table class=""tabla"">
        <thead>
            <tr>
                <th>No. de Empleado</th>
                <th>Nombre</th>
                <th>Carrera</th>
                <th>Teléfono</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 55 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Home/Index.cshtml"
             foreach (var profesor in Model.Profesores)
            {

#line default
#line hidden
            BeginContext(1671, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1718, 19, false);
#line 58 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Home/Index.cshtml"
                   Write(profesor.NoEmpleado);

#line default
#line hidden
            EndContext();
            BeginContext(1737, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1769, 15, false);
#line 59 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Home/Index.cshtml"
                   Write(profesor.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(1784, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1816, 16, false);
#line 60 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Home/Index.cshtml"
                   Write(profesor.Carrera);

#line default
#line hidden
            EndContext();
            BeginContext(1832, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1864, 17, false);
#line 61 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Home/Index.cshtml"
                   Write(profesor.Telefono);

#line default
#line hidden
            EndContext();
            BeginContext(1881, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1938, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62ea52965c4848248bd5b91d18a2c2bf", async() => {
                BeginContext(2022, 12, true);
                WriteLiteral("Ver detalles");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Home/Index.cshtml"
                                                                          WriteLiteral(profesor.NoEmpleado);

#line default
#line hidden
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
            EndContext();
            BeginContext(2038, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 66 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Home/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2105, 111, true);
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"5\"><span>Total de registros: ");
            EndContext();
            BeginContext(2217, 22, false);
#line 70 "/home/brian/Documentos/mugrero/web/ASP.NET/RegistroAlumnosYProfesores/Views/Home/Index.cshtml"
                                                     Write(Model.Profesores.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2239, 73, true);
            WriteLiteral("</span></td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegistroAlumnosYProfesores.Models.HomeIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
