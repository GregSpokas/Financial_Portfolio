using System;
using System.Collections.Generic;
using ServiceStack;
using System.Linq;
using System.Web;

namespace Financial_Portfolio.Data
{
    public class Stock_Func
    {
        /*Not sure if I can use this file...*/
        public List<Stock_Data> Get_Test_Stocks()
        {
            List<Stock_Data> test_stock = new List<Stock_Data>();
            string symbol = "APPL";
            string apiKey = "E6ZUIRZSKLBENGRD";
            test_stock = $"https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={symbol}&apikey={apiKey}&datatype=csv"
                            .GetStringFromUrl().FromCsv<List<Stock_Data>>();
            return test_stock;
        }
    }
}