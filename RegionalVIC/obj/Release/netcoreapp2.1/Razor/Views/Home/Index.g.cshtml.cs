#pragma checksum "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ed9eab5e02859f81d943135d0988cae1753b22b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ed9eab5e02859f81d943135d0988cae1753b22b", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("page-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\kasal\source\repos\kasaluoqi\RegionalVIC\RegionalVIC\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
            BeginContext(41, 8352, true);
            WriteLiteral(@"<style>

    .vidheader {
        position: relative;
        width: 100%;
        height: 100%;
        display: flex;
        align-items: center;
        justify-content: center;
        overflow: hidden;
    }

    video {
        position: absolute;
        top: 0;
        left: 0;
        width: 100%;
        height: 100%;
        min-width: 100%;
        min-height: 100%;
        z-index: -1;
        object-position: center;
        object-fit: cover;
    }

    .carousel-item-sm {
        height: 100vh;
        max-height: 380px;
        background: no-repeat center center scroll;
        -webkit-background-size: cover;
        -moz-background-size: cover;
        -o-background-size: cover;
        background-size: cover;
    }

    /*From Alan*/
    .carousel-item {
        height: 100vh;
        max-height: 450px;
        background: no-repeat center center scroll;
        -webkit-background-size: cover;
        -moz-background-size: cover;
        -o-backgr");
            WriteLiteral(@"ound-size: cover;
        background-size: cover;
    }

    .carousel-indicators li {
        width: 10px !important;
        height: 10px !important;
        background-color: #ddd !important;
    }


    .cta-100 {
        margin-top: 100px;
        padding-left: 8%;
        padding-top: 7%;
    }

    .col-md-4 {
        padding-bottom: 20px;
    }

    .white {
        color: #fff !important;
    }

    .mt {
        float: left;
        margin-top: -20px;
        padding-top: 20px;
    }

    .bg-blue-ui {
        background-color: #708198 !important;
    }

    figure img {
        width: 300px;
    }

    #blogCarousel {
        padding-bottom: 100px;
    }

    .blog .carousel-indicators {
        left: 0;
        top: -50px;
        height: 50%;
    }


        /* The colour of the indicators */

        .blog .carousel-indicators li {
            background: #708198;
            border-radius: 50%;
            width: 8px;
            height: 8");
            WriteLiteral(@"px;
        }

        .blog .carousel-indicators .active {
            background: #0fc9af;
        }




    .item-carousel-blog-block {
        outline: medium none;
        padding: 15px;
    }

    .item-box-blog {
        border: 1px solid #dadada;
        text-align: center;
        z-index: 4;
        padding: 20px;
    }

    .item-box-blog-image {
        position: relative;
    }

        .item-box-blog-image figure img {
            width: 100%;
            height: auto;
        }

    .item-box-blog-date {
        position: absolute;
        z-index: 5;
        padding: 4px 20px;
        top: -20px;
        right: 8px;
        background-color: #41cb52;
    }

        .item-box-blog-date span {
            color: #fff;
            display: block;
            text-align: center;
            line-height: 1.2;
        }

            .item-box-blog-date span.mon {
                font-size: 18px;
            }

            .item-box-blog-date span.da");
            WriteLiteral(@"y {
                font-size: 16px;
            }

    .item-box-blog-body {
        padding: 10px;
    }

    .item-heading-blog a h5 {
        margin: 0;
        line-height: 1;
        text-decoration: none;
        transition: color 0.3s;
    }

    .item-box-blog-heading a {
        text-decoration: none;
    }

    .item-box-blog-data p {
        font-size: 13px;
    }

        .item-box-blog-data p i {
            font-size: 12px;
        }

    .item-box-blog-text {
        max-height: 100px;
        overflow: hidden;
    }

    .mt-10 {
        float: left;
        margin-top: -10px;
        padding-top: 10px;
    }

    .btn.bg-blue-ui.white.read {
        cursor: pointer;
        padding: 4px 20px;
        float: left;
        margin-top: 10px;
    }

    .btn.bg-blue-ui.white.read:hover {
        box-shadow: 0px 5px 15px inset #4d5f77;
    }
    /*From Tonya*/
    .col-center {
        margin: 0 auto;
        float: none !important;
    }

   ");
            WriteLiteral(@" .carousel {
        margin: 30px auto 80px;
        padding: 0 80px;
    }

        .carousel .item {
            text-align: center;
            overflow: hidden;
        }

            .carousel .item h4 {
                font-family: 'Varela Round', sans-serif;
            }

            .carousel .item img {
                max-width: 100%;
                display: inline-block;
            }

            .carousel .item .btn {
                border-radius: 0;
                font-size: 12px;
                text-transform: uppercase;
                font-weight: bold;
                border: none;
                background: #2E9CCA;
                padding: 6px 15px;
                margin-top: 5px;
            }

                .carousel .item .btn:hover {
                    background: #8c5bff;
                }

                .carousel .item .btn i {
                    font-size: 14px;
                    font-weight: bold;
                    margin-left: ");
            WriteLiteral(@"5px;
                }

        .carousel .thumb-wrapper {
            margin: 5px;
            text-align: left;
            background: #fff;
            height:100%;
            box-shadow: 0px 2px 2px rgba(0,0,0,0.1);
        }

        .carousel .thumb-content {
            padding: 15px;
            font-size: 13px;
            height: 190px;
        }

        .carousel .carousel-control {
            height: 44px;
            width: 44px;
            background: none;
            margin: auto 0;
            border-radius: 50%;
            border: 3px solid rgba(0, 0, 0, 0.8);
        }

            .carousel .carousel-control i {
                font-size: 36px;
                position: absolute;
                top: 50%;
                display: inline-block;
                margin: -19px 0 0 0;
                z-index: 5;
                left: 0;
                right: 0;
                color: rgba(0, 0, 0, 0.8);
                text-shadow: none;
             ");
            WriteLiteral(@"   font-weight: bold;
            }

            .carousel .carousel-control.left i {
                margin-left: -3px;
            }

            .carousel .carousel-control.right i {
                margin-right: -3px;
            }

        .carousel .carousel-indicators {
            bottom: -50px;
        }

    .carousel-indicators li, .carousel-indicators li.active {
        width: 10px;
        height: 10px;
        border-radius: 50%;
        margin: 4px;
        border-color: transparent;
    }

    .carousel-indicators li {
        background: #ababab;
        border-top: 0px solid transparent !important;
        border-bottom: 0px solid transparent !important;
    }


        .carousel-indicators li.active {
            background: #555 !important;
        }
    .row {
        display: -webkit-box;
        display: -webkit-flex;
        display: -ms-flexbox;
        display: flex;
    }

        .row > [class*='col-'] {
            display: flex;
        ");
            WriteLiteral(@"    flex-direction: column;
        }

    .text-nav {
        font-size: 18px !important;
        font-weight: bold !important;
    }
    .content-font-family {
        font-family: Montserrat,-apple-system,BlinkMacSystemFont,'Segoe UI',Roboto,'Helvetica Neue',Arial,sans-serif,'Apple Color Emoji','Segoe UI Emoji','Segoe UI Symbol','Noto Color Emoji';
    }

    .content-font-link {
        font-family: Montserrat,-apple-system,BlinkMacSystemFont,'Segoe UI',Roboto,'Helvetica Neue',Arial,sans-serif,'Apple Color Emoji','Segoe UI Emoji','Segoe UI Symbol','Noto Color Emoji';
        color: #0085A1;
    }


    .fullwidth-video {
        position: absolute;
        top: 0;
        left: 0;
        z-index: -1;
        min-height: 100%;
        min-width: 100%;
        -webkit-transform-style: preserve-3d;
    }

        .fullwidth-video video {
            position: absolute;
            top: 0;
            left: 0;
            z-index: -1;
            min-height: 100%;
           ");
            WriteLiteral(" min-width: 100%;\r\n            height: auto;\r\n            width: 100%;\r\n            object-fit: cover;\r\n        }\r\n</style>\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(8393, 1254, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0afca4c523b432a8f98e8f8d6e70171", async() => {
                BeginContext(8399, 1241, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content="""">
    <meta name=""author"" content="""">
    <title>RegionalVICInsight - A guide to moving to regional Victoria</title>
    <!-- Bootstrap core CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
    <!-- Custom fonts for this template -->
    <link href=""vendor/fontawesome-free/css/all.min.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""https://fonts.googleapis.com/css?family=Montserrat:400,700"" rel=""stylesheet"" type=""text/css"">
    <link href='https://fonts.googleapis.com/css?family=Kaushan+Script' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Droid+Serif:400,700,400italic,700italic' rel='stylesheet' type='text/css'>
    <l");
                WriteLiteral("ink href=\'https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700\' rel=\'stylesheet\' type=\'text/css\'>\r\n    <!-- Custom styles for this template -->\r\n    <link href=\"css/agency.min.css\" rel=\"stylesheet\">\r\n\r\n");
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
            BeginContext(9647, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(9649, 17940, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "902e5de55a9f49b5a7f864045acbd0ad", async() => {
                BeginContext(9669, 2034, true);
                WriteLiteral(@"
    <!-- Navigation -->
    <nav class=""navbar navbar-expand-lg navbar-dark fixed-top"" id=""mainNav"">
        <div class=""container"">
            <a class=""navbar-brand js-scroll-trigger"" href=""#page-top"">RegionalVIC&nbsp;Insight</a>
            <button class=""navbar-toggler navbar-toggler-right"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                Menu
                <i class=""fas fa-bars""></i>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                <ul class=""navbar-nav ml-auto"">

                    <li class=""nav-item"">
                        <a class=""nav-link js-scroll-trigger text-nav"" href=""/Map/Recommendation"">Recommendation</a>
                    </li>

                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle text-nav"" href=""/Map"" id=""navbarDropdown"" role=""");
                WriteLiteral(@"button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            Area Insight
                        </a>
                        <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                            <a class=""dropdown-item content-font-family"" href=""/Map#description"">Regional Areas Information</a>
                            <a class=""dropdown-item content-font-family"" href=""/Map#living"">Rent</a>
                            <a class=""dropdown-item content-font-family"" href=""/Map#job"">Job Opportunity</a>
                            <a class=""dropdown-item content-font-family"" href=""/Map#safety"">Safety</a>
                            <a class=""dropdown-item content-font-family"" href=""/Map#culture"">Culture</a>
                        </div>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link js-scroll-trigger text-nav"" href=""/News"">News</a>
                    </li>

");
                EndContext();
                BeginContext(12214, 831, true);
                WriteLiteral(@"
                </ul>
            </div>
        </div>
    </nav>
    <!-- Header -->
    <header class=""masthead"">
        <div class='container'>
            <div class=""fullwidth-video"">
                <video id=""bgvid"" playsinline autoplay muted loop poster=""/video/poster.png"">
                    <source src=""/video/home2.mp4"" type=""video/mp4"">
                </video>
            </div>
            <div class=""intro-text"">
                <div class=""intro-lead-in""></div>
                <div class=""intro-heading"">Planning to move to regional Victoria after graduation?</div>
                <a class=""btn btn-primary btn-xl js-scroll-trigger"" href=""/Map/Recommendation""><i>Let us help!</i></a>
            </div>
        </div>
    </header>

    <!-- Function-->
    <section id=""function"">
");
                EndContext();
                BeginContext(13263, 12517, true);
                WriteLiteral(@"        <br>
        <br>
        <div class=""container"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-12 col-center m-auto"">
                        <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"" data-interval=""0"">
                            <!-- Carousel indicators -->
                            <ol class=""carousel-indicators"">
                                <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
                                <li data-target=""#myCarousel"" data-slide-to=""1""></li>
                            </ol>
                            <!-- Wrapper for carousel items -->
                            <div class=""carousel-inner"">
                                <div class=""item carousel-item active"">
                                    <div class=""row"">
                                        <div class=""col-sm-4"">
                                            <div class=""thum");
                WriteLiteral(@"b-wrapper"">
                                                <div class=""img-box"">
                                                    <img src=""img/carousel/recommendation.jpeg"" class=""img-responsive img-fluid"" alt="""">
                                                </div>
                                                <div class=""thumb-content d-flex align-items-start flex-column"">
                                                    <h4 class=""content-font-family"">Recommendation</h4>
                                                    <p class=""content-font-family"">
                                                        There are too many aspects to consider. Let us help you to find the best options.
                                                    </p>

                                                    <a href=""/Map/recommendation"" class=""btn btn-primary mt-auto"">More <i class=""fa fa-angle-right""></i></a>
                                                </div>
                             ");
                WriteLiteral(@"               </div>
                                        </div>
                                        <div class=""col-sm-4"">
                                            <div class=""thumb-wrapper"">
                                                <div class=""img-box"">
                                                    <img src=""img/carousel/housing.jpeg"" class=""img-responsive img-fluid"" alt="""">
                                                </div>
                                                <div class=""thumb-content d-flex align-items-start flex-column"">
                                                    <h4 class=""content-font-family"">Rent</h4>
                                                    <p class=""content-font-family"">
                                                        Find the regions that have houses or flats within your budget.
                                                    </p>
                                                    <a href=""/Map#living"" class=""btn b");
                WriteLiteral(@"tn-primary mt-auto"">More <i class=""fa fa-angle-right""></i></a>
                                                </div>
                                            </div>
                                        </div>

                                        <div class=""col-sm-4"">
                                            <div class=""thumb-wrapper"">
                                                <div class=""img-box"">
                                                    <img src=""img/carousel/job.jpeg"" class=""img-responsive img-fluid"" alt="""">
                                                </div>
                                                <div class=""thumb-content d-flex align-items-start flex-column"">
                                                    <h4 class=""content-font-family"">Job</h4>
                                                    <p class=""content-font-family"">Find the ideal regional area for your industry to have more job opportunities.</p>
                                    ");
                WriteLiteral(@"                <a href=""/Map#job"" class=""btn btn-primary mt-auto"">More <i class=""fa fa-angle-right""></i></a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""item carousel-item"">
                                    <div class=""row"">
                                        <div class=""col-sm-4"">
                                            <div class=""thumb-wrapper"">
                                                <div class=""img-box"">
                                                    <img src=""img/carousel/safety.png"" class=""img-responsive img-fluid"" alt="""">
                                                </div>
                                                <div class=""thumb-content d-flex align-items-start flex-column"">
                                             ");
                WriteLiteral(@"       <h4 class=""content-font-family"">Safety</h4>
                                                    <p class=""content-font-family"">Find the regions with least criminal rate to live safely.</p>
                                                    <a href=""/Map#safety"" class=""btn btn-primary mt-auto"">More <i class=""fa fa-angle-right""></i></a>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""col-sm-4"">
                                            <div class=""thumb-wrapper"">
                                                <div class=""img-box"">
                                                    <img src=""img/carousel/culture.jpeg"" class=""img-responsive img-fluid"" alt="""">
                                                </div>
                                                <div class=""thumb-content d-flex align-items-start flex-column"">
           ");
                WriteLiteral(@"                                         <h4 class=""content-font-family"">Culture</h4>
                                                    <p class=""content-font-family"">Find the regions with people from your home country and can speak the same language.</p>
                                                    <a href=""/Map#culture"" class=""btn btn-primary mt-auto"">More <i class=""fa fa-angle-right""></i></a>
                                                </div>
                                            </div>
                                        </div>

                                        <div class=""col-sm-4"">
                                            <div class=""thumb-wrapper"">
                                                <div class=""img-box"">
                                                    <img src=""/img/carousel/news.jpg"" class=""img-responsive img-fluid"" alt="""">
                                                </div>
                                                <div class=""thu");
                WriteLiteral(@"mb-content d-flex align-items-start flex-column"">
                                                    <h4 class=""content-font-family"">News</h4>
                                                    <p class=""content-font-family"">Get the latest news related to immigration to stay up to date.</p>
                                                    <a href=""/News"" class=""btn btn-primary mt-auto"">More <i class=""fa fa-angle-right""></i></a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                </div>
                            </div>
                            <!-- Carousel controls -->
                            <a class=""carousel-control left carousel-control-prev"" href=""#myCarousel"" data-slide=""prev"">
                                <i class=""fa fa-angle-left""></i>
                            </a>
                           ");
                WriteLiteral(@" <a class=""carousel-control right carousel-control-next"" href=""#myCarousel"" data-slide=""next"">
                                <i class=""fa fa-angle-right""></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- About -->
    <section id=""about"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 text-center"">
                    <h2 class=""section-heading text-uppercase""><font color=""black"">About us</font></h2>
                </div>
            </div>

            <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                <ol class=""carousel-indicators"">
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                </ol>
             ");
                WriteLiteral(@"   <div class=""carousel-inner"" role=""listbox"">
                    <!-- Slide One - Set the background image for this slide in the line below -->
                    <div class=""carousel-item active"" style=""max-height:380px"">
                        <div class=""carousel-caption row"">
                            <div class=""col-sm-4 align-self-center"">
                                <img class=""rounded-circle img-fluid"" src=""img/about/a1.jpg"" alt="""">
                            </div>
                            <div class=""col-sm-8 align-self-center"">
                                <h6 class=""display-4""><font color=""black"">Background</font></h6>
                                <p class=""content-font-family"">
                                <font color=""black"">
                                    Over population is a major thread for Melbourne. There are lots of competition for the international graduates to get permanent residency in Melbourne. As result, more international graduates are looking ");
                WriteLiteral(@"forward to moving to regional Victoria to get better opportunities to settle in.
                                </font>
                                </p>
                            </div>
                        </div>
                    </div>
                    <!-- Slide Three - Set the background image for this slide in the line below -->
                    <div class=""carousel-item"" style=""max-height:380px"">
                        <div class=""carousel-caption row"">
                            <div class=""col-sm-4 align-self-center"">
                                <img class=""rounded-circle img-fluid"" src=""img/about/a3.jpg"" alt="""">
                            </div>
                            <div class=""col-sm-8 align-self-center"">
                                <h6 class=""display-4""><font color=""black"">Value</font></h6>
                                <p class=""content-font-family"">
                                    <font color=""black"">
                                     ");
                WriteLiteral(@"   Moving to a new regional area is always stressful and confusing. Let us help you to facilitate this process by providing insight on the regional areas of Victoria. Find the most suitable regions to move in according to your preferences.
                                    </font>
                                </p>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- Carousel controls -->
                <a class=""carousel-control left carousel-control-prev"" href=""#carouselExampleIndicators"" data-slide=""prev"">
                    <i class=""fa fa-angle-left""></i>
                </a>
                <a class=""carousel-control right carousel-control-next"" href=""#carouselExampleIndicators"" data-slide=""next"">
                    <i class=""fa fa-angle-right""></i>
                </a>
            </div>
        </div>
    </section>

    <!-- Footer -->
    <footer>
        <div class=""container"">
        ");
                WriteLiteral("    <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    <span class=\"copyright\">\r\n                        Copyright &copy; RegionalVICInsight 2019.\r\n                    </span>\r\n                </div>\r\n");
                EndContext();
                BeginContext(26693, 889, true);
                WriteLiteral(@"                <div class=""col-md-6"">
                    <ul class=""list-inline quicklinks"">
                        <li class=""list-inline-item"">
                            <a href=""/Home/Disclaimer"" class=""content-font-link"">Disclaimer</a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </footer>
    <!-- Bootstrap core JavaScript -->
    <script src=""vendor/jquery/jquery.min.js""></script>
    <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <!-- Plugin JavaScript -->
    <script src=""vendor/jquery-easing/jquery.easing.min.js""></script>
    <!-- Contact form JavaScript -->
    <script src=""js/jqBootstrapValidation.js""></script>
    <script src=""js/contact_me.js""></script>
    <!-- Custom scripts for this template -->
    <script src=""js/agency.min.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(27589, 11, true);
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
