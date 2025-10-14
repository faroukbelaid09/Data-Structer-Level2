using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {45,20,25,16,78,-8,-10,1,4,3};

            Console.WriteLine("Original List: " + string.Join(" ",list));

            // Default sorting
            list.Sort();
            Console.WriteLine("Sort list ASC: " + string.Join(" ", list));

            list.Reverse();
            Console.WriteLine("Sort list DESC: " + string.Join(" ", list));

            // Sort using LINQ
            Console.WriteLine("Sorting ASC: " + string.Join(" ", list.OrderBy(n => n)));
            Console.WriteLine("Sorting DESC: " + string.Join(" ", list.OrderByDescending(n => n)));
        }
    }
}
