using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> fruits = new Dictionary<string, int>();

            // Adding to a dictionary
            fruits.Add("Banana",5);
            fruits.Add("Lemon",3);
            fruits.Add("Grapes",6);

            // looping through dictionary

            foreach (KeyValuePair<string,int> item in fruits) 
            {
                Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
            }

            // Removing item from dictionary
            fruits.Remove("Lemon");

            Console.WriteLine("\n--------------------\n");
            // looping through dictionary
            foreach (KeyValuePair<string, int> item in fruits)
            {
                Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
            }
        }
    }
}
