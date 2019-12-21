using System;
using System.Collections.Generic;
using System.Text;

namespace LearningApp
{
    class Daty
    {
        public int Rok { get; set; }
        public int Miesiac { get; set; }
        public int Dzien { get; set; }
        public int Godzina { get; set; }
        public int Minuta { get; set; }
        public int Sekunda { get; set; }
        public Daty(int rok, int miesiac, int dzien, int godzina, int minuta, int sekunda)
        {
            if (rok >= 1900 && rok <= 9999)
                Rok = rok;
            else
                Console.WriteLine("Podano zly rok");
            if (miesiac >= 1 && miesiac <= 12)
                Miesiac = miesiac;
            else
                Console.WriteLine("Podano zly rok");
            if (dzien >= 1 && dzien <= 31)
                Dzien = dzien;
            else
                Console.WriteLine("Podano zly dzien");
            if (godzina >= 0 && godzina <= 23)
                Godzina = godzina;
            else
                Console.WriteLine("Podano zla godzine");
            if (minuta >= 0 && minuta <= 59)
                Minuta = minuta;
            else
            Console.WriteLine("Podano zla minute");
            if (sekunda >= 0 && sekunda <= 59)
                Sekunda = sekunda;
            else
                Console.WriteLine("Podano zla sekunde");
        }
        public void PokazDate()
        {
            Console.WriteLine(Rok + "/" + Miesiac + "/" + Dzien + " " + Godzina + ":" + Minuta + ":" + Sekunda);
        }
        public void DodajDzien(int dodaj)
        {
            Dzien += dodaj;
        }
        public void UsunDzien(int usun)
        {
            Dzien -= usun;
        }
    }
}
