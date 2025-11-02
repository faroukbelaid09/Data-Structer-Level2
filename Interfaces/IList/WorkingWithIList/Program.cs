using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithIList
{
    public class CustomList<T> : IList<T>
    {
        private List<T> _list = new List<T>();

        public T this[int index] 
        { 
            get => _list[index];
            set => _list[index] = value;
        }

        public int Count => _list.Count;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(T item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i =0; i < _list.Count; i++)
            {
                yield return _list[i];
            }
        }

        public int IndexOf(T item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            _list[index] = item;
        }

        public bool Remove(T item)
        {
            return _list.Remove(item);
        }

        public void RemoveAt(int index)
        {
            _list.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> ints = new CustomList<int>();

            ints.Add(1);
            ints.Add(2);
            ints.Add(3);

            for(int i = 0;i < ints.Count; i++)
            {
                Console.WriteLine(ints[i]);
            }

            Console.WriteLine("-----------");

            ints[0] = 100;

            Console.WriteLine("item at index 0: " + ints[0]);

            Console.WriteLine("Index of value 2 is : " + ints.IndexOf(2));
        }
    }
}