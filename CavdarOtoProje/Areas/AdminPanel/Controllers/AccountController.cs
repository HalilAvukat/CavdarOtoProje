using CavdarOtoProje.Models;
using CavdarOtoProje.Areas.AdminPanel.Data;
using System.Linq;
using System.Web.Mvc;

namespace CavdarOtoProje.Areas.AdminPanel.Controllers
{
    public class AccountController : Controller
    {
        CavdarOtoDBModel db = new CavdarOtoDBModel();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(ManagerLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var manager = db.Managers.FirstOrDefault(m => m.Mail == model.Mail && m.password == model.Password);
                if (manager != null)
                {
                    Session["yonetici"] = manager;
                    return RedirectToAction("Index", "ManagerHome");
                }

                ViewBag.mesaj = "Yönetici Bulunamadı";
            }

            return View(model);
        }
    }
}