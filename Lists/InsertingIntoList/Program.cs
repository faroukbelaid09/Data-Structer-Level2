using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertingIntoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Init List
            List<int> list = new List<int> {1,2,3,4,5};
            Console.WriteLine("Original List: " + string.Join(" ", list));

            // Adding item at the end
            list.Add(6);
            Console.WriteLine("List after adding an item at the end: " + string.Join(" ", list));

            // Adding item at a specific position
            list.Insert(0,0);
            Console.WriteLine("List after adding an item at a specific position: " + string.Join(" ", list));

            // Adding multiple items at the same time
            list.InsertRange(7,new List<int> {7,8,9,10});
            Console.WriteLine("List after adding multiple items at the same time: " + string.Join(" ", list));

        }
    }
}
