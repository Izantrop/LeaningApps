using System;
using System.Collections.Generic;
using System.Text;

namespace LearningApp
{
    class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public Osoba()
        {
        }
        public Osoba(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }
        public void Przedstaw()
        {
            Console.WriteLine(Imie+" "+Nazwisko);
        }
    }
}
