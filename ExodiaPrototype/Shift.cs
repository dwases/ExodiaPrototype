using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{
    public class Shift
    {
        public TimeOnly GodzinaRozpoczecia { get; set; }
        public TimeOnly GodzinaUkonczenia { get; set; }
        public Pracownik pracownik { get; set; }
    }
}
