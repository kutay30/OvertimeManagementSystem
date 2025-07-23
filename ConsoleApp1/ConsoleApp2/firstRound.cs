using System;
using System.IO;
namespace ConsoleApp1;
public class firstRound
{
    static void Main()
    {
        const int max = 1_000_000;
        const int perRound = 500_000;

        var file1 ="C:\\Users\\pc\\Desktop\\tur1.txt" ;
        

        var used = new bool[max + 1]; 
        var random = new Random();

        // 1. TUR
        using (var writer1 = new StreamWriter(file1))
        {
            var count = 0;
            while (count < perRound)
            {
                var num = random.Next(1, max + 1);
                if (used[num]) continue;
                used[num] = true;
                writer1.WriteLine(num.ToString("D7"));
                count++;
            }
        }
        

        Console.WriteLine("İlk turda toplam 500 bin eşsiz sayı üretildi.");
    }
}