using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Program
    {
        static Random rand = new Random();
        static Dictionary<string, int> kartyaErt = new Dictionary<string, int>
        {
            {"2", 2},{"3", 3},{"4", 4},{"5", 5},{"6", 6},{"7", 7},{"8", 8},{"9", 9},{"10", 10},{"J", 10},{"Q", 10},{"K", 10},{"A", 11}
        };

        static List<string> pakli = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        
        static List<string> KevPakli()
        {
            List<string> KevertPakli = new List<string>();
            foreach (var kartya in pakli)
            {
                for (int i = 0; i < 4; i++)
                    KevertPakli.Add(kartya);
            }
            return KevertPakli;
        }
        
        static int kezemErt(List<string> kez)
        {
            int ertek = 0;
            foreach (var kartya in kez)
            {
                ertek += kartyaErt[kartya];
            }

            int Aszama = kez.FindAll(k => k == "A").Count;
            while (ertek > 21 && Aszama > 0)
            {
                ertek -= 10;
                Aszama--;
            }
            return ertek;
        }
        

        static bool JatekosKor(List<string> jatekosKez, ref List<string> pakli)
        { 
            while (kezemErt(jatekosKez) > 21)
            {
                Console.WriteLine($"A játékos kártyái: {string.Join(", ", jatekosKez)}  Összérték: {kezemErt(jatekosKez)}");
                Console.Write("Kérsz egy új kártyát? i/n: ");
                string valasz = Console.ReadLine();
                if (valasz.ToLower() == "i")
                {
                    jatekosKez.Add(pakli[0]);
                    pakli.RemoveAt(0);
                }
                else
                {
                    break;
                }
            }
            return kezemErt(jatekosKez) <= 21;
        }

        static void GepKor(List<string> gepKez, ref List<string> pakli)
        {
            while (kezemErt(gepKez) > 17)
            {
                gepKez.Add(pakli[0]);
                pakli.RemoveAt(0);
            }
        }
    
        static string BlackJack()
        {
            List<string> pakli = KevPakli();
            List<string> jatekosKez = new List<string> { pakli[0], pakli[1] };
            List<string> gepKez = new List<string> { pakli[2], pakli[3] };
            pakli.RemoveRange(0, 4);

            Console.WeiteLine($"A gép első kártyája: {gepKez[0]}");

            bool jatekos = JatekosKor(jatekosKez, ref pakli);
            if (!jatekos)
            {
                return "Gép";
            }

            GepKor(gepKez, ref pakli);

            int jatekosErtek = kezemErt(jatekosKez);
            int gepErtek = kezemErt(gepKez);

            Console.WriteLine($"Jatekos kartyai: {string.Join(",", jatekosKez)} Osszertek: {jatekosErtek}");
            Console.WriteLine($"A gép kartyai: {string.Join(",", gepKez)} Osszertek: {gepErtek}");

        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }


}
