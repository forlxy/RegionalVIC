#pragma checksum "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/Rtrtbls/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cd65ee0b1112aa5fd20ca22ca165793bcae0c47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rtrtbls_Details), @"mvc.1.0.view", @"/Views/Rtrtbls/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rtrtbls/Details.cshtml", typeof(AspNetCore.Views_Rtrtbls_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd65ee0b1112aa5fd20ca22ca165793bcae0c47", @"/Views/Rtrtbls/Details.cshtml")]
    public class Views_Rtrtbls_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegionalVIC.Models.DB.Rtrtbl>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/Rtrtbls/Details.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(61, 25, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(86, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47f648aa76cf453c962f12ec99f0c79f", async() => {
                BeginContext(92, 86, true);
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>Details</title>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(185, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(186, 1664, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4a4d7b246004ba79e2cc0f3b6d4521d", async() => {
                BeginContext(192, 95, true);
                WriteLiteral("\n\n<div>\n    <h4>Rtrtbl</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
                EndContext();
                BeginContext(288, 38, false);
#line 21 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/Rtrtbls/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Yr));

#line default
#line hidden
                EndContext();
                BeginContext(326, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(367, 34, false);
#line 24 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/Rtrtbls/Details.cshtml"
       Write(Html.DisplayFor(model => model.Yr));

#line default
#line hidden
                EndContext();
                BeginContext(401, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(442, 39, false);
#line 27 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/Rtrtbls/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Mth));

#line default
#line hidden
                EndContext();
                BeginContext(481, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(522, 35, false);
#line 30 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/Rtrtbls/Details.cshtml"
       Write(Html.DisplayFor(model => model.Mth));

#line default
#line hidden
                EndContext();
                BeginContext(557, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(598, 43, false);
#line 33 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/Rtrtbls/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Quarter));

#line default
#line hidden
                EndContext();
                BeginContext(641, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(682, 39, false);
#line 36 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/Rtrtbls/Details.cshtml"
       Write(Html.DisplayFor(model => model.Quarter));

#line default
#line hidden
                EndContext();
                BeginContext(721, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(762, 42, false);
#line 39 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/Rtrtbls/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Region));

#line default
#line hidden
                EndContext();
                BeginContext(804, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(845, 38, false);
#line 42 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/Rtrtbls/Details.cshtml"
       Write(Html.DisplayFor(model => model.Region));

#line default
#line hidden
                EndContext();
                BeginContext(883, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(924, 43, false);
#line 45 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/Rtrtbls/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LgaCode));

#line default
#line hidden
                EndContext();
                BeginContext(967, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(1008, 39, false);
#line 48 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/Rtrtbls/Details.cshtml"
       Write(Html.DisplayFor(model => model.LgaCode));

#line default
#line hidden
                EndContext();
                BeginContext(1047, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(1088, 39, false);
#line 51 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/Rtrtbls/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Typ));

#line default
#line hidden
                EndContext();
                BeginContext(1127, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(1168, 35, false);
#line 54 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/Rtrtbls/Details.cshtml"
       Write(Html.DisplayFor(model => model.Typ));

#line default
#line hidden
                EndContext();
                BeginContext(1203, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(1244, 45, false);
#line 57 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/Rtrtbls/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NoOfBedrm));

#line default
#line hidden
                EndContext();
                BeginContext(1289, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(1330, 41, false);
#line 60 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/Rtrtbls/Details.cshtml"
       Write(Html.DisplayFor(model => model.NoOfBedrm));

#line default
#line hidden
                EndContext();
                BeginContext(1371, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(1412, 41, false);
#line 63 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/Rtrtbls/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Count));

#line default
#line hidden
                EndContext();
                BeginContext(1453, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(1494, 37, false);
#line 66 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/Rtrtbls/Details.cshtml"
       Write(Html.DisplayFor(model => model.Count));

#line default
#line hidden
                EndContext();
                BeginContext(1531, 40, true);
                WriteLiteral("\n        </dd>\n        <dt>\n            ");
                EndContext();
                BeginContext(1572, 42, false);
#line 69 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/Rtrtbls/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Median));

#line default
#line hidden
                EndContext();
                BeginContext(1614, 40, true);
                WriteLiteral("\n        </dt>\n        <dd>\n            ");
                EndContext();
                BeginContext(1655, 38, false);
#line 72 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/Rtrtbls/Details.cshtml"
       Write(Html.DisplayFor(model => model.Median));

#line default
#line hidden
                EndContext();
                BeginContext(1693, 62, true);
                WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    <a asp-action=\"Edit\"");
                EndContext();
                BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1755, "\"", 1780, 1);
#line 77 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/Rtrtbls/Details.cshtml"
WriteAttributeValue("", 1770, Model.Seq, 1770, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1781, 62, true);
                WriteLiteral(">Edit</a> |\n    <a asp-action=\"Index\">Back to List</a>\n</div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1850, 9, true);
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegionalVIC.Models.DB.Rtrtbl> Html { get; private set; }
    }
}
#pragma warning restore 1591
