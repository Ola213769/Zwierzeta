using System;

namespace Zwierzeta_projekt
{
	internal class Pokarm
    {
        // losowanie jakości pokarmu
        public static int Nakarm(int[] zwierze, int min, int max)
        {
            Random rnd = new Random();
			int zdrowie;

			zdrowie = rnd.Next(min, max);

			Console.WriteLine($"Pokarm zmienia o {zdrowie} punkty zdrowia");

			zwierze[0] += zdrowie;

			return zwierze[0];
        }
		public static int Lubi(int[] zwierze, int min, int max)
		{
			Random rnd = new Random();
			int szczescie;

			szczescie = rnd.Next(min, max);

			Console.WriteLine($"Pokarm zmienia o {szczescie} punkty szczęścia");

			zwierze[1] += szczescie;

			return zwierze[1];
		}

	}
}
