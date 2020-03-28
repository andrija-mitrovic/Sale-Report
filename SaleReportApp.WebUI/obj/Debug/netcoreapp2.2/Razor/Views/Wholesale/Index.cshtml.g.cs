#pragma checksum "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\Wholesale\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae721631475966d7a3a2c1920c6ac8c2b341c10a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wholesale_Index), @"mvc.1.0.view", @"/Views/Wholesale/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Wholesale/Index.cshtml", typeof(AspNetCore.Views_Wholesale_Index))]
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
#line 1 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\_ViewImports.cshtml"
using SaleReportApp.WebUI;

#line default
#line hidden
#line 2 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\_ViewImports.cshtml"
using SaleReportApp.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae721631475966d7a3a2c1920c6ac8c2b341c10a", @"/Views/Wholesale/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86f9e3402035efed845378bc212f19120fd12e18", @"/Views/_ViewImports.cshtml")]
    public class Views_Wholesale_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListPagination<WholesaleIndexViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\Wholesale\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(96, 703, true);
            WriteLiteral(@"
<h3>Wholesale report</h3>
<hr />

<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">Sifra Robe</th>
            <th scope=""col"" style=""width:130px"">Naziv Robe</th>
            <th scope=""col"">Kolicina</th>
            <th scope=""col"">Nabavna Vr.</th>
            <th scope=""col"">Nabavna Cij.</th>
            <th scope=""col"">VP Cijena</th>
            <th scope=""col"">VP Vrijed.</th>
            <th scope=""col"">Ukalk. RUC</th>
            <th scope=""col"">Kolicina</th>
            <th scope=""col"">Nabavna Vr.</th>
            <th scope=""col"">VP Cijena</th>
            <th scope=""col"">VP Vrijed.</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 27 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\Wholesale\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(848, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(887, 10, false);
#line 30 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\Wholesale\Index.cshtml"
               Write(item.sifra);

#line default
#line hidden
            EndContext();
            BeginContext(897, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(925, 10, false);
#line 31 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\Wholesale\Index.cshtml"
               Write(item.naziv);

#line default
#line hidden
            EndContext();
            BeginContext(935, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(963, 10, false);
#line 32 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\Wholesale\Index.cshtml"
               Write(item.ukoli);

#line default
#line hidden
            EndContext();
            BeginContext(973, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1001, 10, false);
#line 33 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\Wholesale\Index.cshtml"
               Write(item.unavr);

#line default
#line hidden
            EndContext();
            BeginContext(1011, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1039, 10, false);
#line 34 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\Wholesale\Index.cshtml"
               Write(item.unacj);

#line default
#line hidden
            EndContext();
            BeginContext(1049, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1077, 10, false);
#line 35 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\Wholesale\Index.cshtml"
               Write(item.uprcj);

#line default
#line hidden
            EndContext();
            BeginContext(1087, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1115, 10, false);
#line 36 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\Wholesale\Index.cshtml"
               Write(item.uprvr);

#line default
#line hidden
            EndContext();
            BeginContext(1125, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1153, 10, false);
#line 37 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\Wholesale\Index.cshtml"
               Write(item.urucn);

#line default
#line hidden
            EndContext();
            BeginContext(1163, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1191, 10, false);
#line 38 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\Wholesale\Index.cshtml"
               Write(item.ikoli);

#line default
#line hidden
            EndContext();
            BeginContext(1201, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1229, 10, false);
#line 39 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\Wholesale\Index.cshtml"
               Write(item.inavr);

#line default
#line hidden
            EndContext();
            BeginContext(1239, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1267, 10, false);
#line 40 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\Wholesale\Index.cshtml"
               Write(item.iprcj);

#line default
#line hidden
            EndContext();
            BeginContext(1277, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1305, 10, false);
#line 41 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\Wholesale\Index.cshtml"
               Write(item.iprvr);

#line default
#line hidden
            EndContext();
            BeginContext(1315, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 43 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\Wholesale\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1352, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
#line 47 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\Wholesale\Index.cshtml"
  
    var disablePrevious = !Model.IsPreviousPageAvailable ? "disabled" : "";
    var disableNext = !Model.IsNextPageAvailable ? "disabled" : "";

#line default
#line hidden
            BeginContext(1531, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1533, 132, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae721631475966d7a3a2c1920c6ac8c2b341c10a9872", async() => {
                BeginContext(1645, 16, true);
                WriteLiteral("\r\n    Previous\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\Wholesale\Index.cshtml"
              WriteLiteral(Model.PageIndex-1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1614, "btn", 1614, 3, true);
            AddHtmlAttributeValue(" ", 1617, "btn-info", 1618, 9, true);
#line 54 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\Wholesale\Index.cshtml"
AddHtmlAttributeValue(" ", 1626, disablePrevious, 1627, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1665, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1667, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae721631475966d7a3a2c1920c6ac8c2b341c10a12821", async() => {
                BeginContext(1775, 12, true);
                WriteLiteral("\r\n    Next\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\Wholesale\Index.cshtml"
              WriteLiteral(Model.PageIndex+1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1748, "btn", 1748, 3, true);
            AddHtmlAttributeValue(" ", 1751, "btn-info", 1752, 9, true);
#line 59 "D:\Projects\ASP .NET Core\SaleReportApp\SaleReportApp.WebUI\Views\Wholesale\Index.cshtml"
AddHtmlAttributeValue(" ", 1760, disableNext, 1761, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1791, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListPagination<WholesaleIndexViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
