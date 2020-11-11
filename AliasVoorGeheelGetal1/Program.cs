using System;

namespace AliasVoorGeheelGetal1
{
    using System;
    class Program
    {
        static void Main()
        {
            Weekdag d1, d2;

            VulWeekdagIn("Weekdag 1", out d1);
            VulWeekdagIn("Weekdag 2", out d2);

            Weekdag eerste = d1;
            Weekdag laatste = d2;
            if (d1 > d2)
            {
                eerste = d1;
                laatste = d2;
            }

            Console.WriteLine($"{eerste} komt niet na {laatste}.");
            Console.ReadLine();
        }
        static void VulWeekdagIn(string label, out Weekdag w)
        {
            string invoer;
            do
            {
                Console.Write(label + "?: ");
                invoer = Console.ReadLine();
            }
            while (!Enum.TryParse<Weekdag>(invoer, out w));
        }
    }
    enum Weekdag
    {
        Maandag, Dinsdag, Woensdag, Donderdag, Vrijdag, Zaterdag, Zondag
    }

}
