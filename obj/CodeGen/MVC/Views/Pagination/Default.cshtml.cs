#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\MVC\Views\Pagination\Default.cshtml"
    using Telerik.Sitefinity.GenericContent.Model;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Pagination/Default.cshtml")]
    public partial class _MVC_Views_Pagination_Default_cshtml : System.Web.Mvc.WebViewPage<SitefinityWebApp.Mvc.Models.PaginationModel>
    {
        public _MVC_Views_Pagination_Default_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 4 "..\..\MVC\Views\Pagination\Default.cshtml"
   
	var paginationId = ViewBag.Id + "pagination";

            
            #line default
            #line hidden
WriteLiteral("\r\n<h1>Page: ");

            
            #line 7 "..\..\MVC\Views\Pagination\Default.cshtml"
     Write(ViewBag.Page);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 193), Tuple.Create("\"", 224)
            
            #line 8 "..\..\MVC\Views\Pagination\Default.cshtml"
, Tuple.Create(Tuple.Create("", 201), Tuple.Create<System.Object, System.Int32>(ViewBag.WrapperClasses
            
            #line default
            #line hidden
, 201), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 225), Tuple.Create("\"", 241)
            
            #line 8 "..\..\MVC\Views\Pagination\Default.cshtml"
, Tuple.Create(Tuple.Create("", 230), Tuple.Create<System.Object, System.Int32>(ViewBag.Id
            
            #line default
            #line hidden
, 230), false)
);

WriteLiteral(">\r\n\t<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\MVC\Views\Pagination\Default.cshtml"
		
            
            #line default
            #line hidden
            
            #line 10 "..\..\MVC\Views\Pagination\Default.cshtml"
         foreach (var item in Model.ContentItems)
		{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<div");

WriteAttribute("class", Tuple.Create(" class=\"", 322), Tuple.Create("\"", 354)
            
            #line 12 "..\..\MVC\Views\Pagination\Default.cshtml"
, Tuple.Create(Tuple.Create("", 330), Tuple.Create<System.Object, System.Int32>(ViewBag.WrapTileClasses
            
            #line default
            #line hidden
, 330), false)
);

WriteLiteral(">\r\n");

WriteLiteral("\t\t\t\t");

            
            #line 13 "..\..\MVC\Views\Pagination\Default.cshtml"
           Write(Html.Raw(item.Content.Value));

            
            #line default
            #line hidden
WriteLiteral(";\r\n\t\t\t</div>\r\n");

            
            #line 15 "..\..\MVC\Views\Pagination\Default.cshtml"
		}

            
            #line default
            #line hidden
WriteLiteral("\t</div>\r\n</div>\r\n\r\n<div");

WriteLiteral(" class=\"mu-pagination\"");

WriteAttribute("id", Tuple.Create(" id=\"", 455), Tuple.Create("\"", 473)
            
            #line 19 "..\..\MVC\Views\Pagination\Default.cshtml"
, Tuple.Create(Tuple.Create("", 460), Tuple.Create<System.Object, System.Int32>(paginationId
            
            #line default
            #line hidden
, 460), false)
);

WriteLiteral(">\r\n\t<nav>\r\n\t\t<ul");

WriteLiteral(" class=\"pagination\"");

WriteLiteral(">\r\n\t\t\t<li>\r\n\t\t\t\t<a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" aria-label=\"Previous\"");

WriteAttribute("class", Tuple.Create(" class=\"", 558), Tuple.Create("\"", 612)
, Tuple.Create(Tuple.Create("", 566), Tuple.Create("btn", 566), true)
            
            #line 23 "..\..\MVC\Views\Pagination\Default.cshtml"
, Tuple.Create(Tuple.Create(" ", 569), Tuple.Create<System.Object, System.Int32>(Model.CurrentPage > 0 ? "" : "disabled"
            
            #line default
            #line hidden
, 570), false)
);

WriteLiteral(">\r\n\t\t\t\t\t<span");

WriteLiteral(" class=\"fa fa-angle-left\"");

WriteLiteral("></span> Prev\r\n\t\t\t\t</a>\r\n\t\t\t</li>\r\n");

            
            #line 27 "..\..\MVC\Views\Pagination\Default.cshtml"
			
            
            #line default
            #line hidden
            
            #line 27 "..\..\MVC\Views\Pagination\Default.cshtml"
             for (var i = 0; i < Model.MaxPage; i++)
			{

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<li");

WriteLiteral(" class=\"active\"");

WriteLiteral("><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">");

            
            #line 29 "..\..\MVC\Views\Pagination\Default.cshtml"
                                           Write(i + 1);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

            
            #line 30 "..\..\MVC\Views\Pagination\Default.cshtml"
			}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<li>\r\n\t\t\t\t<a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" aria-label=\"Next\"");

WriteAttribute("class", Tuple.Create(" class=\"", 839), Tuple.Create("\"", 910)
, Tuple.Create(Tuple.Create("", 847), Tuple.Create("btn", 847), true)
            
            #line 32 "..\..\MVC\Views\Pagination\Default.cshtml"
, Tuple.Create(Tuple.Create(" ", 850), Tuple.Create<System.Object, System.Int32>(Model.CurrentPage >= Model.MaxPage - 1 ? "disabled" : ""
            
            #line default
            #line hidden
, 851), false)
);

WriteLiteral(">\r\n\t\t\t\t\tNext <span");

WriteLiteral(" class=\"fa fa-angle-right\"");

WriteLiteral("></span>\r\n\t\t\t\t</a>\r\n\t\t\t</li>\r\n\t\t</ul>\r\n\t</nav>\r\n</div>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
