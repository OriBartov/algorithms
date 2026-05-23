using System;

class TwoSum2
{
    public static int[] TwoSum(int[] numbers, int target)
    {
        int i = 0;
        int j = numbers.Length - 1;

        while (i<j)
        {
            var sum = numbers[i] + numbers[j];
            if (sum == target)
            {
                return [i+1, j+1];
            }
            else if (sum < target)
            {
                i++;
            }
            else
            {
                j--;
            }
        }
        return [0,0];
    }
        
    static void Main()
    {
        int[] numbers = { -4, 5, 16, 29, 36, 42 };

        var res = TwoSum(numbers, 25);

        Console.WriteLine($"Indices: [{res[0]}, {res[1]}]"); 
    }
}