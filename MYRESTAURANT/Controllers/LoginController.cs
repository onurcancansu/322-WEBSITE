using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MYRESTAURANT.Models.Classes;


namespace MYRESTAURANT.Controllers
{
    public class LoginController : Controller
    {
        Context context = new Context();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult Partial1()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Partial(Customer t)
        {
            context.Customers.Add(t);
            context.SaveChanges();
            return PartialView();
        }

    }
}