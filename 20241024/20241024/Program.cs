using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241024
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            szoveg();
            feladatok();
            Console.ReadKey();
        }
        static void szoveg()
        {
            string sz = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            Console.WriteLine($"A szöveg hossz: {sz.Length}");
            Console.WriteLine($"Kivágás: {sz.Substring(6, 5)}");
            Console.WriteLine($"Kicserélés: {sz.Replace('L', 'Y')}");
            Console.WriteLine($"Eltávolítás: {sz.Remove(4)}");
            Console.WriteLine($"Szokoz lecsapása: {sz.Trim()}");
            string[] szavak = sz.Split();
            Console.WriteLine($"A szavak száma: {szavak.Length}");
            Console.WriteLine($"Az i indexe: {sz.IndexOf('i')}");
            Console.WriteLine($"nagybetűs: {sz.ToUpper()}");
            Console.WriteLine($"kisbetűs: {sz.ToLower()}");
            Console.WriteLine($"Az i indexe: {sz.ToLower().IndexOf('i')}");
            Console.WriteLine($"Tartalmaz-e: {sz.Contains('W')}");
            int db_e = 0;
            for (int i = 0; i < sz.Length; i++) ;
            {
                if (sz[i]=='e')
                {
                    db_e++;
                }
            }
            Console.WriteLine($"e betűk száma: {db_e}");
            Console.WriteLine($"E betűk SZÁMA: {sz.Split('e').Length-1}");
        }
        static void feladatok()
        {
            Console.WriteLine("\n\t1. Feladat");
            string szoveg = "clvass";
            foreach (char letter in szoveg)
            {
                Console.Write(letter + " ");
            }



        }

    }
}
