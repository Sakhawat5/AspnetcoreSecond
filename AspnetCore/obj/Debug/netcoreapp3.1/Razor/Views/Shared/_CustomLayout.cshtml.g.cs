#pragma checksum "E:\DevSkill\LiaborySystemTow\AspnetCore\Views\Shared\_CustomLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ea13b7fdc728c8a91566c6276205eefc87aee5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CustomLayout), @"mvc.1.0.view", @"/Views/Shared/_CustomLayout.cshtml")]
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
#line 1 "E:\DevSkill\LiaborySystemTow\AspnetCore\Views\_ViewImports.cshtml"
using AspnetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DevSkill\LiaborySystemTow\AspnetCore\Views\_ViewImports.cshtml"
using AspnetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ea13b7fdc728c8a91566c6276205eefc87aee5c", @"/Views/Shared/_CustomLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3be7994e22263b55f36c3483f2f22b93d42eeffa", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CustomLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ea13b7fdc728c8a91566c6276205eefc87aee5c3258", async() => {
                WriteLiteral("\r\n  <meta charset=\"utf-8\">\r\n  <meta content=\"width=device-width, initial-scale=1.0\" name=\"viewport\">\r\n\r\n  <title>Amoeba Bootstrap Template - Home</title>\r\n  <meta");
                BeginWriteAttribute("content", " content=\"", 205, "\"", 215, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"descriptison\">\r\n  <meta");
                BeginWriteAttribute("content", " content=\"", 246, "\"", 256, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""keywords"">

  <!-- Favicons -->
  <link href=""assets/img/favicon.png"" rel=""icon"">
  <link href=""assets/img/apple-touch-icon.png"" rel=""apple-touch-icon"">

  <!-- Google Fonts -->
  <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Lato:400,300,700,900"" rel=""stylesheet"">

  <!-- Vendor CSS Files -->
  <link href=""assets/vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">
  <link href=""assets/vendor/animate.css/animate.min.css"" rel=""stylesheet"">
  <link href=""assets/vendor/icofont/icofont.min.css"" rel=""stylesheet"">
  <link href=""assets/vendor/venobox/venobox.css"" rel=""stylesheet"">

  <!-- Template Main CSS File -->
  <link href=""assets/css/style.css"" rel=""stylesheet"">

  <!-- =======================================================
  * Template Name: Amoeba - v2.0.0
  * Template URL: https://bootstrapmade.com/free-one-page-bootstrap-template-amoeba/
  * Author: BootstrapMade.com
  * License: https://bootstrapmade.com/license/
  ==");
                WriteLiteral("====================================================== -->\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ea13b7fdc728c8a91566c6276205eefc87aee5c5904", async() => {
                WriteLiteral(@"

    <!-- ======= Header ======= -->
    <header id=""header"" class=""fixed-top"">
        <div class=""container"">

            <div class=""logo float-left"">
                <h1 class=""text-light""><a href=""index.html""><span>Amoeba</span></a></h1>
                <!-- Uncomment below if you prefer to use an image logo -->
                <!-- <a href=""index.html""><img src=""assets/img/logo.png"" alt="""" class=""img-fluid""></a>-->
            </div>

            <nav class=""nav-menu float-right d-none d-lg-block"">
                <ul>
                    <li class=""active""><a href=""#header"">Home</a></li>
                    <li><a href=""#about"">About Us</a></li>
                    <li><a href=""#services"">Services</a></li>
                    <li><a href=""#portfolio"">Portfolio</a></li>
                    <li><a href=""#team"">Team</a></li>
                    <li class=""drop-down"">
                        <a");
                BeginWriteAttribute("href", " href=\"", 2290, "\"", 2297, 0);
                EndWriteAttribute();
                WriteLiteral(@">Drop Down</a>
                        <ul>
                            <li><a href=""#"">Drop Down 1</a></li>
                            <li class=""drop-down"">
                                <a href=""#"">Drop Down 2</a>
                                <ul>
                                    <li><a href=""#"">Deep Drop Down 1</a></li>
                                    <li><a href=""#"">Deep Drop Down 2</a></li>
                                    <li><a href=""#"">Deep Drop Down 3</a></li>
                                    <li><a href=""#"">Deep Drop Down 4</a></li>
                                    <li><a href=""#"">Deep Drop Down 5</a></li>
                                </ul>
                            </li>
                            <li><a href=""#"">Drop Down 3</a></li>
                            <li><a href=""#"">Drop Down 4</a></li>
                            <li><a href=""#"">Drop Down 5</a></li>
                        </ul>
                    </li>
                    <li><a href=""#co");
                WriteLiteral("ntact\">Contact Us</a></li>\r\n                </ul>\r\n            </nav><!-- .nav-menu -->\r\n\r\n        </div>\r\n    </header><!-- End #header -->\r\n    <!-- ======= Hero Section ======= -->\r\n");
                WriteLiteral("<!-- #hero -->\r\n    ");
#nullable restore
#line 88 "E:\DevSkill\LiaborySystemTow\AspnetCore\Views\Shared\_CustomLayout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <!-- End #main -->
    <!-- ======= Footer ======= -->
    <footer id=""footer"">
        <div class=""container"">
            <div class=""copyright"">
                &copy; Copyright <strong><span>Amoeba</span></strong>. All Rights Reserved
            </div>
            <div class=""credits"">
                <!-- All the links in the footer should remain intact. -->
                <!-- You can delete the links only if you purchased the pro version. -->
                <!-- Licensing information: https://bootstrapmade.com/license/ -->
                <!-- Purchase the pro version with working PHP/AJAX contact form: https://bootstrapmade.com/free-one-page-bootstrap-template-amoeba/ -->
                Designed by <a href=""https://bootstrapmade.com/"">BootstrapMade</a>
            </div>
        </div>
    </footer><!-- End #footer -->

    <a href=""#"" class=""back-to-top""><i class=""icofont-simple-up""></i></a>

    <!-- Vendor JS Files -->
    <script src=""assets/vendor/jquery/jquery.min.j");
                WriteLiteral(@"s""></script>
    <script src=""assets/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <script src=""assets/vendor/jquery.easing/jquery.easing.min.js""></script>
    <script src=""assets/vendor/php-email-form/validate.js""></script>
    <script src=""assets/vendor/isotope-layout/isotope.pkgd.min.js""></script>
    <script src=""assets/vendor/venobox/venobox.min.js""></script>

    <!-- Template Main JS File -->
    <script src=""assets/js/main.js""></script>

");
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
            WriteLiteral("\r\n\r\n</html>");
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