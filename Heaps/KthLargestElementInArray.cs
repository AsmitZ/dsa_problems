namespace Algorithms.Heaps;

static class KthLargestElement
{
    public static int Find(int[] nums, int k)
    {
        MinHeap heap = new MinHeap(k);

        foreach (var num in nums)
        {
            if (heap.Size < k)
            {
                heap.Add(num);
            }
            else if (num > heap.Peek())
            {
                heap.Remove();
                heap.Add(num);
            }
        }
        
        return heap.Peek();
    }


}
public class MinHeap
{
    int[] heap;
    int size;

    public MinHeap(int k)
    {
        heap = new int[k];
        size = 0;
    }

    public int Size => size;

    public int Peek()
    {
        return heap[0];
    }

    public void Add(int a)
    {
        heap[size] = a;
        size++;
        HeapifyUp(size - 1);
    }

    public int Remove()
    {
        int root = heap[0];
        heap[0] = heap[size - 1];
        size--;
        HeapifyDown(0);
        return root;
    }

    private void HeapifyUp(int index)
    {
        if (index == 0)
            return;

        var parentIndex = (index - 1) / 2;
        if (heap[parentIndex] > heap[index])
        {
            Swap(parentIndex, index);
            HeapifyUp(parentIndex);
        }
    }
    
    private void HeapifyDown(int index)
    {
        while(index < size)
        {
            var left = 2 * index + 1;
            var right = 2 * index + 2;
            var smallest = index;

            if (left < size && heap[smallest] > heap[left])
            {
                smallest = left;
            }
            if (right < size && heap[smallest] > heap[right])
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
    
    public void Swap(int parentIndex, int index)
    {
        var temp = heap[parentIndex];
        heap[parentIndex] = heap[index];
        heap[index] = temp;
    }
}