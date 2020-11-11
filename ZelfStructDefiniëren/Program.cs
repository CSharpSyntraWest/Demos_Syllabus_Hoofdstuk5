using System;

namespace ZelfStructDefiniëren
{
    using System;
    struct Coordinaat
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Coordinaat c1 = new Coordinaat() { X = 3, Y = 4 };
            Console.WriteLine($"Orgineel: X:{c1.X} Y:{c1.Y}");

            Coordinaat c2 = c1;
            Console.WriteLine($"Kopie: X:{c2.X} Y:{c2.Y}");

            c2.X = 5;
            Console.WriteLine($"Orgineel na wijziging kopie: X:{c1.X} Y:{c1.Y}");
            Console.WriteLine($"Kopie na wijziging kopie: X:{c2.X} Y:{c2.Y}");

            Console.ReadLine();
        }
    }

}
