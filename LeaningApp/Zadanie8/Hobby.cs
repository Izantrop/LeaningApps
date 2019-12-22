using System;
using System.Collections.Generic;
using System.Text;

namespace LearningApp
{
    class Hobby
    {
        private string Hobbi { get; set; }
        public Hobby(string hobby)
        {
            Hobbi = hobby;
        }
        public void Wypisz()
        {
            Console.WriteLine("Hobby: " + Hobbi);
        }
    }
}
