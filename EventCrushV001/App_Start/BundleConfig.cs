using System.Web.Optimization;

namespace EventCrush
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));

            bundles.Add(new StyleBundle("~/Content/eventcrushcss/css").Include(
                        "~/Content/eventcrushcss/animate.css",
                        "~/Content/eventcrushcss/bootstrap-theme.css",
                        "~/Content/eventcrushcss/bootstrap-thememin.css",
                        "~/Content/eventcrushcss/bootstrap.css",
                        "~/Content/eventcrushcss/bootstrapmin.css",
                        "~/Content/eventcrushcss/custom.css",
                        "~/Content/eventcrushcss/fileinputmin.css",
                        "~/Content/eventcrushcss/jquery-ui.css",
                        "~/Content/eventcrushcss/hover.css",
                        "~/Content/eventcrushcss/bootstrap-datepicker3.css"));

            bundles.Add(new ScriptBundle("~/bundles/eventcrushjs").Include(
                        "~/Scripts/eventcrushjs/jquerymin.js",
                        "~/Scripts/eventcrushjs/bootstrap.js",
                        "~/Scripts/eventcrushjs/bootstrapmin.js",
                        "~/Scripts/eventcrushjs/fileinputmin.js",
                        "~/Scripts/eventcrushjs/headroom.js",
                        "~/Scripts/eventcrushjs/jquery-ui.js",
                        "~/Scripts/eventcrushjs/jQuery.headroommin.js",
                        "~/Scripts/eventcrushjs/bootstrap-datepickerdamin.js",
                        "~/Scripts/eventcrushjs/bootstrap-datepickermin.js",
                        "~/Scripts/eventcrushjs/bootstrap-datepicker.js"));
        }
    }
}