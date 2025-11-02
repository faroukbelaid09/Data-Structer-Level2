using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithIComparable
{
    public class Person : IComparable<Person>
    {
        public int id {  get; set; }
        public int age {  get; set; }
        public string name { get; set; }

        public Person(int id, int age,string name) 
        {
            this.id = id;
            this.age = age;
            this.name = name;
        }

        public int CompareTo(Person obj)
        {
            if(obj == null) return -1;

            return this.age.CompareTo(obj.age);
        }

        public override string ToString() 
        {
            return $"{this.name} : Age: {this.age}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Person> list = new List<Person>();

            list.Add(new Person(1,35,"test"));
            list.Add(new Person(1,30,"test 1"));
            list.Add(new Person(1,26,"test 2"));

            list.Sort();

            foreach(var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
