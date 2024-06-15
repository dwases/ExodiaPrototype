using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{
    public class Inwentaryzacja
    {
        public Polprodukty ListaStraty { get; set; } = new Polprodukty();
        public Polprodukty WartoscNaStanie { get; set; } = new Polprodukty();
        public Polprodukty Zuzycie { get; set; } = new Polprodukty();
        public Polprodukty StanDniaPoprzedniego { get; set; } = new Polprodukty();
        public Kierownik kierownik { get; set; }

        public void WprowadzDane(List<Polprodukt> produktyNaStanie)
        {
            foreach (var produkt in produktyNaStanie)
            {
                WartoscNaStanie.polprodukty.Add(produkt);
            }
        }

        public void CreateListaStraty()
        {
            foreach (var produkt in StanDniaPoprzedniego.polprodukty)
            {
                var produktObecny = WartoscNaStanie.polprodukty.Find(p => p.Nazwa == produkt.Nazwa);
                if (produktObecny != null && produkt.Ilosc > produktObecny.Ilosc)
                {
                    int straty = produkt.Ilosc - produktObecny.Ilosc;
                    ListaStraty.polprodukty.Add(new Polprodukt { Nazwa = produkt.Nazwa, Ilosc = straty });
                }
            }
        }

        public void CreateWartoscNaStanie()
        {
            int suma = 0;
            foreach (var produkt in WartoscNaStanie.polprodukty)
            {
                suma += produkt.Ilosc;
            }
            WartoscNaStanie.polprodukty.Add(new Polprodukt { Nazwa = "Wartość na stanie", Ilosc = suma });
        }

        public void CreateZuzycie()
        {
            foreach (var produkt in StanDniaPoprzedniego.polprodukty)
            {
                var produktObecny = WartoscNaStanie.polprodukty.Find(p => p.Nazwa == produkt.Nazwa);
                if (produktObecny != null)
                {
                    int zuzycie = produkt.Ilosc - produktObecny.Ilosc;
                    if (zuzycie > 0)
                    {
                        Zuzycie.polprodukty.Add(new Polprodukt { Nazwa = produkt.Nazwa, Ilosc = zuzycie });
                    }
                }
            }
        }

        public string GenerujRaport()
        {
            string raport = "";


            raport += "Raport inwentaryzacji:\n";

            raport += "Lista strat:\n";
            foreach (var produkt in ListaStraty.polprodukty)
            {
                raport += $"{produkt.Nazwa}: {produkt.Ilosc}\n";
            }

            raport += "Wartość na stanie:\n";
            foreach (var produkt in WartoscNaStanie.polprodukty)
            {
                raport += $"{produkt.Nazwa}: {produkt.Ilosc}\n";
            }

            raport += "Zużycie:\n";
            foreach (var produkt in Zuzycie.polprodukty)
            {
                raport += $"{produkt.Nazwa}: {produkt.Ilosc}\n";
            }

            return raport;
        }
    }
}