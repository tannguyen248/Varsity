using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using Telerik.Sitefinity.Data.Linq.Dynamic;
using Telerik.Sitefinity.Utilities.TypeConverters;
using Telerik.Sitefinity.Data.Metadata;
using Telerik.Sitefinity.DynamicModules;
using System.Collections;
using Telerik.Sitefinity.DynamicModules.Model;
using SitefinityWebApp.Utilities;
using Telerik.Sitefinity.RelatedData;
using Telerik.Sitefinity.GenericContent.Model;

namespace SitefinityWebApp.Mvc.Controllers
{
    public class CourseDetailController : Controller
    {
        public ActionResult Index(string title = "Engineering-Lorem-ipsum-dolor-sit-amet")
        {
            var course = DynamicContentHelpers.GetDynamicContent("Telerik.Sitefinity.DynamicTypes.Model.Course.Course", Utils.DecodeDetailTitle(title)).FirstOrDefault();
            var courses = DynamicContentHelpers.GetDynamicContent("Telerik.Sitefinity.DynamicTypes.Model.Course.Course");
            var outlines = course.GetRelatedItems<DynamicContent>("Outline")
                                    .ToList();

            var model = new CourseDetailModel
            {
                CourseDetail = course,
                Outlines = outlines,
                RelatedCourses = courses
            };

            return View(model);
        }
    }
}