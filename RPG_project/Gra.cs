using System;

namespace Zwierzeta_projekt
{
    internal class Gra
    {
        static void Main(string[] args)
        {
            int[] Zwierze = Zwierzeta.WyborZwierzecia();
            int Dzien = 1;
            bool KoniecGry = false;
            
            do
            {
			    Console.WriteLine("> Co chcesz zrobić? o - odpoczynek s - spacer l - lecznica k - koniec gry");
                string klawisz = Console.ReadLine();
                switch (klawisz)
                {
                	case "o":
						Console.WriteLine("OK. Lenimy się ze zwierzęciem w domu");
						Akywnosc.Odpoczynek(Zwierze);
						Dzien += 1;
						break;
					case "s":
                        Console.WriteLine("OK. Idziemy ze zwierzęciem na spacer");
                        Akywnosc.Spaceruj(Zwierze);
						Dzien += 1;
						break;
                    case "l":
						Console.WriteLine("OK. Idziemy ze zwierzęciem do lecznicy");
                        Organizm.Lecznica(Zwierze);
						Dzien += 1;
						break;
                    case "k":
                        Console.WriteLine("OK. Konczymy grę");
                        KoniecGry = true;
                        break;
                    default:
                        Console.WriteLine("Nie wciskaj niczego innego!");
                
                        break;
                    }
                    StanGry.WyswietlStan(Zwierze, Dzien);
            }
            while (Zwierzeta.CzyZyje(Zwierze) & !KoniecGry);
			Console.WriteLine("Koniec gry!!! (Wciśnij dowolny klawisz żeby zamknąć okienko gry)");
			Console.ReadKey();
		}

	}
}
