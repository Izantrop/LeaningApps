using System;
using System.Collections.Generic;
using System.Text;

namespace LearningApp
{
    class Samochody
    {
        private string Marka { get; set; }
        private string Model { get; set; }
        private string Kolor { get; set; }

        public Samochody(string marka, string model, string kolor)
        {
            Marka = marka;
            Model = model;
            Kolor = kolor;
        }
        public void Wypisz ()
        {
            Console.WriteLine("Auto: "+Marka + " " + Model + ", kolor " + Kolor);
        }
    }
}
