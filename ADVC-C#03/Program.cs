using System;
using System.Collections;

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

            //int[] numbers = { 1, 2, 3, 4, 5, 2 };

            //HashSet<int> seen = new HashSet<int>();
            //bool hasDuplicate = false;

            //foreach (int num in numbers)
            //{
            //    if (!seen.Add(num)) 
            //    {
            //        hasDuplicate = true;
            //        break;
            //    }
            //}

            //if (hasDuplicate)
            //    Console.WriteLine("Array contains duplicates.");
            //else
            //    Console.WriteLine(" Array does not contain duplicates.");


            #endregion





            #region 6-Implement a SortedDictionary that stores student IDs (int) and their names (string). Perform operations like adding, removing, and retrieving student names.


            //    SortedDictionary<int, string> students = new SortedDictionary<int, string>();

            //    students.Add(102, "Ali");
            //    students.Add(101, "Mona");
            //    students.Add(103, "Sara");

            //    Console.WriteLine("\n Students after adding:");
            //    PrintStudents(students);

            //    int searchId = 101;
            //    if (students.ContainsKey(searchId))
            //    {
            //        Console.WriteLine($"\n Student with ID {searchId} is {students[searchId]}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"\nStudent with ID {searchId} not found.");
            //    }

            //    int removeId = 102;
            //    if (students.Remove(removeId))
            //    {
            //        Console.WriteLine($"\n Student with ID {removeId} removed.");
            //    }

            //    Console.WriteLine("\n Students after removing:");
            //    PrintStudents(students);
            //}

            //static void PrintStudents(SortedDictionary<int, string> dict)
            //{
            //    foreach (var kvp in dict)
            //    {
            //        Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
            //    }

            #endregion

            #region 7-Create an employee directory where employee IDs (int) are keys and employee names (string) are values. Use a SortedList to manage and retrieve employees in order of their IDs.
            //    SortedList<int, string> employees = new SortedList<int, string>();

            //    employees.Add(103, "Sara");
            //    employees.Add(101, "Ali");
            //    employees.Add(105, "Omar");
            //    employees.Add(102, "Mona");

            //    Console.WriteLine(" Employee Directory:");
            //    PrintEmployees(employees);

            //    int searchId = 102;
            //    if (employees.ContainsKey(searchId))
            //    {
            //        Console.WriteLine($"\nEmployee with ID {searchId}: {employees[searchId]}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"\n Employee with ID {searchId} not found.");
            //    }

            //    employees[103] = "Sarah Ahmed"; 
            //    Console.WriteLine("\nAfter updating employee 103:");
            //    PrintEmployees(employees);

            //    employees.Remove(105);
            //    Console.WriteLine("\n After removing employee 105:");
            //    PrintEmployees(employees);
            //}

            //static void PrintEmployees(SortedList<int, string> list)
            //{
            //    foreach (var kvp in list)
            //    {
            //        Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
            //    }
            #endregion


            #region 8-Given an array of integers from 1 to N with some numbers missing, find the missing numbers.
            //int N = 10; 
            //int[] arr = { 1, 2, 4, 6, 7, 10 }; 

            //HashSet<int> present = new HashSet<int>(arr);

            //Console.WriteLine(" Missing numbers:");
            //for (int i = 1; i <= N; i++)
            //{
            //    if (!present.Contains(i))
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region 9-You  have a list of integers with possible duplicates, create a HashSet that contains only unique values.

            //List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 5, 3, 1, 6 };

            //HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

            //Console.WriteLine(" Unique values:");
            //foreach (int num in uniqueNumbers)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion

            #region 10-You have a hashtable with unique values, create a new hashtable where the keys and values are swapped.

            //    Hashtable original = new Hashtable()
            //{
            //    { 1, "Ali" },
            //    { 2, "Mona" },
            //    { 3, "Omar" }
            //};

            //    Hashtable swapped = new Hashtable();

            //    foreach (DictionaryEntry entry in original)
            //    {
            //        swapped[entry.Value] = entry.Key;
            //    }

            //    Console.WriteLine(" Swapped Hashtable:");
            //    foreach (DictionaryEntry entry in swapped)
            //    {
            //        Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            //    }
            #endregion




            #region 11-Find the union of two sets, returning the unique elements from both sets.

            //HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4 };
            //HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6 };

            //HashSet<int> unionSet = new HashSet<int>(set1);

            //unionSet.UnionWith(set2);

            //Console.WriteLine(" Union of two sets:");
            //foreach (int num in unionSet)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion





            #region 12-You have a dictionary with string keys, the user will enter targetChar , count how many keys start with this targetChar.

            Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            { "apple", 1 },
            { "animal", 2 },
            { "airport", 3 },
            { "banana", 4 },
            { "cat", 5 }
        };

            Console.Write("Enter target character: ");
            char targetChar = Console.ReadLine()[0]; 

            int count = 0;

            foreach (var key in dict.Keys)
            {
                if (key.StartsWith(targetChar.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }

            Console.WriteLine($"\n Number of keys starting with '{targetChar}': {count}");



            #endregion

            #region



            #endregion
            #region



            #endregion





        }
    }
}