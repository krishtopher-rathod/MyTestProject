using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web17.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult MyUser()
        {
            return View();
        }
    }
}