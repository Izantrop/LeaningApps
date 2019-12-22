using System;
using System.Collections.Generic;
using System.Text;

namespace LearningApp
{
    class Edukacja
    {
        private string Miasto { get; set; }
        private string Szkola { get; set; }
        private string Stopien { get; set; }
        public Edukacja(string miasto, string szkola, string stopien)
        {
            Miasto = miasto;
            Szkola = szkola;
            Stopien = stopien;
        }
        public void Wypisz()
        {
            Console.WriteLine("Uczyl sie w: " + Miasto + ", " + Szkola + ". Stopien: " + Stopien);
        }
    }
}
