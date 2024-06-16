using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{
    public class Product
    {
        public string ProductName { get; set; }
        public float Price { get; set; }
        public string Wrin { get; set; }
        public List<ParaPolproduktIlosc> sklad = new List<ParaPolproduktIlosc>();

        public Product(string prodName, float price, string wrin)
        {
            ProductName = prodName;
            Price = price;
            Wrin = wrin;
        }
    }
}
