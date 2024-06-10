using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{
    public class Day
    {
        public List<Shift> shifts = new List<Shift>();

        public int id { get; set; }

        public void add_shift(TimeOnly start, TimeOnly end)
        {
            shifts.Add(new Shift(start, end));
        }
        public void remove_shifts()
        {
            shifts.Clear();
        }

        public Day(int id)
        {
        this.id = id; 
        }
    }
}
