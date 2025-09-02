using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1-Given an array of integers, count the frequency of each element using a hash table.

            int[] numbers = { 1, 2, 2, 3, 4, 1, 5, 2, 3, 3 };

            Dictionary<int, int> frequency = new Dictionary<int, int>();
            foreach (int num in numbers)
            {
                if(frequency.ContainsKey(num))
                    frequency[num]++;  
        
            else
            {
                frequency[num] = 1; 
            }

        }
            Console.WriteLine(" Frequency of elements:");
            foreach (var kvp in frequency)
            {
                Console.WriteLine($"Element {kvp.Key} appears {kvp.Value} times");
            }
            #endregion







        }
    }
}