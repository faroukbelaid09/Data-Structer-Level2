using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 3, 4, 4, 5 };

            HashSet<int> set = new HashSet<int>(arr);

            foreach (int num in set) 
            {
                Console.WriteLine(num);
            }
        }
    }
}
