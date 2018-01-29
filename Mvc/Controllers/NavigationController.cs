using System.Web.Mvc;
using System.Linq;
using Telerik.Sitefinity.Mvc;
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