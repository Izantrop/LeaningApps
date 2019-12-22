using System;
using System.Collections.Generic;
using System.Text;

namespace LearningApp
{
    class Sumator
    {
        int sum;
        private int[] Liczby;
        public Sumator(int[] tablica)
        {
            Liczby = tablica;
        }
        public int Suma()
        {
            sum = 0;
            for (int i = 0; i < Liczby.Length; i++)
            {
                sum += Liczby[i];
            }
            return sum;
        }

        public int Sumal3()
        {
            sum = 0;
            for (int i = 0; i < Liczby.Length; i++)
            {
                if (Liczby[i]%3 == 0)
                {
                    sum += Liczby[i];
                }
            }
            return sum;
        }

        public int IleElementow()
        {
            return Liczby.Length;
        }

        public string WszystkieElementy()
        {
            string kolLicz = "Liczby w tablicy:";
            for (int i = 0; i < Liczby.Length; i++)
            {
                kolLicz += " " + Liczby[i];
            }
            return kolLicz;
        }

        public string Indeksy(int lowIndex, int highIndex)
        {
            string calyIndex = "Indeksy pomiedzy "+lowIndex+", a "+highIndex+":";
            
            for (int i = lowIndex; i <= highIndex; i++)
            {
                if (i < 0)
                    i = 0;
                if (i >= Liczby.Length)
                    return calyIndex;
                    calyIndex += " "+Liczby[i].ToString();
            }
            return calyIndex;
        }
    }
}
