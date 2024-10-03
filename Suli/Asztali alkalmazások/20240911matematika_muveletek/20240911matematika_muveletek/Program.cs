using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240911matematika_muveletek
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Feladat
            Console.WriteLine("\n\t4. Feladat");
            int hr_hossz;
            int hrm;
            int hr_terulet;

            Console.Write("Add meg a háromszög oldalainak hosszát: ");
            hr_hossz = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg a háromszög magasságát");
            hrm = Convert.ToInt32(Console.ReadLine());

            hr_terulet = (hr_hossz + hrm) / 2;
            Console.WriteLine($"A háromszög területe: {hr_terulet}");
            
            //5. Feladat
            Console.WriteLine("\n\t5. Feladat");
            int k_sugar;
            double k_kerulet;
            double k_terulet;

            Console.Write("Add meg a kör sugarát: ");
            k_sugar = Convert.ToInt32(Console.ReadLine());

            k_kerulet = 2 * k_sugar * Math.PI;
            Console.WriteLine($"A kör kerülete: {k_kerulet}");

            k_terulet = k_sugar * 2 * Math.PI;
            Console.WriteLine($"A kör területe: {k_terulet}");
            Console.ReadKey();


        }
    }
}
