using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sortedList = new SortedList<int, string>()
            {
                {1,"One"},
                {2,"Two"},
                {3,"Three"},
                {4,"Four"},
            };

            var newList = sortedList.Where(x => x.Key > 1);

            foreach (var item in newList) 
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            Console.WriteLine("--------------------------------------------------");
            // Advance LINQ Usage

            SortedList<int, string> fruits = new SortedList<int, string>()
            {
                {1,"Apple"},
                {2,"Banana"},
                {3,"Cherry"},
                {4,"Date"},
                {5,"Grape"},
                {6,"Fig"},
                {7,"Elderberry"},
            };

            var groupedByLength = fruits.GroupBy(x => x.Value.Length);

            foreach (var item in groupedByLength) 
            {
                Console.WriteLine("Length " + item.Key + ": " + string.Join(", ",item.Select(x=>x.Value)));
            }
        }
    }
}
