using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20241121_tanulmany
{
    class Eredmeny
    {
        public int helyezes, eredmeny;
        public string nev, iskola, telepules, szakma;

        public Eredmeny(string egysor)
        {
            string[] darabok = egysor.Trim().Split('\t');
            helyezes = int.Parse(darabok[0]);
            nev = darabok[1];
            iskola = darabok[2];
            telepules = darabok[3];
            eredmeny = int.Parse(darabok[4]);
            szakma = darabok[5];
        }
    }
    class Program
    {
        static List<Eredmeny> eredmenyek = new List<Eredmeny>();
        static void Main(string[] args)
        {
            f1();
            f2();
            f3();
            f4();
            f5();
            f6();
            f7();
            f8();
            f9();
            f10();
            f11();
            f12();


            Console.ReadKey();
        }


        static void f1()
        {
            string[] beolvas = File.ReadAllLines("eredmenyek.txt", Encoding.Default);
            foreach (var item in beolvas)
            {
                eredmenyek.Add(new Eredmeny(item));
            }
            Console.WriteLine("Az adatok sikeresen belettek olvasva!");
        }

        static void f2()
        {
            Console.WriteLine($"\n\t2.Feladat \n{eredmenyek.Count()} Diák indult a versenyen!");
        }

        static void f3()
        {
            int gepesz = 0, info = 0, korny = 0;
            foreach (var item in eredmenyek)
            {
                if (item.szakma == "gépész")
                {
                    gepesz++;
                }
                if (item.szakma == "informatika")
                {
                    info++;
                }
                if (item.szakma == "környezetvédelem")
                {
                    korny++;
                }
            }
            Console.WriteLine($"\n\t3.Feladat \n - {gepesz}-an/en vettek részt a Gépész versenyen\n - {info}-an/en vettek részt az Informatika versenyen\n - {korny}-an/en vettek részt a környezetvédelmi versenyen");
        }

        static void f4()
        {
            //iras
        }

        static void f5()
        {
            foreach (var item in eredmenyek)
            {
                if (item.nev.Split()[1] == "Ábrahám")
                {
                    Console.WriteLine($"\n\t5.Feladat \nHelyezés: {item.helyezes} | Iskola: {item.iskola} | Település: {item.telepules} | Eredmény:{item.eredmeny}% | Szakma: {item.szakma}");
                }
            }
        }

        static void f6()
        {
            //foly.
        }

        static void f7()
        {
            int ves = 0;
            foreach (var item in eredmenyek)
            {
                if (item.telepules == "Eger")
                {
                    ves++;
                }

            }
            Console.WriteLine($"\n\t7. Feladat \n{ves} versenyző volt Egerből!");
        }

        static void f8()
        {
            int gepesz2 = 0, info2 = 0, korny2 = 0;
            foreach (var item in eredmenyek)
            {
                if (item.szakma == "gépész" && item.telepules == "Budapest")
                {
                    gepesz2++;
                }
                if (item.szakma == "informatika" && item.telepules == "Budapest")
                {
                    info2++;
                }
                if (item.szakma == "környezetvédelem" && item.telepules == "Budapest")
                {
                    korny2++;
                }

            }
            Console.WriteLine($"\n\t8. Feladat \n - Budapestről {gepesz2}-an/en indultak a Gépész versenyen\n - Budapestről {info2}-an/en indultak az Informatika versenyen\n - Budapestről {korny2}-an/en indultak a környezetvédelmi versenyen");
        }

        static void f9()
        {
            int buda = 0, videk = 0;
            foreach (var item in eredmenyek)
            {
                if (item.telepules == "Budapest" && item.szakma == "környezetvédelem")
                {
                    buda++;
                }

                else
                {
                    videk++;
                }

                if (buda > videk)
                {
                    Console.WriteLine($"\n\t9. Feladat \n Budapesten több környezetvédelmi versenyző volt!");
                }

                if (videk > buda)
                {
                    Console.WriteLine($"\n\t9. Feladat \n Videéken több környezetvédelmi versenyző volt!");
                }
            }
            
        }

        static void f10()
        {

        }

        static void f11()
        {

        }

        static void f12()
        {

        }
    }
}
