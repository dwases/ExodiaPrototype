﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{
    public class Product
    {
        public string ProductName { get; set; }
        public string Price { get; set; }
        public string Wrin { get; set; }
        public List<ParaPolproduktIlosc> sklad = new List<ParaPolproduktIlosc>();
    }
}
