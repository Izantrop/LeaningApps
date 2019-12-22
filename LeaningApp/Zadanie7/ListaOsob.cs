using System;
using System.Collections.Generic;
using System.Text;

namespace LearningApp
{
    class ListaOsob
    {
        public List<Osoba> daneOs = new List<Osoba>();
        public Osoba[] listaOsob = new Osoba[5];
        public void ListaDanych()
        {
            daneOs.Reverse();
            foreach (var item in daneOs)
            {
                Console.WriteLine(item.Nazwisko+" "+item.Imie);
            }
        }

        public void ListaZListy()
        {
            for (int i = 0; i < listaOsob.Length; i++)
            {
                try
                {
                    Console.WriteLine(listaOsob[i].Nazwisko + " " + listaOsob[i].Imie);
                }
                catch (NullReferenceException)
                {
                    
                }
            }
        }

        public void DodajDane(Osoba osoba)
        {
            daneOs.Add(osoba);
        }

        public void ZwiekszListe()
        {
            Array.Resize(ref listaOsob, listaOsob.Length*2);
        }
    }
}
