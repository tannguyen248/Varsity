using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SitefinityWebApp.Mvc.Models
{
    public class NavigationModel
    {
        /// <summary>
        /// Display Text
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// Navigation Link
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Chid
        /// </summary>
        public IList<NavigationModel> Children { get; set; }
    }
}