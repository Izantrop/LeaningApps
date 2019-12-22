using System;
using System.Collections.Generic;
using System.Text;

namespace LearningApp
{
    class Filtr
    {
        public void WypiszZawod(CzlonkowieRodziny czlonek, Zawody zawod)
        {
            czlonek.Wypisz();
            zawod.Wypisz();
        }
        public void WypiszSamochod(CzlonkowieRodziny czlonek, Samochody samochody)
        {
            czlonek.Wypisz();
            samochody.Wypisz();
        }
        public void WypiszHobby(CzlonkowieRodziny czlonek, Hobby hobby)
        {
            czlonek.Wypisz();
            hobby.Wypisz();
        }
        public void WypiszEdukacja(CzlonkowieRodziny czlonek, Edukacja edukacja)
        {
            czlonek.Wypisz();
            edukacja.Wypisz();
        }
        public void WypiszWszystko(CzlonkowieRodziny czlonek, Zawody zawod, Samochody samochody, Hobby hobby, Edukacja edukacja)
        {
            czlonek.Wypisz();
            zawod.Wypisz();
            samochody.Wypisz();
            hobby.Wypisz();
            edukacja.Wypisz();
        }

        public void WypiszKolekcje()
        {
            
        }
    }
}
