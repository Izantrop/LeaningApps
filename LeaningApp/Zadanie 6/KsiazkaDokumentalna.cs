using System;
using System.Collections.Generic;
using System.Text;

namespace LearningApp.Zadanie_6
{
    class KsiazkaDokumentalna : Ksiazka
    {
        string opisKrotki = "Opis KsiazkaDokumentalna";
        string opisDlugi;
        public KsiazkaDokumentalna(string Tytul, Osoba Autor, DateTime DataWydania, string opDl) : base(Tytul, Autor, DataWydania)
        {
            opisDlugi = opDl;
        }
        public override string Wypisz()
        {
            return base.Wypisz() +"\nOpis: "+opisKrotki;
        }
    }
}
