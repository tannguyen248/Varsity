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

namespace SitefinityWebApp.ResourcePackages.Bootstrap.MVC.Views.LanguageSelector
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
    
    #line 4 "..\..MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/LanguageSelector/LanguageSelector.LanguageLinks.cshtml")]
    public partial class LanguageSelector_LanguageLinks : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.LanguageSelector.LanguageSelectorViewModel>
    {

#line 25 "..\..MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
public System.Web.WebPages.HelperResult GetClass(string culture)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 26 "..\..MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
 
    if (Model.CurrentLanguage == culture)
    {
        

#line default
#line hidden

#line 29 "..\..MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
WriteTo(__razor_helper_writer, Html.Raw("selected"));


#line default
#line hidden

#line 29 "..\..MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
                             ;
    }


#line default
#line hidden
});

#line 31 "..\..MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
}
#line default
#line hidden

        public LanguageSelector_LanguageLinks()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 190), Tuple.Create("\"", 213)
            
            #line 6 "..\..MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
, Tuple.Create(Tuple.Create("", 198), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 198), false)
);

WriteLiteral(">\n    <ul");

WriteLiteral(" class=\"sf-lang-selector list-inline\"");

WriteLiteral(">\n");

            
            #line 8 "..\..MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
        
            
            #line default
            #line hidden
            
            #line 8 "..\..MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
         foreach (var language in Model.Languages)
        {

            
            #line default
            #line hidden
WriteLiteral("            <li>\n");

            
            #line 11 "..\..MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
                
            
            #line default
            #line hidden
            
            #line 11 "..\..MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
                 if (SystemManager.IsDesignMode)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <a");

WriteLiteral(" href=\"\"");

WriteLiteral(" onclick=\"return false;\"");

WriteAttribute("class", Tuple.Create(" class=\"", 461), Tuple.Create("\"", 496)
            
            #line 13 "..\..MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
, Tuple.Create(Tuple.Create("", 469), Tuple.Create<System.Object, System.Int32>(GetClass(language.Culture)
            
            #line default
            #line hidden
, 469), false)
);

WriteLiteral(">");

            
            #line 13 "..\..MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
                                                                                      Write(language.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a>\n");

            
            #line 14 "..\..MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("\t                <a");

WriteLiteral(" href=\"\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 608), Tuple.Create("\"", 662)
, Tuple.Create(Tuple.Create("", 618), Tuple.Create("openLink(\'", 618), true)
            
            #line 17 "..\..MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
, Tuple.Create(Tuple.Create("", 628), Tuple.Create<System.Object, System.Int32>(language.Culture
            
            #line default
            #line hidden
, 628), false)
, Tuple.Create(Tuple.Create("", 645), Tuple.Create("\');", 645), true)
, Tuple.Create(Tuple.Create(" ", 648), Tuple.Create("return", 649), true)
, Tuple.Create(Tuple.Create(" ", 655), Tuple.Create("false;", 656), true)
);

WriteAttribute("class", Tuple.Create(" class=\"", 663), Tuple.Create("\"", 698)
            
            #line 17 "..\..MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
              , Tuple.Create(Tuple.Create("", 671), Tuple.Create<System.Object, System.Int32>(GetClass(language.Culture)
            
            #line default
            #line hidden
, 671), false)
);

WriteLiteral(">");

            
            #line 17 "..\..MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
                                                                                                                     Write(language.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a>\n");

            
            #line 18 "..\..MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </li>\n");

            
            #line 20 "..\..MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\n</div>\n\n");

WriteLiteral("\n");

WriteLiteral("\n");

            
            #line 33 "..\..MVC\Views\LanguageSelector\LanguageSelector.LanguageLinks.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/LanguageSelector/language-selector.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
