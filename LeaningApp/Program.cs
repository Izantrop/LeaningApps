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
            //Console.WriteLine("Suma liczb w tablicy podzielna przez 3: " + s1.Sumal3());
            //Console.WriteLine("Suma el. w tablicy: " + s1.IleElementow());
            //Console.WriteLine("Suma el. w tablicy: " + s1.IleElementow());
            //Console.WriteLine(s1.WszystkieElementy());
            //Console.WriteLine(s1.WszystkieElementy());
            //Console.WriteLine(s1.Indeksy(-2, 9));


            //Console.WriteLine("\r\n------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Zadanie 3: ");
            //Statyczna ss1 = new Statyczna(4);
            //Statyczna ss2 = new Statyczna(3);
            //Statyczna.Zwieksz();

            //// metody statyczne - doczytac

            ////Console.WriteLine(ss1.I.ToString());
            /////*1. MOŻNA.*/
            /////*2. Z metody Statyczna.Zwieksz nie mozna odwolac sie do pola I poniewaz nie jest ono statyczne.*/


            //Console.WriteLine("\r\n------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Zadanie 4: ");
            //Daty d1 = new Daty(77, 12, 30, 08, 08, 50);
            //d1.PokazDate();

            //d1.DodajTydzien();
            //d1.PokazDate();
            //d1.UsunTydzien();
            //d1.PokazDate();
            //Daty d2 = new Daty(1999, 12, 12, 12, 11, 55, "yyyy-MM-dd");
            //d2.PokazDateFormatowana();

            //Console.WriteLine(d1.Dzis("dd.MM.yyy"));
            //Console.WriteLine(d2.ZmienDate(true, "yyyy-MM-dd hh.mm.ss"));
            //Console.WriteLine(d2.ZmienDate(false, "MM/dd/yy"));


            //Console.WriteLine("\r\n------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Zadanie 5: ");

            //Liczba li1 = new Liczba();
            //char[] nowaLiczba = Console.ReadLine().ToCharArray();

            //li1.WpiszLiczbe(nowaLiczba);

            //li1.Mnozenie(98989898);
            //li1.WypiszLiczbe();
            //int silnia = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine(li1.Silnia(silnia));

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


            //Console.WriteLine("\r\n------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Zadanie 7: ");

            //int iter = 0;
            //string imie;
            //string nazwisko;
            //ListaOsob lo1 = new ListaOsob();
            //ListaOsob lo2 = new ListaOsob();

            //Console.WriteLine("Wybierz opcje latwa (1), lub trudna (2):");
            //string opcja = Console.ReadLine();
            //if (opcja == "1")
            //{
            //    while (iter < 5)
            //    {
            //        Console.Write("Podaj Imie " + (iter+1) + ": ");
            //        imie = Console.ReadLine();
            //        Console.Write("Podaj Nazwisko " + (iter+1) + ": ");
            //        nazwisko = Console.ReadLine();
            //        Osoba o1 = new Osoba(imie, nazwisko);
            //        o1.Przedstaw();
            //        lo1.DodajDane(o1);
            //        iter++;
            //    }
            //    lo1.ListaDanych();
            //}
            //else if (opcja == "2")
            //{
            //    do
            //    {
            //        Console.Write("Podaj Imie " + (iter + 1) + ": ");
            //        imie = Console.ReadLine();
            //        Console.Write("Podaj Nazwisko " + (iter + 1) + ": ");
            //        nazwisko = Console.ReadLine();
            //        Osoba o2 = new Osoba(imie, nazwisko);
            //        o2.Przedstaw();
            //        if (iter < lo2.listaOsob.Length)
            //            lo2.listaOsob[iter] = o2;
            //        else
            //        {
            //            lo2.ZwiekszListe();
            //            if (iter < lo2.listaOsob.Length)
            //                lo2.listaOsob[iter] = o2;
            //            else
            //                lo2.ZwiekszListe();
            //        }
            //        iter++;
            //    } while (nazwisko != String.Empty);

            //    lo2.ListaZListy();
            //}
            //else
            //    Console.WriteLine("Wybrano zla opcje.");

            //Console.WriteLine("Koniec programu");


            //Console.WriteLine("\r\n------------------------------------------------------------------------------------------------");
            //Console.WriteLine("Zadanie 8: ");
            //CzlonkowieRodziny c1 = new CzlonkowieRodziny(1, "A1", "A2", 51);
            //Zawody z1 = new Zawody("Spawacz", 23);
            //Samochody s1 = new Samochody("Opel", "Astra", "srebny");
            //Hobby h1 = new Hobby("brak");
            //Edukacja e1 = new Edukacja("Białystok", "SP 1", "brak");

            //Filtr f1 = new Filtr();
            //f1.WypiszWszystko(c1, z1, s1,h1, e1);

            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Zadanie 9");
            //A a1 = new A();
            //A a2 = new A();
            //B b1 = new B();
            //B b2 = new B();
            //C c1 = new C();
            //C c2 = new C();

            //List<A> listaA = new List<A>();
            //List<B> listaB = new List<B>();
            //List<C> listaC = new List<C>();

            //listaA.Add(a1);
            //listaA.Add(a2);
            //listaA.Add(b1);
            //listaA.Add(b2);
            //listaA.Add(c1);
            //listaA.Add(c2);

            //listaB.Add(b1);
            //listaB.Add(b2);
            //listaB.Add(c1);
            //listaB.Add(c2);

            //listaC.Add(c1);
            //listaC.Add(c2);

            //foreach (var item in listaA)
            //{
            //    item.Metoda1();
            //    item.Metoda2();
            //}

            //Console.WriteLine();
            //foreach (var item in listaB)
            //{
            //    item.Metoda1();
            //    item.Metoda2();
            //}

            //Console.WriteLine();
            //foreach (var item in listaC)
            //{
            //    item.Metoda1();
            //    item.Metoda2();
            //}


            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Zadanie 10");
            //AA aa1 = new AA();
            //BB bb1 = new BB();
            //CC cc1 = new CC();

            //aa1.Metoda();


            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Zadanie 11");
            AAA aaa1 = new AAA();
            //BBB bbb1 = aaa1; 
            //bbb1.X = 3;


            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Zadanie 12");
            //Samochod s1 = new Samochod();



            Console.ReadLine();
        }
    }
}
