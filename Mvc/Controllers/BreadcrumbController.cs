using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Breadcrumb", Title = "Breadcrumb", SectionName = "MvcWidgets")]
    public class BreadcrumbController : Controller
    {
        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            return View("Default");
        }
    }
}