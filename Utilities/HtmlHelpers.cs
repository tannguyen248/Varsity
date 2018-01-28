using ServiceStack.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace SitefinityWebApp.Utilities
{
    public static class HtmlHelpers
    {
        public static MvcHtmlString ActionLink(string prefix, string actionName, string controllerName, Dictionary<string, string> parameters)
        {
            StringBuilder strBuilder = new StringBuilder("?");
            foreach(var parameter in parameters)
            {
                strBuilder.Append($"{parameter.Key}={parameter.Value}&");
            }

            var link = $"/{prefix}/{controllerName}/{actionName}/{strBuilder.ToString().TrimEnd('&')}";
            return new MvcHtmlString(link);
        }

        public static bool IsActiveNode(SiteMapNode node, string currentUrl)
        {
            var childNodes = node.ChildNodes.Cast<SiteMapNode>();
            var urls = childNodes.Select(x => x.Url.ToLower()).ToList();
            urls.Add(node.Url.ToLower());

            foreach(var url in urls)
            {
                if (url.Contains(currentUrl.ToLower()))
                {
                    return true;
                }
            }

            return false;
        }
    }
}