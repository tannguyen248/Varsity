using System.Web.Mvc;
using System.Linq;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using Telerik.Sitefinity.Modules.Pages;
using Telerik.Sitefinity.Pages.Model;
using Telerik.Sitefinity.Web.UI.NavigationControls;
using Telerik.Sitefinity.Web;
using Telerik.Sitefinity.Model;
using System.Web;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Navigation", Title = "Navigation", SectionName = "MvcWidgets")]
    public class NavigationController : Controller
    {
        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            return View("Default", Utilities.Utils.GetNavigationNodes());
        }
    }
}