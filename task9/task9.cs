﻿using System;
using static System.Console;
using System.Collections;

class Program
{
    static void Main()
    {
        Task9();
    }
    static void Task9()
    {
        var dict = GetDictionary();
        PrintDict(dict);
        ProcessWords(dict);
        FindLongShortWords(dict);
    }
    static Dictionary<string, int> GetDictionary(){
        string content = "data structures and algorithms is about data structures and algorithms. data structures is about data structures. algorithms is the about algorithms. there are good algorithms and not so good algorithms. good algorithms are good good, not so good ones are not so good.";
        var dict = new Dictionary<string, int>();
        char[] delimiterChars = {',', '.', ' '};
        string[] words = content.Split(delimiterChars);
        foreach(var wd in words){
            if(wd.Trim().Length == 0) continue;
            string w = wd.ToLower();
            if(dict.ContainsKey(w) == false)
                dict.Add(w, 1);   
            else
                dict[w]++; 
        }
        return dict;
    }
    static void PrintDict(Dictionary<string, int> dict){
        foreach(var (k, v) in dict){
        WriteLine($"{k} {v}");
        }
    }
    static void ProcessWords(Dictionary<string,int> dict){
        int most = int.MinValue;
        int less = int.MaxValue;
        var mostWords = new List<string>();
        var lessWords = new List<string>();
        foreach(var (k, v) in dict){
            if(v > most) most = v;
        }
            foreach(var (k, v) in dict){
            if(v == most) mostWords.Add(k);                       
        }
        foreach(var (k, v) in dict){
            if(v < less) less = v;
        }
            foreach(var (k, v) in dict){
            if(v == less) lessWords.Add(k);                       
        }
        WriteLine("\nMost frequent words with their frequencies: ");
        mostWords.ForEach(w => Write(w + " "));
        WriteLine(most);
        lessWords.ForEach(w => Write(w + " "));
        WriteLine(less);  
    }
    static void FindLongShortWords(Dictionary<string,int> dict){
        double longCount = 0;
        double shortCount = 0;
        var CountWordsLong = new List<string>();
        var CountWordsShort = new List<string>();
        foreach(var (k, v) in dict){
            if(v == longCount) longCount = v;
            }
                foreach(var (k, v) in dict){
                longCount++;                     
            }
            foreach(var (k, v) in dict){
                if(v == shortCount) shortCount = v;
            }
            foreach(var (k, v) in dict){
                shortCount++;                       
            }
        WriteLine("\nLongest words with frequency: ");
        CountWordsLong.ForEach(w => Write(w + " "));
        WriteLine(longCount);
        WriteLine("Shortest words frequency:: ");
        CountWordsShort.ForEach(w => Write(w + " "));
        WriteLine(shortCount);
    }
}



