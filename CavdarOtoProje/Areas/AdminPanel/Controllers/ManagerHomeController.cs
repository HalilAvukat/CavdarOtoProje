using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CavdarOtoProje.Areas.AdminPanel.Controllers
{
    public class ManagerHomeController : Controller
    {
        // GET: AdminPanel/ManagerHome
        public ActionResult Index()
        {
            return View();
        }
    }
}