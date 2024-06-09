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
        public List<ParaProduktLiczba> SkladZamowienia = new List<ParaProduktLiczba>();
        public Order(Pracownik pracownik, int pracownikID, Status statusy)
        {
            this.pracownik = pracownik;
            PracownikID = pracownikID;
            Statusy = statusy;
        }
    }
}
