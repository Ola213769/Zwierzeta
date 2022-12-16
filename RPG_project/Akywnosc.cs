using System;

namespace Zwierzeta_projekt
{
    public class Akywnosc
    {
        public static int[] Odpoczynek(int[] Zwierze)
        {
			// zwierzę zjada dobry pokarm, ale szkodzi mu brak ruchu i nie jest za szczęśliwe
			Console.WriteLine("Twój zwierzak siedzi nieszczęśliwy w domu, ale na szczęście pamiętałeś żeby go nakarmić.");
			
			Zwierze[0] = Pokarm.Nakarm(Zwierze, 1, 7);
			Zwierze[1] = Pokarm.Lubi(Zwierze, -10, 3);

			return Zwierze;
        }
		public static int[] Spaceruj(int[] Zwierze)
		{
			// zwierzę zażywa ruchu i jest szczęśliwe, ale może samo coś zjeść
			Console.WriteLine("> Na spacerze Twoje zwierzę coś znalazło... Czy pozwolisz mu to coś zjeść? wciśnij t - tak n - nie");

			string klawisz = Console.ReadLine();
			switch (klawisz)
			{
				case "t":
					return Zjada(Zwierze);
				case "n":
					return NieZjada(Zwierze);
				default:
					Console.WriteLine("wybierz t lub n");
					return Zwierze;
			}
		}

		public static int[] Zjada(int[] Zwierze)
        {
            if (Zwierze[1] >= 25)
            {
                // szczęśliwe zwierzę dobrze bada pokarm, wiec pozostanie raczej zdrowe
                Console.WriteLine("Twoje zwierzątko zjadło znaleziony pokarm");
                Zwierze[0] = Pokarm.Nakarm(Zwierze, -4, 4);
				Zwierze[1] = Pokarm.Lubi(Zwierze, -5, 7);
			}
			else
            {
                // nieszczęśliwe zwierzę zjada byle co, może więc mu cos zaszkodzić
				Console.WriteLine("Twoje zwierzątko zjadło jakiś znaleziony pokarm");
				Zwierze[0] = Pokarm.Nakarm(Zwierze, -10, 3);
				Zwierze[1] = Pokarm.Lubi(Zwierze, -5, 10);
			}
			return Zwierze;
        }

        public static int[] NieZjada(int[] Zwierze)
        {
			// zwierzę nic nie zjada, wiec tylko troche zabieramy zdrowia, ale nie jest zadowolone
			Console.WriteLine("Twoje zwierzątko nie zjadło niczego. Zdrowie się pomału pogarsza.");
			Zwierze[0] = Pokarm.Nakarm(Zwierze, -8, 2);
			Zwierze[1] = Pokarm.Lubi(Zwierze, -10, 5);
			return Zwierze;
        }
    }
}
