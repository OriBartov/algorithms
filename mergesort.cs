using System;

class MergeSortExample
{
    static void MergeSort(int[] array)
    {
        var length = array.Length;
        if (length <= 1)
            return;

        int middle = length / 2;
        int[] leftArray = new int[middle];
        int[] rightArray = new int[length - middle];

        int i = 0;
        int j = 0;

        for (; i < length; i++)
        {
            if (i < middle)
            {
                leftArray[i] = array[i];
            }
            else
            {
                rightArray[j] = array[i];
                j++;
            }
        }

        // break down the arrays until we have arrays of size 1
        MergeSort(leftArray);
        MergeSort(rightArray);
        // then merge them back together in sorted order
        Merge(array, leftArray, rightArray);
        
    }

    static void Merge(int[] array, int[] leftArray, int[] rightArray)
    {
        int leftSize = leftArray.Length;
        int rightSize = rightArray.Length;

        int leftIndex = 0, rightIndex = 0, arrayIndex = 0;
        while (leftIndex < leftSize && rightIndex < rightSize)
        {
            if (leftArray[leftIndex] < rightArray[rightIndex])
            {
                array[arrayIndex] = leftArray[leftIndex];
                leftIndex++;
            }
            else
            {
                array[arrayIndex] = rightArray[rightIndex];
                rightIndex++;
            }
            arrayIndex++; // increment the index for the new merged array
        }
        
        // in case one of the arrays is bigger than the other
        while (leftIndex < leftSize)
        {
            array[arrayIndex] = leftArray[leftIndex];
            leftIndex++;
            arrayIndex++;
        }
        while (rightIndex < rightSize)
        {
            array[arrayIndex] = rightArray[rightIndex];
            rightIndex++;
            arrayIndex++;
        }
    }
    static void Main()
    {
        int[] numbers = { 33, 10, 55, 71, 29, 4, 16, 42 };
        Console.WriteLine("Before sort: " + string.Join(", ", numbers));

        MergeSort(numbers);

        Console.WriteLine("After sort: " + string.Join(", ", numbers));
    }
}
