#pragma checksum "C:\83\Proyecto-Ciclo3.App\ProyectoCiclo3.App.Frontend\Pages\Rutas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7eee5bcb09ba63e26cbc80b34c37c3439fe678f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoCiclo3.App.Frontend.Pages.Rutas.Pages_Rutas_Details), @"mvc.1.0.razor-page", @"/Pages/Rutas/Details.cshtml")]
namespace ProyectoCiclo3.App.Frontend.Pages.Rutas
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
#line 1 "C:\83\Proyecto-Ciclo3.App\ProyectoCiclo3.App.Frontend\Pages\_ViewImports.cshtml"
using ProyectoCiclo3.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eee5bcb09ba63e26cbc80b34c37c3439fe678f6", @"/Pages/Rutas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fac2ae24fef211f78e08fb554a390914631813e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Rutas_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\83\Proyecto-Ciclo3.App\ProyectoCiclo3.App.Frontend\Pages\Rutas\Details.cshtml"
  
    var ruta = Model.Ruta;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul class=\"list-group list-group-flush\">\r\n  <li class=\"list-group-item\"> <b>id: </b> ");
#nullable restore
#line 8 "C:\83\Proyecto-Ciclo3.App\ProyectoCiclo3.App.Frontend\Pages\Rutas\Details.cshtml"
                                      Write(ruta.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"> <b>Oriegen: </b> ");
#nullable restore
#line 9 "C:\83\Proyecto-Ciclo3.App\ProyectoCiclo3.App.Frontend\Pages\Rutas\Details.cshtml"
                                           Write(ruta.origen.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"> <b>Destino: </b> ");
#nullable restore
#line 10 "C:\83\Proyecto-Ciclo3.App\ProyectoCiclo3.App.Frontend\Pages\Rutas\Details.cshtml"
                                           Write(ruta.destino.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>Tiempo Estimado: </b> ");
#nullable restore
#line 11 "C:\83\Proyecto-Ciclo3.App\ProyectoCiclo3.App.Frontend\Pages\Rutas\Details.cshtml"
                                                  Write(ruta.tiempo_estimado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoCiclo3.App.Frontend.Pages.DetailsRutasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.DetailsRutasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.DetailsRutasModel>)PageContext?.ViewData;
        public ProyectoCiclo3.App.Frontend.Pages.DetailsRutasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
