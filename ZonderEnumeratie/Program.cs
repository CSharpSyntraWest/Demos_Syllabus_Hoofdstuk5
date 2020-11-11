using System;

namespace ZonderEnumeratie
{
    using System;
    class Program
    {
        static void Main()
        {
            Console.WriteLine(GetAantalLesuren("Maandag"));
            Console.WriteLine(GetAantalLesuren("Woensdag"));
            Console.WriteLine(GetAantalLesuren("Zaterdag"));

            Console.ReadLine();
        }
        static int GetAantalLesuren(string weekdag)
        {
            if (weekdag == "Maandag" || weekdag == "Dinsdag" ||
                weekdag == "Donderdag" || weekdag == "Vrijdag") { return 8; }
            else if (weekdag == "Woensdag") { return 4; }
            else { return 0; }
        }
    }

}
