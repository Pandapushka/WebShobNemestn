﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShobGleb.Models;

namespace OnlineShopDB.Models
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
        public int Amount { get; set; }
        public OrderItem() 
        {

        }  
    }
}
