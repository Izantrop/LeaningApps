using System;
using System.Collections.Generic;
using System.Text;

namespace LearningApp.Zadanie_6
{
    class Recenzent : Czytelnik
    {
        string recenzja;
        public Recenzent(string Imie, string Nazwisko, int Wiek) : base(Imie, Nazwisko, Wiek)
        {
        }
        public new void Wypisz()
        {
            var rand = new Random();

            foreach (var item in ListaPrzeczytanych)
            {
                recenzja += "\n" + item.Wypisz()+ " Ocena: " + (rand.Next(1,6));
            }
            Console.WriteLine(recenzja);
        }
    }
}
