using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string,int> sortedList = new SortedList<string,int>();

            sortedList.Add("Banana",2);
            sortedList.Add("Apple",1);

            Console.WriteLine("Fruit: " + sortedList["Banana"]);

            Console.WriteLine("------------------------");

            foreach (var item in sortedList) 
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

            Console.WriteLine("------------------------");
            sortedList.Remove("Apple");

            foreach (var item in sortedList)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
