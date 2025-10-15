using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrivingDataFromDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> fruits = new Dictionary<string, int>();

            fruits.Add("Banana" , 12);
            fruits.Add("Apple" , 2);

            // Get Value
            
            if(fruits.TryGetValue("Banana", out int value))
            {
                Console.WriteLine("Value: " + value);
            }
            else
            {
                Console.WriteLine("There is no fruit with this key.");
            }
        }
    }
}