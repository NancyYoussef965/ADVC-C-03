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

            //Dictionary<string, int> scores = new Dictionary<string, int>()
            //{

            //{ "Ali", 85 },
            //{ "Mona", 92 },
            //{ "Sara", 78 },
            //{ "Omar", 95 },
            //{ "Nader", 88 }
            //};

            //var maxEntry = scores.Aggregate((l, r) => l.Value > r.Value ? l : r);

            //Console.WriteLine($" The highest score is {maxEntry.Value}, by {maxEntry.Key}");




            #endregion



            #region 3-You have a hashtable , the  user will enter targetValue find all keys that associated with a specific targetValue

            //            Dictionary<string, string> fruits = new Dictionary<string, string>
            //{
            //    { "key1", "apple" },
            //    { "key2", "banana" },
            //    { "key3", "apple" }
            //};

            //            Console.Write("Enter target value: ");
            //            string targetValue = Console.ReadLine();
            //            bool found = false;
            //            foreach (var Kvp in fruits)

            //            {


            //                if (Kvp.Value==targetValue)


            //                {
            //                    Console.WriteLine(Kvp.Key);
            //                    found = true;


            //                }

            //            }
            //            if (!found)
            //            {
            //                Console.WriteLine("Key not found");

            //            }

            #endregion


            #region 4-Given an array of strings, group anagrams together.
            // string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };
            //Dictionary<string , List<string>> groups= new Dictionary<string , List<string>>();

            // foreach (string word in words) 

            // {
            //     string sorted = String.Concat(word.OrderBy(c => c));

            //     if (!groups.ContainsKey(sorted))
            //     {
            //         groups[sorted] = new List<string>();
            //     }

            //     groups[sorted].Add(word);
            // }
            // Console.WriteLine(" Grouped Anagrams:");
            // foreach (var group in groups.Values)
            // {
            //     Console.WriteLine($"[{string.Join(", ", group)}]");
            // }
            #endregion

            #region 5-Given an array of integers, check if the array contains any duplicates.

            int[] numbers = { 1, 2, 3, 4, 5, 2 };

            HashSet<int> seen = new HashSet<int>();
            bool hasDuplicate = false;

            foreach (int num in numbers)
            {
                if (!seen.Add(num)) 
                {
                    hasDuplicate = true;
                    break;
                }
            }

            if (hasDuplicate)
                Console.WriteLine("Array contains duplicates.");
            else
                Console.WriteLine(" Array does not contain duplicates.");


            #endregion

        }
    }
}