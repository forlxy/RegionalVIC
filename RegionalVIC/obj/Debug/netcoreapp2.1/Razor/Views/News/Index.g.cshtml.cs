#pragma checksum "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a62e32524728ee990615a77e394b40259973201f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Index), @"mvc.1.0.view", @"/Views/News/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/News/Index.cshtml", typeof(AspNetCore.Views_News_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a62e32524728ee990615a77e394b40259973201f", @"/Views/News/Index.cshtml")]
    public class Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 723, true);
            WriteLiteral(@"<style>
.post-preview > a {
  color: #212529;
}

.post-preview > a:focus, .post-preview > a:hover {
  text-decoration: none;
  color: #0085A1;
}

.post-preview > a > .post-title {
  font-size: 24px;
  margin-top: 30px;
  margin-bottom: 10px;
}

.post-preview > a > .post-subtitle {
  font-weight: 300;
  margin: 0 0 10px;
}

.post-preview > .post-meta {
  font-size: 18px;
  font-style: italic;
  margin-top: 0;
  color: #868e96;
}

.post-preview > .post-meta > a {
  text-decoration: none;
  color: #212529;
}

.post-preview > .post-meta > a:focus, .post-preview > .post-meta > a:hover {
  text-decoration: underline;
  color: #0085A1;
}

</style>
<!DOCTYPE html>
<html lang=""en"">
");
            EndContext();
            BeginContext(723, 2299, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4af0f9b1d1e048a4a58a6b4eb3feaca4", async() => {
                BeginContext(729, 2286, true);
                WriteLiteral(@"

    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content="""">
    <meta name=""author"" content="""">
    <title>RegionalVIC - Explore Regional Victoria</title>
    <!-- Bootstrap core CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
    <!-- Custom fonts for this template -->
    <link href=""/vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Montserrat:400,700"" rel=""stylesheet"" type=""text/css"">
    <link href='https://fonts.googleapis.com/css?family=Kaushan+Script' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Droid+Serif:400,700,400italic,700italic' rel='stylesheet' type='text/css'>
    <link href='https:/");
                WriteLiteral(@"/fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700' rel='stylesheet' type='text/css'>
    <!-- Custom styles for this template -->
    <link href=""/css/agency.min.css"" rel=""stylesheet"">

    <link href='https://api.tiles.mapbox.com/mapbox-gl-js/v0.53.1/mapbox-gl.css' rel='stylesheet' />
    <link rel='/stylesheet' href='https://api.mapbox.com/mapbox-gl-js/plugins/mapbox-gl-geocoder/v3.1.6/mapbox-gl-geocoder.css' type='text/css' />

    <!-- Bootstrap core JavaScript -->
    <script src=""/vendor/jquery/jquery.min.js""></script>
    <script src=""/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <!-- Plugin JavaScript -->
    <script src=""/vendor/jquery-easing/jquery.easing.min.js""></script>
    <script src=""https://unpkg.com/tinyqueue@2.0.0/tinyqueue.min.js""></script>
    <script src=""/js/polylabel.js""></script>
    <script src='https://api.tiles.mapbox.com/mapbox-gl-js/v0.53.1/mapbox-gl.js'></script>
    <script src=""https://cdn.jsdelivr.net/npm/chart.js@2.8.0""></script>
    ");
                WriteLiteral("<script src=\'https://api.mapbox.com/mapbox-gl-js/plugins/mapbox-gl-geocoder/v3.1.6/mapbox-gl-geocoder.min.js\'></script>\r\n\r\n\r\n    <link rel=\"stylesheet\" href=\"/css/css-loader.css\">\r\n    <link href=\"/css/rangeslider.css\" rel=\"stylesheet\">\r\n");
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
            BeginContext(3022, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3024, 6133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "483367e031a14c96b95ee1f96a36ef49", async() => {
                BeginContext(3030, 2143, true);
                WriteLiteral(@"

    <nav class=""navbar navbar-expand-lg navbar-dark fixed-top"" id=""mainNav"">
        <div class=""container"">
            <a class=""navbar-brand js-scroll-trigger"" href=""/"">RegionalVIC</a>
            <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                Menu
                <i class=""fas fa-bars""></i>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                <ul class=""navbar-nav text-uppercase ml-auto"">
                    <li class=""nav-item"">
                        <a class=""nav-link js-scroll-trigger"" href=""/"">Home</a>
                    </li>

                    <li class=""nav-item"">
                        <a class=""nav-link js-scroll-trigger"" href=""/Map"">Map</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
   ");
                WriteLiteral(@" <!-- Header -->
    <header class=""masthead"" style=""background-image: url('/img/news1.jpg');background-size: cover;"">
        <div class=""container"">
            <div class=""intro-normal"">
            </div>
        </div>
    </header>

    <div class=""loader loader-default is-active"" data-text id=""loader""></div>
    <!-- Main Content -->
    <section id=""articles"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-8 col-md-10 mx-auto"">
                    <div class=""news"">
                    </div>
                    <hr>
                </div>
                <hr>
            </div>
        </div>
        </div>
    </section>

    <!-- Footer -->
    <footer>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <span class=""copyright"">
                        Copyright &copy; RegionalVIC 2019. Theme is from <a href=""https://startbootstrap.com/themes/"">Start ");
                WriteLiteral("Bootstrap</a> website under MIT license.\r\n                    </span>\r\n                </div>\r\n");
                EndContext();
                BeginContext(6564, 2586, true);
                WriteLiteral(@"            </div>
        </div>
    </footer>
    <script>

        {
            $.ajax({
                url:
                    //""https://newsapi.org/v2/everything?q=-Trump,+immigration,+plan&sources=abc-news-au&apiKey=79a6a2e25a7c4063a5857e750e7b80fc"",
                    //""https://gnews.io/api/v2/?q=plan+visa+austrlia+migration&token=d6064764444e9134bd179852cec2c4a7"",
                    ""https://gnews.io/api/v2/?q=australia+policy+immigration+visa&country=AU&token=d6064764444e9134bd179852cec2c4a7"",
                method: ""GET"",
                error: function () {
                    console.log(""fucked"");

                    $(""#loader"").removeClass(""is-active"");
                },
                success: function (data) {
                    processData(data);

                    $(""#loader"").removeClass(""is-active"");
                }
            });

            function processData(data) {

                if (data.count_results === 0) {

                    var");
                WriteLiteral(@" $element = $('<div class=""post-preview""> <strong> <h3 class=""post-title""> ' + ""No content"" + '</h3>'
                        + '<h5 class=""post-subtitle""> ' + ""There is no latest news about immigration."" + '</h5></strong></div><hr>');

                    $("".news"").append($element);
                }
                else {
                    for (var i = 0; i < data.articles.length; i++) {
                        var source = data.articles[i].source;
                        var title = data.articles[i].title;
                        var description = data.articles[i].desc;
                        var artUrl = data.articles[i].link;
                        var date = data.articles[i].date;
                        var website = data.articles[i].website;

                        var $element = $('<div class=""post-preview""> <a href=""' + artUrl + '""> <h3 class=""post-title""> ' + title + '</h3>'
                            + '<h5 class=""post-subtitle""> ' + description + '</h5></a><p class=""post-met");
                WriteLiteral(@"a"">Posted by  <a href=""' + website + '"">' + source + '</a> on <strong>' + date + ' </strong> </p></div><hr>');

                        $("".news"").append($element);
                        //console.log(artUrl);
                    }
                }
            }

        }
    </script>
    <!-- Contact form JavaScript -->
    <script src=""/js/jqBootstrapValidation.js""></script>
    <script src=""/js/contact_me.js""></script>
    <!-- Custom scripts for this template -->
    <script src=""/js/agency.min.js""></script>
");
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
            BeginContext(9157, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
