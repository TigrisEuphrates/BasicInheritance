using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(80);
            myCar.Speed = 50;
            Console.WriteLine($"My car is going {myCar.Speed} MPH");
            Console.WriteLine();

            MiniVan myMV = new MiniVan();
            myMV.Speed = 100;
            Console.WriteLine($"My van is going {myMV.Speed} MPH");
            Console.WriteLine();
        }
    }
}
