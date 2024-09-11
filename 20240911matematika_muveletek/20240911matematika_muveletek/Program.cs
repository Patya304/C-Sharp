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

            //1. Feladat
            Console.WriteLine("\t1. Feladat");
            int oldalh;
            int n_kerulet;
            int n_terulet;
            Console.Write("Add meg a négyzet oldal hosszát: ");
            oldalh = Convert.ToInt32(Console.ReadLine());


            n_kerulet = 4 * oldalh;
            Console.WriteLine($"A négyzet kerülete: {n_kerulet}");

            n_terulet = oldalh * oldalh;
            Console.WriteLine($"A négyzet területe: {n_terulet}");

            //2. Feladat
            Console.WriteLine("\n\t2. Feladat");
            int fhossz;
            int ahossz;
            int trm;
            int tr_terulet;

            Console.Write("Add meg a trapéz felső hosszát: ");
            fhossz = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg a trapéz alsó hosszát: ");
            ahossz = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg a trapéz magasságát: ");
            trm = Convert.ToInt32(Console.ReadLine());

            tr_terulet = ((ahossz + fhossz) * trm) / 2;
            Console.WriteLine($"A trapéz területe: {tr_terulet}");

            //3. Feladat
            Console.WriteLine("\n\t3. Feladat");
            int thossz;
            int szelesseg;
            int tg_terulet;
            int tg_kerulet;

            Console.Write("Add meg a téglalap hosszúságát: ");
            thossz = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg a téglalap szélességét: ");
            szelesseg = Convert.ToInt32(Console.ReadLine());

            tg_terulet = thossz * szelesseg;
            Console.WriteLine($"A téglalap területe: {tg_terulet}");

            tg_kerulet = 2 * (thossz + szelesseg);
            Console.WriteLine($"A téglalap kerülete: {tg_terulet}");

            //4. Feladat
            Console.WriteLine("\n\t4. Feladat")

            int hr_hossz;
            int hrm;
            int hr_terulet;

            Console.Write("Add meg a háromszög oldalainak hosszát: ");
            hr_hossz = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg a háromszög magasságát");
            hrm = Convert.ToInt32(ConsoleReadLine());

            hr_terulet = (hr_hossz + hrm) / 2;
            Console.WriteLine($"A háromszög területe: {hr_terulet}");





            Console.ReadKey();


        }
    }
}
