#pragma checksum "C:\Users\lenovo\source\repos\Omdbapi\Omdbapi.Cms\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2d4e978e4fbb4e2d7e709dfe7676e36103bd208"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\lenovo\source\repos\Omdbapi\Omdbapi.Cms\Views\_ViewImports.cshtml"
using Omdbapi.Cms;

#line default
#line hidden
#line 2 "C:\Users\lenovo\source\repos\Omdbapi\Omdbapi.Cms\Views\_ViewImports.cshtml"
using Omdbapi.Cms.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2d4e978e4fbb4e2d7e709dfe7676e36103bd208", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0f478e7adfdb87d56e4004243d0524eb0aabd6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/avatar1_small.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/multiple-select.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 39, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(39, 1572, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2d4e978e4fbb4e2d7e709dfe7676e36103bd2086280", async() => {
                BeginContext(45, 134, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta name=\"description\"");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 179, "\"", 213, 1);
#line 8 "C:\Users\lenovo\source\repos\Omdbapi\Omdbapi.Cms\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 189, ViewData["description"], 189, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(214, 26, true);
                WriteLiteral(">\r\n    <meta name=\"author\"");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 240, "\"", 269, 1);
#line 9 "C:\Users\lenovo\source\repos\Omdbapi\Omdbapi.Cms\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 250, ViewData["author"], 250, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(270, 27, true);
                WriteLiteral(">\r\n    <meta name=\"keyword\"");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 297, "\"", 328, 1);
#line 10 "C:\Users\lenovo\source\repos\Omdbapi\Omdbapi.Cms\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 307, ViewData["Keywords"], 307, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(329, 71, true);
                WriteLiteral(">\r\n    <link rel=\"shortcut icon\" href=\"img/favicon.png\">\r\n\r\n    <title>");
                EndContext();
                BeginContext(401, 17, false);
#line 13 "C:\Users\lenovo\source\repos\Omdbapi\Omdbapi.Cms\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(418, 917, true);
                WriteLiteral(@" - InGameCore.WebUI.CMS</title>

    <!-- Bootstrap core CSS -->
    <link href=""/css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""/css/bootstrap-reset.css"" rel=""stylesheet"">
    <!--external css-->

    <link href=""/assets/font-awesome/css/all.min.css"" rel=""stylesheet"" />
    <link href=""/assets/jquery-easy-pie-chart/jquery.easy-pie-chart.css"" rel=""stylesheet"" type=""text/css"" media=""screen"" />
    <link rel=""stylesheet"" href=""/css/owl.carousel.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""/css/jquery.fancybox.min.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""/css/multiple-select.css"" type=""text/css"">
    <link href=""https://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css"" rel=""stylesheet"" />
    <!-- Custom styles for this template -->
    <link href=""/css/style.css"" rel=""stylesheet"">
    <link href=""/css/style-responsive.css"" rel=""stylesheet"" />

    ");
                EndContext();
                BeginContext(1336, 40, false);
#line 30 "C:\Users\lenovo\source\repos\Omdbapi\Omdbapi.Cms\Views\Shared\_Layout.cshtml"
Write(RenderSection("Styles", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(1376, 228, true);
                WriteLiteral("\r\n    <!-- HTML5 shim and Respond.js IE8 support of HTML5 tooltipss and media queries -->\r\n    <!--[if lt IE 9]>\r\n      <script src=\"js/html5shiv.js\"></script>\r\n      <script src=\"js/respond.min.js\"></script>\r\n    <![endif]-->\r\n");
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
            BeginContext(1611, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1615, 5338, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2d4e978e4fbb4e2d7e709dfe7676e36103bd20810939", async() => {
                BeginContext(1621, 408, true);
                WriteLiteral(@"
    <section id=""container"">
        <header class=""header white-bg"">
            <div id=""sidebarLogo"">
                <div class=""sidebar-toggle-box"">
                    <div class=""fa fa-bars tooltips"" data-placement=""right"" data-original-title=""Toggle Navigation""></div>
                </div>
                <div class=""logoStart"">
                    <!--logo start-->
                    ");
                EndContext();
                BeginContext(2029, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2d4e978e4fbb4e2d7e709dfe7676e36103bd20811746", async() => {
                    BeginContext(2086, 11, true);
                    WriteLiteral("  Anasayfa ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2101, 590, true);
                WriteLiteral(@"
                    <!--logo end-->
                </div>


            </div>


            <div class=""top-nav "">
                <!--search & user info start-->

                <ul class=""nav pull-right top-menu"">
                    <li>
                        <input type=""text"" class=""form-control search"" placeholder=""Search"">
                    </li>
                    <!-- user login dropdown start-->
                    <li class=""dropdown"">
                        <a data-toggle=""dropdown"" class=""dropdown-toggle"" href=""#"">
                            ");
                EndContext();
                BeginContext(2691, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c2d4e978e4fbb4e2d7e709dfe7676e36103bd20814121", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2733, 468, true);
                WriteLiteral(@"

                            <b class=""caret""></b>
                        </a>
                        <ul class=""dropdown-menu extended logout"">


                            <li><a href=""#""><i class="" fa fa-suitcase""></i>Profile</a></li>
                            <li><a href=""#""><i class=""fa fa-cog""></i> Settings</a></li>
                            <li><a href=""#""><i class=""fa fa-bell-o""></i> Notification </a></li>
                            <li>");
                EndContext();
                BeginContext(3201, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2d4e978e4fbb4e2d7e709dfe7676e36103bd20815935", async() => {
                    BeginContext(3249, 30, true);
                    WriteLiteral("Exit <i class=\"fa fa-key\"></i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3283, 1048, true);
                WriteLiteral(@"</li>

                        </ul>
                    </li>
                    <!-- user login dropdown end -->
                </ul>


            </div>
        </header>
        <!--header start-->
        <!--header end-->
        <!--sidebar start-->


        <style>
            .fa-HomeManagement:before {
                content: ""\f0c0"";
            }



            .fa-PcCollectionManagement:before {
                content: ""\f084"";
            }
        </style>
        <aside>
            <div class=""sidebar nav-collapse"" id=""sidebar"">
                <ul class=""navigation sidebar-menu"">
                    <li><a href=""/Home/Index""><i class=""fa fa-HomeManagement""></i> Anasayfa </a></li>
 
                </ul>
            </div>
        </aside>


         <section id=""main-content"">
            <section class=""wrapper"">
                <div class=""panel"">
                    <div class=""panel-body"">
                        <div class=""col-md-12"">
    ");
                WriteLiteral("                        ");
                EndContext();
                BeginContext(4332, 12, false);
#line 116 "C:\Users\lenovo\source\repos\Omdbapi\Omdbapi.Cms\Views\Shared\_Layout.cshtml"
                       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(4344, 1100, true);
                WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </section>
        </section>
    </section>

    <!-- js placed at the end of the document so the pages load faster -->
    <script src=""/js/jquery.js""></script>
    <script src=""/js/jquery-1.8.3.min.js""></script>
    <script src=""https://code.jquery.com/ui/1.12.1/jquery-ui.js""></script>
    <script src=""/js/bootstrap.min.js""></script>
    <script class=""include"" type=""text/javascript"" src=""/js/jquery.dcjqaccordion.2.7.js""></script>
    <script src=""/js/jquery.scrollTo.min.js""></script>
    <script src=""/js/jquery.nicescroll.js"" type=""text/javascript""></script>
    <script src=""/js/jquery.sparkline.js"" type=""text/javascript""></script>
    <script src=""/assets/jquery-easy-pie-chart/jquery.easy-pie-chart.js""></script>
    <script src=""/js/owl.carousel.js""></script>
    <script src=""/js/jquery.customSelect.min.js""></script>
    <script src=""/js/respond.min.js""></script>
    <script src=""/js/jscolor");
                WriteLiteral(".js\"></script>\r\n    <script src=\"/js/jquery.fancybox.min.js\"></script>\r\n    ");
                EndContext();
                BeginContext(5444, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2d4e978e4fbb4e2d7e709dfe7676e36103bd20820280", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5491, 1411, true);
                WriteLiteral(@"

    <!--common script for all pages-->
    <script src=""/js/common-scripts.js""></script>

    <!--script for this page-->
    <script src=""/js/sparkline-chart.js""></script>
    <script src=""/js/easy-pie-chart.js""></script>
    <script src=""/js/count.js""></script>

    <script>

        var path = window.location.pathname.split('/');
        var pageUrl = ""/"" + path[1];
        var sidebarMenuItems = document.querySelectorAll('.sidebar-menu li a');
        sidebarMenuItems.forEach(function (item) {
            if (item.getAttribute(""href"") === pageUrl) {
                item.classList.add(""active"");
            }
        });

        //owl carousel

        $(document).ready(function () {
            LayoutPageDocument();

        });

        //custom select box

       

    </script>

    <script src=""/js/lib/site.js""></script>
    <script src=""/js/jquery.maskedinput.js""></script>

    <script>
        function readURL(input) {
            if (input.files && input.fi");
                WriteLiteral(@"les[0]) {
                var reader = new FileReader();

                reader.onload = function (e) {
                    $('#selectedImage').attr('src', e.target.result);
                }

                reader.readAsDataURL(input.files[0]);
            }
        }

        $(""#file"").change(function () {
            readURL(this);
        });
    </script>

    ");
                EndContext();
                BeginContext(6903, 41, false);
#line 194 "C:\Users\lenovo\source\repos\Omdbapi\Omdbapi.Cms\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(6944, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(6953, 11, true);
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