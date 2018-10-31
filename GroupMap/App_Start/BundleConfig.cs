using System.Web;
using System.Web.Optimization;

namespace GroupMap
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      //"~/Scripts/bootstrap.js",
                      "~/Content/libs/jquery/dist/jquery.min.js",
                      "~/Content/libs/bootstrap/dist/js/bootstrap.min.js",
                      "~/Content/libs/fastclick/lib/fastclick.js",
                      "~/Content/libs/js/adminlte.min.js",
                      "~/Content/libs/jquery-sparkline/dist/jquery.sparkline.min.js",
                      "~/Content/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                      "~/Content/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
                      "~/Content/libs/jquery-slimscroll/jquery.slimscroll.min.js",
                      "~/Content/libs/chart.js/Chart.js",
                      "~/Content/libs/js/pages/dashboard2.js",
                      "~/Content/libs/js/demo.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      //"~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/libs/bootstrap/dist/css/bootstrap.min.css",
                      "~/Content/libs/font-awesome/css/font-awesome.min.css",
                      "~/Content/libs/Ionicons/css/ionicons.min.css",
                      "~/Content/libs/jvectormap/jquery-jvectormap.css",
                      "~/Content/libs/css/AdminLTE.min.css",
                      "~/Content/libs/css/skins/_all-skins.min.css"
                      ));
        }
    }
}
