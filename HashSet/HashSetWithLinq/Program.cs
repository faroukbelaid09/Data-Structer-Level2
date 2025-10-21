using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetWithLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> nums = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = nums.Where(x => x%2 == 0);

            foreach (int x in evenNumbers) 
            {
                Console.WriteLine(x);
            }
        }
    }
}
