using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOrderTreeTraversal
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T value)
        {
            this.Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree<T>
    {
        public Node<T> Root;

        public BinaryTree()
        {
            this.Root = null;
        }

        public void Insert(T value)
        {
            if (this.Root == null)
            {
                this.Root = new Node<T>(value);
                return;
            }

            Queue<Node<T>> nodes = new Queue<Node<T>>();
            nodes.Enqueue(this.Root);

            while (nodes.Count > 0) 
            {
                var current = nodes.Dequeue();

                if (current.Left == null) 
                {
                    current.Left = new Node<T>(value);
                    break;
                }
                else
                {
                    nodes.Enqueue(current.Left);
                }

                if (current.Right == null) 
                {
                    current.Right = new Node<T>(value);
                    break;
                }
                else
                {
                    nodes.Enqueue(current.Right);
                }
            }
        }

        public void InOrderTraversal(Node<T> node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                Console.Write(node.Value + " ");
                InOrderTraversal(node.Right);
            }
        }

        public void PrintTree()
        {
            PrintTree(this.Root, 0);
        }

        private void PrintTree(Node<T> root, int space)
        {
            int COUNT = 10;  // Distance between levels to adjust the visual representation
            if (root == null)
                return;


            space += COUNT;
            PrintTree(root.Right, space); // Print right subtree first, then root, and left subtree last


            Console.WriteLine();
            for (int i = COUNT; i < space; i++)
                Console.Write(" ");
            Console.WriteLine(root.Value); // Print the current node after space


            PrintTree(root.Left, space); // Recur on the left child
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();

            binaryTree.Insert(0);
            binaryTree.Insert(1);
            binaryTree.Insert(2);
            binaryTree.Insert(3);
            binaryTree.Insert(4);
            binaryTree.Insert(5);
            binaryTree.Insert(6);
            binaryTree.Insert(7);
            binaryTree.Insert(8);
            binaryTree.Insert(9);
            binaryTree.Insert(10);

            binaryTree.PrintTree();
            Console.WriteLine();
            binaryTree.InOrderTraversal(binaryTree.Root);
        }
    }
}