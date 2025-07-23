using System;
using System.IO;

class Program
{
    private static void Main()
    {
        const int max = 1_000_000;
        const int perRound = 500_000;
        const string inputFromRound1 = "C:\\Users\\pc\\Desktop\\tur1.txt";
        if (inputFromRound1 == null) throw new ArgumentNullException(nameof(inputFromRound1));
        const string file2 = "C:\\Users\\pc\\Desktop\\tur2.txt";
        
        var used = new bool[max + 1];
        foreach (var line in File.ReadLines(inputFromRound1))
        {
            var num = int.Parse(line);
            used[num] = true;
        }


        var random = new Random();
        using (var writer2 = new StreamWriter(file2))
        {
            var count = 0;
            while (count < perRound)
            {
                var num = random.Next(1, max + 1);
                if (used[num]) continue;
                used[num] = true;
                writer2.WriteLine(num.ToString("D7"));
                count++;
            }
        }

        Console.WriteLine("2. tur tamamlandı, eşsiz 500.000 sayı daha üretildi.");
    }
}