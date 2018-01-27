using SitefinityWebApp.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Optimization;
using System.Web.Security;
using System.Web.SessionState;
using Telerik.Sitefinity.Abstractions;

namespace SitefinityWebApp
{
    public class Global : System.Web.HttpApplication
    {

        void Bootstrapper_Initialized(object sender, Telerik.Sitefinity.Data.ExecutedEventArgs e)
        {
            if (e.CommandName == "Bootstrapped")
            {
                System.Web.Mvc.RouteCollectionExtensions.MapRoute(
                    System.Web.Routing.RouteTable.Routes,
                    "Classic",
                    "Course/{controller}/{action}/{id}",
                    new { controller = "CourseArchive", action = "Index", id = (string)null }
                );
            }
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            Bootstrapper.Initialized += Bootstrapper_Initialized;

            BundleConfig.RegisterBundles(BundleTable.Bundles);

            BundleTable.VirtualPathProvider = HostingEnvironment.VirtualPathProvider;
            // CHANGE THIS TO ENABLING BUNDLING
            BundleTable.EnableOptimizations = false;
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}