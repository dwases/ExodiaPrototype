using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{
    public class Pracownik
    {
        public Pracownik(string imie, string nazwisko, float placa, bool isInstructor, int id)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Placa = placa;
            IsInstructor = isInstructor;
            Id = id;
            grafik = null;
        }

        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public float Placa { get; set; }
        public bool IsInstructor { get; set; }
        public int Id { get; set; }

        public Schedule? grafik;
        //nazwy ponizszych 2 funkcji moga byc mylace, ale pierwsza tworzy zamowienie, a druga dodaje je do listy zamowien
        public Order AddOrder(Pracownik pracownik, int pracownikID, Status statusy)
        {
            Order order = new Order(pracownik, pracownikID, statusy);
            return order;
        }
        public void PlaceOrder(List<Order> orders, Order order)
        {
            orders.Add(order);
        }
        public string ViewActiveOrders(List<Order> orders)
        {
            var result = "All active orders:";
            int i = 0;
            foreach (var order in orders)
            {
                if (order.Statusy != Status.W_Trakcie_Realizacji)
                {
                    continue;
                }
                i++;
                result = result + "\nl.p.: ";
                result = result + i.ToString();
                result = result + "\nID pracownika: ";
                result = result + order.PracownikID.ToString();
                result = result + "\nSklad zamowienia: ";
                foreach (var para in order.SkladZamowienia)
                {
                    result = result + para.Produkt.ProductName;
                    result = result + " x ";
                    result = result + para.Liczba.ToString();
                    result = result + "\n";
                }
            }
            return result;
        }
        public void FinalizeOrder(Order order)
        {
            order.Statusy = Status.Zrealizowane;
        }
        public string ViewSchedule()
        {
            string result = "Grafik pracownika o id " + this.Id + ":\n";
            for (int i = 0; i < grafik.days.Count; i++)
            {
                result += grafik.days[i].id + "poczatek pracy: " + grafik.days[i].shifts[0].GodzinaRozpoczecia + ", koniec pracy: " + grafik.days[i].shifts[0].GodzinaUkonczenia + "\n";
            }
            return result;
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
