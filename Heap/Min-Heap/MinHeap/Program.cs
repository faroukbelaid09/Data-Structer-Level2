using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHeap
{
    class MinHeap
    {
        private List<int> _heap = new List<int>();

        public void Insert(int value)
        {
            _heap.Add(value);

            HeapifyUp(_heap.Count-1);
        }

        private void HeapifyUp(int index)
        {
            while (index > 0) 
            {
                int parentIndex = (index-1)/2;

                if (_heap[index] >= _heap[parentIndex]) break;

                (_heap[index], _heap[parentIndex]) = (_heap[parentIndex], _heap[index]);

                index = parentIndex;
            }
        }

        public void DisplayMinHeap()
        {
            Console.WriteLine("Min Heap: ");

            foreach(int value in _heap) Console.WriteLine(value);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            MinHeap minHeap = new MinHeap();

            minHeap.Insert(10);
            minHeap.Insert(4);
            minHeap.Insert(15);
            minHeap.Insert(2);
            minHeap.Insert(8);

            minHeap.DisplayMinHeap();
        }
    }
}
