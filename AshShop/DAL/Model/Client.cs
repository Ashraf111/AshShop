﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AshShop.DAL.Model
{
    public class Client
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}