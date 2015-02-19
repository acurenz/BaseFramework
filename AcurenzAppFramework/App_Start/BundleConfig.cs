using System.Web;
using System.Web.Optimization;

namespace AcurenzAppFramework
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

            bundles.Add(new ScriptBundle("~/bundles/notyjs").Include("~/Scripts/noty/jquery.noty.js"));

            var array1 = new string[]{
                "~/Scripts/noty/layouts/bottom.js","~/Scripts/noty/layouts/bottomCenter.js","~/Scripts/noty/layouts/bottomLeft.js","~/Scripts/noty/layouts/bottomRight.js","~/Scripts/noty/layouts/center.js","~/Scripts/noty/layouts/centerLeft.js","~/Scripts/noty/layouts/centerRight.js","~/Scripts/noty/layouts/inline.js","~/Scripts/noty/layouts/top.js","~/Scripts/noty/layouts/topCenter.js","~/Scripts/noty/layouts/topLeft.js","~/Scripts/noty/layouts/topRight.js"};

            bundles.Add(new ScriptBundle("~/bundles/notylayout").Include(
                        array1));
            var array = new string[]{
                "~/Scripts/noty/themes/bootstrap.js","~/Scripts/noty/themes/default.js"};
            bundles.Add(new ScriptBundle("~/bundles/notythemes").Include(array));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/gridmvc.js",
                      "~/Scripts/TwitterBootstrapMvcJs.js",
                      "~/Scripts/bootstrap.typeahead.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/local.css",
                      "~/Content/GridMvc.css",
                      "~/Content/site.css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
