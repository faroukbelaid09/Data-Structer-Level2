using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithIEnumerable
{

    public class CustomCollection<T> : IEnumerable<T>
    {

        private List<T> list = new List<T>();

       public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item) 
        {
            list.Add(item);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var customCollection = new CustomCollection<int>();

            customCollection.Add(1);
            customCollection.Add(2);
            customCollection.Add(3);

            foreach (int i in customCollection) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
