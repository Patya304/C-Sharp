using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241003
{
    class Program
    {
        static void Main(string[] args)
        {
            f1();
            f2();
            Console.ReadKey();
        }

        static void f1()
        {
            // 1. Feladat
            Console.WriteLine("\t1. Feladat");
            //Random rnd = new Random();
            // int randSzamok = rnd.Next(20);
            //int[] szamok;
            //szamok = new int[8];
            //int[] randSzamok = { 11, 23, 56, 40, 9, 12, 113, 54};
            Random rnd = new Random();
            int[] Nszamok = new int[25];
            int SS = 0;
            for (int i = 0; i < Nszamok.Length; i++)
            {
                Nszamok[i] = rnd.Next(20);
                if (Nszamok[i] % 2 != 0)
                {
                    SS++;
                }
            }
            Console.Write($"Ennyi páratlan volt: {SS}");
        }
        static void f2()
        {
            // 2. Feladat
            Console.WriteLine("\n\n\t2. Feladat");
            //Random rnd = new Random();
            // int randSzamok = rnd.Next(20);
            //int[] szamok;
            //szamok = new int[8];
            //int[] randSzamok = { 11, 23, 56, 40, 9, 12, 113, 54};
            Random rnd = new Random();
            int[] Pszamok = new int[25];
            int PSS = 0;
            
            for (int z = 0; z < Pszamok.Length; z++)
            {
                Pszamok[z] = rnd.Next(20);
                if (Pszamok[z] % 2 == 0)
                {
                    PSS = PSS + Pszamok[z];
                }
            }
            Console.Write($"Páros számok összege: {PSS}");
        }

    }
}
