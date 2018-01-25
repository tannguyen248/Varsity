using Telerik.Sitefinity.DynamicModules.Model;
using Telerik.Sitefinity.Model;
using SitefinityWebApp.Models;

namespace SitefinityWebApp.Services
{
    public static class DynamicContentHelper
    {
        public static Course ParseDynamicContent(DynamicContent dynamicItem)
        {
            var course = new Course();
            course.Title = dynamicItem.GetValue("Title")?.ToString();
            course.LongDescription = dynamicItem.GetValue("LongDescription")?.ToString();
            course.Type = dynamicItem.GetValue("Type")?.ToString();
            course.DisplayTitle = dynamicItem.GetValue("DisplayTitle")?.ToString();
            course.ShortDescription = dynamicItem.GetValue("ShortDescription")?.ToString();
            course.ImageLink = dynamicItem.GetValue("ImageLink")?.ToString();
            course.Day = dynamicItem.GetValue("Days")?.ToString();
            course.Price = dynamicItem.GetValue("Price")?.ToString();
            course.Place = dynamicItem.GetValue("Place")?.ToString();
            course.TotalStudent = dynamicItem.GetValue("TotalStudent")?.ToString();
            course.CourseDuration = dynamicItem.GetValue("CourseDuration")?.ToString();
            course.CourseStart = dynamicItem.GetValue("CourseStart")?.ToString();

            return course;
        }
    }
}