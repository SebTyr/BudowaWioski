using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int KosztZamku = 2000;
            const int KosztDomu = 500;
            const int KosztKoszar = 1000;

            int NaszHajs;
            int PoZmianie;

            int LiczbaZamkow;
            int LiczbaDomow;
            int LiczbaKoszar;

            Console.WriteLine("Ile masz złota ?");
            NaszHajs = int.Parse(Console.ReadLine());

            if (NaszHajs <= 0)
            {
                Console.WriteLine("Nie stać cię");
                Console.WriteLine("Spadaj :]");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Masz " + NaszHajs + " złota.");
            Console.WriteLine();

            Console.WriteLine("Ile domów wybudować ?");
            LiczbaDomow = int.Parse(Console.ReadLine());
            PoZmianie = NaszHajs - (LiczbaDomow * KosztDomu);
            Console.WriteLine("Pozostało ci " + PoZmianie + " złota");

            Console.WriteLine("Ile zamków wybudować ?");
            LiczbaZamkow = int.Parse(Console.ReadLine());
            PoZmianie = PoZmianie - (LiczbaZamkow * KosztZamku);
            Console.WriteLine("Pozostało ci " + PoZmianie + " złota");

            Console.WriteLine("Ile koszar wybudować ?");
            LiczbaKoszar = int.Parse(Console.ReadLine());
            PoZmianie = PoZmianie - (LiczbaKoszar * KosztKoszar);
            Console.WriteLine("Pozostało ci " + PoZmianie + " złota");
            Console.WriteLine();
            Console.WriteLine("Wybudowałeś " + LiczbaDomow + " domów, " + LiczbaZamkow + " zamków i " + LiczbaKoszar + " koszar.");
            Console.WriteLine();
            Console.WriteLine("Kosztowało cię to " + (NaszHajs - PoZmianie) + " złota");
            Console.WriteLine();


        }
    }
}
