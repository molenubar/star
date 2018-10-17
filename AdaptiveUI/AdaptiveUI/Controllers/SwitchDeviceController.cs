using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;
using System.Web.Mvc;

namespace AdaptiveUI.Controllers
{
    public class SwitchDeviceController : Controller
    {
        public RedirectResult SwitchDevice(bool m, string ru)
        {
            if(Request.Browser.IsMobileDevice == m)
            {
                HttpContext.ClearOverriddenBrowser();
            } else
            {
                HttpContext.SetOverriddenBrowser(m ? BrowserOverride.Mobile : BrowserOverride.Desktop);
            }
            return Redirect(ru);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}