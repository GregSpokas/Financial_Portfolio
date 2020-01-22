using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Financial_Portfolio.Models;
using Financial_Portfolio.Data;

namespace Financial_Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            //test
            /*
            List<Stock_Data> temp = Stock_Data.Get_Test_Stocks();
            Viewbag.temp = temp;
            */
            Stock_Data stock_data = new Stock_Data();
            //stock_data.symbol = "APPL";
            //stock_data.Get_Test_Stocks();
            //ViewBag.test_list = stock_data.Get_Test_Stocks();
            List<Stock_Data> pass_in = stock_data.Get_Test_Stocks();
            ViewBag.pass_in = pass_in;
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
