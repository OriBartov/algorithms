//Given a non-negative integer x, return the square root of x rounded down to the nearest integer. The returned integer should be non-negative as well.

//You must not use any built-in exponent function or operator.

public class Solution {
    public int MySqrt(int x) 
    {
        if (x < 2)
        {
            return x; 
        }

        int left = 1, right = x / 2; // The square root of x is at most x/2 for x > 1
        
        while (left <= right) 
        {
            int mid = (left + right) / 2;
            long square = mid * mid; 
            if (square == x) {
                return mid; // Found exact square root
            } else if (square < x) {
                left = mid + 1; // Move right to find a larger number
            } else {
                right = mid - 1; // Move left to find a smaller number
            }
        }
        return right; // Return the floor of the square root
    }


    public static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        var solution = new Solution();
        Console.WriteLine($"The square root of {x} is: {solution.MySqrt(x)}");
    }
}