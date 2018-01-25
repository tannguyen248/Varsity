using System;
using System.Linq;

namespace SitefinityWebApp.Mvc.Models
{
    public class CourseDetailModel
    {
        public string Title { get; set; }
        public string LongDescription { get; set; }
        public string CourseType { get; set; }
        public string DisplayTitle { get; set; }
        public string ShortDescription { get; set; }
        public string ImageLink { get; set; }
        public string Days { get; set; }
        public string Price { get; set; }
        public string Place { get; set; }
        public string TotalStudent { get; set; }
        public string CourseDuration { get; set; }
        public string CourseStart { get; set; }
    }
}