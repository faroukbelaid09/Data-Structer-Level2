using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemovingFromHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> fruits = new HashSet<string>();

            fruits.Add("Apple");
            fruits.Add("Orange");
            fruits.Add("Grapes");

            Console.WriteLine("Count before: " + fruits.Count);

            fruits.Remove("Orange");

            Console.WriteLine("Count after: " + fruits.Count);
        }
    }
}
