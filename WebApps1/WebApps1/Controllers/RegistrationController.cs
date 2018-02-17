using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApps1.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Register(Table T)
        {
            return View(T);
        }

    }
}