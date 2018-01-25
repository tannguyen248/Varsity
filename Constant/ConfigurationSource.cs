using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Hosting;

namespace SitefinityWebApp.Constant
{
    public static class ConfigurationSource
    {
        public static readonly string DefaultSourceDirectory = HostingEnvironment.MapPath(@"~/App_Data");
        public static readonly string Navigation = Path.Combine(DefaultSourceDirectory, @"Configurations\Navigation.txt");
        public static readonly string Slider = Path.Combine(DefaultSourceDirectory, @"Configurations\Slider.txt");
    }
}