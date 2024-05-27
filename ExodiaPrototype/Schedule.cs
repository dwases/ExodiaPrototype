using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{
    public class Schedule
    {
        public List<Day> days = new List<Day>();
        public Pracownik pracownik { get; set; }
        public Kierownik kierownik { get; set; }
        public Clock clock { get; set; }
    }
}
