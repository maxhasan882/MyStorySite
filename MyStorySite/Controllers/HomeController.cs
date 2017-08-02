using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyStorySite.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ILog log = LogManager.GetLogger("DebugLog");
        public ActionResult Index()
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    int sum = 10 / i;
                }
            }
            catch(Exception ex)
            {
                log.Debug("Error in Index", ex);
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}