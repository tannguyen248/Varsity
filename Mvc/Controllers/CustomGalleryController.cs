using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using SitefinityWebApp.Utilities;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "CustomGallery", Title = "CustomGallery", SectionName = "MvcWidgets")]
    public class CustomGalleryController : Controller
    {
        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            var gallery = DynamicContentHelpers.GetDynamicContent("Telerik.Sitefinity.DynamicTypes.Model.Gallery.CustomGallery");
            return View("Default", gallery);
        }
    }
}