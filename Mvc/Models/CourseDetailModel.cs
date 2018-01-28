using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.Sitefinity.DynamicModules.Model;

namespace SitefinityWebApp.Mvc.Models
{
    public class CourseDetailModel
    {
        public DynamicContent CourseDetail { get; set; }
        public List<DynamicContent> RelatedCourses { get; set; }
    }
}