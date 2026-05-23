using System;
using System.Text.RegularExpressions;

public class ValidPalindrome
{
    public static bool IsPalindrome(string s)
    {
        //Replace all non-alphanumeric characters and convert to lowercase
        var regex = new Regex("[^a-zA-Z0-9]");
        s = regex.Replace(s, "");
        s = s.ToLower();

        int len = s.Length;
        int j = len - 1;

        for (int i = 0; i <= len / 2 - 1; i++)
        {
            if (char.ToLower(s[i]) != char.ToLower(s[j]))
            {
                return false;
            }
            j--;
        }
        return true;
    }

    static void Main()
    {
        if (IsPalindrome(Console.ReadLine()))
        {
            Console.WriteLine("It's a palindrome!");

        }else
        {
            Console.WriteLine("It's not a palindrome.");
        }
    }
}

