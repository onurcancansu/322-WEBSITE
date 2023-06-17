using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MYRESTAURANT.Models.Classes;

namespace MYRESTAURANT.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        Context context = new Context();
        public ActionResult Index()
        {
            var customer = context.Customers.ToList();
            return View(customer);
        }
        public ActionResult DeleteCustomers(int id)
        {
            var Cus = context.Customers.Find(id);
            context.Customers.Remove(Cus);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CallCustomers(int id)
        {
            var kus = context.Categories.Find(id);
            return View("CallCategory", kus);
        }
    }
}