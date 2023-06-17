using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MYRESTAURANT.Models.Classes;

namespace MYRESTAURANT.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        Context context = new Context();
        public ActionResult Index()
        {
            var values = context.Categories.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category c)
        {
            context.Categories.Add(c);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCategory(int id)
        {
            var Categor = context.Categories.Find(id);
            context.Categories.Remove(Categor);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CallCategory(int id)
        {
            var ktg = context.Categories.Find(id);
            return View("CallCategory", ktg);
        }
        public ActionResult UpdateCategory(Category c)
        {
            var ctgr = context.Categories.Find(c.CategoryID);
            ctgr.CategoryName = c.CategoryName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}