// See https://aka.ms/new-console-template for more information
using ExodiaPrototype;

//Console.WriteLine("Hello, World!");
KierownikRestauracji sara = new KierownikRestauracji("Sara", "Kulewicz", 2137.0f, false, 0);
Kierownik kierownik = new Kierownik("Pan", "Kierownik", 5376.0f, true, 1);
Pracownik pracownik = new Pracownik("Pani", "Pracowniczka", 4250.0f, false, 2);
Pracownik instruktor = new Pracownik("Pan", "Instruktor", 4870.0f, true, 3);

ListaPracownikow lista = new ListaPracownikow();
lista.DodajPracownika(pracownik);
lista.DodajPracownika(kierownik);
lista.DodajPracownika(instruktor);



//testy zwiazane ze skladaniem zamowien:
Pracownik pracownikNaKasie = new Pracownik("Kasjer", "Zwyczajny", 4250.0f, false, 5);
Pracownik pracownikNaKuchni = new Pracownik("Kucharz", "Pospolity", 4250.0f, false, 6);
lista.DodajPracownika(pracownikNaKasie);
lista.DodajPracownika(pracownikNaKuchni);

Order order1 = pracownikNaKasie.AddOrder(pracownikNaKasie, 5, Status.W_Trakcie_Realizacji);
ParaProduktLiczba produktLiczba1 = new ParaProduktLiczba(3, new Product("hamburger", 15.20f, "2334"));
ParaProduktLiczba produktLiczba2 = new ParaProduktLiczba(6, new Product("woda 1l", 15.20f, "1111"));
order1.SkladZamowienia.Add(produktLiczba1);
order1.SkladZamowienia.Add(produktLiczba2);

Order order2 = pracownikNaKasie.AddOrder(pracownikNaKasie, 5, Status.W_Trakcie_Realizacji);
ParaProduktLiczba produktLiczba3 = new ParaProduktLiczba(7, new Product("hot dog", 10.00f, "2354"));
order2.SkladZamowienia.Add(produktLiczba3);

Orders orders = new Orders();
pracownikNaKasie.PlaceOrder(orders.orders, order1);
pracownikNaKasie.PlaceOrder(orders.orders, order2);

Console.WriteLine("\nTEST ZAMOWIEN");
Console.WriteLine(pracownikNaKuchni.ViewActiveOrders(orders.orders));

pracownikNaKuchni.FinalizeOrder(order2);
Console.WriteLine("\nTEST ZAMOWIEN po finalizacji jednego z nich:");
Console.WriteLine(pracownikNaKuchni.ViewActiveOrders(orders.orders));



//testy zwiazane ze szkoleniem:
TimeOnly start = TimeOnly.FromDateTime(DateTime.Now);
TimeOnly end = start.AddHours(3);
TimeOnly start2 = TimeOnly.FromDateTime(DateTime.Now);
start2 = start2.AddHours(3);
TimeOnly end2 = start2.AddHours(3);
Szkolenie szkolenie = new Szkolenie(start, end, "0", "Szkolenie ze smazenia frytek", pracownik, instruktor);
Szkolenie szkolenie2 = new Szkolenie(start2, end2, "0", "Szkolenie z obslugi kasy fiskalnej", pracownikNaKuchni, instruktor);
Szkolenia szkolenia = new Szkolenia(kierownik);
szkolenia.AddSzkolenie(szkolenie);
szkolenia.AddSzkolenie(szkolenie2);

Console.WriteLine("\n\nTest szkolen(kierownik):");
Console.WriteLine(szkolenia.ViewSzkolenia(kierownik));

Console.WriteLine("\n\nTest szkolen(szkolony):");
Console.WriteLine(pracownik.ZobaczSzkolenie(szkolenie));


Console.WriteLine("\n\nTest szkolen(instruktor):");
Console.WriteLine(instruktor.ZobaczSzkolenie(szkolenie)+"\n\n");

// Przykładowe dane dla inwentaryzacji
List<Polprodukt> stanDniaPoprzedniego = new List<Polprodukt>
            {
                new Polprodukt { Nazwa = "Kotlet", Ilosc = 100 },
                new Polprodukt { Nazwa = "Frytki", Ilosc = 200 },
                new Polprodukt { Nazwa = "Napoje", Ilosc = 150 }
            };

List<Polprodukt> aktualnyStan = new List<Polprodukt>
            {
                new Polprodukt { Nazwa = "Kotlet", Ilosc = 80 },
                new Polprodukt { Nazwa = "Frytki", Ilosc = 170 },
                new Polprodukt { Nazwa = "Napoje", Ilosc = 140 }
            };

// Przeprowadzenie testowe inwentaryzacji
kierownik.PrzeprowadzInwentaryzacje(stanDniaPoprzedniego, aktualnyStan);

//testy grafiku
Console.WriteLine("TEST GRAFIKU");
List<(TimeOnly Start, TimeOnly End)> godziny = new List<(TimeOnly, TimeOnly)>();
for (int i = 0; i < 30; i++)
{
    TimeOnly Start = new TimeOnly(9, 0); // Przykład: rozpoczęcie o 9:00
    TimeOnly End = new TimeOnly(17, 0);  // Przykład: zakończenie o 17:00
    godziny.Add((Start, End));
}
pracownik.grafik = kierownik.AddSchedule(30, pracownik, kierownik, godziny);
Console.Write(pracownik.ViewSchedule());

//testy zegara
Console.WriteLine("\n\nTEST ODBIC");
pracownik.grafik.clock.AddOdbicie(new TimeOnly(9, 0), DateOnly.FromDateTime(DateTime.Now), "Poczatek pracy", pracownik);
pracownik.grafik.clock.AddOdbicie(new TimeOnly(12, 15), DateOnly.FromDateTime(DateTime.Now), "Przerwa", pracownik);
pracownik.grafik.clock.AddOdbicie(new TimeOnly(12, 45), DateOnly.FromDateTime(DateTime.Now), "Poczatek pracy", pracownik);
pracownik.grafik.clock.AddOdbicie(new TimeOnly(17, 0), DateOnly.FromDateTime(DateTime.Now), "Koniec pracy", pracownik);

Console.WriteLine(pracownik.grafik.clock.PrintOdbicia());

return 0;

