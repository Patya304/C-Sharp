using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elagazas
{
    class Program
    {
        static void Main(string[] args)
        {
            f2();
            f3();
            Console.ReadKey();
        }
        static void f2()
        {
            //2. Feladat
            Console.WriteLine("\t2. Feladat");

            int ev;
            Console.Write("Kérem az év számot: ");
            ev = Convert.ToInt32(Console.ReadLine());

            if (ev % 4 == 0 && ev % 100 != 0 || ev % 400 == 0)
            {
                Console.WriteLine("Szökőév!");
            }
            else
            {
                Console.WriteLine("Nem szökőév!");
            }
        }

        static void f3()
        {
            //3. Feladat
            Console.WriteLine("\n\t3. Feladat");

            int szam;
            Console.Write("Kérek egy számot: ");
            szam = Convert.ToInt32(Console.ReadLine());

            if (szam % 2 == 0)
            {
                Console.WriteLine("A szám pozitív!");
            }
            else
            {
                Console.WriteLine("A szám negatív!");
            }

        }
    }
}
