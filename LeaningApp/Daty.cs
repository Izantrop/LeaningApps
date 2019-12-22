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
        public string Format { get; set; }

        public Daty(int rok, int miesiac, int dzien, int godzina, int minuta, int sekunda)
        {
            WeryfikujeDate(rok, miesiac, dzien, godzina, minuta, sekunda);
        }

        public Daty(int rok, int miesiac, int dzien, int godzina, int minuta, int sekunda, string format)
        {
            WeryfikujeDate(rok, miesiac, dzien, godzina, minuta, sekunda);
            Format = format;
        }

        public void WeryfikujeDate(int rok, int miesiac, int dzien, int godzina, int minuta, int sekunda)
        {
            if (rok < 1900 || rok > 9999)
            {
                if (rok < 1900)
                {
                    Console.WriteLine("Podano zly rok. Ustawiono wartosc domyslna.");
                    Rok = 1900;
                }
                if (rok > 9999)
                {
                    Console.WriteLine("Podano zly rok. Ustawiono wartosc domyslna.");
                    Rok = 9999;
                }
            }
            else
                Rok = rok;

            if (miesiac < 1 || miesiac > 12)
            {
                if (miesiac < 1)
                {
                    Console.WriteLine("Podano zly miesiac. Ustawiono wartosc domyslna.");
                    miesiac = 1;
                }
                if (miesiac > 12)
                {
                    Console.WriteLine("Podano zly miesiac. Ustawiono wartosc domyslna.");
                    miesiac = 12;
                }
            }
            else
                Miesiac = miesiac;


            if (dzien < 1 && dzien > 31)
            {
                if (dzien < 1)
                {
                    Console.WriteLine("Podano zly dzien. Ustawiono wartosc domyslna.");
                    dzien = 1;
                }
                if (dzien > 31)
                {
                    Console.WriteLine("Podano zly dzien. Ustawiono wartosc domyslna.");
                    dzien = 31;
                }
            }
            else
                Dzien = dzien;

            if (godzina < 0 && godzina > 23)
            {
                if (godzina < 1)
                {
                    Console.WriteLine("Podano zla godzine. Ustawiono wartosc domyslna.");
                    godzina = 1;
                }
                if (godzina > 59)
                {
                    Console.WriteLine("Podano zla godzine. Ustawiono wartosc domyslna.");
                    godzina = 24;
                }
            }
            else
                Godzina = godzina;

            if (minuta < 0 && minuta > 59)
            {
                if (minuta < 1)
                {
                    Console.WriteLine("Podano zla minute. Ustawiono wartosc domyslna.");
                    minuta = 1;
                }
                if (minuta > 59)
                {
                    Console.WriteLine("Podano zla minute. Ustawiono wartosc domyslna.");
                    minuta = 59;
                }
            }
            else
                Minuta = minuta;

            if (sekunda < 0 && sekunda > 59)
            {
                if (sekunda < 1)
                {
                    Console.WriteLine("Podano zla sekunde. Ustawiono wartosc domyslna.");
                    sekunda = 1;
                }
                if (sekunda > 59)
                {
                    Console.WriteLine("Podano zla sekunde. Ustawiono wartosc domyslna.");
                    sekunda = 59;
                }
            }
            else
                Sekunda = sekunda;
        }

        public void PokazDate()
        {
            Console.WriteLine(Rok + "/" + Miesiac + "/" + Dzien + " " + Godzina + ":" + Minuta + ":" + Sekunda);
        }

        public void PokazDateFormatowana()
        {
            if (Format == "yyyy-MM-dd hh:mm:ss")
                Console.WriteLine(Rok + "/" + Miesiac + "/" + Dzien + " " + Godzina + ":" + Minuta + ":" + Sekunda);
            else if (Format == "yyyy-MM-dd")
                Console.WriteLine(Rok + "/" + Miesiac + "/" + Dzien);
            else
                Console.WriteLine("Nie znaleziono formatu");
        }

        public void DodajTydzien()
        {
            Dzien += 7;
            if (Dzien > 31)
            {
                Miesiac++;
                if (Miesiac > 12)
                {
                    Rok++;
                    Miesiac -= 12;
                }
                Dzien -= 31;
            }
                
        }
        public void UsunTydzien()
        {
            Dzien -= 7;
            if (Dzien < 0)
            {
                Miesiac--;
                if (Miesiac < 1)
                {
                    Rok--;
                    Miesiac = 12 - Miesiac;
                }
                Dzien = 31 + Dzien;
            }
        }
    }
}
