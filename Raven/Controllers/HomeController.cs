using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SharpRaven;
using SharpRaven.Data;

namespace Raven.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var ravenClient = new RavenClient("https://6650da350516457ba17840fb4cf8c641@o92137.ingest.sentry.io/6208998");
            ravenClient.Capture(new SentryEvent(new Exception("Raven")));


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