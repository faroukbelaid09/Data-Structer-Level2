using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithSortedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> fruits = new SortedDictionary<string, int>();

            //Adding
            fruits.Add("Apple", 2);
            fruits.Add("Banana", 1);
            fruits.Add("Grapes", 3);

            //Displaying
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit.Key + ": " + fruit.Value);
            }

            Console.WriteLine("------------------");

            //Removing
            if (fruits.Remove("Grapes"))
            {
                foreach (var fruit in fruits)
                {
                    Console.WriteLine(fruit.Key + ": " + fruit.Value);

                }
            }
        
            
        }
    }
}
