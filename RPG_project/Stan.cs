using System;

namespace Zwierzeta_projekt
{
    internal class StanGry
    {
        public static void WyswietlStan(int[] stan, int Dzien)
        {
            Console.WriteLine($"Dzień {Dzien} - Zwierzątko ma teraz {stan[0]} punktów zdrowia i {stan[1]} punktów szczęścia");
        }


    }
}
