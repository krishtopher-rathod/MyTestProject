using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web17.Controllers
{
    public class AboutUsController : Controller
    {
        // GET: AboutUs
        public ActionResult Info()
        {
            return View();
        }
    }
}