using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdaptiveUI.Controllers
{
    public class HomeController : Controller
    {
        //The below can be placed on classes or anywhere to add cache
        [OutputCache(Duration =10, Location =System.Web.UI.OutputCacheLocation.Server)]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            Response.Cache.SetExpires(DateTime.Now.AddYears(1));
            Response.Cache.SetCacheability(HttpCacheability.Public);
            return View();
        }

        [OutputCache(Location = System.Web.UI.OutputCacheLocation.None, NoStore =true)] //stops caching
        public ActionResult SomeWork()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [OutputCache(CacheProfile ="myCacheProfile")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}