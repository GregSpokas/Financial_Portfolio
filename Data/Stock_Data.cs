using System;
using System.Collections.Generic;
using System.Linq;
//Install-Package ServiceStack.Text -- use this in NuGet to install package
using ServiceStack;
using ServiceStack.Text;

namespace Financial_Portfolio.Data
{
    public class Stock_Data
    {
        //public string symbol { get; set; }
        public DateTime Timestamp { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }

        public decimal Close { get; set; }
        public decimal Volume { get; set; }

        //private string apiKey = "E6ZUIRZSKLBENGRD"; // retrieve your api key from https://www.alphavantage.co/support/#api-key


        //TODO - This function probably needs to go somewhere else... maybe by itself
        // Needs to be its own class to work i think... - JMA 1-22-2020
        public List<Stock_Data> Get_Test_Stocks()
        {
            List<Stock_Data> test_stock = new List<Stock_Data>();
            string symbol = "AAPL";
            string apiKey = "E6ZUIRZSKLBENGRD"; // retrieve your api key from https://www.alphavantage.co/support/#api-key
            test_stock = $"https://www.alphavantage.co/query?function=TIME_SERIES_DAILY&symbol={symbol}&apikey={apiKey}&datatype=csv"
                            .GetStringFromUrl().FromCsv<List<Stock_Data>>();
            
            return test_stock;
        }
    }
}
