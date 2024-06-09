using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{
    public class Kierownik : Pracownik
    {
        public void AddSchedule()
        {
            
        }
        public Szkolenie AddSzkolenie(TimeOnly GodzinaRozpoczecia, TimeOnly GodzinaUkonczenia, string Status, string Details, Pracownik szkolony, Pracownik Instruktor)
        {
            Szkolenie s = new Szkolenie(GodzinaRozpoczecia, GodzinaUkonczenia, Status, Details, szkolony, Instruktor);
            return s;
        }
        public void PrzeprowadzInwentoryzacje()
        {

        }
    }
}
