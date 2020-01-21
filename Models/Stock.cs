using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Financial_Portfolio.Models
{
    public class Stock
    {
        public string Symbol { get; set; }
        public double Close_price { get; set; }
        public string Stock_type { get; set; }
        public string Stock_interval { get; set; }
        
        // See if we need to changes these to datetime objects...
        public string Max_date { get; set; }
        public string Min_date { get; set; }
    }
}
