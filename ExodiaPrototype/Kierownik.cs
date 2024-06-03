using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{
    public class Kierownik : Pracownik
    {
        public void AddSchedule(TimeOnly GodzinaRozpoczecia, TimeOnly GodzinaUkonczenia, string Status, string Details, Pracownik szkolony, Pracownik Instruktor)
        {
            //tutaj bedzie wywolanie konstruktora szkolenia
        }
        public void PrzeprowadzInwentoryzacje()
        {

        }
    }
}
