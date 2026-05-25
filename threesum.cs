/* Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] where nums[i] + nums[j] + nums[k] == 0, and the indices i, j and k are all distinct.

The output should not contain any duplicate triplets. You may return the output and the triplets in any order. */

using System;

class Solution
{
    public static List<List<int>> ThreeSum(int[] nums)
    {
        var result = new List<List<int>>();
        nums.Sort();
        for (int i = 0; i <= nums.Length - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue; // Skip duplicate elements
            }
            var numberToSum = 0 - nums[i];
            int left = i + 1, right = nums.Length - 1;

            while (left < right)
            {
                if (nums[left] + nums[right] < numberToSum)
                {
                    left++;
                }
                else if (nums[left] + nums[right] > numberToSum)
                {
                    right--;
                }
                else
                {
                    result.Add(new List<int>(){
                        nums[i], nums[left], nums[right]
                        });
                    left++;
                    right--;
                }
            }
        }
        return result;
    }

    static void Main()
    {
        int[] numbers = { -1,0,1,2,-1,-4};

        var res = ThreeSum(numbers);

        // Turn the list of lists into a string representation
        var resultStrings = new List<string>();
        foreach (var list in res)
        {
            resultStrings.Add("[" + string.Join(",", list) + "]");
        }

        // Print the result
        Console.WriteLine("Triplets that sum to zero:");
        foreach (var str in resultStrings)
        {
            Console.WriteLine(str);
        }
    }
}