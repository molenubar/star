using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdaptiveUI
{
    public class sub
    {
        public static string Sub(HttpContext context)
        {
            return DateTime.Now.ToString();
        }
    }
}