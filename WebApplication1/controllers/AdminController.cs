using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace edccAdvisingProject.Controllers
{
    public class AdminController : Controller
    {
        [Authorize]
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Details/5
   
    }
}
