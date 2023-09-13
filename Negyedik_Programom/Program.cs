using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negyedik_Programom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Változó deklarálása
            int ora = 0;
            //Bekérés
            Console.Write("Kérek egy óra számot: ");
            //ora változó feltöltése a bekért értékkel
            ora = int.Parse(Console.ReadLine());
            //VIzsgálat 1 -> Reggeli időszak (0-8)
            if (ora >= 0 && ora <= 8)
            {
                Console.WriteLine("Jó reggelt!");
            }
            //Vizsgálat 2 -> Nap közbeni időszak (8-18)
            else if (ora  > 8 && ora <= 18)
            {
                Console.WriteLine("Szép napot!");
            }
            //Vizsgálat 3 -> Esti időszak (18-24)
            else if (ora > 18 && ora <= 24)
            {
                Console.WriteLine("Jó éjszakát!");
            }
            //Hiba üzenet
            else
            {
                Console.WriteLine("Sajnálom, nincs ilyen óra!");
            }
            Console.ReadKey();
        }
    }
}
