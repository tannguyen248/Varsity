using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.Sitefinity.DynamicModules.Model;
using Telerik.Sitefinity.GenericContent.Model;

namespace SitefinityWebApp.Mvc.Models
{
    public class SliderModel
    {
        public ContentItem ContentItem { get; set; }
        public List<DynamicContent> DynamicContentItems { get; set; }
        public string ContainerClasses { get; set; }
        public string TileClasses { get; set; }
    }
}