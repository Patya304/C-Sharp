using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haramdik_Programom
{
    internal class Program
    {
        static void Main()
        {
            string keresztnev = ""; //üres string változó
            string vezeteknev = ""; //üres string változó
            string monogram = ""; //üres string változó

            //Bekérés
            Console.Write("Kérem a Vezetéknevét: "); 
            vezeteknev = Console.ReadLine();
            Console.Write("Kérem a Keresztnevét: ");
            keresztnev = Console.ReadLine();
            //adattípus átalakítása
            monogram = vezeteknev[0].ToString();
            monogram += keresztnev[0].ToString(); // += -> ezzel adom hozzá, és így nem lesz felül írva a "monogram" változó
            Console.Write($"A monogram: {monogram}");
            Console.ReadKey();
        }
    }
}
