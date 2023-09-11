using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masodik_Programom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double atlag = 0.00;
            double szorzata = 1;
            for (int i = 0; i <= 10; i++)
            {
                sum += i;
            }
            atlag = sum / 10;
            int j = 1;
            while(j <= 10)
            {
                szorzata *= j;
                j++;

            }
            Console.WriteLine($"Számok összege: {sum}");
            Console.WriteLine($"Számok átlaga: {atlag}");
            Console.WriteLine($"Számok szorzata: {szorzata}");
            Console.ReadKey();

        }
    }
}
