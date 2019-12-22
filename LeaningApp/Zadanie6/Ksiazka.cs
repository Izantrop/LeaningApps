using System;
using System.Collections.Generic;
using System.Text;

namespace LearningApp.Zadanie_6
{
    class Ksiazka
    {
        protected string Tytul { get; set; }
        protected Osoba Autor { get; set; }
        protected DateTime DataWydania { get; set; }
        public Ksiazka(string Tytul, Osoba Autor, DateTime DataWydania)
        {
            this.Tytul = Tytul;
            this.Autor = Autor;
            this.DataWydania = DataWydania;
        }

        public virtual string Wypisz()
        {
            return ("'"+Tytul+"' Autor: " + Autor.Wypisz() + ", wydana: " + DataWydania.ToString("yyyy-MM-dd"));
        }
    }
}
