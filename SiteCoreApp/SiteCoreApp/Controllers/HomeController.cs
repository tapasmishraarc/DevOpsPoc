using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteCoreApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/  test
        public ActionResult Index()
        {
            return View("Index");
        }

      
    }
}
