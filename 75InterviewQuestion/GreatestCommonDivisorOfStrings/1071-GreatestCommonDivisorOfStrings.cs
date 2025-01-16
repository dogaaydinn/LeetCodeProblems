namespace _75InterviewQuestion.GreatestCommonDivisorOfStrings;

public static class _1071_GreatestCommonDivisorOfStrings
{
    /*
     * 1071. Greatest Common Divisor of Strings
     In this problem, we are given two strings: str1 and str2. We are asked to find the greatest common divisor of two strings.

    The greatest common divisor of two strings is the largest string that divides both strings without leaving a remainder.

    We can solve this problem by checking if the concatenation of the two strings is equal to the concatenation of the other string.

    If the concatenation of str1 and str2 is equal to the concatenation of str2 and str1, then the greatest common divisor is the substring of str1 or str2 up to the greatest common divisor length.

    Approach:
    - Check if the concatenation of str1 and str2 is equal to the concatenation of str2 and str1.
    - If the concatenation is equal, return the substring of str1 or str2 up to the greatest common divisor length.
    - Otherwise, return an empty string.

    Time complexity:
    - O(n + m), where n is the length of str1 and m is the length of str2.

    Space complexity:
    - O(n + m).
     */
    public static string GcdOfStrings(string str1, string str2)
    {
        return str1 + str2 != str2 + str1 ? "" : str1[..Gcd(str1.Length, str2.Length)];
    }

    private static int Gcd(int a, int b)
    {
        while (true)
        {
            if (b == 0) return a;
            var a1 = a;
            a = b;
            b = a1 % b;
        }
    }
}