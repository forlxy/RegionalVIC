#pragma checksum "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/locations/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f709eb72c917f6d405b860418b8cafb6f9cdbba2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_locations_Index), @"mvc.1.0.view", @"/Views/locations/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/locations/Index.cshtml", typeof(AspNetCore.Views_locations_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f709eb72c917f6d405b860418b8cafb6f9cdbba2", @"/Views/locations/Index.cshtml")]
    public class Views_locations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RegionalVIC.Models.location>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/location.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-3.3.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/locations/Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(129, 101, true);
            WriteLiteral("\n<h2>Index</h2>\n<div id=\"map\" style=\"height:500px\"></div>\n<div id=\'geocoder\' class=\'geocoder\'></div>\n");
            EndContext();
            BeginContext(296, 14, true);
            WriteLiteral("<br />\n<br />\n");
            EndContext();
            BeginContext(310, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c25df9a24f24b3ca53423ba02de2a07", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(355, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(356, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d808dc7d45574df48a6b0a8ced74ea7c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(405, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(482, 1414, true);
            WriteLiteral(@"<script src='https://api.mapbox.com/mapbox-gl-js/plugins/mapbox-gl-directions/v3.1.3/mapbox-gl-directions.js'></script>
<link rel='stylesheet' href='https://api.mapbox.com/mapbox-gl-js/plugins/mapbox-gl-directions/v3.1.3/mapbox-gl-directions.css' type='text/css' />

<div class=""col-sm-6"">
    <div class=""form-group"">

    </div>
</div>
<div class=""col-sm-6"">
    <br />
    <br />
    <br />
</div>


<script>
    var counter = 0;
    $('.multi-field-wrapper').each(function () {
        var $wrapper = $('.multi-fields', this);
        $("".add-field"", $(this)).click(function (e) {
            counter++;
            $('.multi-field:first-child', $wrapper).clone(true).appendTo($wrapper).find('location').val('').focus();
        });
        $('.multi-field .remove-field', $wrapper).click(function () {
            if ($('.multi-field', $wrapper).length > 1)
                $(this).parent('.multi-field').remove();
        });
    });
    document.getElementById('form-trip')
        .addEventListener('click', function");
            WriteLiteral(@" () {
            console.log(""form a trip"");
            var list = $('.multi-field-wrapper .multi-field .tmp');
            var counter = 0;
            var length = list.length;
            for (var e of list) {
                clearDropoff();
                var value = e.options[e.selectedIndex].value;
                var lat, lng;
                $.ajax({
                    url: '");
            EndContext();
            BeginContext(1897, 36, false);
#line 59 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/locations/Index.cshtml"
                     Write(Url.Action("getLatLng", "locations"));

#line default
#line hidden
            EndContext();
            BeginContext(1933, 803, true);
            WriteLiteral(@"',
                    type: 'POST',
                    data: ""{id:'"" + value + ""', counter:'"" + counter + ""'}"",
                    contentType: 'Application/json',
                    success: function(result)
                    {
                        var array = result.split("";"");
                        newDropoff([array[0], array[1]], array[2], length);
                    }
                });
                counter++;
            }


        });

    document.getElementById('show-trip')
        .addEventListener('click', function () {
            console.log(""show a saved trip"");
            var list = $('.form-group .form-control');

            for (var e of list) {
                var value = e.options[e.selectedIndex].value;
                $.ajax({
                    url: '");
            EndContext();
            BeginContext(2737, 34, false);
#line 83 "/Users/sysadmin/GitKraken/RegionalVIC/RegionalVIC/Views/locations/Index.cshtml"
                     Write(Url.Action("getTrip", "locations"));

#line default
#line hidden
            EndContext();
            BeginContext(2771, 428, true);
            WriteLiteral(@"',
                    type: 'POST',
                    data: ""{route_id:'"" + value + ""'}"",
                    contentType: 'Application/json',
                    success: function(data)
                    {
                        showSavedTrip(JSON.parse(data));
                        //newDropoff([array[0], array[1]], array[2], length);
                    }
                });
            }


        });

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RegionalVIC.Models.location>> Html { get; private set; }
    }
}
#pragma warning restore 1591
