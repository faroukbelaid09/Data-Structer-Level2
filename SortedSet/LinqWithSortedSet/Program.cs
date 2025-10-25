using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithSortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SortedSet<int> nums = new SortedSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // filltering nums grater then 2
            var newNums = nums.Where(x => x > 2);

            Console.WriteLine("numbers greater then 2:");
            foreach(int x in newNums) Console.Write(x + " ");

            Console.WriteLine("\n----------------");

            // Sum of all elements
            Console.WriteLine("Sum of nums: " + nums.Sum(x => x));

            Console.WriteLine("\n----------------");

            Console.WriteLine("Max number: " + nums.Max());

            Console.WriteLine("\n----------------");

            Console.WriteLine("Min number: " + nums.Min());
        }
    }
}