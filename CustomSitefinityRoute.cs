using System;
using System.Globalization;
using System.Web;
using System.Web.Routing;
using Telerik.Microsoft.Practices.Unity;
using Telerik.Sitefinity.Abstractions;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Localization.UrlLocalizationStrategies;
using Telerik.Sitefinity.Modules.Pages.Configuration;
using Telerik.Sitefinity.Pages.Model;
using Telerik.Sitefinity.Services;
using Telerik.Sitefinity.Web;

namespace SitefinityWebApp
{
    public class CustomSitefinityRoute : SitefinityRoute
    {
        public override System.Web.Routing.RouteData GetRouteData(HttpContextBase httpContext)
        {
            //get the path from the httpContext variable and parse it
            var virtuallPath = this.GetVirtualPathInternal(httpContext);
            //where dougtestcoursedetails is the Name of the Virtual Page in SiteFinity
            if (virtuallPath.Contains("course-detail"))
            {
                if (!(virtuallPath.Contains(".css")) && !(virtuallPath.Contains(".js")))
                {
                    //parse the acutal path to find the PageSiteNode from the sitemap provider
                    var sitemapProvider = this.GetSiteMapProvider();
                    if (sitemapProvider == null)
                        return null;
                    bool isAdditional;
                    string[] pars;
                    //where Training/dougtestcoursedetails is the Virtual Path in SiteFinity
                    var node = sitemapProvider.FindSiteMapNode("course", false, out isAdditional, out pars);
                    if (node != null)
                        return this.GetRouteDataInternal(pars, httpContext.Request.QueryString, node);
                }
            }
            return base.GetRouteData(httpContext);
        }

        public static void RegisterType()
        {
            ObjectFactory.Container.RegisterType<SitefinityRoute, CustomSitefinityRoute>();
        }
    }
}