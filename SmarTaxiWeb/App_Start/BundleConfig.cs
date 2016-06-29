using System.Web;
using System.Web.Optimization;

namespace SmarTaxiWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/js/plugins/jquery/jquery.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jquerycontinue").Include(
                        "~/Scripts/js/plugins/jquery/jquery-ui.min.js",
                        "~/Scripts/js/plugins/bootstrap/bootstrap.min.js",
                        "~/Scripts/js/plugins/icheck/icheck.min.js",
                        "~/Scripts/js/plugins/mcustomscrollbar/jquery.mCustomScrollbar.min.js",
                        "~/Scripts/js/plugins/scrolltotop/scrolltopcontrol.js",
                        "~/Scripts/js/plugins/morris/raphael-min.js",
                        "~/Scripts/js/plugins/morris/morris.min.js",
                        "~/Scripts/js/plugins/rickshaw/d3.v3.js",
                        "~/Scripts/js/plugins/rickshaw/rickshaw.min.js",
                        "~/Scripts/js/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                        "~/Scripts/js/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
                        "~/Scripts/js/plugins/bootstrap/bootstrap-datepicker.js",
                        "~/Scripts/js/plugins/owl/owl.carousel.min.js",
                        "~/Scripts/js/plugins/moment.min.js",
                        "~/Scripts/js/plugins/daterangepicker/daterangepicker.js",
                        "~/Scripts/js/plugins.js",
                        "~/Scripts/js/actions.js",
                        "~/Scripts/js/demo_dashboard.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/theme-default.css",
                      "~/Content/site.css",
                      "~/Content/font-awesome.css"));
        }
    }
}
