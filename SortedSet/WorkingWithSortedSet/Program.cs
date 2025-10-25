using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithSortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> nums = new SortedSet<int>();

            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);

            // Displaying
            foreach (int i in nums) 
            {
                Console.Write(i + " ");
            }

            // Check existence
            if (nums.Contains(1)) 
            {
                Console.WriteLine("Nums contains 1!!");
            }

            // Remove
            nums.Remove(1);

            Console.WriteLine("After removing: ");
            foreach (int i in nums)
            {
                Console.Write(i + " ");
            }
        }
    }
}
