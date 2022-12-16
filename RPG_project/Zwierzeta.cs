using System;

namespace Zwierzeta_projekt
{
    internal class Zwierzeta
    {
        public static int[] WyborZwierzecia()
        {
			// tu wybieramy gatunek zwierzecia

            Console.WriteLine("Witaj!");
			while (true)
            {
                Console.WriteLine("> Możesz hodować psa (ma więcej szczęścia) lub kota (ma więcej zdrowia) - wybierz p lub k:");
                string klawisz = Console.ReadLine();
                if (klawisz == "p")
                {
                   // niech pies bedzie mial wiecej szczęścia
                    int[] p = { 20, 40 };
                    return p;
                }
                else if (klawisz == "k")
                {
                    // niech kot bedzie mial wiecej zdrowia
                    int[] k = { 40, 20 };
                    return k;
                }
                else
                {
                    Console.WriteLine("Nie wciskaj niczego innego!");
                }
            }
        }
        public static bool CzyZyje(int[] Zwierze)
        {
            if (Zwierze[0] <= 0)
                return false;
			if (Zwierze[1] <= 0)
				return false;
			return true;
        }
    }
}
