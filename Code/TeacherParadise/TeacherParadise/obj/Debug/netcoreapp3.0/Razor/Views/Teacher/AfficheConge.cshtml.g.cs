#pragma checksum "C:\Users\User\Documents\GitHub\ASP.NET-HEPH-Condorcet\Code\TeacherParadise\TeacherParadise\Views\Teacher\AfficheConge.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "981a7ee72a8daa7415fdd41b775b9335c70d4984"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_AfficheConge), @"mvc.1.0.view", @"/Views/Teacher/AfficheConge.cshtml")]
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
#line 1 "C:\Users\User\Documents\GitHub\ASP.NET-HEPH-Condorcet\Code\TeacherParadise\TeacherParadise\Views\_ViewImports.cshtml"
using TeacherParadise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\ASP.NET-HEPH-Condorcet\Code\TeacherParadise\TeacherParadise\Views\_ViewImports.cshtml"
using TeacherParadise.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"981a7ee72a8daa7415fdd41b775b9335c70d4984", @"/Views/Teacher/AfficheConge.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc760755d312d00d8e75712cc811d4ca5ba67da1", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_AfficheConge : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CConge>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AjoutConge", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteConge", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\ASP.NET-HEPH-Condorcet\Code\TeacherParadise\TeacherParadise\Views\Teacher\AfficheConge.cshtml"
  
    ViewData["Title"] = "Mes congés";
    List<CConge> conge = (List<CConge>)TempData["Conge"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--\n    Projet scolaire HEPH Condorcet 2019-2020\n    Made by Simon Jonathan\n    -->\n<h1>");
#nullable restore
#line 10 "C:\Users\User\Documents\GitHub\ASP.NET-HEPH-Condorcet\Code\TeacherParadise\TeacherParadise\Views\Teacher\AfficheConge.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "981a7ee72a8daa7415fdd41b775b9335c70d49844920", async() => {
                WriteLiteral(" Cliquez ici pour ajouter un congé ");
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
            WriteLiteral("\n\n");
#nullable restore
#line 14 "C:\Users\User\Documents\GitHub\ASP.NET-HEPH-Condorcet\Code\TeacherParadise\TeacherParadise\Views\Teacher\AfficheConge.cshtml"
 if((bool?)TempData["Error"] == true) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label> Une erreur est survenue lors de votre opération, veillez recommencer. </label>\n");
#nullable restore
#line 16 "C:\Users\User\Documents\GitHub\ASP.NET-HEPH-Condorcet\Code\TeacherParadise\TeacherParadise\Views\Teacher\AfficheConge.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table>\n    <tr>\n        <th>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "981a7ee72a8daa7415fdd41b775b9335c70d49846759", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 21 "C:\Users\User\Documents\GitHub\ASP.NET-HEPH-Condorcet\Code\TeacherParadise\TeacherParadise\Views\Teacher\AfficheConge.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DateDebut);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </th>\n        <th>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "981a7ee72a8daa7415fdd41b775b9335c70d49848281", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 24 "C:\Users\User\Documents\GitHub\ASP.NET-HEPH-Condorcet\Code\TeacherParadise\TeacherParadise\Views\Teacher\AfficheConge.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DateFin);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </th>\n        <th>\n            <label> Supprimer </label>\n        </th>\n        <th>\n            <label> Modifier </label>\n        </th>\n    </tr>\n");
#nullable restore
#line 33 "C:\Users\User\Documents\GitHub\ASP.NET-HEPH-Condorcet\Code\TeacherParadise\TeacherParadise\Views\Teacher\AfficheConge.cshtml"
      
        if(conge == null) {

        } else {
            foreach(CConge c in conge) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        <label> ");
#nullable restore
#line 40 "C:\Users\User\Documents\GitHub\ASP.NET-HEPH-Condorcet\Code\TeacherParadise\TeacherParadise\Views\Teacher\AfficheConge.cshtml"
                           Write(Html.DisplayFor(modelItem => c.DateDebut));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                    </td>\n                    <td>\n                        <label> ");
#nullable restore
#line 43 "C:\Users\User\Documents\GitHub\ASP.NET-HEPH-Condorcet\Code\TeacherParadise\TeacherParadise\Views\Teacher\AfficheConge.cshtml"
                           Write(Html.DisplayFor(modelItem => c.DateFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                    </td>\n                    <td>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "981a7ee72a8daa7415fdd41b775b9335c70d498411144", async() => {
                WriteLiteral("\n                            <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1257, "\"", 1270, 1);
#nullable restore
#line 47 "C:\Users\User\Documents\GitHub\ASP.NET-HEPH-Condorcet\Code\TeacherParadise\TeacherParadise\Views\Teacher\AfficheConge.cshtml"
WriteAttributeValue("", 1265, c.ID, 1265, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                            <input type=\"submit\" value=\"Supprimer\" />\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 52 "C:\Users\User\Documents\GitHub\ASP.NET-HEPH-Condorcet\Code\TeacherParadise\TeacherParadise\Views\Teacher\AfficheConge.cshtml"
            }
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CConge> Html { get; private set; }
    }
}
#pragma warning restore 1591
