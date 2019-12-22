using System;
using System.Collections.Generic;
using System.Text;

namespace LearningApp
{
    class Zawody
    {
        private string Zawod { get; set; }
        private int StazPracy { get; set; }
        public Zawody(string zawod, int stazpracy)
        {
            Zawod = zawod;
            StazPracy = stazpracy;
        }
        public void Wypisz()
        {
            Console.WriteLine("Zawod: " + Zawod + " o stazu: " + StazPracy + " lat.\n");
        }
    }
}
