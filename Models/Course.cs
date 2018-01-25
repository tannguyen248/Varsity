using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.Models
{
    public class Course
    {
        public string CourseOutline { get; set; }
        public string Title { get; set; }
        public string LongDescription { get; set; }
        public string Type { get; set; }
        public string DisplayTitle { get; set; }
        public string ShortDescription { get; set; }
        public string ImageLink { get; set; }
        public string Day { get; set; }
        public string Price { get; set; }
        public string Place { get; set; }
        public string TotalStudent { get; set; }
        public string CourseDuration { get; set; }
        public string CourseStart { get; set; }
    }
}