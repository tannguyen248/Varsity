using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using SitefinityWebApp.Mvc.Models;
using Telerik.Sitefinity.Modules.GenericContent;
using Telerik.Sitefinity.Frontend.InlineEditing.Attributes;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "HTMLContent", Title = "HTMLContent", SectionName = "MvcWidgets")]
    public class HTMLContentController : Controller
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [Category("String Properties")]
        [DynamicLinksContainer]
        [FieldInfo("Content", "LongText")]
        public string Message { get; set; }

        /// <summary>
        /// This is the default Action.
        /// </summary>
        public ActionResult Index()
        {
            var model = new HTMLContentModel();
            model.Message = this.Message;

            return View("Default", model);
        }
    }
}