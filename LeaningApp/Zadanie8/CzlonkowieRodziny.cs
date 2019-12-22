using System;
using System.Collections.Generic;
using System.Text;

namespace LearningApp
{
    class CzlonkowieRodziny
    {
        public int IDCzlonka { get; set; }
        private string Imie { get; set; }
        private string Nazwisko { get; set; }
        private int Wiek { get; set; }
        public List<CzlonkowieRodziny> czlonkowieRodziny = new List<CzlonkowieRodziny>();
        public List<List<object>> kolekcja = new List<List<object>>();
        public CzlonkowieRodziny(int ID, string imie, string nazwisko, int wiek)
        {
            IDCzlonka = ID;
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
            DodajCzlonka(this);
        }public void DodajCzlonka(CzlonkowieRodziny czlonkowie)
        {
            czlonkowieRodziny.Add(czlonkowie);
        }
        public void Wypisz()
        {
            Console.WriteLine(Imie + " " + Nazwisko + " wiek: " + Wiek);
        }
        public void DodajDoKolekcji(CzlonkowieRodziny czlonek, object nowy)
        {
                kolekcja[0].Add(czlonek);
                kolekcja[1].Add(nowy);
        }
        public void WypiszKolekcje(CzlonkowieRodziny czlonek)
        {
            for (int i = 0; i < kolekcja.Count; i++)
            {
                //if (kolekcja[i][i])
                //{

                //}
            }
        }
    }
}
