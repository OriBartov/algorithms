using System;

class TwoSum
{
    public static int[] TwoSumSolution(int[] numbers, int target)
    {
        var hashMap = new Dictionary<int,int>();

        for (int i=0; i < numbers.Length; i++)
        {
            if (hashMap.ContainsKey(target - numbers[i]))
            {
                return [i, hashMap[target - numbers[i]]];
            }
            hashMap.Add(numbers[i], i);
        }
        return [0,0];
    }
        
    static void Main()
    {
        int[] numbers = { 7, 6, 2, 3 };

        var res = TwoSumSolution(numbers, 10);

        Console.WriteLine($"Indices: [{res[0]}, {res[1]}]"); 
    }
}