using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithGeneralTree
{
    class Node
    {
        public string Name { get; set; }
        
        public List<Node> Children = new List<Node>();

        public Node(string name, Node parent = null) 
        {
            Name = name; 
        }

        public void AddChild(Node child) 
        {
            this.Children.Add(child);
        }
    }

    class GeneralTreeExample
    {
        public Node root {  get; set; }

        public GeneralTreeExample(Node root) 
        {
            this.root = root;
        } 
    }
    
    internal class Program
    {
        static void displayTree(Node root, string indent = "")
        {
            Console.WriteLine(indent + root.Name);

            foreach (Node child in root.Children)
            {
                displayTree(child , indent + " ");
            }
        }

        static void Main(string[] args)
        {
            GeneralTreeExample tree = new GeneralTreeExample(new Node("0"));

            Node first = new Node("1");
            Node third = new Node("3");
            Node fourth = new Node("4");

            Node second = new Node("2");
            Node fifth = new Node("5");
            Node sixth = new Node("6");

            tree.root.AddChild(first);
            tree.root.AddChild(second);

            first.AddChild(third);
            first.AddChild(fourth);

            second.AddChild(fifth);
            second.AddChild(sixth);

            displayTree(tree.root);
        }
    }
}
