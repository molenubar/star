using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;

namespace AdaptiveUI.App_Start
{
    public class DisplayModeConfig
    {
        public static void RegisterDisplayModes(IList<IDisplayMode> dms)
        {
            //HttpContext.Current.Request.UserAgent;
            DefaultDisplayMode ddm = new DefaultDisplayMode("Smartphone");
            dms.Add(ddm);

            //HttpContext.Current.Request.UserAgent;
            DefaultDisplayMode ddm2 = new DefaultDisplayMode("Tablet");
            dms.Add(ddm2);
        }
    }
}