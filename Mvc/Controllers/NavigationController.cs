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
using Telerik.Sitefinity.SitemapGenerator;

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
            PageManager pageManager = PageManager.GetManager();
            var pages = pageManager.GetPageNodes().Where(x => x.ShowInNavigation == true).Select(x => x.GetFullTitlesPath("/")).ToList();
            ViewBag.Pages = pages;
            

            return View("Default", GetNavigationItems());
        }

        private List<NavigationModel> GetNavigationItems()
        {
            var data = System.IO.File.ReadAllText(Constant.ConfigurationSource.Navigation);
            return JsonConvert.DeserializeObject<List<NavigationModel>>(data);
        }
    }
}