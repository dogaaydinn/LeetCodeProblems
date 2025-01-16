namespace LeetCodeProblems.PalindromeNumber;

public class _009_PalindromeNumber
{
    /*
     Problem: 9. Palindrome Number

        Given an integer x, return true if x is palindrome integer.
        An integer is a palindrome when it reads the same backward as forward. For example, 121 is palindrome while 123 is not.

        Approach:
        1. If x is int.MinValue, return false.
        2. Get the absolute value of x.
        3. Initialize reversed as 0.
        4. Iterate while x is greater than 0.
        5. Multiply reversed by 10 and add x % 10.
        6. Divide x by 10.
        7. Return reversed == x.

        Time complexity: O(log n)
        Space complexity: O(1)
     */
    public static bool IsPalindrome(int x)
    {
        if (x == int.MinValue) return false;

        var value = x;
        x = Math.Abs(value);

        var reversed = 0;
        while (x > 0)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }

        return reversed == value;
    }
}