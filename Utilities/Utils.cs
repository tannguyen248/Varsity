using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitefinityWebApp.Utilities
{
    public static class Utils
    {
        public static string EncodeDetailTitle(string title)
        {
            return title.Replace(" ", "-");
        }

        public static string DecodeDetailTitle(string encodedTitle)
        {
            return encodedTitle.Replace("-", " ");
        }
    }
}