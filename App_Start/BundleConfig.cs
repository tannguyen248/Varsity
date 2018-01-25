using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SitefinityWebApp.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include(
                    "~/Scripts/jquery.min.js"
                )
            );
            bundles.Add(new ScriptBundle("~/bundles/master")
                .Include(
                    "~/Scripts/waypoints.js",
                    "~/Scripts/jquery.counterup.js",
                    "~/Scripts/slick.min.js",
                    "~/Scripts/bootstrap.js",
                    "~/Scripts/custom.js"
                )
            );

            bundles.Add(new ScriptBundle("~/bundle/pagination")
                .Include(
                    "~/Scripts/pagination.js"
                )
            );



            bundles.Add(new StyleBundle("~/Styles/master")
                .Include(
                    //"~/Styles/bootstrap.css",
                    "~/Styles/default-theme.css",
                    "~/Styles/events.widget.css",
                    "~/Styles/fancybox.css",
                    "~/Styles/font-awesome.css",
                    "~/Styles/galleria.classic.css",
                    "~/Styles/icons.css",
                    "~/Styles/nav.widget.css",
                    "~/Styles/slick.css",
                    "~/Styles/style.css"
                )
           );
        }
    }
}