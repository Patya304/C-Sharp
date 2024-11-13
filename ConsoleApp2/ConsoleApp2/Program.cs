using System;
using System.Collections.Generic;
using System.IO;

class KozmondasProgram
{
    static List<string> angolKozmondasok = new List<string>();
    static List<string> magyarKozmondasok = new List<string>();

    static void Main()
    {
        // 1. Feladat
        Beolvas();

        // 2. Feladat
        Console.WriteLine("2. feladat: Az angol közmondások száma: " + angolKozmondasok.Count);

        // 3. Feladat
        int allSzo = 0;
        foreach (var kozmondas in angolKozmondasok)
        {
            if (kozmondas.Contains("all")) // Meghatározza, hogy a karakterlánc tartalmaza-e az "all" szót.
            {
                allSzo++;
            }
        }
        Console.WriteLine("\n3. feladat: 'all' szót tartalmazó közmondások száma: " + allSzo);

        // 4. Feladat
        List<string> veletlenKozmondasok = VeletlenKivalasztas(5);
        Console.WriteLine("\nVéletlenszerűen kiválasztott közmondások:");
        foreach (var kozmondas in veletlenKozmondasok)
        {
            Console.WriteLine(kozmondas);
        }

        // 5. Feladat
        Console.WriteLine("\nVéletlen közmondások elemzése:");

        // 5.a 
        string leghosszabbKozmondas = "";
        foreach (var kozmondas in veletlenKozmondasok)
        {
            if (kozmondas.Length > leghosszabbKozmondas.Length)
            {
                leghosszabbKozmondas = kozmondas;
            }
        }
        Console.WriteLine("Leghosszabb közmondás: " + leghosszabbKozmondas + " (" + leghosszabbKozmondas.Length + " karakter)");

        // 5.b 
        int tBetukSzama = 0;
        foreach (var kozmondas in veletlenKozmondasok)
        {
            foreach (char karakter in kozmondas)
            {
                if (karakter == 't' || karakter == 'T')
                {
                    tBetukSzama++;
                }
            }
        }
        Console.WriteLine("'t' betűk száma: " + tBetukSzama);

        // 5.c
        int maganhangzokSzama = 0;
        string maganhangzok = "aeiouAEIOU";
        foreach (var kozmondas in veletlenKozmondasok)
        {
            foreach (char karakter in kozmondas)
            {
                if (maganhangzok.Contains(karakter.ToString()))
                {
                    maganhangzokSzama++;
                }
            }
        }
        Console.WriteLine("Magánhangzók száma: " + maganhangzokSzama);
    }

    static void Beolvas()
    {
        angolKozmondasok = new List<string>(File.ReadAllLines("proverbs.txt"));
        magyarKozmondasok = new List<string>(File.ReadAllLines("kozmondasok.txt"));
    }

    static List<string> VeletlenKivalasztas(int szam)
    {
        List<string> kivalasztottKozmondasok = new List<string>();
        Random rand = new Random();
        for (int i = 0; i < szam; i++)
        {
            int veletlenIndex = rand.Next(angolKozmondasok.Count);
            kivalasztottKozmondasok.Add(angolKozmondasok[veletlenIndex]);
        }
        return kivalasztottKozmondasok;
    }
}
