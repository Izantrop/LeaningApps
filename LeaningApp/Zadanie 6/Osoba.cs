using System;
using System.Collections.Generic;
using System.Text;

namespace LearningApp.Zadanie_6
{
    class Osoba
    {
        private string imie;

        private string Imie { 
            get 
            { 
                return imie; 
            } 
            set 
            {
                imie = value;

            }
        }

        private string Nazwisko { get; set; }
        private int Wiek { get; set; }
        public Osoba(string Imie, string Nazwisko, int Wiek)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Wiek = Wiek;
        }

        public virtual string Wypisz()
        {
            return (Imie + " " + Nazwisko + ". Wiek: " + Wiek);
        }
    }
}
