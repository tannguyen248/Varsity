using Telerik.Sitefinity.DynamicModules.Model;
using Telerik.Sitefinity.Model;
using SitefinityWebApp.Models;
using System.Collections.Generic;
using Telerik.Sitefinity.DynamicModules;
using Telerik.Sitefinity.Utilities.TypeConverters;
using System.Linq;
using Telerik.Sitefinity.GenericContent.Model;
using Telerik.Sitefinity.Data.Linq.Dynamic;

namespace SitefinityWebApp.Utilities
{
    public static class DynamicContentHelpers
    {
        public static List<DynamicContent> GetDynamicContent(string type, string title = "")
        {
            var dynamicModuleManager = DynamicModuleManager.GetManager();
            var contentType = TypeResolutionService.ResolveType(type);
            var contentItems = dynamicModuleManager.GetDataItems(contentType)
                                        .Where(x => x.Status == ContentLifecycleStatus.Live && x.Visible);
            
            if (!string.IsNullOrWhiteSpace(title))
            {
                contentItems = contentItems.Where($"Title.Contains(\"{title}\") && Status=\"Live\"");
            }

            return contentItems.ToList();
        }
    }
}