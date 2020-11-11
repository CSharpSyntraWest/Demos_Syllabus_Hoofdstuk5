using System;

namespace MetEnumeratie
{
    using System;
    class Program
    {
        static void Main()
        {
            Console.WriteLine(GetAantalLesuren(Weekdag.Maandag));
            Console.WriteLine(GetAantalLesuren(Weekdag.Woensdag));
            Console.WriteLine(GetAantalLesuren(Weekdag.Zaterdag));

            Console.ReadLine();
        }
        static int GetAantalLesuren(Weekdag w)
        {
            if (w == Weekdag.Maandag || w == Weekdag.Dinsdag ||
                w == Weekdag.Donderdag || w == Weekdag.Vrijdag) { return 8; }
            else if (w == Weekdag.Woensdag) { return 4; }
            else { return 0; }
        }
    }
    enum Weekdag
    {
        Maandag, Dinsdag, Woensdag, Donderdag, Vrijdag, Zaterdag, Zondag
    }

}
