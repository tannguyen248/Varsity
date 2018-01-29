using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using System.Web.UI.WebControls;
using Telerik.Sitefinity.Web;
using System.Collections.Generic;
using System.Web;

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