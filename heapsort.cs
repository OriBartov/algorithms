// heapsort
using System;

class HeapSortExample
{
    static void HeapSort(int[] array)
    {
        int size = array.Length;

        // Build a maxheap
        for (int i = size / 2 - 1; i >= 0; i--)
            Heapify(array, size, i);

        // One by one extract elements from heap
        for (int i = size - 1; i > 0; i--)
        {
            // Move current root to end
            Swap(array, 0, i);

            // call max heapify on the reduced heap
            Heapify(array, i, 0);
        }
    }

    static void Heapify(int[] array, int size, int root)
    {
        int largest = root; // Initialize largest as root
        int left = 2 * root + 1; // left = 2*root + 1
        int right = 2 * root + 2; // right = 2*root + 2

        // If left child is larger than root
        if (left < size && array[left] > array[largest])
            largest = left;

        // If right child is larger than largest so far
        if (right < size && array[right] > array[largest])
            largest = right;

        // If largest is not root
        if (largest != root)
        {
            Swap(array, root, largest);

            // Recursively heapify the affected sub-tree
            Heapify(array, size, largest);
        }
    }

    static void Swap(int[] array, int a, int b)
    {
        int temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }

    static void Main()
    {
        int[] numbers = { 33, 10, 55, 71, 29, 4, 16, 42 };
        Console.WriteLine("Before sort: " + string.Join(", ", numbers));

        HeapSort(numbers);

        Console.WriteLine("After sort: " + string.Join(", ", numbers));
    }
}