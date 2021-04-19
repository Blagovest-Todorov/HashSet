using System;
using System.Collections.Generic;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>(); // HashSet is dynamic collection keeping only unigue Elemets, not duplicate, very fast, used in keshing, DB

            int n = int.Parse(Console.ReadLine());     // hashSet got bit similar with List collection 

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                names.Add(line);
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
