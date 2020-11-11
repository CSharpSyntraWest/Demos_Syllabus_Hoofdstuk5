using System;

namespace EnumeratieAlsReturntype
{
    using System;
    class Program
    {
        static void Main()
        {
            Console.WriteLine(GetSluitingDag());
        }
        static Weekdag GetSluitingDag()
        {
            return Weekdag.Zondag;
        }
    }
    enum Weekdag
    {
        Maandag, Dinsdag, Woensdag, Donderdag, Vrijdag, Zaterdag, Zondag
    }

}
