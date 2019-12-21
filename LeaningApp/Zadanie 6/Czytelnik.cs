using System;
using System.Collections.Generic;
using System.Text;

namespace LearningApp.Zadanie_6
{
    class Czytelnik : Osoba
    {
        string ksiazki = null;
        protected Ksiazka[] ListaPrzeczytanych = { };
        Ksiazka[] listaKs = { };
        public Czytelnik(string Imie, string Nazwisko, int Wiek) : base(Imie, Nazwisko, Wiek) {}
        public Czytelnik(string Imie, string Nazwisko, int Wiek, Ksiazka[] lista) : base(Imie, Nazwisko, Wiek)
        {
            listaKs = lista;
        }

        public void Przeczytaj(Ksiazka przeczytana)
        {
            Array.Resize(ref ListaPrzeczytanych, ListaPrzeczytanych.Length + 1);
            ListaPrzeczytanych[ListaPrzeczytanych.Length-1] = przeczytana;
        }
        public string WypiszKsiazki()
        {
            foreach (var item in ListaPrzeczytanych)
            {
                ksiazki += "\n"+item.Wypisz();
            }
            return ksiazki;
        }
        public override string Wypisz()
        {
            ksiazki += base.Wypisz();
            ksiazki = WypiszKsiazki();
            return ksiazki;
        }
    }
}
