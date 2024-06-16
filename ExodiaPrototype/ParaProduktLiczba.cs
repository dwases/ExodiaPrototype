using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{
    public class ParaProduktLiczba
    {
        public int Liczba { get; set; }
        public Product Produkt { get; set; }
        public ParaProduktLiczba(int liczba, Product produkt)
        {
            Liczba = liczba;
            Produkt = produkt;
        }
    }
}
