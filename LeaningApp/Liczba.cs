using System;
using System.Collections.Generic;
using System.Text;

namespace LearningApp
{
    class Liczba
    {
        public char[] listaCyfr;
        string stringLiczba;
        string wynik;

        public void WpiszLiczbe(char[] liczba)
        {
            listaCyfr = liczba;
        }

        public void Mnozenie(int mnoznik)
        {
            stringLiczba = string.Join("", listaCyfr);
            wynik = ((Convert.ToDecimal(stringLiczba))*mnoznik).ToString();
            //if (listaCyfr.Length >= wynik.Length)
                listaCyfr = wynik.ToCharArray();
            //else
            //{
            //    ZwiekszListe(wynik.Length);
            //    listaCyfr = wynik.ToCharArray();
            //}
        }
        public void WypiszLiczbe()
        {
            Console.WriteLine(listaCyfr);
        }
        
        //public void ZwiekszListe(int dlWyniku)
        //{
        //    Array.Resize(ref listaCyfr, listaCyfr.Length * 2);
        //    if (listaCyfr.Length < dlWyniku)
        //        ZwiekszListe(dlWyniku);
        //}
        
        public int Silnia(int silnia)
        {
            if (silnia == 0 || silnia == 1)
                return 1;
            int wynik = ((silnia) * Silnia(silnia - 1));
            return wynik;
        }
    }
}
