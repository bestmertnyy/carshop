﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Data.Models
{
    public class ShopCartitem
    {
        public int id {get; set;}
        public Car car { get; set; }
        public int price { get; set; }
        public string ShopCartid { get; set; }

    }
}
