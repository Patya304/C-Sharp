using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace @class
{


    class Etel
    {
        public string neve, tipusa;
        public int ara;
        public Etel(string egysor)
        {
            string[] darabok = egysor.Trim().Split('\t');
            neve = darabok[0];
            ara = int.Parse(darabok[1]);
            tipusa = darabok[2].ToLower();
        }
    }


    class Program
    {
        static List<Etel> etelek = new List<Etel>();
        static void Main(string[] args)
        {
            f1();
            f2();
            f3();
            f4();
            f5();
            f6();
            /*f7();
            f8();
            f9();
            f10();
            */
            Console.ReadKey();
        }




        static void f1()
        {
            string[] Beolvas = File.ReadAllLines("etelek.txt", Encoding.Default);
            foreach (var item in Beolvas)
            {
                etelek.Add(new Etel(item));
            }
            Console.WriteLine("Adatok sikeresen belettek olvasva!");
            //Console.WriteLine(etelek[0].neve);
        }

        static void f2()
        {
            Console.WriteLine($"\n\t2. Feladat \nAz étterem {etelek.Count()} féle ételt kínál.");
        }

        /*static void f3()
        {
            int db_leves = 0, allar = 0;
            foreach (var item in etelek)
            {
                if (item.tipusa == "leves")
                {
                    db_leves ++;
                    allar = allar + item.ara;
                }
            }
            Console.WriteLine($"\n\t3. Feladat \nA levesek átlagos ára {(double)allar / db_leves} forint.");
        }*/

        static void f3()
        {
            List<int> levesearak = new List<int>();
            foreach (var item in etelek)
            {
                if (item.tipusa == "leves")
                {
                    levesearak.Add(item.ara);
                }
            }
            Console.WriteLine($"\n\t3. Feladat \nA levesek átlagos ára {(double)levesearak.Sum() / levesearak.Count} forint.");
        }

        static void f4()
        {
            int fetel = 0;
            foreach (var item in etelek)
            {
                if (item.tipusa == "foetel")
                {
                    fetel++;
                }
            }
            Console.WriteLine($"\n\t4. Feladat \n {fetel} Főétel közül lehet választani.");
        }




        static void f5()
        {
            Console.WriteLine($"\n\t5. Feladat \nLibából készült ételek:");
            foreach (var item in etelek)
            {
                if (item.neve.ToLower().Contains("liba"))
                {
                    Console.WriteLine($" - {item.neve}");
                }
            }
        }

        static void f6()
        {
            List<Etel> des = new List<Etel>();
            foreach (var item in etelek)
            {
                if (item.tipusa == "desszert")
                {
                    des.Add(item);
                }
            }
            if (des.Count > 0)
            {

            }

            else
            {
                Console.WriteLine($"\n\t6.Feladat \n Nincs desszert az étlapon");
            }
        }
    }
}
