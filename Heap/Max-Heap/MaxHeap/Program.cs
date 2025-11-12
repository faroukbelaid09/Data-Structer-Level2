using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxHeap
{
    class MaxHeap
    {
        private List<int> _heap = new List<int>();

        public void Insert(int value)
        {
            _heap.Add(value);

            HeapifyUp(_heap.Count - 1);
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;

                if (_heap[index] <= _heap[parentIndex]) break;

                (_heap[index], _heap[parentIndex]) = (_heap[parentIndex], _heap[index]);

                index = parentIndex;
            }
        }

        public void DisplayMaxHeap()
        {
            Console.WriteLine("Max Heap: ");

            foreach (int value in _heap) Console.WriteLine(value);
        }

        // Peek the max element without removing it
        public int Peek()
        {
            if (_heap.Count == 0)
            {
                throw new InvalidOperationException("Heap is empty.");
            }

            return _heap[0]; // The max element is at the root
        }

        public int ExtractMax()
        {
            if (_heap.Count == 0)
            {
                throw new InvalidOperationException("Heap is Empty.");
            }

            int maxValue = _heap[0];

            _heap[0] = _heap[_heap.Count - 1];
            _heap.RemoveAt(_heap.Count - 1);

            HeapifyDown(_heap.Count - 1);

            return maxValue;
        }

        private void HeapifyDown(int index)
        {
            while (index < _heap.Count)
            {
                int leftChildIndex = 2 * index + 1;
                int rightChildIndex = 2 * index + 2;

                int largestIndex = index;

                if (leftChildIndex < _heap.Count && _heap[leftChildIndex] > _heap[largestIndex])
                {
                    largestIndex = leftChildIndex;
                }

                if (rightChildIndex < _heap.Count && _heap[rightChildIndex] > _heap[largestIndex])
                {
                    largestIndex = rightChildIndex;
                }

                if (largestIndex == index) break;

                (_heap[index], _heap[largestIndex]) = (_heap[largestIndex], _heap[index]);

                index = largestIndex;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            MaxHeap maxHeap = new MaxHeap();

            maxHeap.Insert(10);
            maxHeap.Insert(4);
            maxHeap.Insert(15);
            maxHeap.Insert(2);
            maxHeap.Insert(8);

            maxHeap.DisplayMaxHeap();

            maxHeap.ExtractMax();

            maxHeap.DisplayMaxHeap();
        }
    }
}
