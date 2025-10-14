using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingThroughList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine("Print list items through for loop.");

            // for loop
            for (int i = 0; i < list.Count; i++) 
            {
                Console.Write(list[i] + " ");
            }

            Console.WriteLine("\n\nPrint list items through foreach.");

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\nPrint list items using List foreach.");

            list.ForEach(x => Console.Write(x + " "));
        }
    }
}