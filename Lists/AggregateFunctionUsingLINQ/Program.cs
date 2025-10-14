using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateFunctionUsingLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine("List Sum: " + list.Sum());
            Console.WriteLine("List Average: " + list.Average());
            Console.WriteLine("List Min: " + list.Min());
            Console.WriteLine("List Max: " + list.Max());
            Console.WriteLine("List Count: " + list.Count());
        }
    }
}
