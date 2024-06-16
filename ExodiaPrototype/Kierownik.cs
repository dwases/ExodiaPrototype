using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{

    public class Kierownik : Pracownik
    {
        public Kierownik(string imie, string nazwisko, float placa, bool isInstructor, int id) : base(imie, nazwisko, placa, isInstructor, id)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Placa = placa;
            IsInstructor = isInstructor;
            Id = id;
            grafik = null;
        }
        public Schedule AddSchedule(int liczba_dni, Pracownik p, Kierownik k, List<(TimeOnly Start, TimeOnly End)> hours)
        {
            Schedule grafik = new Schedule(liczba_dni, p, k);
            for (int i = 0; i < hours.Count(); i++)
            {
                grafik.add_Day(i, hours[i].Start, hours[i].End);
            }
            return grafik;
        }
        public Szkolenie AddSzkolenie(TimeOnly GodzinaRozpoczecia, TimeOnly GodzinaUkonczenia, string Status, string Details, Pracownik szkolony, Pracownik Instruktor)
        {
            Szkolenie s = new Szkolenie(GodzinaRozpoczecia, GodzinaUkonczenia, Status, Details, szkolony, Instruktor);
            return s;
        }
        public void PrzeprowadzInwentaryzacje(List<Polprodukt> stanDniaPoprzedniego, List<Polprodukt> aktualnyStan)
        {
            var inwentaryzacja = new Inwentaryzacja
            {
                StanDniaPoprzedniego = new Polprodukty { polprodukty = stanDniaPoprzedniego },
                WartoscNaStanie = new Polprodukty { polprodukty = aktualnyStan }
            };

            inwentaryzacja.CreateListaStraty();
            inwentaryzacja.CreateWartoscNaStanie();
            inwentaryzacja.CreateZuzycie();

            string raport = inwentaryzacja.GenerujRaport();
            Console.WriteLine(raport);
        }
    }
}