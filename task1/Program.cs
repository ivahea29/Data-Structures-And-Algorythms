using System;
using static System.Console;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class Program
{
static void Main()
    {   
        int[] a = GenerateUniqueRandomNumbers(5);
        a.ToList().ForEach(n=>Write(n + " "));
        int n = a.Length;
        ArrayOperations(a);
    }
    static int[] GenerateUniqueRandomNumbers(int size)
    {
        Random random = new Random();
        var values = new HashSet<int>();
        while(true)
        {
            values.Add(random.Next(1, 100));
            if(values.Count == size) break;
        }
        return values.ToArray();
    }
    static void ArrayOperations(int[] a)
    {
        int m = a.Min();
        WriteLine($"\nThe minimum number is: {m, 5}");
        int idx = Array.IndexOf(a, m);
        WriteLine($"The minimum number index is: {idx}");
        int Min = int.MinValue;
        foreach(int i in a)
        {
            if(i > Min) Min = i;
        }
    }
}


