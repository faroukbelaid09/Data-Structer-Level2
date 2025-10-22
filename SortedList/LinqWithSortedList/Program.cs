using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sortedList = new SortedList<int, string>()
            {
                {1,"One"},
                {2,"Two"},
                {3,"Three"},
                {4,"Four"},
            };

            var newList = sortedList.Where(x => x.Key > 1);

            foreach (var item in newList) 
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            Console.WriteLine("--------------------------------------------------");
            // Advance LINQ Usage

            SortedList<int, string> fruits = new SortedList<int, string>()
            {
                {1,"Apple"},
                {2,"Banana"},
                {3,"Cherry"},
                {4,"Date"},
                {5,"Grape"},
                {6,"Fig"},
                {7,"Elderberry"},
            };

            var groupedByLength = fruits.GroupBy(x => x.Value.Length);

            foreach (var item in groupedByLength) 
            {
                Console.WriteLine("Length " + item.Key + ": " + string.Join(", ",item.Select(x=>x.Value)));
            }

            Console.WriteLine("--------------------------------------------------\n");
            // Sorted List with Custom Object

            SortedList<int, Employees> employees = new SortedList<int, Employees>
            {
                {1, new Employees("Mark","HR",1000)},
                {2, new Employees("Bob","IT",3000)},
                {3, new Employees("Alice","HR",1000)},
                {4, new Employees("Henry","Marketing",3000)},
                {5, new Employees("Katya","IT",4000)},
            };

            var newEMPs = employees.Where(emp => emp.Value.Department == "IT")
                .OrderByDescending(emp => emp.Value.salary)
                .Select(emp => emp.Value.Name);

            foreach(var employee in newEMPs)
            {
                Console.WriteLine(employee);
            }

        }
    }

    class Employees
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int salary { get; set; }


        public Employees(string name, string department, int salary) 
        {
            this.Name = name;
            this.Department = department;
            this.salary = salary;
        }
    }
}
