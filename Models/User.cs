using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Financial_Portfolio.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Email { get; set; } // username will be email
        private string Password { get; set; }
    }
}