using Financial_Portfolio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Financial_Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Test()
        {
            Stock_Data stock = new Stock_Data();
            List<Stock_Data> test_data = new List<Stock_Data>();
            test_data = stock.Get_Test_Stocks();
            ViewBag.pass_in = test_data;
            
            // return View(test_data);
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}