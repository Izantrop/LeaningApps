using System;
using System.Collections.Generic;

namespace LearningApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Zadanie 1: ");
            //Licz L1 = new Licz(66);
            //Licz L2 = new Licz(12);
            //Licz L3 = new Licz(12);
            //Licz L4 = new Licz(12);

            //Console.WriteLine("Wart. pola przekazywane do konstruktora: " + L1.wypisz());
            //L2.odejmij(2);
            //L3.dodaj(453);
            //L4.odejmij(232);

            //L2.wypisz();
            //L3.wypisz();
            //L4.wypisz();


            //Console.WriteLine("\r\n------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Zadanie 2: ");
            //int[] lista = { 23, 234, 5, 1, 465, 7, 123, 09 };
            //Sumator s1 = new Sumator(lista);

            //Console.WriteLine("Suma liczb w tablicy: " + s1.Suma());
            //Console.WriteLine("Suma liczb w tablicy: " + s1.Suma());
            //Console.WriteLine("Suma liczb w tablicy podzielna przez 3: " + s1.Sumal3());
            //Console.WriteLine("Suma el. w tablicy: " + s1.IleElementow());
            //Console.WriteLine(s1.WszystkieElementy());
            //Console.WriteLine(s1.Indeksy(1, 100));


            //Console.WriteLine("\r\n------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Zadanie 3: ");
            //Statyczna ss1 = new Statyczna(4);
            //Statyczna ss2 = new Statyczna(3);
            //Statyczna.Zwieksz();

            //// metody statyczne - doczytac

            ////Console.WriteLine(ss1.I.ToString());
            /////*1. MOŻNA.*/
            /////*2. Z metody Statyczna.Zwieksz nie mozna odwolac sie do pola I poniewaz nie jest ono statyczne.*/


            Console.WriteLine("\r\n------------------------------------------------------------------------------------------------");
            Console.WriteLine("Zadanie 4: ");
            Daty d1 = new Daty(2000,19,12,08,08,50);
            d1.PokazDate();

            d1.DodajDzien(2);
            //Daty d2 = new Daty();

            //Console.WriteLine(d1.Dzis("dd.MM.yyy"));
            //Console.WriteLine(d2.ZmienDate(true, "yyyy-MM-dd hh.mm.ss"));
            //Console.WriteLine(d2.ZmienDate(false, "MM/dd/yy"));

            d1.PokazDate();


            Console.WriteLine("\r\n------------------------------------------------------------------------------------------------");
            Console.WriteLine("Zadanie 5: ");

            Liczba li1 = new Liczba();
            //char[] nowaLiczba = Console.ReadLine().ToCharArray();

            //li1.WpiszLiczbe(nowaLiczba);

            //li1.Mnozenie(98989898);
            //li1.WypiszLiczbe();
            int silnia = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(li1.Silnia(silnia));

            //Console.WriteLine("\r\n------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Zadanie 6: ");
            //Zadanie_6.Osoba o1 = new Zadanie_6.Osoba("Adam", "Adamski", 24);
            //Zadanie_6.Osoba o2 = new Zadanie_6.Osoba("Piotr", "Szymanski", 42);
            //Zadanie_6.Osoba o3 = new Zadanie_6.Osoba("Michalina", "Kak", 31);

            //Zadanie_6.Ksiazka k1 = new Zadanie_6.Ksiazka("Adamowo", o1, new DateTime(1990, 12, 21));
            //Zadanie_6.Ksiazka k2 = new Zadanie_6.Ksiazka("Piotrowo", o2, new DateTime(1999, 09, 09));
            //Zadanie_6.Ksiazka k3 = new Zadanie_6.Ksiazka("Szymanowo", o3, new DateTime(2018, 08, 12));
            //Zadanie_6.Czytelnik c1 = new Zadanie_6.Czytelnik("Piotr", "Piotrowski", 13);
            //Zadanie_6.Recenzent r1 = new Zadanie_6.Recenzent("Karol", "Stras", 66);
            //Zadanie_6.KsiazkaDokumentalna kd1 = new Zadanie_6.KsiazkaDokumentalna("Dokumant NASA", o2, new DateTime(2011, 11, 09), "opis1");
            //Zadanie_6.KsiazkaPrzygodowa kp1 = new Zadanie_6.KsiazkaPrzygodowa("Przygody NASA", o2, new DateTime(2004, 02, 03), "opis2");

            //Console.WriteLine(o1.Wypisz());
            //r1.Przeczytaj(k1);
            //r1.Przeczytaj(k2);
            //r1.Przeczytaj(k3);
            //c1.Przeczytaj(kd1);
            //c1.Przeczytaj(kp1);
            //Console.WriteLine(c1.Wypisz());
            //r1.Wypisz();

            //Zadanie_6.Osoba o4 = new Zadanie_6.Czytelnik("Michalina", "Kak", 31);
            //var czyt = ((Zadanie_6.Czytelnik)o4);
            //czyt.Przeczytaj(k2);
            //Console.WriteLine(o4.Wypisz()); 

            //Poczytać o operatorach IS i AS

            //List<Zadanie_6.Osoba> listaOs = new List<Zadanie_6.Osoba>();
            //listaOs.Add(o1);
            //listaOs.Add(o2);
            //listaOs.Add(o3);
            //listaOs.Add(c1);
            //listaOs.Add(r1);

            //foreach (var person in listaOs)
            //{
            //    Console.WriteLine(person.Wypisz());
            //}


            //Console.WriteLine(o1.Wypisz());
            //Console.WriteLine(k1.Wypisz());
            //Console.WriteLine(c1.WypiszKsiazki());
            //Console.WriteLine(o1.Wypisz());



            //Console.ReadLine();
        }
    }
}
