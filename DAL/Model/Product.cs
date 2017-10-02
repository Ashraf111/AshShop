using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AshShop.DAL.Model
{
    public class Product
    {
        public int CookiesId { get; set; }
        public int id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductPrice { get; set; }
        public int ProductQuntity { get; set; }
        public string ProductImage { get; set; }
        public string ProductCategory { get; set; }
    }
}