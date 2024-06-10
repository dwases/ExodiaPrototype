using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{
    public class Clock
    {
        public List<Odbicie> odbicia = new List<Odbicie>();

        public void AddOdbicie(TimeOnly g, DateOnly d, string t, Pracownik p)
        {
            Odbicie o = new Odbicie(g, d, t, p);
            odbicia.Add(o);
        }
        public string PrintOdbicia()
        {
            string result = "Odbicia: \n";
            for (int i = 0; i < odbicia.Count; i++)
            {
                result += odbicia[i].Data + " " + odbicia[i].Godzina + " id: " + odbicia[i].pracownik.Id + " typ: " + odbicia[i].Typ + "\n";
            }
            return result;
        }

    }
}
