using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AshShop.DAL.Model
{
    public class AdminLogin
    {
        public int Id { get; set; }
        public string AdminName { get; set; }
        public string Password { get; set; }
    }
}