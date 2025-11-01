using System;
using System.Collections;
using System.Collections.Generic;

namespace WorkingWithICollection
{

    public class SimpleCollection<T> : ICollection<T>
    {
        private List<T> list = new List<T>();

        public int Count => list.Count;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++) 
            {
                yield return list[i];
            }
        }

        public bool Remove(T item)
        {
            return list.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    
        public void Replace(int index, T newValue)
        {
            list[index] = newValue;
        }

        public T GetValue(int index) 
        {
            return (T)list[index];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleCollection<int> simpleCollection = new SimpleCollection<int>();


            // Adding
            simpleCollection.Add(1);
            simpleCollection.Add(2);
            simpleCollection.Add(3);

            // Looping
            foreach (int i in simpleCollection)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------");

            // Replace
            simpleCollection.Replace(0,500);

            Console.WriteLine(simpleCollection.GetValue(0));

            Console.WriteLine("-------------");

            //Copying
            int[] arr = new int[3];
            simpleCollection.CopyTo(arr,0);

            // Displaying copied array
            Console.WriteLine("Copied Array: ");
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------");
        }
    }
}