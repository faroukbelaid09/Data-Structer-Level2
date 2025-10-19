using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> fruits = new HashSet<string>();

            fruits.Add("Orange");
            fruits.Add("Apple");
            fruits.Add("Grapes");

            // Trying to add duplicate value
            fruits.Add("Orange");
            fruits.Add("Orange");

            // looping through the hashset
            foreach (string fruit in fruits) 
            {
                Console.WriteLine(fruit);
            }
        }
    }
}