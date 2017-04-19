using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Added on 4/19/2017
            return View();
        }
    }
}
