using System.Web;
using System.Web.Optimization;

namespace Aprel
{
    public class BundleConfig
    {
       
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/lightslider.js",
                      "~/Scripts/jquery-1.12.4.js",
                      "~/Scripts/jquery-ui.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/lightslider.css",
                      "~/Content/site.css",
                      "~/Content/style.css",
                      "~/Content/jquery-ui.css"
                      ));



        }
    }
}
