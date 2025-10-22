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
        }
    }
}
