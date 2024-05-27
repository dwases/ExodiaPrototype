using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{
    public class Odbicie
    {
        public TimeOnly Godzina { get; set; }
        public string Typ { get; set; }
        public DateOnly Data { get; set; }
        public Pracownik pracownik { get; set; }
    }
}
