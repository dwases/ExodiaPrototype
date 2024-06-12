using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{
    public class KierownikRestauracji : Kierownik
    {
        public KierownikRestauracji(string imie, string nazwisko, float placa, bool isInstructor, int id) : base(imie, nazwisko, placa, isInstructor, id)
        {

        }

        public void ZobaczRaport()
        {

        }
        public void ZarzadzajListaPracownikow(List<ListaPracownikow> pracownicy)
        {

        }
        public void ZarzadzajListaProduktow(List<Products> produkty)
        {

        }
    }
}
