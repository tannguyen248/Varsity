using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telerik.Sitefinity.Web;

namespace SitefinityWebApp.Utilities
{
    public static class Utils
    {
        public static string EncodeDetailTitle(string title)
        {
            return title.Replace(" ", "-");
        }

        public static string DecodeDetailTitle(string encodedTitle)
        {
            return encodedTitle.Replace("-", " ");
        }

        public static List<SiteMapNode> GetNavigationNodes()
        {
            var provider = SiteMapBase.GetSiteMapProvider("FrontendSiteMap");
            var nodes = provider.GetChildNodes(provider.RootNode);

            var siteMapNodes = new SiteMapNode[nodes.Count];
            nodes.CopyTo(siteMapNodes, 0);
            var showNodes = siteMapNodes.Where(x => ((PageSiteNode)x).ShowInNavigation == true).ToList();

            var course = new SiteMapNode(provider, "key", "~/Course", "Course");
            var courseArchive = new SiteMapNode(provider, "key", "~/Course/CourseArchive/Index", "Course Archive");
            var courseDetail = new SiteMapNode(provider, "key", "~/Course/CourseDetail/Index", "Course Detail");
            var childNodes = new SiteMapNodeCollection(new SiteMapNode[] { courseArchive, courseDetail });
            course.ChildNodes = childNodes;
            showNodes.Insert(1, course);

            return showNodes;
        }
    }
}