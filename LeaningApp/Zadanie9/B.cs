using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp
{
    class B : A
    {
        public override void Metoda1()
        {
            Console.WriteLine("Metoda wirtualna klasy B");
        }
        public new void Metoda2()
        {
            Console.WriteLine("Metoda void klasy B");
        }
    }
}
