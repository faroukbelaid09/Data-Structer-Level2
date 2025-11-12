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

        // Peek the minimum element without removing it
        public int Peek()
        {
            if (_heap.Count == 0)
            {
                throw new InvalidOperationException("Heap is empty.");
            }

            return _heap[0]; // The smallest element is at the root
        }
    
        public int ExtractMin()
        {
            if (_heap.Count == 0) 
            {
                throw new InvalidOperationException("Heap is Empty.");
            }

            int minValue = _heap[0];

            _heap[0] = _heap[_heap.Count-1];
            _heap.RemoveAt(_heap.Count-1);

            HeapifyDown(_heap.Count-1);

            return minValue;
        }
        
        private void HeapifyDown(int index)
        {
            while (index < _heap.Count) 
            {
                int leftChildIndex = 2 * index + 1;
                int rightChildIndex = 2 * index + 2;

                int smallestIndex = index;
                
                if(leftChildIndex < _heap.Count && _heap[leftChildIndex] < _heap[smallestIndex])
                {
                    smallestIndex = leftChildIndex;
                }

                if (rightChildIndex < _heap.Count && _heap[rightChildIndex] < _heap[smallestIndex])
                {
                    smallestIndex = rightChildIndex;
                }

                if (smallestIndex == index) break;

                (_heap[index], _heap[smallestIndex]) = (_heap[smallestIndex], _heap[index]);

                index = smallestIndex;
            }
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

            minHeap.ExtractMin();

            minHeap.DisplayMinHeap();
        }
    }
}
