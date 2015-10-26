﻿using System.Web;
using System.Web.Optimization;

namespace AdminWeb
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/bundles/assetsCss").Include(
                    "~/assets/global/css/family.css",
                    "~/assets/global/plugins/font-awesome/css/font-awesome.min.css",
                    "~/assets/global/plugins/simple-line-icons/simple-line-icons.min.css",
                    "~/assets/global/plugins/bootstrap/css/bootstrap.min.css",
                    "~/assets/global/plugins/uniform/css/uniform.default.css",
                    "~/assets/global/plugins/bootstrap-switch/css/bootstrap-switch.min.css",
                    "~/assets/global/plugins/bootstrap-daterangepicker/daterangepicker-bs3.css",
                    "~/assets/global/plugins/fullcalendar/fullcalendar.min.css",
                    "~/assets/global/plugins/jqvmap/jqvmap/jqvmap.css",
                    "~/assets/admin/pages/css/tasks.css",
                    "~/assets/global/css/components-rounded.css",
                    "~/assets/global/css/plugins.css",
                    "~/assets/admin/layout4/css/layout.css",
                    "~/assets/admin/layout4/css/themes/light.css",
                    "~/assets/admin/layout4/css/custom.css"
                ));
            bundles.Add(new ScriptBundle("~/bundles/assetsJS").Include(
                "~/assets/global/plugins/jquery-migrate.min.js",
                "~/assets/global/plugins/jquery-ui/jquery-ui.min.js",
                "~/assets/global/plugins/bootstrap/js/bootstrap.min.js",
                "~/assets/global/plugins/bootstrap-hover-dropdown/bootstrap-hover-dropdown.min.js",
                "~/assets/global/plugins/jquery-slimscroll/jquery.slimscroll.min.js",
                "~/assets/global/plugins/jquery.blockui.min.js",
                "~/assets/global/plugins/jquery.cokie.min.js",
                "~/assets/global/plugins/uniform/jquery.uniform.min.js",
                "~/assets/global/plugins/bootstrap-switch/js/bootstrap-switch.min.js",
                "~/assets/global/plugins/jqvmap/jqvmap/jquery.vmap.js",
                "~/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.russia.js",
                "~/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.world.js",
                "~/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.europe.js",
                "~/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.germany.js",
                "~/assets/global/plugins/jqvmap/jqvmap/maps/jquery.vmap.usa.js",
                "~/assets/global/plugins/jqvmap/jqvmap/data/jquery.vmap.sampledata.js",
                "~/assets/global/plugins/morris/morris.min.js",
                "~/assets/global/plugins/morris/raphael-min.js",
                "~/assets/global/plugins/jquery.sparkline.min.js",

                "~/assets/global/scripts/metronic.js",
                "~/assets/admin/layout4/scripts/layout.js",
                "~/assets/admin/layout4/scripts/demo.js",
                "~/assets/admin/pages/scripts/index3.js",
                "~/assets/admin/pages/scripts/tasks.js"
                ));
        }
    }
}
