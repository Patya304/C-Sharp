using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elso_Programom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Szam_1; //adat 1
            int Szam_2; //adat 2
            int Sum = 0;
            //Bekérés
            Console.Write("Kérem az első számot: ");
            Szam_1 = Convert.ToInt32(Console.ReadLine()); //a bekért adat integer adattípussá való átalakítása
            Console.WriteLine($"Az első szám értéke: {Szam_1}"); //bekért szám kiírása (ellenörzés képpen)
            //Bekérés 2
            Console.Write("Kérem a második számot: ");
            Szam_2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A második szám értéke: {Szam_2}");

            Sum = Szam_1 + Szam_2; //a két bekért szám összeadása
            Console.WriteLine($"A két szám összege: {Sum}");
            Console.ReadKey();
        }
    }
}
