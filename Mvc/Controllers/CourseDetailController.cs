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
using System.Collections.Generic;
using Telerik.Sitefinity.Model;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "CourseDetail", Title = "CourseDetail", SectionName = "MvcWidgets")]
    public class CourseDetailController : ContentBaseController
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [Category("String Properties")]
        public string Message { get; set; }

        /// <summary>
        /// This is the default Action.
        /// </summary>
        [RelativeRoute("{title?}")]
        public ActionResult Index(string title = "")
        {
            ViewData["Title"] = title;

            return View("Default", GetContentItems());
        }

        private List<CourseDetailModel> GetContentItems()
        {
            var dynamicModuleManager = DynamicModuleManager.GetManager();
            var contentType = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.Course.Course");
            var contentItems = dynamicModuleManager.GetDataItems(contentType)
                                        .Where(x => x.Status == Telerik.Sitefinity.GenericContent.Model.ContentLifecycleStatus.Live)
                                        .ToList();

            return ParseToCourseDetailModel(contentItems);
        } 

        public List<CourseDetailModel> ParseToCourseDetailModel(List<DynamicContent> dynamicItems)
        {
            var courseDetailModels = new List<CourseDetailModel>();
            foreach (var item in dynamicItems)
            {
                var model = new CourseDetailModel();
                model.Title = item.GetValue("Title")?.ToString();
                model.LongDescription = item.GetValue("LongDescription")?.ToString();
                model.CourseType = item.GetValue("Type")?.ToString();
                model.DisplayTitle = item.GetValue("DisplayTitle")?.ToString();
                model.ShortDescription = item.GetValue("ShortDescription")?.ToString();
                model.ImageLink = item.GetValue("ImageLink")?.ToString();
                model.Days = item.GetValue("Days")?.ToString();
                model.Price = item.GetValue("Price")?.ToString();
                model.Place = item.GetValue("Place")?.ToString();
                model.TotalStudent = item.GetValue("TotalStudent")?.ToString();
                model.CourseDuration = item.GetValue("CourseDuration")?.ToString();
                model.CourseStart = item.GetValue("CourseStart")?.ToString();

                courseDetailModels.Add(model);
            }

            return courseDetailModels;
        }
    }
}