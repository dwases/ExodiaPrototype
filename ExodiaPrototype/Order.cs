using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{
    public class Order
    {
        public Pracownik pracownik { get; set; }
        public int PracownikID { get; set; }
        public Status Statusy { get; set; }
    }
}
