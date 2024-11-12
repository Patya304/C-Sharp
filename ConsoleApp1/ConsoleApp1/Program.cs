using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static Random rand = new Random();

    // kartyak ertekei
    static Dictionary<string, int> kartyaErt = new Dictionary<string, int>
    {
        {"2", 2},{"3", 3},{"4", 4},{"5", 5},{"6", 6},{"7", 7},{"8", 8},{"9", 9},{"10", 10},{"J", 10},{"Q", 10},{"K", 10},{"A", 11}
    };


    static List<string> pakli = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

    // keveres
    static List<string> KevPakli()
    {
        List<string> kevertPakli = new List<string>();
        foreach (var kartya in pakli)
        {
            for (int i = 0; i < 4; i++)
                kevertPakli.Add(kartya);
        }
        kevertPakli.Sort((x, y) => rand.Next().CompareTo(rand.Next()));
        return kevertPakli;
    }

    // kezertek
    static int kezemErt(List<string> kez)
    {
        int ertek = 0;
        foreach (var kartya in kez)
        {
            ertek += kartyaErt[kartya];
        }

        int AszSzama = kez.FindAll(k => k == "A").Count;
        while (ertek > 21 && AszSzama > 0)
        {
            ertek -= 10;
            AszSzama--;
        }

        return ertek;
    }

    // uj kartya
    static bool JatekosKor(List<string> jatekosKez, ref List<string> pakli)
    {
        while (kezemErt(jatekosKez) < 21)
        {
            Console.WriteLine($"Jatekos kartyai: {string.Join(", ", jatekosKez)} | osszertek: {kezemErt(jatekosKez)}");
            Console.Write(" - kersz egy uj kartyat? (i/n): ");
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

    // gep dont
    static void GepKor(List<string> gepKez, ref List<string> pakli)
    {
        while (kezemErt(gepKez) < 17)
        {
            gepKez.Add(pakli[0]);
            pakli.RemoveAt(0);
        }
    }

    // teszt
    static string JatszBlackjack()
    {
        List<string> pakli = KevPakli();
        List<string> jatekosKez = new List<string> { pakli[0], pakli[1] };
        List<string> gepKez = new List<string> { pakli[2], pakli[3] };
        pakli.RemoveRange(0, 4);

        Console.WriteLine($"\nGep elso kartyaja: {gepKez[0]}");

        bool jatekosJo = JatekosKor(jatekosKez, ref pakli);
        if (!jatekosJo)
        {
            return "Gep";
        }

        GepKor(gepKez, ref pakli);

        int jatekosErtek = kezemErt(jatekosKez);
        int gepErtek = kezemErt(gepKez);

        Console.WriteLine($"\n*** Jatekos kartyai: {string.Join(", ", jatekosKez)} | Osszertek: {jatekosErtek} ***");
        Console.WriteLine($"*** Gep kartyai: {string.Join(", ", gepKez)} | Osszertek: {gepErtek} ***");

        if (jatekosErtek > 21) return "Gep";
        if (gepErtek > 21) return "Jatekos";

        if (jatekosErtek > gepErtek) return "Jatekos";
        else if (gepErtek > jatekosErtek) return "Gep";
        else return "Dontetlen";
    }

    // mentes
    static void MentesCSVBe(int jatekosNyert, int gepNyert, int dontetlen)
    {
        string fajlNev = "blackjack_teszt.csv";
        bool ujFajl = !File.Exists(fajlNev);
        int jatekosWin = 0, gepWin = 0, jgDont = 0;
        int tszt = 1;

        if (!ujFajl)
        {
            string[] sorok = File.ReadAllLines(fajlNev);
            tszt = sorok.Length;
        }

        using (StreamWriter sw = new StreamWriter(fajlNev, true, System.Text.Encoding.UTF8))
        {
            if (ujFajl)
            {
                sw.WriteLine("Tesztek, Játékos Nyert,Gép Nyert,Döntetlen");
            }

            sw.WriteLine($"{tszt}. Teszt, {jatekosNyert},{gepNyert},{dontetlen}");
        }

        Console.WriteLine("\nAz eredmények elmentve a blackjack_eredmenyek.csv fájlba.");
    }

    static void FuttassSzimulaciot(int jatekokSzama)
    {
        int jatekosNyert = 0;
        int gepNyert = 0;
        int dontetlen = 0;

        for (int i = 0; i < jatekokSzama; i++)
        {
            string nyertes = JatszBlackjack();
            if (nyertes == "Jatekos") jatekosNyert++;
            else if (nyertes == "Gep") gepNyert++;
            else dontetlen++;
        }


        Console.WriteLine("\n*** Játék végeredménye ***");
        Console.WriteLine($"Jatekok szama: {jatekokSzama}");
        Console.WriteLine($"Jatekos nyert: {jatekosNyert}");
        Console.WriteLine($"Gep nyert: {gepNyert}");
        Console.WriteLine($"Dontetlen: {dontetlen}");

        MentesCSVBe(jatekosNyert, gepNyert, dontetlen);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Blackjack kezdete..");
        FuttassSzimulaciot(2);
    }
}
