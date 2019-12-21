using System;
using System.Collections.Generic;
using System.Text;

namespace LearningApp
{
    class Statyczna
    {
        public int I;
        static int Liczba;
        public Statyczna(int ustaw)
        {
            I = ustaw;
            Zwieksz();
        }

        public static void Zwieksz()
        {
            
            Liczba++;
            //return Liczba;
        }
    }
}
