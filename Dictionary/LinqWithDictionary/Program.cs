using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> fruits = new Dictionary<string,int>();

            fruits.Add("Banana",5);
            fruits.Add("Apple",10);
            fruits.Add("Grapes",2);

            var newFruits = fruits.Select(f => f);

            foreach (var item in newFruits)
            {
                Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
            }

            Console.WriteLine("Ordered: " + string.Join(" ", fruits.OrderBy(n => n.Value)));

            Console.WriteLine("Value Sum: " + fruits.Sum(n => n.Value));

        }
    }
}