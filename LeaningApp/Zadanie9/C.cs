using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp
{
    class C : B
    {
        public override void Metoda1()
        {
            base.Metoda1();
            Console.WriteLine("Metoda wirtualna klasy C");
        }
        public new void Metoda2()
        {
            base.Metoda2();
            Console.WriteLine("Metoda void klasy C");
        }
    }
}
