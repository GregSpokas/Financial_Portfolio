using Financial_Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Financial_Portfolio.DAL
{
    public class Stock_Initializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<Stock_Context>
    {
        protected override void Seed(Stock_Context context)
        {
            var stock = new Stock();
            stock.ID = 1; stock.Symbol = "TEST"; stock.Close_price = 0; stock.Stock_type = "TEST"; stock.Stock_interval = "TEST";
            stock.Max_date = "TEST"; stock.Min_date = "TEST";
            context.Stock.Add(stock);
            context.SaveChanges();

        }
    }
}