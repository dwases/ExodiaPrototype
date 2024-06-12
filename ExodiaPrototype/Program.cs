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




