using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web17.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult DemoView()
        {
            return View();
        }
    }
}