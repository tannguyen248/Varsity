using System.Collections.Generic;
using Telerik.Sitefinity.GenericContent.Model;

namespace SitefinityWebApp.Mvc.Models
{
    public class PaginationModel
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public IList<ContentItem> ContentItems { get; set; }

        public int MaxPage { get; set; }

        public int CurrentPage { get; set; }
    }
}