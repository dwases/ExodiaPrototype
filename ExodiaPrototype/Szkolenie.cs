using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{
    public class Szkolenie
    {
        public Szkolenie(TimeOnly godzinaRozpoczecia, TimeOnly godzinaUkonczenia, string status, string details, Pracownik szkolony, Pracownik instruktor)
        {
            GodzinaRozpoczecia = godzinaRozpoczecia;
            GodzinaUkonczenia = godzinaUkonczenia;
            Status = status;
            Details = details;
            Szkolony = szkolony;
            Instruktor = instruktor;
        }

        public Pracownik Szkolony { get; set; }
        public Pracownik Instruktor { get; set; }
        public TimeOnly GodzinaRozpoczecia { get; set; }
        public TimeOnly GodzinaUkonczenia { get; set; }
        public string Status { get; set; }
        public string Details { get; set; }
    }
}
