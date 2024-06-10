using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{
    public class Odbicie
    {
        public Odbicie(TimeOnly g, DateOnly d, string t, Pracownik p) {
            Godzina = g;
            Data = d;
            Typ = t;
            pracownik = p;
        }
        public TimeOnly Godzina { get; set; }
        public string Typ { get; set; }
        public DateOnly Data { get; set; }
        public Pracownik pracownik { get; set; }
    }
}
