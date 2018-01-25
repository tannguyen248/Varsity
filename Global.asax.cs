using SitefinityWebApp.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Optimization;
using System.Web.Security;
using System.Web.SessionState;

namespace SitefinityWebApp
{
    public class Global : System.Web.HttpApplication
    {

        void Bootstrapper_Initialized(object sender, Telerik.Sitefinity.Data.ExecutedEventArgs args)
        {
            if (args.CommandName == "RegisterRoutes")
            {
                //YES: I can intercept the web request; but it is not "REROUTING";  it is intercepting
                System.Web.Routing.RouteTable.Routes.Insert(0, new CustomSitefinityRoute());
            }
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            BundleTable.VirtualPathProvider = HostingEnvironment.VirtualPathProvider;
            // CHANGE THIS TO ENABLING BUNDLING
            BundleTable.EnableOptimizations = false;

            //Telerik.Sitefinity.Abstractions.Bootstrapper.Initialized += new EventHandler<Telerik.Sitefinity.Data.ExecutedEventArgs>(Bootstrapper_Initialized);
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