using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{
    public class Pracownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public float Placa { get; set; }
        public bool IsInstructor { get; set; }
        public int Id { get; set; }
        public void AddOrder()
        {

        }
        public void PlaceOrder() 
        {

        }
        public void ViewActiveOrders()
        {

        }
        public void FinalizeOrder() 
        {

        }
        public void ViewSchedule()
        {

        }
        public string ZobaczSzkolenie(Szkolenie szkolenie)
        {
            string result = "";
            result = result + "Dane szkolenia:\n";
            result = result + "Godzina rozpoczecia: ";
            result = result + szkolenie.GodzinaRozpoczecia.ToString();
            result = result + "\nGodzina zakonczenia: ";
            result = result + szkolenie.GodzinaUkonczenia.ToString();
            result = result + "\nStatus: ";
            result = result + szkolenie.Status;
            result = result + "\nSzkolony: ";
            result = result + szkolenie.Szkolony.Imie;
            result = result + " ";
            result = result + szkolenie.Szkolony.Nazwisko;
            result = result + "\nInstruktor: ";
            result = result + szkolenie.Instruktor.Imie;
            result = result + " ";
            result = result + szkolenie.Instruktor.Nazwisko;
            result = result + "\nSzczegoly:\n";
            result = result + szkolenie.Details;
            return result;
        }
        public void ZobaczRaport()
        {

        }
    }
}
