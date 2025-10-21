using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingForExistence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> fruits = new HashSet<string>();

            fruits.Add("Apple");
            fruits.Add("Orange");
            fruits.Add("Grapes");

            if (fruits.Contains("Apple"))
            {
                Console.WriteLine("Apple!!!");
            }
            else
            {
                Console.WriteLine("Not a healthy day:(");
            }
        }
    }
}
