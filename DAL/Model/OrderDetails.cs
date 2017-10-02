﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AshShop.DAL.Model
{
    public class OrderDetails
    {
        public int id { get; set; }
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice{ get; set; }
        public int ProductQuantity { get; set; }
        public string ProductImage { get; set; }


    }
}