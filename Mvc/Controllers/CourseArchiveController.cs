using SitefinityWebApp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitefinityWebApp.Mvc.Controllers
{
    public class CourseArchiveController : Controller
    {
        public const int ItemPerPage = 6;

        public ActionResult Index(int page = 1)
        {
            var courses = DynamicContentHelpers.GetDynamicContent("Telerik.Sitefinity.DynamicTypes.Model.Course.Course");
            var maxPage = (int)Math.Ceiling(courses.Count * 1.0 / ItemPerPage);

            if (page > maxPage)
            {
                page = maxPage;
            }
            else if (page <= 0)
            {
                page = 1;
            }

            var selectedCourses = courses.Skip((page - 1)* ItemPerPage).Take(ItemPerPage).ToList();

            ViewBag.CurrentPage = page;
            ViewBag.MaxPage = maxPage;

            return View(selectedCourses);
        }
    }
}