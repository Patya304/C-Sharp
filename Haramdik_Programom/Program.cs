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
            string keresztnev = "";
            string vezeteknev = "";
            string monogram = "";

            Console.Write("Kérem a Vezetéknevét: ");
            vezeteknev = Console.ReadLine();
            Console.Write("Kérem a Keresztnevét: ");
            keresztnev = Console.ReadLine();

            monogram = vezeteknev[0].ToString();
            monogram += keresztnev[0].ToString();
            Console.Write($"A monogram: {monogram}");
            Console.ReadKey();
        }
    }
}
