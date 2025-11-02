using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithIDictionary
{

    public class SimpleDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private List< KeyValuePair<TKey, TValue> > _list = new List<KeyValuePair<TKey, TValue>>();

        public TValue this[TKey key] 
        {
            get 
            {
                foreach(KeyValuePair<TKey, TValue> item in _list)
                {
                    if(item.Key.Equals(key)) return item.Value;
                }
                throw new KeyNotFoundException($"The given key '{key}' was not present in the dictionary.");
            }
            set
            {
                bool found = false;
                for (int i = 0; i < _list.Count; i++) 
                {
                    if (_list[i].Key.Equals(key)) 
                    {
                        _list[i] = new KeyValuePair<TKey, TValue> (_list[i].Key,value);
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    _list.Add(new KeyValuePair<TKey, TValue> (key, value));
                }
            }
        }

        public ICollection<TKey> Keys => _list.ConvertAll(item => item.Key);

        public ICollection<TValue> Values => _list.ConvertAll(item => item.Value);

        public int Count => _list.Count;

        public bool IsReadOnly => false;

        public void Add(TKey key, TValue value)
        {
            _list.Add(new KeyValuePair<TKey, TValue>(key, value));
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            _list.Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return _list.Contains(item);
        }

        public bool ContainsKey(TKey key)
        {
            foreach (var item in _list) 
            {
                if(item.Key.Equals(key)) return true;
            }
            return false;
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);

        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            foreach (var item in _list)
            {
                yield return new KeyValuePair<TKey, TValue>(item.Key, item.Value);
            }
        }

        public bool Remove(TKey key)
        {
            for(int i = 0; i < _list.Count; i++)
            {
                if (_list[i].Key.Equals(key))
                {
                    _list.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return _list.Remove(item);
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            for(int i = 0; i < _list.Count; i++)
            {
                if (_list[i].Key.Equals(key))
                {
                    value = _list[i].Value;
                    return true;
                }
            }

            value = default;
            return false;
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
            SimpleDictionary<string,int> simpleDic = new SimpleDictionary<string,int>();


            simpleDic.Add("a", 1);
            simpleDic.Add("b", 2);
            simpleDic.Add("c", 3);
            simpleDic.Add("d", 4);


            foreach(var i in simpleDic)
            {
                Console.WriteLine(i);
            }

            simpleDic.Remove("a");

            Console.WriteLine("-------");

            foreach (var i in simpleDic)
            {
                Console.WriteLine(i);
            }
        }
    }
}
