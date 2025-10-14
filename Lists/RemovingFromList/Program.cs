using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemovingFromList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Init List
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Original List: " + string.Join(" ", list)); 

            // Removing specific value
            list.Remove(5);
            Console.WriteLine("List after removing 5: " + string.Join(" ", list));

            // Removing item at a specific position
            list.RemoveAt(0);
            Console.WriteLine("List after removing item at position 0: " + string.Join(" ", list));

            // Removing multiple items
            list.RemoveRange(1, 2);
            Console.WriteLine("List after removing multiple items: " + string.Join(" ", list));

            // Clear list
            list.Clear();
            Console.WriteLine("List after clearing: " + string.Join(" ", list));
        }
    }
}
