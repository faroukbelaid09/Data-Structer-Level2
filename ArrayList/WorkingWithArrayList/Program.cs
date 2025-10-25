using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("Hello");
            arrayList.Add(true);

            foreach (var item in arrayList) 
            {
                Console.WriteLine(item);
            }

            arrayList.Remove(true);


            Console.WriteLine("-----------------");
            for (int i = 0; i < arrayList.Count; i++) 
            {
                Console.WriteLine(arrayList[i]);
            }
        }
    }
}
