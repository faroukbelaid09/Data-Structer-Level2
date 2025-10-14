using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillteringUsingLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5,6,7,8,9,10};

            Console.WriteLine("Even number in the list: " + string.Join(" ", list.Where(n => n % 2 == 0)));
            Console.WriteLine("Odd number in the list: " + string.Join(" ", list.Where(n => n % 2 != 0)));
            Console.WriteLine("Numbers grater then 5: " + string.Join(" ", list.Where(n => n > 5)));
            Console.WriteLine("Numbers between 3 and 8: " + string.Join(" ", list.Where(n => n > 3 && n < 8)));
            Console.WriteLine("Numbers between 3 and 8: " + string.Join(" ", list.Where(n => n > 3 && n < 8)));
            Console.WriteLine("Every second number: " + string.Join(" ", list.Where((n,index) => index % 2 == 1)));
        }
    }
}
