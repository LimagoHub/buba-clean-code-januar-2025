// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

public static class ListExtensions
{
    // Erweiterungsmethode, um eine Liste in Partitionen einer bestimmten Größe aufzuteilen
    public static IEnumerable<List<T>> Partition<T>(this List<T> source, int size)
    {
        if (size <= 0)
        {
            throw new ArgumentException("Die Größe der Partition muss größer als 0 sein.", nameof(size));
        }

        for (int i = 0; i < source.Count; i += size)
        {
            yield return source.GetRange(i, Math.Min(size, source.Count - i));
        }
    }
}

public class Program
{
    public static void Main()
    {
        List<int> numbers = Enumerable.Range(1, 10).ToList();
        int partitionSize = 3;

        foreach (var partition in numbers.Partition(partitionSize))
        {
            Console.WriteLine($"Partition: {string.Join(", ", partition)}");
        }
    }
}



