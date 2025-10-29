using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithObservableCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> Items = new ObservableCollection<string>();

            Items.CollectionChanged += ObservableCollectionChanged;
            
            Items.Add("1");
            Items.Add("two");
            Items.Add("Hello");
            Items.Add("World!");


            Items[1] = "Replaced Item";


            Items.Move(0,1);

            Items.Remove("1");
        }

        static void ObservableCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e) 
        {
            Console.WriteLine("\nCollection Changed");

            switch (e.Action) 
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    Console.WriteLine("Added:");
                    foreach(var item in e.NewItems)
                    {
                        Console.WriteLine("- " + item);
                    }
                    break;
                
                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                    Console.WriteLine("Replaced:");

                    foreach(var oldItems in e.OldItems)
                    {
                        Console.WriteLine("- " + oldItems);
                    }

                    Console.WriteLine("With: ");
                    foreach(var newItem in e.NewItems)
                    {
                        Console.WriteLine("- " + newItem);
                    }
                    break;
                
                case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
                    Console.WriteLine("Moved: ");
                    Console.WriteLine($"- From index {e.OldStartingIndex} \n- To index {e.NewStartingIndex}");
                    break;
                
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("Removed: ");
                    foreach (var oldItem in e.OldItems)
                    {
                        Console.WriteLine("- " + oldItem);
                    }
                    break;
            }
        }
    }
}