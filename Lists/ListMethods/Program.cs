using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {12,44,10,2,3,4,1,-8,-5,-87,100,56,236};

            Console.WriteLine("Contains: " + list.Contains(-5));
            Console.WriteLine("Exists: " + list.Exists(n => n < 0));
            Console.WriteLine("Find: " + list.Find(n => n > 50));
            Console.WriteLine("Find All: " + string.Join(" ", list.FindAll(n => n >= 100)));
            Console.WriteLine("Any: " + list.Any(n => n < 0));
        }
    }
}
