using System;

namespace Zwierzeta_projekt
{
    internal class Organizm
    {
        public static int[] Lecznica(int[] Zwierze)
        {
			Console.WriteLine("Witamy w lecznicy - leczenie poprawia punkty zdrowia o trochę a operacja o więcej");
			Console.WriteLine("Ale pamiętaj - operacja bardziej zmniejsza punkty szczęścia!");
			Console.WriteLine("> Co chcesz robić w lecznicy? Wciśnij l - leczenie o - operacja");
            string klawisz = Console.ReadLine();
            switch (klawisz)
            {
                case "l":
                    return Leczenie(Zwierze);
				case "o":
					return Operacja(Zwierze);
				default:
                    return Zwierze;
            }
        }

        public static int[] Leczenie(int[] Zwierze)
        {
            if (Zwierze[1] >= 30)
            {
				// szczęśliwe zwięrzę szybko poprawia zdrowie, ale nie lubi lekarstw - szczęscie troche maleje
				Zwierze[0] += 10;
                Zwierze[1] += -10;
                Console.WriteLine("Leczenie bardzo udane, choć pacjent trochę tego nie lubił - szczęście spadło!");
             }
            else
            {
				// nieszczęśliwe zwięrzę słabo poprawia zdrowie, ale nie lubi lekarstw - szczęscie troche maleje
				Zwierze[0] += 5;
				Zwierze[1] += -10;
				Console.WriteLine("Leczenie bardzo udane, choć pacjent trochę tego nie lubił - szczęście spadło!");
			}

			return Zwierze;
        }

		public static int[] Operacja(int[] Zwierze)
		{
			if (Zwierze[1] >= 40)
			{
				// szczęśliwe zwięrzę szybko poprawia zdrowie, ale nie lubi operacji - szczęscie mocno maleje
				Zwierze[0] += 20;
				Zwierze[1] += -20;
				Console.WriteLine("Operacja udana, ale pacjent bardzo tego nie lubił - szczęście mocno spadło!");
			}
			else
			{
				// nieszczęśliwe zwięrzę słabo poprawia zdrowie, ale nie lubi operacji - szczęscie mocno maleje
				Zwierze[0] += 10;
				Zwierze[1] += -20;
				Console.WriteLine("Operacja udana, ale pacjent bardzo tego nie lubił - szczęście mocno spadło!");
			}

			return Zwierze;
		}





	}
}
