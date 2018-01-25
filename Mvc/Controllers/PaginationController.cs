using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using System.Collections.Generic;
using Telerik.Sitefinity.GenericContent.Model;
using Telerik.Sitefinity.Modules.GenericContent;
using Telerik.Sitefinity.Taxonomies.Model;
using Telerik.Sitefinity.Taxonomies;
using Telerik.OpenAccess;
using Telerik.Sitefinity.Model;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "Pagination", Title = "Pagination", SectionName = "MvcWidgets")]
    public class PaginationController : ContentBaseController
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the ContentTitles.
        /// </summary>
        [Category("String Properties")]
        public string ContentTitles { get; set; }

        /// <summary>
        /// Gets or sets the Category.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the TilePerPage.
        /// </summary>
        public int TilePerPage { get; set; }

        /// <summary>
        /// Gets or sets the WrapTileClasses
        /// </summary>
        public string WrapTileClasses { get; set; }

        /// <summary>
        /// Gets or sets the WrapperClasses
        /// </summary>
        public string WrapperClasses { get; set; }

        [RelativeRoute("{page?}")]
        public ActionResult Index(int? page)
        {
            var contentItems = GetContentItems().ToList();
            var maxPage = (int)Math.Ceiling(contentItems.Count * 1.0 / TilePerPage);
            ViewBag.Page = page;
            var model = new PaginationModel
            {
                ContentItems = contentItems,
                MaxPage = maxPage > 1 ? maxPage : 1
            };

            ViewBag.WrapTileClasses = WrapTileClasses;
            ViewBag.WrapperClasses = WrapperClasses;
            ViewBag.TilePerPage = TilePerPage;
            ViewBag.Id = string.IsNullOrWhiteSpace(Id) ? Guid.NewGuid().ToString() : Id;


            return View("Default", model);
        }

        private IList<ContentItem> GetContentItems()
        {
            var tax = GetCategoryByTitle(Category);
            var contentItem = GetContentByCategory(tax.Id);
            return contentItem;
        }

        public Taxon GetCategoryByTitle(string title)
        {
            var taxonomyMgr = TaxonomyManager.GetManager();

            HierarchicalTaxonomy category = taxonomyMgr.GetTaxonomies<HierarchicalTaxonomy>().Where(x => x.Name == "Categories").SingleOrDefault();

            if (category == null)
            {
                return null;
            }

            return category.Taxa.Where(x => string.Equals(x.Title, title, StringComparison.CurrentCultureIgnoreCase)).SingleOrDefault();
        }

        public List<ContentItem> GetContentByCategory(Guid categoryId)
        {
            var taxonomyMgr = TaxonomyManager.GetManager();
            var contentManager = ContentManager.GetManager();

            // Get the Id of the category
            var taxonId = taxonomyMgr.GetTaxa<HierarchicalTaxon>()
                                     .Where(t => t.Id == categoryId)
                                     .SingleOrDefault()
                                     .Id;

            // Get all news items that are assigned to this category
            var contentItem = contentManager.GetContent().Where(p => p.Status == ContentLifecycleStatus.Live 
                                        && p.GetValue<TrackedList<Guid>>("Category").Contains(taxonId));
            return contentItem.ToList();
        }
    }
}