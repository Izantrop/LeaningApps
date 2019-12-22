using System;
using System.Collections.Generic;
using System.Text;

namespace LearningApp.Zadanie_6
{
    class KsiazkaPrzygodowa : Ksiazka
    {
        string opisKrotki = "Opis KsiazkaPrzygodowa";
        string opidDlugi;
        public KsiazkaPrzygodowa(string Tytul, Osoba Autor, DateTime DataWydania, string opDl) : base(Tytul, Autor, DataWydania)
        {
            opidDlugi = opDl;
        }
        public override string Wypisz()
        {
            return base.Wypisz() + "\nOpis: " + opisKrotki;
        }
    }
}
