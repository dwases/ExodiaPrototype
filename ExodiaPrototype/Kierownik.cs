﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExodiaPrototype
{

    public class Kierownik : Pracownik
    {
        public Kierownik(string imie, string nazwisko, float placa, bool isInstructor, int id) : base(imie, nazwisko, placa,isInstructor,id)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Placa = placa;
            IsInstructor = isInstructor;
            Id = id;
            grafik = null;
        }
        public Schedule AddSchedule(int liczba_dni, Pracownik p, Kierownik k, List<List<TimeOnly>> hours)
        {
            Schedule grafik = new Schedule(liczba_dni, p, k);
            for(int i = 0; i < hours.Count(); i++)
            {
                grafik.add_Day(i + 1, hours[i][0], hours[i][1]);
            }
            return grafik;
        }
        public Szkolenie AddSzkolenie(TimeOnly GodzinaRozpoczecia, TimeOnly GodzinaUkonczenia, string Status, string Details, Pracownik szkolony, Pracownik Instruktor)
        {
            Szkolenie s = new Szkolenie(GodzinaRozpoczecia, GodzinaUkonczenia, Status, Details, szkolony, Instruktor);
            return s;
        }
        public void PrzeprowadzInwentoryzacje()
        {

        }
    }
}
