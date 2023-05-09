using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
    Task2();
    }
    static void Task2()
    {
        //Task 2 pseudo code
        //function (int array a, target x)
        //{

        //}
        int[] a = GenerateUniqueRandomNumbers(6);
        a.ToList().ForEach(n=>Write(n + " "));
        CountPrime(a);
        int n = a.Length;
        Segregate(a, 0, a.Length - 1);   
        ReverseArray(a);
        a.ToList().ForEach(n=>Write(n + " "));  
        WriteLine($"{a}");
    }
    static int[] GenerateUniqueRandomNumbers(int size)
    {
        Random random = new Random(); 
        HashSet<int> values = new HashSet<int>();
        while(true)
        {
            values.Add(random.Next(1, 100));
            if(values.Count == size) break;
        }
        return values.ToArray();
    }
    static bool IsPrime(int a) 
    {
        if(a <= 1) return false;
        if(a == 2) return true;
        if(a % 2 == 0) return false;
        for(int i =3; i < Math.Sqrt(a); i++)
        {
            if(a % i == 0) return false; 
        }
        return true; 
    }       
        static void Segregate(int[] arr, int left, int right)
            {
                while(IsPrime(arr[left])) left++;
                while(!IsPrime(arr[right])) right--;
                if(left >= right) return;
                int t = arr[left];
                arr[left] = arr[right];
                arr[right] = t;
                Segregate(arr, left, right);               
            }
    static void CountPrime(int[] a)
        {
            int count = 0;
            foreach(int j in a)
            {
                if(IsPrime(j) == true)
                {
                    count++;
                }
            }
            WriteLine($"\nCount of prime numbers: {count}");
        }
    public static void ReverseArray(int[] a)
    {
        int j = a.Length - 1;
        for (int i = 0; i < (a.Length / 2); i++)
        {
            int tem = a[i];
            a[i] = a[j];
            a[j] = tem;

            j--;
        }
    }
}
