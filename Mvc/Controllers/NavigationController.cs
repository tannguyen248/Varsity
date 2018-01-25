using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

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
            return View("Default", GetNavigationItems());
        }

        private List<NavigationModel> GetNavigationItems()
        {
            var data = System.IO.File.ReadAllText(Constant.ConfigurationSource.Navigation);
            return JsonConvert.DeserializeObject<List<NavigationModel>>(data);
        }
    }
}