using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CavdarOtoProje.Models;
using System.Web.Mvc;


namespace CavdarOtoProje.Areas.AdminPanel.Controllers
{
    public class CategoryController : Controller
    {
        CavdarOtoDBModel db = new CavdarOtoDBModel();
        public ActionResult Index()
        {
            return View(db.Categories.Where(x => x.IsDeleted == false).ToList());
        }
        public ActionResult IndexAll()
        {
            return View(db.Categories.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Categories.Add(model);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Category");
                }
                catch
                {
                    ViewBag.sonuc = false;
                }
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Category category = db.Categories.Find(id);
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Category model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index", "Category");
                }
                catch 
                {
                    ViewBag.sonuc = false;
                }
            }
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            Category category = db.Categories.Find(id);
            category.IsDeleted = true;
            db.SaveChanges();
            return RedirectToAction("Index", "Category");
        }
        public ActionResult Deactivate(int id)
        {
            Category category =db.Categories.Find(id);
            category.IsActive = false;
            db.SaveChanges();
            return RedirectToAction("Index", "Category");
        }
        public ActionResult Activate(int id)
        {
            Category category = db.Categories.Find(id);
            category.IsActive = true;
            db.SaveChanges();
            return RedirectToAction("Index", "Category");
        }
    }
}