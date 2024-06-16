using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{
    public class Szkolenia
    {
        public List<Szkolenie> szkolenia = new List<Szkolenie>();
        public Kierownik Author { get; set; }
        public string ViewSzkolenia(Kierownik kierownik)
        {
            var result = "";
            result = result + "\nWykaz szkolen:\n";
            for (int i = 0; i < szkolenia.Count(); i++)
            {
                result = result + kierownik.ZobaczSzkolenie(szkolenia[i]);
                result = result + "\n";
            }
            return result;
        }
        public void AddSzkolenie(Szkolenie szkolenie)
        {
            szkolenia.Add(szkolenie);
        }
        public Szkolenia(Kierownik kierownik)
        {
            Author = kierownik;
        }
    }
}
