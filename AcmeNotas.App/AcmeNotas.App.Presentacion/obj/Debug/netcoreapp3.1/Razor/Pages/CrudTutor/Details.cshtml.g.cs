#pragma checksum "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a66e03c80f8333c09a45fb858dc05c065f05c680"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AcmeNotas.App.Presentacion.Pages.CrudTutor.Pages_CrudTutor_Details), @"mvc.1.0.razor-page", @"/Pages/CrudTutor/Details.cshtml")]
namespace AcmeNotas.App.Presentacion.Pages.CrudTutor
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
#line 1 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\_ViewImports.cshtml"
using AcmeNotas.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a66e03c80f8333c09a45fb858dc05c065f05c680", @"/Pages/CrudTutor/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b058714d9acaf20abeed3abde626823c0da4523", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CrudTutor_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Tutor</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tutor.CodigoTutor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tutor.CodigoTutor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tutor.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tutor.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tutor.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tutor.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tutor.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tutor.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tutor.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tutor.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tutor.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tutor.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tutor.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tutor.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tutor.CorreoElectronico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tutor.CorreoElectronico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n                <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tutor.MunicipioPersona));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tutor.MunicipioPersona));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 70 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tutor.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tutor.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tutor.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            \r\n            ");
#nullable restore
#line 80 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tutor.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 83 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tutor.PrimerRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 86 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tutor.PrimerRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a66e03c80f8333c09a45fb858dc05c065f05c68012450", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\MisionTic\Proyecto\ACME-git\AcmeNotas.App\AcmeNotas.App.Presentacion\Pages\CrudTutor\Details.cshtml"
                           WriteLiteral(Model.Tutor.Id);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a66e03c80f8333c09a45fb858dc05c065f05c68014620", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AcmeNotas.App.Presentacion.Pages.CrudTutor.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AcmeNotas.App.Presentacion.Pages.CrudTutor.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AcmeNotas.App.Presentacion.Pages.CrudTutor.DetailsModel>)PageContext?.ViewData;
        public AcmeNotas.App.Presentacion.Pages.CrudTutor.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
