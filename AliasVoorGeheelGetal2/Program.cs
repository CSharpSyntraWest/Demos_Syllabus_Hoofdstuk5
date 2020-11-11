using System;

namespace AliasVoorGeheelGetal2
{
    using System;
    enum Volume { Klein = 3, Normaal = 4, Groot = 5 }
    class Program2
    {
        static void Main()
        {
            Volume volumeDrankje1 = Volume.Klein;
            Volume volumeDrankje2 = Volume.Groot;
            Volume volumeDrankje3 = Volume.Groot;

            Console.Write(GetTotaalVolume(volumeDrankje1, volumeDrankje2, volumeDrankje3));
            Console.ReadLine();
        }
        static int GetTotaalVolume(params Volume[] volumes)
        {
            int totaalVolume = 0;
            foreach (Volume v in volumes)
            {
                totaalVolume = totaalVolume + (int)v;
            }
            return totaalVolume;
        }
    }
}

