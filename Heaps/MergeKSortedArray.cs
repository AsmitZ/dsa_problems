namespace Algorithms.Heaps;

static class MergeKSortedArrays
{
    public static int[] Merge(int[][] arr, int k)
    {
        MinHeap minHeap = new(k);
        int[] result = new int[k * k];
        
        for (int row = 0; row < k; row++)
        {
            minHeap.Add(arr[row][0], 0, row);
        }

        for(int i = 0; i < k*k; i++)
        {
            var smallest = minHeap.Remove();
            int row = smallest.row;
            int col = smallest.col + 1;
            if (col < arr[row].Length)
            {
                minHeap.Add(arr[row][col], col, row);
            }

            result[i] = smallest.value;
        }

        return result;
    }

    public class MinHeap
    {
        int size;

        (int value, int col, int row)[] heap;

        public MinHeap(int capacity)
        {
            heap = new (int value, int col, int row)[capacity];
            size = 0;
        }

        public int Size => size;

        public void Add(int value, int col, int row)
        {
            heap[size] = (value, col, row);
            size++;
            HeapifyUp(size - 1);
        }

        public (int value, int col, int row) Peek() => heap[0];

        public (int value, int col, int row) Remove()
        {
            var root = heap[0];
            heap[0] = heap[size - 1];
            size--;
            HeapifyDown(0);
            return root;
        }

        private void HeapifyDown(int index)
        {
            while (index < size)
            {
                var smallest = index;
                var left = 2 * index + 1;
                var right = 2 * index + 2;

                if (left < size && heap[smallest].value > heap[left].value)
                {
                    smallest = left;
                }
                if (right < size && heap[smallest].value > heap[right].value)
                {
                    smallest = right;
                }
                
                if (smallest == index)
                {
                    break;
                }

                Swap(smallest, index);
                index = smallest;
            }
        }

        private void HeapifyUp(int index)
        {
            while(index > 0)
            {
                var parentIndex = (index - 1) / 2;

                if (heap[parentIndex].value <= heap[index].value)
                    break;
                
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }

        private void Swap(int parentIndex, int index) => (heap[index], heap[parentIndex]) = (heap[parentIndex], heap[index]);
    }
}