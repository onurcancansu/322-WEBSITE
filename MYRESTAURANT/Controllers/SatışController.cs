using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MYRESTAURANT.Models.Classes;
namespace MYRESTAURANT.Controllers
{
    public class SatışController : Controller
    {
        // GET: Satış
        Context context = new Context();
        public ActionResult Index()
        {
            var x = context.Sales.ToList();
            return View(x);
        }
    }
}