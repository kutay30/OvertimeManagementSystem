using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\pc\\Desktop\\check.txt";  // değiştirebilirsin
        var seen = new HashSet<string>();
        var duplicates = new HashSet<string>();

        foreach (var line in File.ReadLines(filePath))
        {
            var trimmed = line.Trim();

            if (!seen.Add(trimmed))
            {
                // Zaten vardı → duplicate
                duplicates.Add(trimmed);
            }
        }

        Console.WriteLine("Duplicate sayılar:");
        foreach (var dup in duplicates)
        {
            Console.WriteLine(dup);
        }

        Console.WriteLine("İşlem tamamlandı.");
    }
}