using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class ProverbsProgram
{
    static List<string> englishProverbs = new List<string>();
    static List<string> hungarianProverbs = new List<string>();

    static void Main()
    {
        // 1. Feladat: Fájlok beolvasása
        ReadFiles();

        // 2. Feladat: Angol közmondások számának kiírása
        Console.WriteLine("2. feladat: Az angol közmondások száma: " + englishProverbs.Count);

        // 3. Feladat: "all" szót tartalmazó közmondások kiírása
        var allProverbs = englishProverbs.Where(p => p.Contains("all")).ToList();
        Console.WriteLine("\n3. feladat: 'all' szót tartalmazó közmondások száma: " + allProverbs.Count);

        // 4. Feladat: 5 véletlenszerű angol közmondás kiválasztása
        Random rand = new Random();
        var randomProverbs = englishProverbs.OrderBy(x => rand.Next()).Take(5).ToList();
        Console.WriteLine("\n4. feladat: Véletlenszerűen kiválasztott közmondások:");
        foreach (var proverb in randomProverbs)
        {
            Console.WriteLine(proverb);
        }

        // 5. feladat: Véletlen közmondások elemzése
        Console.WriteLine("\n\t5. feladat:");

        // 5.a: Véletlen közmondások megjelenítése
        Console.Write("a) \n");
        foreach (var proverb in randomProverbs)
        {
            Console.WriteLine(proverb);
        }

        // 5.b: Leghosszabb közmondás és hossza
        var longestProverb = randomProverbs.OrderByDescending(p => p.Length).First();
        Console.WriteLine("\nb) A leghosszabb közmondás: " + longestProverb + " (" + longestProverb.Length + " karakter)");

        // 5.c: "t" betűk száma
        int tCount = randomProverbs.Sum(p => p.Count(c => c == 't' || c == 'T'));
        Console.WriteLine("\nc) 't' betűk száma a véletlen közmondásokban: " + tCount);

        // 5.d: Magánhangzók száma
        int vowelCount = randomProverbs.Sum(p => p.Count(c => "aeiouAEIOU".Contains(c)));
        Console.WriteLine("\nd) Magánhangzók száma a véletlen közmondásokban: " + vowelCount);

        // 5.g: Véletlen közmondások ábécé sorrendbe rendezése
        randomProverbs.Sort();
        Console.WriteLine("\ng) ABC sorrendben a véletlen közmondások:");
        foreach (var proverb in randomProverbs)
        {
            Console.WriteLine(proverb);
        }

        // 5.h: Különböző szavak száma
        var uniqueWords = new HashSet<string>(randomProverbs.SelectMany(p => p.Split(' ')));
        Console.WriteLine("\nh) Különböző szavak száma a véletlen közmondásokban: " + uniqueWords.Count);

        // 5.i: Magyar megfelelő megjelenítése
        Console.WriteLine("\ni) A közmondások magyar megfelelői:");
        foreach (var proverb in randomProverbs)
        {
            int index = englishProverbs.IndexOf(proverb);
            if (index >= 0 && index < hungarianProverbs.Count)
            {
                Console.WriteLine(proverb + " - " + hungarianProverbs[index]);
            }
        }

        // 5.j: Magánhangzók száma a magyar közmondásokban
        int hungarianVowelCount = hungarianProverbs.Sum(p => p.Count(c => "aáeéiíoóöőuúüű".Contains(c)));
        Console.WriteLine("\nj) A magyar közmondásokban található magánhangzók száma: " + hungarianVowelCount);
    }

    static void ReadFiles()
    {
        englishProverbs = File.ReadAllLines("proverbs.txt").ToList();
        hungarianProverbs = File.ReadAllLines("kozmondasok.txt").ToList();
    }
}
