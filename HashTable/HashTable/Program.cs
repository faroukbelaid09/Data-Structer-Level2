using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable();

            hashTable.Add("key1","value1");
            hashTable.Add("key2","value2");
            hashTable.Add("key3","value3");

            hashTable.Remove("key1");

            hashTable["key2"] = "value1";

            foreach (string key in hashTable.Keys) 
            {
                Console.WriteLine(hashTable[key]);
            }


        }
    }
}
