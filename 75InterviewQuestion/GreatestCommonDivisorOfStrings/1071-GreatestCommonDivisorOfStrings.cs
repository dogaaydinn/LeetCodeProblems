namespace _75InterviewQuestion.GreatestCommonDivisorOfStrings;

public static class _1071_GreatestCommonDivisorOfStrings
{
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