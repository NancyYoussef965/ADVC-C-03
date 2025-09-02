using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1-Given an array of integers, count the frequency of each element using a hash table.

            //    int[] numbers = { 1, 2, 2, 3, 4, 1, 5, 2, 3, 3 };

            //    Dictionary<int, int> frequency = new Dictionary<int, int>();
            //    foreach (int num in numbers)
            //    {
            //        if(frequency.ContainsKey(num))
            //            frequency[num]++;  

            //    else
            //    {
            //        frequency[num] = 1; 
            //    }

            //}
            //    Console.WriteLine(" Frequency of elements:");
            //    foreach (var kvp in frequency)
            //    {
            //        Console.WriteLine($"Element {kvp.Key} appears {kvp.Value} times");
            //    }
            #endregion


            #region 2-You have a hashtable where its values are integers, find the key associated with the highest value.

            Dictionary<string, int> scores = new Dictionary<string, int>()
            {

            { "Ali", 85 },
            { "Mona", 92 },
            { "Sara", 78 },
            { "Omar", 95 },
            { "Nader", 88 }
            };

            var maxEntry = scores.Aggregate((l, r) => l.Value > r.Value ? l : r);

            Console.WriteLine($" The highest score is {maxEntry.Value}, by {maxEntry.Key}");




            #endregion





        }
    }
}