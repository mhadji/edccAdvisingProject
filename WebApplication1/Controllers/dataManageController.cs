using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace edccAdvisingProject.Controllers
{
    public class dataManageController : Controller
    {
        [Authorize]
        // GET: dataManage
        public ActionResult Index()
        {
            return View();
        }
    }
}