using System;

class QuickSortExample
{
    static void QuickSort(int[] array, int left, int right)
    {
        if (left >= right)
            return;

        int pivotIndex = Partition(array, left, right);
        QuickSort(array, left, pivotIndex - 1);
        QuickSort(array, pivotIndex + 1, right);
    }

    static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, right);
        return i + 1;
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

        QuickSort(numbers, 0, numbers.Length - 1);

        Console.WriteLine("After sort: " + string.Join(", ", numbers));
    }
}
