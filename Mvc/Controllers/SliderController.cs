using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using Telerik.Sitefinity.GenericContent.Model;
using Telerik.Sitefinity.Modules.GenericContent;
using Telerik.Sitefinity.DynamicModules.Model;
using Telerik.Sitefinity.DynamicModules;
using Telerik.Sitefinity.Model;
using Telerik.Sitefinity.Utilities.TypeConverters;
using SitefinityWebApp.Utilities;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Slider", Title = "Slider", SectionName = "MvcWidgets")]
    public class SliderController : Controller
    {
        public string ContentTitles { get; set; }
        public string ContainerClasses { get; set; }
        public string TileClasses { get; set; }
        public bool isDynamicContent { get; set; }
        public string DynamicContentType { get; set; }
        public string Template { get; set; }

        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            var titles =  !string.IsNullOrWhiteSpace(ContentTitles) ? ContentTitles.Split(',').Select(x => x.Trim()).ToList() : new List<string>();
            var view = string.IsNullOrWhiteSpace(Template) ? "Default" : Template;

            var model = new SliderModel();
            model.ContainerClasses = ContainerClasses;
            model.TileClasses = TileClasses;

            if (isDynamicContent)
            {
                model.DynamicContentItems = GetDynamicContent(titles, DynamicContentType);
            }
            else
            {
                model.ContentItem = GetContent(titles);
            }

            return View(view, model);
        }

        private ContentItem GetContent(List<string> titles)
        {
            ContentManager manager = ContentManager.GetManager();
            var contentItem = manager.GetContent().FirstOrDefault(x => titles.Contains(x.Title));

            return contentItem;
        }

        private List<DynamicContent> GetDynamicContent(List<string> titles, string type)
        {
            //"Telerik.Sitefinity.DynamicTypes.Model.Course.Course"
            var contentItems =  DynamicContentHelpers.GetDynamicContent(type);

            ViewBag.Count = contentItems.Count;
            return contentItems;
        }
    }
}