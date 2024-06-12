using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{
    public class ListaPracownikow
    {
        public List<Pracownik> pracownicy = new List<Pracownik>();
        public void DodajPracownika(Pracownik p)
        {
            pracownicy.Add(p);
        }
        public void UsunPracownika(Pracownik p)
        {
            pracownicy.Remove(p);
        }
        public void ZmienRole(Pracownik p)
        {
            Kierownik k = new Kierownik(p.Imie, p.Nazwisko, p.Placa, p.IsInstructor, p.Id);
            pracownicy.Remove(p);
            pracownicy.Add(k);
        }
        public void ZmienRole(Kierownik k)
        {
            Pracownik p = new Pracownik(k.Imie, k.Nazwisko, k.Placa, k.IsInstructor, k.Id);
            pracownicy.Remove(k);
            pracownicy.Add(p);
        }
        public void EdytujPracownika(Pracownik p, string imie, string nazwisko, float placa, bool isInstructor)
        {
            p.Imie = imie;
            p.Placa = placa;
            p.Nazwisko = nazwisko;
            p.IsInstructor = isInstructor;
        }
    }
}
