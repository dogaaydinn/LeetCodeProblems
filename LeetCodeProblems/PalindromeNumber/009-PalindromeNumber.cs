namespace LeetCodeProblems.PalindromeNumber;

public class _009_PalindromeNumber
{
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