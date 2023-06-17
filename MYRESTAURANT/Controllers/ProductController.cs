    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using MYRESTAURANT.Models.Classes;

    namespace MYRESTAURANT.Controllers
    {
        public class ProductController : Controller
        {
            Context context = new Context();
            // GET: Product
            public ActionResult Index()
            {
                var product = context.Products.ToList();
                return View(product);
            }
            [HttpGet]
            public ActionResult AddProduct()
            {
                List<SelectListItem> value1 = (from x in context.Categories.ToList() select new SelectListItem { Text = x.CategoryName, Value = x.CategoryID.ToString() }).ToList();
                ViewBag.val1 = value1;

                return View();
            }
            [HttpPost]
            public ActionResult AddProduct(Product p)
            {
                context.Products.Add(p);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            public ActionResult DeleteProduct(int id)
            {
                var pr = context.Products.Find(id);
                context.Products.Remove(pr);
                context.SaveChanges();
                return RedirectToAction("Index");

            }
            public ActionResult CallProduct(int id)
            {
                var ktg = context.Products.Find(id);
                return View("CallProduct", ktg);
            }
            public ActionResult UpdateProduct(Product p)
            {
                var ctgr = context.Products.Find(p.ProductID);
                ctgr.ProductName = p.ProductName;
                ctgr.Categoryname = p.Categoryname;
            ctgr.ProductImage = p.ProductImage;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
    }
    }