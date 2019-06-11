using System.Web;
using System.Web.Optimization;

namespace EventHandlingApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/models/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap-rtl.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-rtl.css",
<<<<<<< HEAD
<<<<<<< HEAD
                      "~/Content/bootstrap-theme-rtl.css",
=======
                      "~/content/bootstrap-theme.css",
>>>>>>> 2773124291b16f7d7069971df4bb0f0a3be50023
=======
                      "~/content/bootstrap-theme.css",
>>>>>>> 2773124291b16f7d7069971df4bb0f0a3be50023
                      "~/Content/site.css"));
            BundleTable.EnableOptimizations = true;
        }
    }
}
