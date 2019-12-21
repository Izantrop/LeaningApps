using System;
using System.Collections.Generic;
using System.Text;

namespace LearningApp
{
    class Licz
    {
        private int wartosc;
        public Licz(int param)
        {
            wartosc = param;
        }
        public int wypisz()
        {
            return wartosc;
        }
        public void dodaj(int liczba)
        {
            wartosc += liczba;
            //return wartosc;
        }
        public void odejmij(int liczba)
        {
            wartosc -= liczba;
            //return wartosc;
        }
    }
}
