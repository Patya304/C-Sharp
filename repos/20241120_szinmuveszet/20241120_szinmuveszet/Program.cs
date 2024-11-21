using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20241120_szinmuveszet
{
    class Szinesz
    {
        public int ev, oscar;
        public string nev, horoszkop, eredeti;
        public Szinesz(string egysor)
        {
            string[] darabok = egysor.Trim().Split(';');
            eredeti = egysor;
            nev = darabok[0];
            ev = int.Parse(darabok[1]);
            horoszkop = darabok[2];
            
            if (darabok[3] == "")
            {
                oscar = 0;
            }
            else
            {
                oscar = int.Parse(darabok[3]);
            }
        }
    }
    class Program
    {

        static List<Szinesz> szineszek = new List<Szinesz>();
        static void Main(string[] args)
        {

            f1();
            f2();
            f345();
            f6();
            Console.ReadKey();
        }


        static void f1()
        {
            string[] beolvas = File.ReadAllLines("oscar.csv", Encoding.Default);
            foreach (var item in beolvas)
            {
                szineszek.Add(new Szinesz(item));
            }
            Console.WriteLine("Adatok sikeresen belettek olvasva!");
        }

        static void f2()
        {
            Console.WriteLine($"\n\t2. Feladat \n{szineszek.Count()} Színész van a listán.");
        }


        static void f345()
        {
            int db = 0;
            int oss = 0;
            foreach (var item in szineszek)
            {
                if (item.oscar > 0)
                {
                    db++;
                    oss += item.oscar;
                }
            }
            Console.WriteLine($"\n\t3. Feladat \n{db} Oscar-díjas színész van.");
            Console.WriteLine($"\n\t4. Feladat \n{szineszek.Count() - db} Színész nem kapott Oscar-díjat.");
            Console.WriteLine($"\n\t5. Feladat \nÖsszesen {oss} Oscar-díjat kaptak.");
        }

        static void f6()
        {
            int sev = szineszek[0].ev;
            foreach (var item in szineszek)
            {
                if (item.ev < sev)
                {
                    sev = item.ev;
                }
                Console.WriteLine($"\n\t6. Feladat \nA legidősebb színész(ek): \n");
                foreach (var item in szineszek)
                {
                    if (item.ev == )
                    {

                    }
                }
            
        }
    }
}