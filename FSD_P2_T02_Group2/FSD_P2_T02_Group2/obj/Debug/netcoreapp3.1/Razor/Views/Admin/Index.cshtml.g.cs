#pragma checksum "C:\Users\gekteng\Downloads\ngee ann\year 2.2\P2\FSD_P2_T02_Group2\FSD_P2_T02_Group2\FSD_P2_T02_Group2\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9602ab43fbe7511d04f2e7feecec4967187993c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\gekteng\Downloads\ngee ann\year 2.2\P2\FSD_P2_T02_Group2\FSD_P2_T02_Group2\FSD_P2_T02_Group2\Views\_ViewImports.cshtml"
using FSD_P2_T02_Group2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gekteng\Downloads\ngee ann\year 2.2\P2\FSD_P2_T02_Group2\FSD_P2_T02_Group2\FSD_P2_T02_Group2\Views\_ViewImports.cshtml"
using FSD_P2_T02_Group2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\gekteng\Downloads\ngee ann\year 2.2\P2\FSD_P2_T02_Group2\FSD_P2_T02_Group2\FSD_P2_T02_Group2\Views\Admin\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gekteng\Downloads\ngee ann\year 2.2\P2\FSD_P2_T02_Group2\FSD_P2_T02_Group2\FSD_P2_T02_Group2\Views\Admin\Index.cshtml"
using FSD_P2_T02_Group2.DAL;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9602ab43fbe7511d04f2e7feecec4967187993c3", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e46c3380dd73357cc86ca3b27f4d565432fd755a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/bootstrap/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/bootstrap/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\gekteng\Downloads\ngee ann\year 2.2\P2\FSD_P2_T02_Group2\FSD_P2_T02_Group2\FSD_P2_T02_Group2\Views\Admin\Index.cshtml"
   
    Layout = "_UserLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9602ab43fbe7511d04f2e7feecec4967187993c35275", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <link rel=""apple-touch-icon"" sizes=""76x76"" href=""../assets/img/apple-icon.png"">
    <link rel=""icon"" type=""image/png"" href=""../assets/img/favicon.png"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"" />
    <meta content='width=device-width, initial-scale=1.0, shrink-to-fit=no' name='viewport' />
    <!--     Fonts and icons     -->
    <link rel=""stylesheet"" type=""text/css"" href=""https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons"" />
    <link href=""https://fonts.googleapis.com/icon?family=Material+Icons"" rel=""stylesheet"">
    <!-- CSS Files -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9602ab43fbe7511d04f2e7feecec4967187993c36224", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9602ab43fbe7511d04f2e7feecec4967187993c37402", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script type=\"text/javascript\" src=\"https://www.gstatic.com/charts/loader.js\"></script>\r\n");
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
            WriteLiteral("\r\n\r\n\r\n</html>\r\n");
#nullable restore
#line 43 "C:\Users\gekteng\Downloads\ngee ann\year 2.2\P2\FSD_P2_T02_Group2\FSD_P2_T02_Group2\FSD_P2_T02_Group2\Views\Admin\Index.cshtml"
  
    UserDAL user = new UserDAL();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-lg-3 col-md-6 col-sm-6"">
                <div class=""card card-stats"">
                    <div class=""card-header card-header-warning card-header-icon"">
                        <i class=""large material-icons"">person</i>
                        Total No. Of Users
                        <h3 class=""card-title"">
                            ");
#nullable restore
#line 55 "C:\Users\gekteng\Downloads\ngee ann\year 2.2\P2\FSD_P2_T02_Group2\FSD_P2_T02_Group2\FSD_P2_T02_Group2\Views\Admin\Index.cshtml"
                       Write(user.CountUser());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </h3>
                        <small>Users</small>
                    </div>
                </div>
            </div>

            <div class=""col-lg-3 col-md-6 col-sm-6"">
                <div class=""card card-stats"">
                    <div class=""card-header card-header-success card-header-icon"">
                        <div class=""card-icon"">
                            <i class=""large material-icons"">person_add</i>
                            No. Of New Signups
                        </div>
                        <h3 class=""card-title"">34,245</h3>
                        <small>Users</small>
                    </div>
                    <div class=""card-footer"">
                        <div class=""stats"">
                            <i class=""material-icons"">date_range</i> Last 24 Hours
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div id=""curve_chart"" style=""width: 1400px;");
            WriteLiteral(@" height: 700px;""></div>
    </div>
</div>

<script type=""text/javascript"">google.charts.load('current', { 'packages': ['corechart'] });
    google.charts.setOnLoadCallback(drawChart);

    function drawChart() {
        var data = google.visualization.arrayToDataTable([
            ['Year', 'Value'],
            ['2019-01', 2726368],
            ['2019-02', 2522088],
            ['2019-03', 2787741],
            ['2019-04', 2700598],
            ['2019-05', 2691345],
            ['2019-06', 2834087],
            ['2019-07', 2853267],
            ['2019-08', 2911530],
            ['2019-09', 2682724],
            ['2019-10', 2801262],
            ['2019-11', 2855679],
            ['2019-12', 3132828],
            ['2020-01', 2855679],
            ['2020-02', 2893053]
            //['2020-03',  1000],
            //['2020-04',  1000],
            //['2020-05',  1000],
            //['2020-06',  1000],
            //['2020-07',  1000],
            //['2020-08',  1000],
            /");
            WriteLiteral(@"/['2020-09',  1000],
            //['2020-10',  1000],
            //['2020-11',  1000],
            //['2020-12',  1000],
        ]);

        var options = {
            title: 'No. of Users',
            curveType: 'function',
            legend: { position: 'bottom' }
        };

        var chart = new google.visualization.LineChart(document.getElementById('curve_chart'));

        chart.draw(data, options);
    }</script>
");
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